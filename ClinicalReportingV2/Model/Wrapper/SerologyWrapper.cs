namespace ClinicalReporting.Model.Wrapper
{
    public class SerologyW : CommonWrapper<Serology>
    {
        private string _antihcv;
        private string _asotitre;
        private long _fee;
        private string _hbsag;
        private string _helicobacterpylori;
        private string _hiv;
        private string _igg;
        private string _IGG;
        private string _igm;
        private string _IGM;
        private string _kahnsvdrl;
        private string _mantoex;
        private string _parathyphiah;
        private string _parathyphibh;

        private long _patientid;

        // One To One
        private PatientW _patientw;

        private string _pregnancytest;
        private string _rafactor;
        private long _serialno;
        private string _styphith;
        private string _styphito;
        private string _tbplus;
        private string _tdate;
        private string _typhoid;
        private string _widaltest;

        public SerologyW(Serology serologyModel) : base(serologyModel)
        {
            InitializeComplexProperties(serologyModel);
            InitializeCollectionProperties(serologyModel);
        }

        public SerologyW() : base(null)
        {
        }

        public long Serialno
        {
            get => GET(ref _serialno);
            set => SET(ref _serialno, value);
        }

        public long Patientid
        {
            get => GET(ref _patientid);
            set => SET(ref _patientid, value);
        }

        public string Tdate
        {
            get => GET(ref _tdate);
            set => SET(ref _tdate, value);
        }

        public string WidalTest
        {
            get => GET(ref _widaltest);
            set => SET(ref _widaltest, value);
        }

        public string STyphiTo
        {
            get => GET(ref _styphito);
            set => SET(ref _styphito, value);
        }

        public string STyphiTh
        {
            get => GET(ref _styphith);
            set => SET(ref _styphith, value);
        }

        public string ParaThyphiAh
        {
            get => GET(ref _parathyphiah);
            set => SET(ref _parathyphiah, value);
        }

        public string ParaThyphiBh
        {
            get => GET(ref _parathyphibh);
            set => SET(ref _parathyphibh, value);
        }

        public string Typhoid
        {
            get => GET(ref _typhoid);
            set => SET(ref _typhoid, value);
        }

        public string igm
        {
            get => GET(ref _igm);
            set => SET(ref _igm, value);
        }

        public string igg
        {
            get => GET(ref _igg);
            set => SET(ref _igg, value);
        }

        public string HbsAg
        {
            get => GET(ref _hbsag);
            set => SET(ref _hbsag, value);
        }

        public string AsoTitre
        {
            get => GET(ref _asotitre);
            set => SET(ref _asotitre, value);
        }

        public string PregnancyTest
        {
            get => GET(ref _pregnancytest);
            set => SET(ref _pregnancytest, value);
        }

        public string RaFactor
        {
            get => GET(ref _rafactor);
            set => SET(ref _rafactor, value);
        }

        public string AntiHcv
        {
            get => GET(ref _antihcv);
            set => SET(ref _antihcv, value);
        }

        public string Mantoex
        {
            get => GET(ref _mantoex);
            set => SET(ref _mantoex, value);
        }

        public string KahnsVdrl
        {
            get => GET(ref _kahnsvdrl);
            set => SET(ref _kahnsvdrl, value);
        }

        public string TbPlus
        {
            get => GET(ref _tbplus);
            set => SET(ref _tbplus, value);
        }

        public string IGM
        {
            get => GET(ref _IGM);
            set => SET(ref _IGM, value);
        }

        public string IGG
        {
            get => GET(ref _IGG);
            set => SET(ref _IGG, value);
        }

        public string HelicobacterPylori
        {
            get => GET(ref _helicobacterpylori);
            set => SET(ref _helicobacterpylori, value);
        }

        public string Hiv
        {
            get => GET(ref _hiv);
            set => SET(ref _hiv, value);
        }

        public long Fee
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

        private void InitializeCollectionProperties(Serology serologyModel)
        {
        }

        private void InitializeComplexProperties(Serology serologyModel)
        {
            // One To One
            if (serologyModel.Patient != null)
                PatientW = new PatientW(
                    serologyModel.Patient);
        }
    }
}