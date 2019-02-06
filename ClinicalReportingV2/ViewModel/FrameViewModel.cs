using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Repository;
using ClinicalReporting.Services;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClinicalReporting.ViewModel
{
    public class FrameViewModel : ViewModelCommon, IDisposable
    {
        #region Fields

        private readonly AddPatientViewModel _patientVM;
        private ViewModelCommon _selectedPage;
        private string _viewModelName;
        private Patient _patient;
        private ViewModelCommon _selectedtest;
        private readonly Dictionary<string, Stack<ViewModelCommon>> _testsDictionery;

        public sealed override long PatientId { get; set; }

        public override RelayCommand<string> NavigationCommand { get; set; }

        #endregion

        #region CTOR

        [PreferredConstructor]
        public FrameViewModel()
        {
            _testsDictionery = new Dictionary<string, Stack<ViewModelCommon>>(3);
            _patientVM = SimpleIoc.Default.GetInstanceWithoutCaching<AddPatientViewModel>();

            ViewModelName = "New";
            SelectedPage = _patientVM;
            PatientId = _patientVM.PatientTests.PatientID;
            SetCommands();
        }

        public FrameViewModel(Patient patient)
        {
            _testsDictionery = new Dictionary<string, Stack<ViewModelCommon>>(3);
            _patient = patient;
            _patientVM = new AddPatientViewModel(patient, SimpleIoc.Default.GetInstance<IPatientsRepository>());
            ViewModelName = patient.Name;
            PatientId = _patientVM.PatientTests.PatientID;
            SelectedPage = _patientVM;
            SetCommands();
        }

        public FrameViewModel(Patient patient, string SelectedTest)
        {
            _patient = patient;
            _patientVM = new AddPatientViewModel(patient, SimpleIoc.Default.GetInstance<IPatientsRepository>());
            ViewModelName = patient.Name;
            PatientId = _patientVM.PatientTests.PatientID;
            var test =
                SimpleIoc.Default.GetInstance<TestFactory>()
                    .CreateInstance(SelectedTest) as ViewModelCommon;
            //var stack = new Stack<ViewModelCommon>(3);
            //stack.Push(test);
            //   _testsDictionery = new Dictionary<string, Stack<ViewModelCommon>> { { SelectedTest, stack } };
            // SelectedPage = _patientVM;
            _selectedtest = test;
            SelectedPage = test;

            SetCommands();
        }

        public FrameViewModel(Patient patient, IModelCommon testInstance)
        {
            _patient = patient;
            _patientVM = new AddPatientViewModel(patient, SimpleIoc.Default.GetInstance<IPatientsRepository>());
            ViewModelName = patient.Name;
            PatientId = _patientVM.PatientTests.PatientID;
            var tuple =
                SimpleIoc.Default.GetInstance<TestFactory>()
                    .CreateInstance(testInstance);
            _selectedtest = tuple.Item2 as ViewModelCommon;
            SelectedPage = _selectedtest;
            SetCommands();
            //var stack = new Stack<ViewModelCommon>(3);
            //stack.Push(_selectedtest);
            // _testsDictionery = new Dictionary<string, Stack<ViewModelCommon>> { { _selectedtest, stack } };
            //SelectedPage = _patientVM;
        }

        private void SetCommands()
        {
            _patientVM.PropertyChanged += ChangeName;
            _patientVM.CreateNewTest += CreateTest;
            _patientVM.NavigateToTest += NavigateTest;
            HeaderContent = new MainHeaderVM();
            NavigationCommand = new RelayCommand<string>(x =>
                                                         {
                                                             if (x == "backward")
                                                             {
                                                                 SelectedPage = _patientVM;
                                                             }
                                                             else
                                                             {
                                                                 if (_selectedtest != null)
                                                                     SelectedPage = _selectedtest;
                                                             }
                                                         });
        }

        #endregion

        #region DependencyProperties

        private ViewModelCommon _header;

        public override ViewModelCommon HeaderContent
        {
            get => _header;
            set { Set(() => HeaderContent, ref _header, value); }
        }

        public ViewModelCommon SelectedPage
        {
            get => _selectedPage;
            set { Set(() => SelectedPage, ref _selectedPage, value); }
        }

        public sealed override string ViewModelName
        {
            get => _viewModelName;
            set { Set(() => ViewModelName, ref _viewModelName, value); }
        }

        #endregion

        #region Methods 

        //public override void NavigateTo(string destination)
        //{
        //    if (destination == "last")
        //    {
        //    }
        //    else if (destination == "report")
        //    {
        //        var testReport = new BloodGroupReportVM();
        //        _testsDictionery[_selectedtest].Push(testReport);
        //    }
        //    else if (_testsDictionery.ContainsKey(destination) == false)
        //    {
        //        var test =
        //            SimpleIoc.Default.GetInstance<TestFactory>().CreateInstance(destination, _patient) as
        //                ViewModelCommon;
        //        var stack = new Stack<ViewModelCommon>(3);
        //        stack.Push(test);
        //        _testsDictionery.Add(destination, stack);
        //        _selectedtest = destination;
        //        SelectedPage = test;
        //    }
        //}

        //public override void NavigateBack()
        //{
        //    if (_testsDictionery[_selectedtest].Count > 0)
        //    {
        //        var pop = _testsDictionery[_selectedtest].Peek();
        //        SelectedPage = pop;
        //    }
        //}

        private void CreateTest(string obj)
        {
            var test = SimpleIoc.Default.GetInstance<TestFactory>().CreateInstance(obj) as ViewModelCommon;
            _selectedtest = test;
            SelectedPage = test;
        }

        private void NavigateTest(IModelCommon testInstance)
        {
            var tuple = SimpleIoc.Default.GetInstance<TestFactory>().CreateInstance(testInstance);
            _selectedtest = tuple.Item2 as ViewModelCommon;
            SelectedPage = tuple.Item2 as ViewModelCommon;
        }

        private void ChangeName(object sender, PropertyChangedEventArgs e)
        {
            var p = sender as AddPatientViewModel;
            ViewModelName = p.PatientTests.Name;
        }

        public void Dispose()
        {
            _patientVM.PropertyChanged -= ChangeName;
            _patientVM.CreateNewTest -= CreateTest;
            _patientVM.NavigateToTest -= NavigateTest;
        }

        #endregion
    }
}