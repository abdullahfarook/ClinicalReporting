using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class ElisaHbsagTestVM : ViewModelCommon, ITest
    {
        private ElisaHbsagW _elisahbsagw;

        public ElisaHbsagTestVM(IModelCommon elisahbsag)
        {
            _elisahbsagw = new ElisaHbsagW(elisahbsag as ElisaHbsag);
        }

        public ElisaHbsagTestVM()
        {
            _elisahbsagw = new ElisaHbsagW(new ElisaHbsag());
        }

        public ElisaHbsagW ElisaHbsag
        {
            get => _elisahbsagw;
            set { Set(() => ElisaHbsag, ref _elisahbsagw, value); }
        }
    }
}