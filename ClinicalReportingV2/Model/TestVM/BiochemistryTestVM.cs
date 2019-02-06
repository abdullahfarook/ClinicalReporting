using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class BiochemistryTestVM : ViewModelCommon, ITest
    {
        private BiochemistryW _biochemistryw;

        public BiochemistryTestVM(IModelCommon biochemistry)
        {
            _biochemistryw = new BiochemistryW(biochemistry as Biochemistry);
        }

        public BiochemistryTestVM()
        {
            _biochemistryw = new BiochemistryW(new Biochemistry());
        }

        public BiochemistryW Biochemistry
        {
            get => _biochemistryw;
            set { Set(() => Biochemistry, ref _biochemistryw, value); }
        }
    }
}