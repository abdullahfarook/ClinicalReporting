using System;

namespace ClinicalReporting.Model.Wrapper
{
    public class BiochemistryW : CommonWrapper<Biochemistry>
    {
        private string _agratio;
        private string _agrationor;
        private string _agratiounit;
        private string _bloodsugar2hpp;
        private string _bloodsugar2hppnor;
        private string _bloodsugar2hppunit;
        private string _bloodsugarfasting;
        private string _bloodsugarfastingnor;
        private string _bloodsugarfastingunit;
        private string _bloodsugarrandom;
        private string _bloodsugarrandomnor;
        private string _bloodsugarrandomunit;
        private string _bloodurea;
        private string _bloodureanor;
        private string _bloodureaunit;
        private string _bun;
        private string _bunnor;
        private string _bununit;
        private string _ckmb;
        private string _ckmbnor;
        private string _ckmbunit;
        private string _cpk;
        private string _cpknor;
        private string _cpkunit;
        private int _fee;
        private string _hdlcholestrol;
        private string _hdlcholestrolnor;
        private string _hdlcholestrolunit;
        private string _ldh;
        private string _ldhnor;
        private string _ldhunit;
        private string _ldlcholestrol;
        private string _ldlcholestrolnor;
        private string _ldlcholestrolunit;

        private long _patientid;

        // One To One
        private PatientW _patientw;

        private string _salbumin;
        private string _salbuminnor;
        private string _salbuminunit;
        private string _salkphosphatase;
        private string _salkphosphatasenor;
        private string _salkphosphataseunit;
        private string _sbilirubind;
        private string _sbilirubindnor;
        private string _sbilirubindunit;
        private string _sbilirubinind;
        private string _sbilirubinindnor;
        private string _sbilirubinindunit;
        private string _sbilirubint;
        private string _sbilirubintnor;
        private string _sbilirubintunit;
        private string _scalcium;
        private string _scalciumnor;
        private string _scalciumunit;
        private string _schloride;
        private string _schloridenor;
        private string _schlorideunit;
        private string _scholestrol;
        private string _scholestrolnor;
        private string _scholestrolunit;
        private string _screatinine;
        private string _screatininenor;
        private string _screatinineunit;
        private long _serialno;
        private string _sgotast;
        private string _sgotastunit;
        private string _sgotnor;
        private string _sgptalt;
        private string _sgptaltnor;
        private string _sgptaltunit;
        private string _spotassium;
        private string _spotassiumnor;
        private string _spotassiumunit;
        private string _sprotein;
        private string _sproteinnor;
        private string _sproteinunit;
        private string _ssodium;
        private string _ssodiumnor;
        private string _ssodiumunit;
        private string _striglycerides;
        private string _striglyceridesnor;
        private string _striglyceridesunit;
        private string _suricacid;
        private string _suricacidnor;
        private string _suricacidunit;
        private DateTime _tdate;

        public BiochemistryW(Biochemistry biochemistryModel) : base(biochemistryModel)
        {
            InitializeComplexProperties(biochemistryModel);
            InitializeCollectionProperties(biochemistryModel);
        }

        public BiochemistryW() : base(null)
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

        public string BloodSugarFasting
        {
            get => GET(ref _bloodsugarfasting);
            set => SET(ref _bloodsugarfasting, value);
        }

        public string BloodSugarFastingUnit
        {
            get => GET(ref _bloodsugarfastingunit);
            set => SET(ref _bloodsugarfastingunit, value);
        }

        public string BloodSugarFastingNor
        {
            get => GET(ref _bloodsugarfastingnor);
            set => SET(ref _bloodsugarfastingnor, value);
        }

        public string BloodSugar2HPP
        {
            get => GET(ref _bloodsugar2hpp);
            set => SET(ref _bloodsugar2hpp, value);
        }

        public string BloodSugar2HPPUnit
        {
            get => GET(ref _bloodsugar2hppunit);
            set => SET(ref _bloodsugar2hppunit, value);
        }

        public string BloodSugar2HPPNor
        {
            get => GET(ref _bloodsugar2hppnor);
            set => SET(ref _bloodsugar2hppnor, value);
        }

        public string BloodSugarRandom
        {
            get => GET(ref _bloodsugarrandom);
            set => SET(ref _bloodsugarrandom, value);
        }

        public string BloodSugarRandomUnit
        {
            get => GET(ref _bloodsugarrandomunit);
            set => SET(ref _bloodsugarrandomunit, value);
        }

        public string BloodSugarRandomNor
        {
            get => GET(ref _bloodsugarrandomnor);
            set => SET(ref _bloodsugarrandomnor, value);
        }

        public string BloodUrea
        {
            get => GET(ref _bloodurea);
            set => SET(ref _bloodurea, value);
        }

        public string BloodUreaUnit
        {
            get => GET(ref _bloodureaunit);
            set => SET(ref _bloodureaunit, value);
        }

