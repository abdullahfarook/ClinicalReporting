using System;
using System.Windows;
using ClinicalReporting.Model.Repository;
using ClinicalReporting.Services;
using ClinicalReporting.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace ClinicalReporting.ViewModel
{
    public static class ViewList
    {
        public static string HeaderView = "HeaderView";
        public static string SearchView = "SearchView";
        public static string PatientView = "PatientsCollection";
        public static string FrameView = "FrameView";
    }

    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            //  DispatcherHelper.Initialize();
            if (ViewModelBase.IsInDesignModeStatic)
            {
                SimpleIoc.Default.Register<IPatientsRepository, DesignPatientsRepository>();
                SimpleIoc.Default.Register<IDoctorsRepository, DesignDoctorsRepository>();
            }
            else
            {
                SimpleIoc.Default.Register<IDbConnectionFactory>(
                    () =>
                        new OrmLiteConnectionFactory(Environment.CurrentDirectory + "\\DataBase.db",
                            SqliteDialect.Provider));
                SimpleIoc.Default.Register<IPatientsRepository, PatientRepository>();
                SimpleIoc.Default.Register<IDoctorsRepository, DoctorRepository>();
            }
            RegisterViewModels();
            SimpleIoc.Default.Register<TestFactory>(true);
           // SimpleIoc.Default.Register<IFrameNavigation, FrameNavigation>();
            SimpleIoc.Default.Register<ICommonView>(() => new MainHeaderView(), ViewList.HeaderView);
            //  RegisterViews();
        }

        public static ViewModelLocator Instance => Application.Current.Resources["Locator"] as ViewModelLocator;
        public MainwindowViewModel Main => ServiceLocator.Current.GetInstance<MainwindowViewModel>();
        public FrameViewModel FrameViewModel => ServiceLocator.Current.GetInstance<FrameViewModel>();

        private void RegisterViewModels()
        {
            SimpleIoc.Default.Register<AddPatientViewModel>();
            SimpleIoc.Default.Register<SearchViewModel>();

            SimpleIoc.Default.Register<FrameViewModel>();
            SimpleIoc.Default.Register<MainwindowViewModel>();
        }

        public void RegisterViews()
        {
            //var navigationService = new FrameNavigation();
            //navigationService.Configure(HeaderView, new Uri("../Views/Header/MainHeaderView.xaml", UriKind.Relative));
            //navigationService.Configure(SearchView, new Uri("../Views/SearchView.xaml", UriKind.Relative));
            //navigationService.Configure(PatientsCollection, new Uri("../Views/AddPatientView.xaml", UriKind.Relative));
            SimpleIoc.Default.Register<ICommonView>(() => new AddPatientView(), ViewList.PatientView);

            SimpleIoc.Default.Register<ICommonView>(() => new SearchView(), ViewList.SearchView);
            SimpleIoc.Default.Register<ICommonView>(() => new FrameView(), ViewList.FrameView);
        }
    }
}