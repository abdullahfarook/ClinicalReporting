using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class HaematologyTestVM : ViewModelCommon, ITest
    {
        private HaematologyW _haematologyw;

        public HaematologyTestVM(IModelCommon haematology)
        {
            _haematologyw = new HaematologyW(haematology as Haematology);
        }

        public HaematologyTestVM()
        {
            _haematologyw = new HaematologyW(new Haematology());
        }

        public HaematologyW Haematology
        {
            get => _haematologyw;
            set { Set(() => Haematology, ref _haematologyw, value); }
        }
    }
}