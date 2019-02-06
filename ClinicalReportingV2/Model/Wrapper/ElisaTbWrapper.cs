using System;

namespace ClinicalReporting.Model.Wrapper
{
    public class ElisaTbW : CommonWrapper<ElisaTb>
    {
        private double _cutoffvalue;
        private int _fee;
        private long _patientid;

        private double _patientvalue;

        // One To One
        private PatientW _patientw;

        private long _serialno;
        private DateTime _tdate;

        public ElisaTbW(ElisaTb elisatbModel) : base(elisatbModel)
        {
            InitializeComplexProperties(elisatbModel);
            InitializeCollectionProperties(elisatbModel);
        }

        public ElisaTbW() : base(null)
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

        public double PatientValue
        {
            get => GET(ref _patientvalue);
            set => SET(ref _patientvalue, value);
        }

        public double CutOffValue
        {
            get => GET(ref _cutoffvalue);
            set => SET(ref _cutoffvalue, value);
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

        private void InitializeCollectionProperties(ElisaTb elisatbModel)
        {
        }

        private void InitializeComplexProperties(ElisaTb elisatbModel)
        {
            // One To One
            if (elisatbModel.Patient != null)
                PatientW = new PatientW(
                    elisatbModel.Patient);
        }
    }
}