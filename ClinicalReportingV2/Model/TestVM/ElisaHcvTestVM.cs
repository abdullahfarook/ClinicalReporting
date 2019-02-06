using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class ElisaHcvTestVM : ViewModelCommon, ITest
    {
        private ElisaHcvW _elisahcvw;

        public ElisaHcvTestVM(IModelCommon elisahcv)
        {
            _elisahcvw = new ElisaHcvW(elisahcv as ElisaHcv);
        }

        public ElisaHcvTestVM()
        {
            _elisahcvw = new ElisaHcvW(new ElisaHcv());
        }

        public ElisaHcvW ElisaHcv
        {
            get => _elisahcvw;
            set { Set(() => ElisaHcv, ref _elisahcvw, value); }
        }
    }
}