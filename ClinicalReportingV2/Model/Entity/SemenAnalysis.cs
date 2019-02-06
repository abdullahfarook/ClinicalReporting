using System;
using ClinicalReporting.Common;
using ServiceStack.DataAnnotations;

namespace ClinicalReporting.Model
{
    [Alias("SemenAnalysis")]
    public class SemenAnalysis : IModelCommon
    {
        [PrimaryKey]
        [Alias("SerialNo")]
        public long SerialNo { get; set; }

        [Alias("PatientID")]
        public long PatientID { get; set; }

        [Alias("TDate")]
        public DateTime TDate { get; set; }

        [Alias("Colour")]
        public string Colour { get; set; }

        [Alias("Quantity")]
        public string Quantity { get; set; }

        [Alias("PH")]
        public string Ph { get; set; }

        [Alias("Time_Of_Collection")]
        public string TimeOfCollection { get; set; }

        [Alias("Time_Of_Examination")]
        public string TimeOfExamination { get; set; }

        [Alias("Total_Count")]
        public string TotalCount { get; set; }

        [Alias("Active_Motility")]
        public string ActiveMotility { get; set; }

        [Alias("Sluggish")]
        public string Sluggish { get; set; }

        [Alias("Non_Motile")]
        public string NonMotile { get; set; }

        [Alias("Abnormal")]
        public string Abnormal { get; set; }

        [Alias("Pus_Cells")]
        public string PusCells { get; set; }

        [Alias("RBC")]
        public string Rbc { get; set; }

        [Alias("Epithelial_Cell")]
        public string EpithelialCell { get; set; }

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