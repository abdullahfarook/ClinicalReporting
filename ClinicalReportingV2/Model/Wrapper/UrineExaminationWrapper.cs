using System;

namespace ClinicalReporting.Model.Wrapper
{
    public class UrineExaminationW : CommonWrapper<UrineExamination>
    {
        private string _albumin;
        private string _amorphous;
        private string _bilirubin;
        private string _blood;
        private string _caloxalate;
        private string _cast;
        private string _colour;
        private string _crystals;
        private string _epicells;
        private int _fee;
        private string _ketone;
        private string _others;

        private long _patientid;

        // One To One
        private PatientW _patientw;

        private string _puscells;
        private string _rbc;
        private string _reaction;
        private long _serialno;
        private string _specificgravity;
        private string _sugar;
        private DateTime _tdate;
        private string _uricacid;
        private string _urobilnogen;

        public UrineExaminationW(UrineExamination urineexaminationModel) : base(urineexaminationModel)
        {
            InitializeComplexProperties(urineexaminationModel);
            InitializeCollectionProperties(urineexaminationModel);
        }

        public UrineExaminationW() : base(null)
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

        public string Reaction
        {
            get => GET(ref _reaction);
            set => SET(ref _reaction, value);
        }

        public string SpecificGravity
        {
            get => GET(ref _specificgravity);
            set => SET(ref _specificgravity, value);
        }

        public string Albumin
        {
            get => GET(ref _albumin);
            set => SET(ref _albumin, value);
        }

        public string Sugar
        {
            get => GET(ref _sugar);
            set => SET(ref _sugar, value);
        }

        public string Ketone
        {
            get => GET(ref _ketone);
            set => SET(ref _ketone, value);
        }

        public string Blood
        {
            get => GET(ref _blood);
            set => SET(ref _blood, value);
        }

        public string Bilirubin
        {
            get => GET(ref _bilirubin);
            set => SET(ref _bilirubin, value);
        }

        public string UrobilNogen
        {
            get => GET(ref _urobilnogen);
            set => SET(ref _urobilnogen, value);
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

        public string EPiCells
        {
            get => GET(ref _epicells);
            set => SET(ref _epicells, value);
        }

        public string Cast
        {
            get => GET(ref _cast);
            set => SET(ref _cast, value);
        }

        public string Crystals
        {
            get => GET(ref _crystals);
            set => SET(ref _crystals, value);
        }

        public string CalOxalate
        {
            get => GET(ref _caloxalate);
            set => SET(ref _caloxalate, value);
        }

        public string UricAcid
        {
            get => GET(ref _uricacid);
            set => SET(ref _uricacid, value);
        }

        public string Amorphous
        {
            get => GET(ref _amorphous);
            set => SET(ref _amorphous, value);
        }

        public string Others
        {
            get => GET(ref _others);
            set => SET(ref _others, value);
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

        private void InitializeCollectionProperties(UrineExamination urineexaminationModel)
        {
        }

        private void InitializeComplexProperties(UrineExamination urineexaminationModel)
        {
            // One To One
            if (urineexaminationModel.Patient != null)
                PatientW = new PatientW(
                    urineexaminationModel.Patient);
        }
    }
}