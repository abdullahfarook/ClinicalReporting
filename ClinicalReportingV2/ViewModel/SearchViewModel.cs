using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Repository;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ClinicalReporting.ViewModel
{
    public sealed class SearchViewModel : ViewModelCommon
    {
        private readonly IPatientsRepository _repoPatient;
        private ViewModelCommon _header;
        private Patient _patienTests;
        private long _patientId;
        private string _searchName;
        private string _viewModelName;


        public SearchViewModel()
        {
            _repoPatient = ServiceLocator.Current.GetInstance<IPatientsRepository>();
            PatientView = CollectionViewSource.GetDefaultView(_repoPatient.GetAllPatientAsync().Result);
            SearchName = "Abdullah Farooq";
            PatientTests = _repoPatient.GetWithChildren(1);
        }

        [PreferredConstructor]
        public SearchViewModel(IPatientsRepository repository)
        {
            ViewModelName = "Search";
            HeaderContent = new MainHeaderVM();
            _repoPatient = repository;
            DetailCommand = new RelayCommand<long>(NavigateTo);
            AddNewTestCommand = new RelayCommand<string>(AddNewTest);
            TestDetailCommand = new RelayCommand<IModelCommon>(TestDetail);
            EditPatientCommand = new RelayCommand(EditPatient);
        }

        public override ViewModelCommon HeaderContent
        {
            get => _header;
            set { Set(() => HeaderContent, ref _header, value); }
        }

        public ICollectionView PatientView { get; private set; }

        public Patient PatientTests
        {
            get => _patienTests;
            set { Set(() => PatientTests, ref _patienTests, value); }
        }

        public long SelectedPatientId
        {
            get => _patientId;
            set
            {
                Set(() => SelectedPatientId, ref _patientId, value);
                GetPatientChild(_patientId);
            }
        }

        public string SearchName
        {
            get => _searchName;
            set
            {
                Set(() => SearchName, ref _searchName, value);
                PatientTests = null;
                PatientView.Refresh();
            }
        }

        public RelayCommand<long> DetailCommand { get; }
        public RelayCommand<string> AddNewTestCommand { get; }
        public RelayCommand<IModelCommon> TestDetailCommand { get; }
        public RelayCommand EditPatientCommand { get; }

        public override string ViewModelName
        {
            get => _viewModelName;
            set { Set(() => ViewModelName, ref _viewModelName, value); }
        }

        private async void GetPatientChild(long selectePatientId)
        {
            PatientTests =
                await _repoPatient.GetPatientWithChildrenAsync(selectePatientId);
        }

        private void NavigateTo(long patientId)
        {
        }

        public void AddNewTest(string testName)
        {
            var message = new Tuple<Patient, string>(PatientTests, testName);
            Messenger.Default.Send(message);
        }

        public void TestDetail(IModelCommon testObj)
        {
            var message = new Tuple<Patient, IModelCommon>(PatientTests, testObj);
            Messenger.Default.Send(message);
        }

        public void EditPatient()
        {
            if (PatientTests != null)
            {
                var message = new Tuple<Patient, string>(PatientTests, null);
                Messenger.Default.Send(message);
            }
        }

        public async Task LoadAsync()
        {
            PatientView = CollectionViewSource.GetDefaultView(await _repoPatient.GetAllPatientAsync());
            PatientView.SortDescriptions.Add(new SortDescription("PatientID", ListSortDirection.Descending));
            PatientId = PatientView.CurrentPosition + 1;
            PatientView.Filter += s =>
                                  {
                                      if (string.IsNullOrEmpty(SearchName))
                                          return true;
                                      if (SearchName.All(char.IsDigit))
                                      {
                                          var pat = s as Patient;
                                          long.TryParse(SearchName.ToString(), out long id);
                                          return pat != null && pat.PatientID == id;
                                      }
                                      else
                                      {
                                          var pat = s as Patient;
                                          return pat != null && pat.Name.ToLower().Contains(_searchName.ToLower());
                                      }
                                  };
        }
    }
}