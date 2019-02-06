using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class SerologyTestVM : ViewModelCommon, ITest
    {
        private SerologyW _serologyw;

        public SerologyTestVM(IModelCommon serology)
        {
            _serologyw = new SerologyW(serology as Serology);
        }

        public SerologyTestVM()
        {
            _serologyw = new SerologyW(new Serology());
        }

        public SerologyW Serology
        {
            get => _serologyw;
            set { Set(() => Serology, ref _serologyw, value); }
        }
    }
}