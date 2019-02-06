using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class ElisaTbTestVM : ViewModelCommon, ITest
    {
        private ElisaTbW _elisatbw;

        public ElisaTbTestVM(IModelCommon elisatb)
        {
            _elisatbw = new ElisaTbW(elisatb as ElisaTb);
        }

        public ElisaTbTestVM()
        {
            _elisatbw = new ElisaTbW(new ElisaTb());
        }

        public ElisaTbW ElisaTb
        {
            get => _elisatbw;
            set { Set(() => ElisaTb, ref _elisatbw, value); }
        }
    }
}