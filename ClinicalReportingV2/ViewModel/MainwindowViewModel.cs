using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Repository;
using ClinicalReporting.ViewModel;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;
using ServiceStack.OrmLite;

namespace ClinicalReporting
{
    public class MainwindowViewModel : ViewModelCommon
    {
        #region CTOR

        public MainwindowViewModel(IDoctorsRepository docRepo, IPatientsRepository repoPatient)
        {
            //  _navigation = navigation;
            _repoPatient = repoPatient;
            _docRepo = docRepo;
            HeaderContent = new MainHeaderVM();
            ViewModels = new ObservableCollection<ViewModelCommon>();
            NavigationCommand = new RelayCommand<string>(Navigation);
            CloseTabCommand = new RelayCommand<ViewModelCommon>(CloseTab);
            _searchVm = ServiceLocator.Current.GetInstance<SearchViewModel>();

            Messenger.Default.Register<Tuple<Patient, string>>(this,
                message => { AddEditPatient(message.Item1, message.Item2); });
            Messenger.Default.Register<Tuple<Patient, IModelCommon>>(this,
                message => { AddEditPatient(message.Item1, message.Item2); });
        }

        #endregion

        #region Fields

        private readonly BackupViewModel _backupVm = new BackupViewModel();

        private readonly IDoctorsRepository _docRepo;

        // private readonly IFrameNavigation _navigation;
        private readonly SettingsViewModel _settingsVm = new SettingsViewModel();

        private readonly ThemesViewModel _themesVm = new ThemesViewModel();
        private ObservableCollection<Doctor> _doctors;
        private SearchViewModel _searchVm;
        private ViewModelCommon _selectedViewModel;
        private readonly IPatientsRepository _repoPatient;
        public RelayCommand<string> NavigationCommand { get; }
        public ObservableCollection<ViewModelCommon> ViewModels { get; }
        public RelayCommand<ViewModelCommon> CloseTabCommand { get; }
        private ViewModelCommon _header;

        #endregion

        #region Dependency Properties

        public sealed override ViewModelCommon HeaderContent
        {
            get => _header;
            set { Set(() => HeaderContent, ref _header, value); }
        }

        public ViewModelCommon SelectedViewModel
        {
            get => _selectedViewModel;
            set { Set(() => SelectedViewModel, ref _selectedViewModel, value); }
        }

        public SearchViewModel SearchViewModel
        {
            get => _searchVm;
            set { Set(() => SearchViewModel, ref _searchVm, value); }
        }

        public ObservableCollection<Doctor> Doctors
        {
            get => _doctors;
            set { Set(() => Doctors, ref _doctors, value); }
        }

        #endregion

        #region Methods

        private void CloseTab(ViewModelCommon obj)
        {
            ViewModels.Remove(obj);
            obj.Cleanup();
        }


        private void AddEditPatient()
        {
            var frameViewModel = SimpleIoc.Default.GetInstanceWithoutCaching<FrameViewModel>();
            var page = ViewModels.FirstOrDefault(x => x.PatientId == frameViewModel.PatientId);
            if (page == null)
            {
                ViewModels.Add(frameViewModel);
                SelectedViewModel = frameViewModel;
            }
            else
            {
                SelectedViewModel = page;
            }
        }

        private void AddEditPatient(Patient patient, string testName = null)
        {
            var page = ViewModels.FirstOrDefault(x => x.PatientId == patient.PatientID);
            if (page == null)
                if (testName == null)
                {
                    var frameViewModel = new FrameViewModel(patient);
                    ViewModels.Add(frameViewModel);
                    SelectedViewModel = frameViewModel;
                }
                else
                {
                    var frameViewModel = new FrameViewModel(patient, testName);
                    ViewModels.Add(frameViewModel);
                    SelectedViewModel = frameViewModel;
                }
            else
                SelectedViewModel = page;
        }

        private void AddEditPatient(Patient patient, IModelCommon testInstance)
        {
            var page = ViewModels.FirstOrDefault(x => x.PatientId == patient.PatientID);
            if (page == null)
            {
                var frameViewModel = new FrameViewModel(patient, testInstance);
                ViewModels.Add(frameViewModel);
                SelectedViewModel = frameViewModel;
            }
            else
            {
                SelectedViewModel = page;
            }
        }

        private void Navigation(string destination)
        {
            switch (destination)
            {
                case "addpatient":
                    AddEditPatient();
                    break;
                case "search":
                    if (ViewModels.Contains(SearchViewModel) == false)
                    {
                        ViewModels.Add(SearchViewModel);
                        SelectedViewModel = SearchViewModel;
                    }
                    else
                    {
                        SelectedViewModel = SearchViewModel;
                    }
                    break;
                case "backup":
                    break;
                case "settings":
                    break;
                case "themes":
                    break;
            }
        }

        public async void LoadAsync()
        {
            Doctors = new ObservableCollection<Doctor>(await _docRepo.GetAllDoctorAsync());
            Trace.WriteLine("Async Method Started");
            // _navigation.SetUserFrame(ViewList.HeaderView, "HeaderFrame");
            await _searchVm.LoadAsync();
        }

        public long LoadId()
        {
            return _repoPatient.Custom
                       .Scalar<long>("Select seq from sqlite_sequence where name=@name;",
                           new { name = "Patient" }) + 1;
        }

        #endregion
    }
}