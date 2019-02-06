using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class PatientTestVM : ViewModelCommon, ITest
    {
        private PatientW _patientw;

        public PatientTestVM(IModelCommon patient)
        {
            _patientw = new PatientW(patient as Patient);
        }

        public PatientTestVM()
        {
            _patientw = new PatientW(new Patient());
        }

        public PatientW Patient
        {
            get => _patientw;
            set { Set(() => Patient, ref _patientw, value); }
        }
    }
}