        public string BloodUreaNor
        {
            get => GET(ref _bloodureanor);
            set => SET(ref _bloodureanor, value);
        }

        public string Bun
        {
            get => GET(ref _bun);
            set => SET(ref _bun, value);
        }

        public string BUNUnit
        {
            get => GET(ref _bununit);
            set => SET(ref _bununit, value);
        }

        public string BUNNor
        {
            get => GET(ref _bunnor);
            set => SET(ref _bunnor, value);
        }

        public string SCreatinine
        {
            get => GET(ref _screatinine);
            set => SET(ref _screatinine, value);
        }

        public string SCreatinineUnit
        {
            get => GET(ref _screatinineunit);
            set => SET(ref _screatinineunit, value);
        }

        public string SCreatinineNor
        {
            get => GET(ref _screatininenor);
            set => SET(ref _screatininenor, value);
        }

        public string SUricAcid
        {
            get => GET(ref _suricacid);
            set => SET(ref _suricacid, value);
        }

        public string SUricAcidUnit
        {
            get => GET(ref _suricacidunit);
            set => SET(ref _suricacidunit, value);
        }

        public string SUricAcidNor
        {
            get => GET(ref _suricacidnor);
            set => SET(ref _suricacidnor, value);
        }

        public string SCholestrol
        {
            get => GET(ref _scholestrol);
            set => SET(ref _scholestrol, value);
        }

        public string SCholestrolUnit
        {
            get => GET(ref _scholestrolunit);
            set => SET(ref _scholestrolunit, value);
        }

        public string SCholestrolNor
        {
            get => GET(ref _scholestrolnor);
            set => SET(ref _scholestrolnor, value);
        }

        public string STriglycerides
        {
            get => GET(ref _striglycerides);
            set => SET(ref _striglycerides, value);
        }

        public string STriglyceridesUnit
        {
            get => GET(ref _striglyceridesunit);
            set => SET(ref _striglyceridesunit, value);
        }

        public string STriglyceridesNor
        {
            get => GET(ref _striglyceridesnor);
            set => SET(ref _striglyceridesnor, value);
        }

        public string HDLCholestrol
        {
            get => GET(ref _hdlcholestrol);
            set => SET(ref _hdlcholestrol, value);
        }

        public string HDLCholestrolUnit
        {
            get => GET(ref _hdlcholestrolunit);
            set => SET(ref _hdlcholestrolunit, value);
        }

        public string HDLCholestrolNor
        {
            get => GET(ref _hdlcholestrolnor);
            set => SET(ref _hdlcholestrolnor, value);
        }

        public string LDLCholestrol
        {
            get => GET(ref _ldlcholestrol);
            set => SET(ref _ldlcholestrol, value);
        }

        public string LDLCholestrolUnit
        {
            get => GET(ref _ldlcholestrolunit);
            set => SET(ref _ldlcholestrolunit, value);
        }

        public string LDLCholestrolNor
        {
            get => GET(ref _ldlcholestrolnor);
            set => SET(ref _ldlcholestrolnor, value);
        }

        public string SgotAst
        {
            get => GET(ref _sgotast);
            set => SET(ref _sgotast, value);
        }

        public string SGOTASTUnit
        {
            get => GET(ref _sgotastunit);
            set => SET(ref _sgotastunit, value);
        }

        public string SGOTNor
        {
            get => GET(ref _sgotnor);
            set => SET(ref _sgotnor, value);
        }

        public string Ldh
        {
            get => GET(ref _ldh);
            set => SET(ref _ldh, value);
        }

        public string LDHUnit
        {
            get => GET(ref _ldhunit);
            set => SET(ref _ldhunit, value);
        }

        public string LDHNor
        {
            get => GET(ref _ldhnor);
            set => SET(ref _ldhnor, value);
        }

        public string Cpk
        {
            get => GET(ref _cpk);
            set => SET(ref _cpk, value);
        }

        public string CPKUnit
        {
            get => GET(ref _cpkunit);
            set => SET(ref _cpkunit, value);
        }

        public string CPKNor
        {
            get => GET(ref _cpknor);
            set => SET(ref _cpknor, value);
        }

        public string Ckmb
        {
            get => GET(ref _ckmb);
            set => SET(ref _ckmb, value);
        }

        public string CKMBUnit
        {
            get => GET(ref _ckmbunit);
            set => SET(ref _ckmbunit, value);
        }

        public string CKMBNor
        {
            get => GET(ref _ckmbnor);
            set => SET(ref _ckmbnor, value);
        }

        public string SBilirubinT
        {
            get => GET(ref _sbilirubint);
            set => SET(ref _sbilirubint, value);
        }

        public string SBilirubinTUnit
        {
            get => GET(ref _sbilirubintunit);
            set => SET(ref _sbilirubintunit, value);
        }

