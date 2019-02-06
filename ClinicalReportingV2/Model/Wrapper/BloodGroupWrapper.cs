using System;

namespace ClinicalReporting.Model.Wrapper
{
    public class BloodGroupW : CommonWrapper<BloodGroup>
    {
        private string _antihcv;
        private string _donarbloodgroup;
        private string _donarname;
        private int _fee;
        private string _hbsag;
        private string _patientbloodgroup;

        private long _patientid;

        // One To One
        private PatientW _patientw;

        private long _serialno;
        private DateTime _tdate;

        public BloodGroupW(BloodGroup bloodgroupModel) : base(bloodgroupModel)
        {
            InitializeComplexProperties(bloodgroupModel);
            InitializeCollectionProperties(bloodgroupModel);
        }

        public BloodGroupW() : base(null)
        {
        }

        public long SerialNo
        {
            get => GET(ref _serialno);
            set => SET(ref _serialno, value);
        }

        public long PatientID
        {
            get => GET(ref _patientid);
            set => SET(ref _patientid, value);
        }

        public DateTime TDate
        {
            get => GET(ref _tdate);
            set => SET(ref _tdate, value);
        }

        public string PatientBloodGroup
        {
            get => GET(ref _patientbloodgroup);
            set => SET(ref _patientbloodgroup, value);
        }

        public string DonarName
        {
            get => GET(ref _donarname);
            set => SET(ref _donarname, value);
        }

        public string DonarBloodGroup
        {
            get => GET(ref _donarbloodgroup);
            set => SET(ref _donarbloodgroup, value);
        }

        public string HbsAg
        {
            get => GET(ref _hbsag);
            set => SET(ref _hbsag, value);
        }

        public string AntiHCV
        {
            get => GET(ref _antihcv);
            set => SET(ref _antihcv, value);
        }

        public int Fee
        {
            get => GET(ref _fee);
            set => SET(ref _fee, value);
        }

        public PatientW PatientW
        {
            get => _patientw;
            set
            {
                _patientw = value;
                if (!Equals(_patientw, Model.Patient))
                    Model.Patient = _patientw.Model;
                ;
            }
        }

        private void InitializeCollectionProperties(BloodGroup bloodgroupModel)
        {
        }

        private void InitializeComplexProperties(BloodGroup bloodgroupModel)
        {
            // One To One
            if (bloodgroupModel.Patient != null)
                PatientW = new PatientW(
                    bloodgroupModel.Patient);
        }
    }
}