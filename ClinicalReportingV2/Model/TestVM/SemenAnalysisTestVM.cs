using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class SemenAnalysisTestVM : ViewModelCommon, ITest
    {
        private SemenAnalysisW _semenanalysisw;

        public SemenAnalysisTestVM(IModelCommon semenanalysis)
        {
            _semenanalysisw = new SemenAnalysisW(semenanalysis as SemenAnalysis);
        }

        public SemenAnalysisTestVM()
        {
            _semenanalysisw = new SemenAnalysisW(new SemenAnalysis());
        }

        public SemenAnalysisW SemenAnalysis
        {
            get => _semenanalysisw;
            set { Set(() => SemenAnalysis, ref _semenanalysisw, value); }
        }
    }
}