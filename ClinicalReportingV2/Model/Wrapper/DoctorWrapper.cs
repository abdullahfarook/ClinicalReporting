namespace ClinicalReporting.Model.Wrapper
{
    public class DoctorW : CommonWrapper<Doctor>
    {
        private long _doctorid;
        private string _doctorname;

        public DoctorW(Doctor doctorModel) : base(doctorModel)
        {
            InitializeComplexProperties(doctorModel);
            InitializeCollectionProperties(doctorModel);
        }

        public DoctorW() : base(null)
        {
        }

        public long DoctorID
        {
            get => GET(ref _doctorid);
            set => SET(ref _doctorid, value);
        }

        public string DoctorName
        {
            get => GET(ref _doctorname);
            set => SET(ref _doctorname, value);
        }

        private void InitializeCollectionProperties(Doctor doctorModel)
        {
        }

        private void InitializeComplexProperties(Doctor doctorModel)
        {
        }
    }
}