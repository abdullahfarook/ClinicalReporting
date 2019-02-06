using System;
using ClinicalReporting.Common;
using ServiceStack.DataAnnotations;

namespace ClinicalReporting.Model
{
    [Alias("UrineExamination")]
    public class UrineExamination : IModelCommon
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

        [Alias("Reaction")]
        public string Reaction { get; set; }

        [Alias("Specific_Gravity")]
        public string SpecificGravity { get; set; }

        [Alias("Albumin")]
        public string Albumin { get; set; }

        [Alias("Sugar")]
        public string Sugar { get; set; }

        [Alias("Ketone")]
        public string Ketone { get; set; }

        [Alias("Blood")]
        public string Blood { get; set; }

        [Alias("Bilirubin")]
        public string Bilirubin { get; set; }

        [Alias("Urobil_Nogen")]
        public string UrobilNogen { get; set; }

        [Alias("Pus_Cells")]
        public string PusCells { get; set; }

        [Alias("RBC")]
        public string Rbc { get; set; }

        [Alias("EPi_Cells")]
        public string EPiCells { get; set; }

        [Alias("Cast")]
        public string Cast { get; set; }

        [Alias("Crystals")]
        public string Crystals { get; set; }

        [Alias("Cal_Oxalate")]
        public string CalOxalate { get; set; }

        [Alias("Uric_Acid")]
        public string UricAcid { get; set; }

        [Alias("Amorphous")]
        public string Amorphous { get; set; }

        [Alias("Others")]
        public string Others { get; set; }

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