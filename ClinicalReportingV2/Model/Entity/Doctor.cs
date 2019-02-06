using ClinicalReporting.Common;
using ServiceStack.DataAnnotations;

namespace ClinicalReporting.Model
{
    [Alias("Doctor")]
    public class Doctor : IModelCommon
    {
        [PrimaryKey]
        [Alias("DoctorID")]
        public long DoctorID { get; set; }

        [Alias("DoctorName")]
        public string DoctorName { get; set; }

        [Ignore]
        public bool IsNew => DoctorID == default(int);

        [Ignore]
        public bool IsDeleted { get; set; }
    }
}