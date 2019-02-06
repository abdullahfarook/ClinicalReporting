//using System;
//using System.Collections.Generic;
//using System.Windows;
//using System.Windows.Controls;
//using ClinicalReporting.Views;
//using GalaSoft.MvvmLight;
//using GalaSoft.MvvmLight.Views;
//using Microsoft.Practices.ServiceLocation;

//namespace ClinicalReporting.Services
//{
//    public interface IFrameNavigation : INavigationService
//    {
//        object Parameter { get; }
//        void NavigateTo(string pageKey, object parameter);
//        void SetMainFrame(string pageKey);
//        void SetUserFrame(string pageKey, string contentControll);
//        void NavigateBack();
//    }

//    public class FrameNavigation : ObservableObject, IFrameNavigation
//    {
//        #region Fields

//        private readonly Dictionary<string, Frame> _pagesByKey;
//        private readonly List<string> _historic;
//        private string _currentPageKey;
//        private Frame _currentFrame;

//        #endregion

//        #region Properties                                              

//        public string CurrentPageKey
//        {
//            get => _currentPageKey;
//            private set { Set(() => CurrentPageKey, ref _currentPageKey, value); }
//        }

//        public object Parameter { get; private set; }

//        #endregion

//        #region Ctors and Methods

//        public FrameNavigation()
//        {
//            _pagesByKey = new Dictionary<string, Frame>();
//            _historic = new List<string>();
//        }

//        public void GoBack()
//        {
//            var frame = _pagesByKey[CurrentPageKey];
//            frame.NavigationService.GoBack();
//            //if (_historic.Count > 1)
//            //{
//            //    _historic.RemoveAt(_historic.Count - 1);
//            //    NavigateTo(_historic.Last(), null);
//            //}
//        }

//        public void NavigateTo(string pageKey)
//        {
//            NavigateTo(pageKey, null);
//        }

//        public void NavigateTo(string pageKey, string contenctControll)
//        {
//            NavigateTo(pageKey, null);
//        }

//        public virtual void SetMainFrame(string pageKey)
//        {
//            var p = Application.Current.MainWindow;
//            var frame = p.FindName("MainFrame") as Frame;
//            if (frame != null)
//            {
//                frame.Content = ServiceLocator.Current.GetInstance<ICommonView>(pageKey);
//                //  frame.NavigationService.RemoveBackEntry();
//                CurrentPageKey = pageKey;
//            }
//        }

//        public void SetUserFrame(string pageKey, string contentControll)
//        {
//            var userFrame = (Frame) Application.Current.MainWindow.FindName(contentControll);
//            if (userFrame != null)
//            {
//                userFrame.Content = ServiceLocator.Current.GetInstance<ICommonView>(pageKey);
//                userFrame.NavigationService.RemoveBackEntry();
//                CurrentPageKey = pageKey;
//            }
//        }

//        public virtual void NavigateTo(string pageKey, object parameter)
//        {
//            var frame = Application.Current.MainWindow.FindName("MainFrame") as Frame;
//            frame?.NavigationService.Navigate(ServiceLocator.Current.GetInstance<ICommonView>(pageKey));
//            //_historic.Add(pageKey);
//            //CurrentPageKey = pageKey;
//        }

//        public void NavigateBack()
//        {
//        }

//        public void Configure(string key, Uri pageType)
//        {
//            //lock (_pagesByKey)
//            //{
//            //    if (_pagesByKey.ContainsKey(key))
//            //        _pagesByKey[key] = pageType;
//            //    else
//            //        _pagesByKey.Add(key, pageType);
//            //}
//        }
//    }

//    #endregion

//    #region Old Methology

//    //private static FrameworkElement GetDescendantFromName(DependencyObject parent, string name)
//    //{
//    //    var count = VisualTreeHelper.GetChildrenCount(parent);
//    //    if (count < 1)
//    //    {
//    //        return null;
//    //    }
//    //    for (var i = 0; i < count; i++)
//    //    {
//    //        var frameworkElement = VisualTreeHelper.GetChild(parent, i) as FrameworkElement;
//    //        if (frameworkElement != null)
//    //        {
//    //            if (frameworkElement.Name == name)
//    //            {
//    //                return frameworkElement;
//    //            }
//    //            frameworkElement = GetDescendantFromName(frameworkElement, name);
//    //            if (frameworkElement != null)
//    //            {
//    //                return frameworkElement;
//    //            }
//    //        }
//    //    }
//    //    return null;
//    //}
//    //public DependencyObject ConvertToDependency(string xamlFile)
//    //{
//    //    using ( var fs = new FileStream(xamlFile,FileMode.Open))
//    //    {
//    //        var dependencyView = (DependencyObject) XamlReader.Load(fs);
//    //        return dependencyView;
//    //    }
//    //}

//    #endregion
//}