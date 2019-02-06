using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ClinicalReporting.ViewModel
{
    public abstract class ViewModelCommon : ViewModelBase
    {
        private ViewModelCommon _headerContant;

        private string _viewModelName;
        public virtual long PatientId { get; set; }

        public virtual string ViewModelName
        {
            get => _viewModelName;
            set { Set(() => ViewModelName, ref _viewModelName, value); }
        }

        public virtual ViewModelCommon HeaderContent
        {
            get => _headerContant;
            set { Set(() => HeaderContent, ref _headerContant, value); }
        }

        public virtual RelayCommand<string> NavigationCommand { get; set; }

        public virtual void NavigateTo(string destination)
        {
        }

        public virtual void NavigateBack()
        {
        }
    }
}