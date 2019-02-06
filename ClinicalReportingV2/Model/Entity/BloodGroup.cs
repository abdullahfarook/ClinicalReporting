using System;
using ClinicalReporting.Common;
using ServiceStack.DataAnnotations;

namespace ClinicalReporting.Model
{
    [Alias("BloodGroup")]
    public class BloodGroup : IModelCommon
    {
        [PrimaryKey]
        [Alias("SerialNo")]
        public long SerialNo { get; set; }

        [Alias("PatientID")]
        public long PatientID { get; set; }

        [Alias("TDate")]
        public DateTime TDate { get; set; }

        [Alias("Patient_Blood_Group")]
        public string PatientBloodGroup { get; set; }

        [Alias("Donar_Name")]
        public string DonarName { get; set; }

        [Alias("Donar_Blood_Group")]
        public string DonarBloodGroup { get; set; }

        [Alias("HbsAg")]
        public string HbsAg { get; set; }

        [Alias("AntiHCV")]
        public string AntiHCV { get; set; }

        [Alias("Fee")]
        public int Fee { get; set; }

        [Ignore]
        public virtual Patient Patient { get; set; }

        [Ignore]
        public bool IsNew => SerialNo == default(int);

        [Ignore]
        public bool IsDeleted { get; set; }
    }
}