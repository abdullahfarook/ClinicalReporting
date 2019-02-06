using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Repository;
using ClinicalReporting.Model.Wrapper;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using ServiceStack.OrmLite;
using System;
using System.ComponentModel;

namespace ClinicalReporting.ViewModel
{
    public class AddPatientViewModel : ViewModelCommon
    {
        private readonly IPatientsRepository _repoPatient;
        private Patient _patientTests;
        private PatientW _patientW;

        public AddPatientViewModel()
        {
            // var p = new Patient();
            PatientTests = SimpleIoc.Default.GetInstance<IPatientsRepository>().GetWithChildren(1);
            PatientW = new PatientW(PatientTests) { RefBy = "Self", Sex = "Male" };
        }

        [PreferredConstructor]
        public AddPatientViewModel(IPatientsRepository pRepo)
        {
            _repoPatient = pRepo;

            PatientTests = new Patient();
            PatientW = new PatientW(_patientTests)
            {
                PatientID = LoadId(),
                RefBy = "Self",
                Sex = "Male"
            };
            SetCommands();
        }

        public AddPatientViewModel(Patient patient, IPatientsRepository pRepo)
        {
            _repoPatient = pRepo;
            PatientTests = patient;
            PatientW = new PatientW(_patientTests);
            SetCommands();
        }

        public bool Saved { get; set; }

        public Patient PatientTests
        {
            get => _patientTests;
            set { Set(() => PatientTests, ref _patientTests, value); }
        }

        public PatientW PatientW
        {
            get => _patientW;
            set { Set(() => PatientW, ref _patientW, value); }
        }

        public RelayCommand SaveCommand { get; private set; }
        public RelayCommand<string> AddNewTestCommand { get; private set; }
        public RelayCommand<IModelCommon> TestDetailCommand { get; private set; }
        public event Action<string> CreateNewTest = delegate { };
        public event Action<IModelCommon> NavigateToTest = delegate { };

        private void SetCommands()
        {
            SaveCommand = new RelayCommand(Savebtn);
            // AddNewTest = new RelayCommand<string>(addNewTest);
            //  NavigateTo= new RelayCommand<ITransitionEffectSubject();
            AddNewTestCommand = new RelayCommand<string>(AddNewTest);
            TestDetailCommand = new RelayCommand<IModelCommon>(TestDetail);
            PatientW.PropertyChanged += ChnageViewName;
        }

        private void Savebtn()
        {
            var p = PatientTests;
            Console.WriteLine(p.Sex);
        }

        public void AddNewTest(string testName)
        {
            CreateNewTest(testName);
        }

        public void TestDetail(IModelCommon testInstance)
        {
            NavigateToTest(testInstance);
        }

        private void ChnageViewName(object sender, PropertyChangedEventArgs e)
        {
            if (sender is PatientW p) PatientTests = p.Model;

            if (PatientTests.Name != null)
                ViewModelName = PatientTests.Name;
        }

        public long LoadId()
        {
            return _repoPatient.Custom
                       .Scalar<long>("Select seq from sqlite_sequence where name=@name;",
                           new { name = "Patient" }) + 1;
        }

        public void Dispose()
        {
            PatientW.PropertyChanged -= ChnageViewName;
        }
    }
}