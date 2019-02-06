using System;

namespace ClinicalReporting.Model.Wrapper
{
    public class SemenAnalysisW : CommonWrapper<SemenAnalysis>
    {
        private string _abnormal;
        private string _activemotility;
        private string _colour;
        private string _epithelialcell;
        private int _fee;
        private string _nonmotile;

        private long _patientid;

        // One To One
        private PatientW _patientw;

        private string _ph;
        private string _puscells;
        private string _quantity;
        private string _rbc;
        private long _serialno;
        private string _sluggish;
        private DateTime _tdate;
        private string _timeofcollection;
        private string _timeofexamination;
        private string _totalcount;

        public SemenAnalysisW(SemenAnalysis semenanalysisModel) : base(semenanalysisModel)
        {
            InitializeComplexProperties(semenanalysisModel);
            InitializeCollectionProperties(semenanalysisModel);
        }

        public SemenAnalysisW() : base(null)
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

        public string Colour
        {
            get => GET(ref _colour);
            set => SET(ref _colour, value);
        }

        public string Quantity
        {
            get => GET(ref _quantity);
            set => SET(ref _quantity, value);
        }

        public string Ph
        {
            get => GET(ref _ph);
            set => SET(ref _ph, value);
        }

        public string TimeOfCollection
        {
            get => GET(ref _timeofcollection);
            set => SET(ref _timeofcollection, value);
        }

        public string TimeOfExamination
        {
            get => GET(ref _timeofexamination);
            set => SET(ref _timeofexamination, value);
        }

        public string TotalCount
        {
            get => GET(ref _totalcount);
            set => SET(ref _totalcount, value);
        }

        public string ActiveMotility
        {
            get => GET(ref _activemotility);
            set => SET(ref _activemotility, value);
        }

        public string Sluggish
        {
            get => GET(ref _sluggish);
            set => SET(ref _sluggish, value);
        }

        public string NonMotile
        {
            get => GET(ref _nonmotile);
            set => SET(ref _nonmotile, value);
        }

        public string Abnormal
        {
            get => GET(ref _abnormal);
            set => SET(ref _abnormal, value);
        }

        public string PusCells
        {
            get => GET(ref _puscells);
            set => SET(ref _puscells, value);
        }

        public string Rbc
        {
            get => GET(ref _rbc);
            set => SET(ref _rbc, value);
        }

        public string EpithelialCell
        {
            get => GET(ref _epithelialcell);
            set => SET(ref _epithelialcell, value);
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

        private void InitializeCollectionProperties(SemenAnalysis semenanalysisModel)
        {
        }

        private void InitializeComplexProperties(SemenAnalysis semenanalysisModel)
        {
            // One To One
            if (semenanalysisModel.Patient != null)
                PatientW = new PatientW(
                    semenanalysisModel.Patient);
        }
    }
}