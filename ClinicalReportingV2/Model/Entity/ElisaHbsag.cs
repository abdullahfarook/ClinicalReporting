using System;
using ClinicalReporting.Common;
using ServiceStack.DataAnnotations;

namespace ClinicalReporting.Model
{
    [Alias("ELISA_HBSAG")]
    public class ElisaHbsag : IModelCommon
    {
        [PrimaryKey]
        [Alias("SerialNo")]
        public long SerialNo { get; set; }

        [Alias("PatientID")]
        public long PatientID { get; set; }

        [Alias("TDate")]
        public DateTime TDate { get; set; }

        [Alias("Patient_Value")]
        public double PatientValue { get; set; }

        [Alias("Cut_Off_Value")]
        public double CutOffValue { get; set; }

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