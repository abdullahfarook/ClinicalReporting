using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ClinicalReporting.Model.Wrapper
{
    public class PatientW : CommonWrapper<Patient>
    {
        private string _age;

        // One To Many
        // One To Many
        // One To Many
        // One To Many
        // One To Many
        // One To Many
        private string _name;

        private long _patientid;

        private string _refby;

        // One To Many
        // One To Many
        private string _sex;

        // One To Many
        public PatientW(Patient patientModel) : base(patientModel)
        {
            InitializeComplexProperties(patientModel);
            InitializeCollectionProperties(patientModel);
        }

        public PatientW() : base(null)
        {
        }

        public long PatientID
        {
            get => GET(ref _patientid);
            set => SET(ref _patientid, value);
        }

        [Required(ErrorMessage = "Patient Name is Required")]
        public string Name
        {
            get => GET(ref _name);
            set => SET(ref _name, value);
        }

        public string Age
        {
            get => GET(ref _age);
            set => SET(ref _age, value);
        }

        public string Sex
        {
            get => GET(ref _sex);
            set => SET(ref _sex, value);
        }

        public string RefBy
        {
            get => GET(ref _refby);
            set => SET(ref _refby, value);
        }

        public ObservableCollection<HaematologyW> HaematologiesW { get; set; }
        public ObservableCollection<ElisaTbW> ElisaTbsW { get; set; }
        public ObservableCollection<ElisaHcvW> ElisaHcvsW { get; set; }
        public ObservableCollection<ElisaHbsagW> ElisaHbsagsW { get; set; }
        public ObservableCollection<BloodGroupW> BloodGroupsW { get; set; }
        public ObservableCollection<BiochemistryW> BiochemistriesW { get; set; }
        public ObservableCollection<SemenAnalysisW> SemenAnalysesW { get; set; }
        public ObservableCollection<UrineExaminationW> UrineExaminationsW { get; set; }
        public ObservableCollection<SerologyW> SerologiesW { get; set; }

        private void InitializeCollectionProperties(Patient patientModel)
        {
            // One To Many
            if (patientModel.Haematologies != null)
            {
                HaematologiesW = new ObservableCollection<HaematologyW>(
                    patientModel.Haematologies.Select(e => new HaematologyW(e)));
                RegisterCollection(HaematologiesW, patientModel.Haematologies);
            }
            // One To Many
            if (patientModel.ElisaTbs != null)
            {
                ElisaTbsW = new ObservableCollection<ElisaTbW>(
                    patientModel.ElisaTbs.Select(e => new ElisaTbW(e)));
                RegisterCollection(ElisaTbsW, patientModel.ElisaTbs);
            }
            // One To Many
            if (patientModel.ElisaHcvs != null)
            {
                ElisaHcvsW = new ObservableCollection<ElisaHcvW>(
                    patientModel.ElisaHcvs.Select(e => new ElisaHcvW(e)));
                RegisterCollection(ElisaHcvsW, patientModel.ElisaHcvs);
            }
            // One To Many
            if (patientModel.ElisaHbsags != null)
            {
                ElisaHbsagsW = new ObservableCollection<ElisaHbsagW>(
                    patientModel.ElisaHbsags.Select(e => new ElisaHbsagW(e)));
                RegisterCollection(ElisaHbsagsW, patientModel.ElisaHbsags);
            }
            // One To Many
            if (patientModel.BloodGroups != null)
            {
                BloodGroupsW = new ObservableCollection<BloodGroupW>(
                    patientModel.BloodGroups.Select(e => new BloodGroupW(e)));
                RegisterCollection(BloodGroupsW, patientModel.BloodGroups);
            }
            // One To Many
            if (patientModel.Biochemistries != null)
            {
                BiochemistriesW = new ObservableCollection<BiochemistryW>(
                    patientModel.Biochemistries.Select(e => new BiochemistryW(e)));
                RegisterCollection(BiochemistriesW, patientModel.Biochemistries);
            }
            // One To Many
            if (patientModel.SemenAnalyses != null)
            {
                SemenAnalysesW = new ObservableCollection<SemenAnalysisW>(
                    patientModel.SemenAnalyses.Select(e => new SemenAnalysisW(e)));
                RegisterCollection(SemenAnalysesW, patientModel.SemenAnalyses);
            }
            // One To Many
            if (patientModel.UrineExaminations != null)
            {
                UrineExaminationsW = new ObservableCollection<UrineExaminationW>(
                    patientModel.UrineExaminations.Select(e => new UrineExaminationW(e)));
                RegisterCollection(UrineExaminationsW, patientModel.UrineExaminations);
            }
            // One To Many
            if (patientModel.Serologies != null)
            {
                SerologiesW = new ObservableCollection<SerologyW>(
                    patientModel.Serologies.Select(e => new SerologyW(e)));
                RegisterCollection(SerologiesW, patientModel.Serologies);
            }
        }

        private void InitializeComplexProperties(Patient patientModel)
        {
        }
    }
}