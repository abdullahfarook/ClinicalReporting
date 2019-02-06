using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class DoctorTestVM : ViewModelCommon, ITest
    {
        private DoctorW _doctorw;

        public DoctorTestVM(IModelCommon doctor)
        {
            _doctorw = new DoctorW(doctor as Doctor);
        }

        public DoctorTestVM()
        {
            _doctorw = new DoctorW(new Doctor());
        }

        public DoctorW Doctor
        {
            get => _doctorw;
            set { Set(() => Doctor, ref _doctorw, value); }
        }
    }
}