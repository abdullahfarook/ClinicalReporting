using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class BloodGroupTestVM : ViewModelCommon, ITest
    {
        private BloodGroupW _bloodgroupw;

        public BloodGroupTestVM(IModelCommon bloodgroup)
        {
            _bloodgroupw = new BloodGroupW(bloodgroup as BloodGroup);
        }

        public BloodGroupTestVM()
        {
            _bloodgroupw = new BloodGroupW(new BloodGroup());
        }

        public BloodGroupW BloodGroup
        {
            get => _bloodgroupw;
            set { Set(() => BloodGroup, ref _bloodgroupw, value); }
        }
    }
}