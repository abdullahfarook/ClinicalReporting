using System;

namespace ClinicalReporting.Model.Wrapper
{
    public class HaematologyW : CommonWrapper<Haematology>
    {
        private string _basophil;
        private string _basophilnor;
        private string _basophilunit;
        private string _bloodgroup;
        private string _bloodgroupnor;
        private string _bloodgroupunit;
        private string _bt;
        private string _btnor;
        private string _btunit;
        private string _ct;
        private string _ctnor;
        private string _ctunit;
        private string _dlc;
        private string _dlcnor;
        private string _dlcunit;
        private string _eosinophil;
        private string _eosinophilnor;
        private string _eosinophilunit;
        private string _esr;
        private string _esrnor;
        private string _esrunit;
        private int _fee;
        private string _hb;
        private string _hbnor;
        private string _hbunit;
        private string _lymphocytes;
        private string _lymphocytesnor;
        private string _lymphocytesunit;
        private string _malariaparasites;
        private string _malariaparasitesnor;
        private string _malariaparasitesunit;
        private string _mch;
        private string _mchc;
        private string _mchcnor;
        private string _mchcunit;
        private string _mchnor;
        private string _mchunit;
        private string _mcv;
        private string _mcvnor;
        private string _mcvunit;
        private string _monocyte;
        private string _monocytenor;
        private string _monocyteunit;

        private long _patientid;

        // One To One
        private PatientW _patientw;

        private string _plateletscount;
        private string _plateletscountnor;
        private string _plateletscountunit;
        private string _polymorphs;
        private string _polymorphsnor;
        private string _polymorphsunit;
        private string _pt;
        private string _ptnor;
        private string _ptunit;
        private string _pvchaematorcrit;
        private string _pvchaematorcritnor;
        private string _pvchaematorcritunit;
        private string _rhfactor;
        private string _rhfactornor;
        private string _rhfactorunit;
        private long _serialno;
        private DateTime _tdate;
        private string _tlc;
        private string _tlcnor;
        private string _tlcunit;
        private string _totalrbc;
        private string _totalrbcnor;
        private string _totalrbcunit;

        public HaematologyW(Haematology haematologyModel) : base(haematologyModel)
        {
            InitializeComplexProperties(haematologyModel);
            InitializeCollectionProperties(haematologyModel);
        }

        public HaematologyW() : base(null)
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

        public string Hb
        {
            get => GET(ref _hb);
            set => SET(ref _hb, value);
        }

        public string HBUnit
        {
            get => GET(ref _hbunit);
            set => SET(ref _hbunit, value);
        }

        public string HBNor
        {
            get => GET(ref _hbnor);
            set => SET(ref _hbnor, value);
        }

        public string Tlc
        {
            get => GET(ref _tlc);
            set => SET(ref _tlc, value);
        }

        public string TLCUnit
        {
            get => GET(ref _tlcunit);
            set => SET(ref _tlcunit, value);
        }

        public string TLCNor
        {
            get => GET(ref _tlcnor);
            set => SET(ref _tlcnor, value);
        }

        public string Esr
        {
            get => GET(ref _esr);
            set => SET(ref _esr, value);
        }

        public string ESRUnit
        {
            get => GET(ref _esrunit);
            set => SET(ref _esrunit, value);
        }

        public string ESRNor
        {
            get => GET(ref _esrnor);
            set => SET(ref _esrnor, value);
        }

        public string Bt
        {
            get => GET(ref _bt);
            set => SET(ref _bt, value);
        }

        public string BTUnit
        {
            get => GET(ref _btunit);
            set => SET(ref _btunit, value);
        }

        public string BTNor
        {
            get => GET(ref _btnor);
            set => SET(ref _btnor, value);
        }

        public string Ct
        {
            get => GET(ref _ct);
            set => SET(ref _ct, value);
        }

        public string CTUnit
        {
            get => GET(ref _ctunit);
            set => SET(ref _ctunit, value);
        }

        public string CTNor
        {
            get => GET(ref _ctnor);
            set => SET(ref _ctnor, value);
        }

        public string PlateletsCount
        {
            get => GET(ref _plateletscount);
            set => SET(ref _plateletscount, value);
        }

        public string PlateletsCountUnit
        {
            get => GET(ref _plateletscountunit);
            set => SET(ref _plateletscountunit, value);
        }

        public string PlateletsCountNor
        {
            get => GET(ref _plateletscountnor);
            set => SET(ref _plateletscountnor, value);
        }

        public string Pt
        {
            get => GET(ref _pt);
            set => SET(ref _pt, value);
        }

        public string PTUnit
        {
            get => GET(ref _ptunit);
            set => SET(ref _ptunit, value);
        }

        public string PTNor
        {
            get => GET(ref _ptnor);
            set => SET(ref _ptnor, value);
        }

        public string Dlc
        {
            get => GET(ref _dlc);
            set => SET(ref _dlc, value);
        }

        public string DLCUnit
        {
            get => GET(ref _dlcunit);
            set => SET(ref _dlcunit, value);
        }

        public string DLCNor
        {
            get => GET(ref _dlcnor);
            set => SET(ref _dlcnor, value);
        }

        public string Polymorphs
        {
            get => GET(ref _polymorphs);
            set => SET(ref _polymorphs, value);
        }

