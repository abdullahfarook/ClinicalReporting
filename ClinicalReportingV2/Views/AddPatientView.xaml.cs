using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ClinicalReporting.Views
{
    public partial class AddPatientView : UserControl, ICommonView
    {
        public AddPatientView()
        {
            InitializeComponent();
        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            var op = new OpenFileDialog
            {
                Title = "Select a picture",
                Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                                  "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                  "Portable Network Graphic (*.png)|*.png"
            };
            if (op.ShowDialog() == true)
                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
        }

        private void TreeViewLostFocus(object sender, RoutedEventArgs e)
        {
            Blood.IsExpanded = false;
            bio.IsExpanded = false;
            hbsa.IsExpanded = false;
            hcv.IsExpanded = false;
            tb.IsExpanded = false;
            hae.IsExpanded = false;
            se.IsExpanded = false;
            ser.IsExpanded = false;
        }
    }
}