        public string SBilirubinTNor
        {
            get => GET(ref _sbilirubintnor);
            set => SET(ref _sbilirubintnor, value);
        }

        public string SBilirubinD
        {
            get => GET(ref _sbilirubind);
            set => SET(ref _sbilirubind, value);
        }

        public string SBilirubinDUnit
        {
            get => GET(ref _sbilirubindunit);
            set => SET(ref _sbilirubindunit, value);
        }

        public string SBilirubinDNor
        {
            get => GET(ref _sbilirubindnor);
            set => SET(ref _sbilirubindnor, value);
        }

        public string SBilirubinInd
        {
            get => GET(ref _sbilirubinind);
            set => SET(ref _sbilirubinind, value);
        }

        public string SBilirubinIndUnit
        {
            get => GET(ref _sbilirubinindunit);
            set => SET(ref _sbilirubinindunit, value);
        }

        public string SBilirubinIndNor
        {
            get => GET(ref _sbilirubinindnor);
            set => SET(ref _sbilirubinindnor, value);
        }

        public string SAlkPhosphatase
        {
            get => GET(ref _salkphosphatase);
            set => SET(ref _salkphosphatase, value);
        }

        public string SAlkPhosphataseUnit
        {
            get => GET(ref _salkphosphataseunit);
            set => SET(ref _salkphosphataseunit, value);
        }

        public string SAlkPhosphataseNor
        {
            get => GET(ref _salkphosphatasenor);
            set => SET(ref _salkphosphatasenor, value);
        }

        public string SgptAlt
        {
            get => GET(ref _sgptalt);
            set => SET(ref _sgptalt, value);
        }

        public string SGPTALTUnit
        {
            get => GET(ref _sgptaltunit);
            set => SET(ref _sgptaltunit, value);
        }

        public string SGPTALTNor
        {
            get => GET(ref _sgptaltnor);
            set => SET(ref _sgptaltnor, value);
        }

        public string SSodium
        {
            get => GET(ref _ssodium);
            set => SET(ref _ssodium, value);
        }

        public string SSodiumUnit
        {
            get => GET(ref _ssodiumunit);
            set => SET(ref _ssodiumunit, value);
        }

        public string SSodiumNor
        {
            get => GET(ref _ssodiumnor);
            set => SET(ref _ssodiumnor, value);
        }

        public string SPotassium
        {
            get => GET(ref _spotassium);
            set => SET(ref _spotassium, value);
        }

        public string SPotassiumUnit
        {
            get => GET(ref _spotassiumunit);
            set => SET(ref _spotassiumunit, value);
        }

        public string SPotassiumNor
        {
            get => GET(ref _spotassiumnor);
            set => SET(ref _spotassiumnor, value);
        }

        public string SChloride
        {
            get => GET(ref _schloride);
            set => SET(ref _schloride, value);
        }

        public string SChlorideUnit
        {
            get => GET(ref _schlorideunit);
            set => SET(ref _schlorideunit, value);
        }

        public string SChlorideNor
        {
            get => GET(ref _schloridenor);
            set => SET(ref _schloridenor, value);
        }

        public string SCalcium
        {
            get => GET(ref _scalcium);
            set => SET(ref _scalcium, value);
        }

        public string SCalciumUnit
        {
            get => GET(ref _scalciumunit);
            set => SET(ref _scalciumunit, value);
        }

        public string SCalciumNor
        {
            get => GET(ref _scalciumnor);
            set => SET(ref _scalciumnor, value);
        }

        public string SProtein
        {
            get => GET(ref _sprotein);
            set => SET(ref _sprotein, value);
        }

        public string SProteinUnit
        {
            get => GET(ref _sproteinunit);
            set => SET(ref _sproteinunit, value);
        }

        public string SProteinNor
        {
            get => GET(ref _sproteinnor);
            set => SET(ref _sproteinnor, value);
        }

        public string SAlbumin
        {
            get => GET(ref _salbumin);
            set => SET(ref _salbumin, value);
        }

        public string SAlbuminUnit
        {
            get => GET(ref _salbuminunit);
            set => SET(ref _salbuminunit, value);
        }

        public string SAlbuminNor
        {
            get => GET(ref _salbuminnor);
            set => SET(ref _salbuminnor, value);
        }

        public string AGRatio
        {
            get => GET(ref _agratio);
            set => SET(ref _agratio, value);
        }

        public string AGRatioUnit
        {
            get => GET(ref _agratiounit);
            set => SET(ref _agratiounit, value);
        }

        public string AGRatioNor
        {
            get => GET(ref _agrationor);
            set => SET(ref _agrationor, value);
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

        private void InitializeCollectionProperties(Biochemistry biochemistryModel)
        {
        }

        private void InitializeComplexProperties(Biochemistry biochemistryModel)
        {
            // One To One
            if (biochemistryModel.Patient != null)
                PatientW = new PatientW(
                    biochemistryModel.Patient);
        }
    }
}