        public string PolymorphsUnit
        {
            get => GET(ref _polymorphsunit);
            set => SET(ref _polymorphsunit, value);
        }

        public string PolymorphsNor
        {
            get => GET(ref _polymorphsnor);
            set => SET(ref _polymorphsnor, value);
        }

        public string Lymphocytes
        {
            get => GET(ref _lymphocytes);
            set => SET(ref _lymphocytes, value);
        }

        public string LymphocytesUnit
        {
            get => GET(ref _lymphocytesunit);
            set => SET(ref _lymphocytesunit, value);
        }

        public string LymphocytesNor
        {
            get => GET(ref _lymphocytesnor);
            set => SET(ref _lymphocytesnor, value);
        }

        public string Monocyte
        {
            get => GET(ref _monocyte);
            set => SET(ref _monocyte, value);
        }

        public string MonocyteUnit
        {
            get => GET(ref _monocyteunit);
            set => SET(ref _monocyteunit, value);
        }

        public string MonocyteNor
        {
            get => GET(ref _monocytenor);
            set => SET(ref _monocytenor, value);
        }

        public string Eosinophil
        {
            get => GET(ref _eosinophil);
            set => SET(ref _eosinophil, value);
        }

        public string EosinophilUnit
        {
            get => GET(ref _eosinophilunit);
            set => SET(ref _eosinophilunit, value);
        }

        public string EosinophilNor
        {
            get => GET(ref _eosinophilnor);
            set => SET(ref _eosinophilnor, value);
        }

        public string Basophil
        {
            get => GET(ref _basophil);
            set => SET(ref _basophil, value);
        }

        public string BasophilUnit
        {
            get => GET(ref _basophilunit);
            set => SET(ref _basophilunit, value);
        }

        public string BasophilNor
        {
            get => GET(ref _basophilnor);
            set => SET(ref _basophilnor, value);
        }

        public string MalariaParasites
        {
            get => GET(ref _malariaparasites);
            set => SET(ref _malariaparasites, value);
        }

        public string MalariaParasitesUnit
        {
            get => GET(ref _malariaparasitesunit);
            set => SET(ref _malariaparasitesunit, value);
        }

        public string MalariaParasitesNor
        {
            get => GET(ref _malariaparasitesnor);
            set => SET(ref _malariaparasitesnor, value);
        }

        public string BloodGroup
        {
            get => GET(ref _bloodgroup);
            set => SET(ref _bloodgroup, value);
        }

        public string BloodGroupUnit
        {
            get => GET(ref _bloodgroupunit);
            set => SET(ref _bloodgroupunit, value);
        }

        public string BloodGroupNor
        {
            get => GET(ref _bloodgroupnor);
            set => SET(ref _bloodgroupnor, value);
        }

        public string RHFactor
        {
            get => GET(ref _rhfactor);
            set => SET(ref _rhfactor, value);
        }

        public string RHFactorUnit
        {
            get => GET(ref _rhfactorunit);
            set => SET(ref _rhfactorunit, value);
        }

        public string RHFactorNor
        {
            get => GET(ref _rhfactornor);
            set => SET(ref _rhfactornor, value);
        }

        public string TotalRBC
        {
            get => GET(ref _totalrbc);
            set => SET(ref _totalrbc, value);
        }

        public string TotalRBCUnit
        {
            get => GET(ref _totalrbcunit);
            set => SET(ref _totalrbcunit, value);
        }

        public string TotalRBCNor
        {
            get => GET(ref _totalrbcnor);
            set => SET(ref _totalrbcnor, value);
        }

        public string PVCHaematorcrit
        {
            get => GET(ref _pvchaematorcrit);
            set => SET(ref _pvchaematorcrit, value);
        }

        public string PVCHaematorcritUnit
        {
            get => GET(ref _pvchaematorcritunit);
            set => SET(ref _pvchaematorcritunit, value);
        }

        public string PVCHaematorcritNor
        {
            get => GET(ref _pvchaematorcritnor);
            set => SET(ref _pvchaematorcritnor, value);
        }

        public string MCV
        {
            get => GET(ref _mcv);
            set => SET(ref _mcv, value);
        }

        public string MCVUnit
        {
            get => GET(ref _mcvunit);
            set => SET(ref _mcvunit, value);
        }

        public string MCVNor
        {
            get => GET(ref _mcvnor);
            set => SET(ref _mcvnor, value);
        }

        public string MCH
        {
            get => GET(ref _mch);
            set => SET(ref _mch, value);
        }

        public string MCHUnit
        {
            get => GET(ref _mchunit);
            set => SET(ref _mchunit, value);
        }

        public string MCHNor
        {
            get => GET(ref _mchnor);
            set => SET(ref _mchnor, value);
        }

        public string MCHC
        {
            get => GET(ref _mchc);
            set => SET(ref _mchc, value);
        }

        public string MCHCUnit
        {
            get => GET(ref _mchcunit);
            set => SET(ref _mchcunit, value);
        }

        public string MCHCNor
        {
            get => GET(ref _mchcnor);
            set => SET(ref _mchcnor, value);
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

        private void InitializeCollectionProperties(Haematology haematologyModel)
        {
        }

        private void InitializeComplexProperties(Haematology haematologyModel)
        {
            // One To One
            if (haematologyModel.Patient != null)
                PatientW = new PatientW(
                    haematologyModel.Patient);
        }
    }
}