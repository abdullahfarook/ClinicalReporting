using System;
using ClinicalReporting.Common;
using ServiceStack.DataAnnotations;

namespace ClinicalReporting.Model
{
    [Alias("Haematology")]
    public class Haematology : IModelCommon
    {
        [PrimaryKey]
        [Alias("SerialNo")]
        public long SerialNo { get; set; }

        [Alias("PatientID")]
        public long PatientID { get; set; }

        [Alias("TDate")]
        public DateTime TDate { get; set; }

        [Alias("HB")]
        public string Hb { get; set; }

        [Alias("HB_Unit")]
        public string HBUnit { get; set; }

        [Alias("HB_Nor")]
        public string HBNor { get; set; }

        [Alias("TLC")]
        public string Tlc { get; set; }

        [Alias("TLC_Unit")]
        public string TLCUnit { get; set; }

        [Alias("TLC_Nor")]
        public string TLCNor { get; set; }

        [Alias("ESR")]
        public string Esr { get; set; }

        [Alias("ESR_Unit")]
        public string ESRUnit { get; set; }

        [Alias("ESR_Nor")]
        public string ESRNor { get; set; }

        [Alias("BT")]
        public string Bt { get; set; }

        [Alias("BT_Unit")]
        public string BTUnit { get; set; }

        [Alias("BT_Nor")]
        public string BTNor { get; set; }

        [Alias("CT")]
        public string Ct { get; set; }

        [Alias("CT_Unit")]
        public string CTUnit { get; set; }

        [Alias("CT_Nor")]
        public string CTNor { get; set; }

        [Alias("Platelets_Count")]
        public string PlateletsCount { get; set; }

        [Alias("Platelets_Count_Unit")]
        public string PlateletsCountUnit { get; set; }

        [Alias("Platelets_Count_Nor")]
        public string PlateletsCountNor { get; set; }

        [Alias("PT")]
        public string Pt { get; set; }

        [Alias("PT_Unit")]
        public string PTUnit { get; set; }

        [Alias("PT_Nor")]
        public string PTNor { get; set; }

        [Alias("DLC")]
        public string Dlc { get; set; }

        [Alias("DLC_Unit")]
        public string DLCUnit { get; set; }

        [Alias("DLC_Nor")]
        public string DLCNor { get; set; }

        [Alias("Polymorphs")]
        public string Polymorphs { get; set; }

        [Alias("Polymorphs_Unit")]
        public string PolymorphsUnit { get; set; }

        [Alias("Polymorphs_Nor")]
        public string PolymorphsNor { get; set; }

        [Alias("Lymphocytes")]
        public string Lymphocytes { get; set; }

        [Alias("Lymphocytes_Unit")]
        public string LymphocytesUnit { get; set; }

        [Alias("Lymphocytes_Nor")]
        public string LymphocytesNor { get; set; }

        [Alias("Monocyte")]
        public string Monocyte { get; set; }

        [Alias("Monocyte_Unit")]
        public string MonocyteUnit { get; set; }

        [Alias("Monocyte_Nor")]
        public string MonocyteNor { get; set; }

        [Alias("Eosinophil")]
        public string Eosinophil { get; set; }

        [Alias("Eosinophil_Unit")]
        public string EosinophilUnit { get; set; }

        [Alias("Eosinophil_Nor")]
        public string EosinophilNor { get; set; }

        [Alias("Basophil")]
        public string Basophil { get; set; }

        [Alias("Basophil_Unit")]
        public string BasophilUnit { get; set; }

        [Alias("Basophil_Nor")]
        public string BasophilNor { get; set; }

        [Alias("Malaria_Parasites")]
        public string MalariaParasites { get; set; }

        [Alias("Malaria_Parasites_Unit")]
        public string MalariaParasitesUnit { get; set; }

        [Alias("Malaria_Parasites_Nor")]
        public string MalariaParasitesNor { get; set; }

        [Alias("Blood_Group")]
        public string BloodGroup { get; set; }

        [Alias("Blood_Group_Unit")]
        public string BloodGroupUnit { get; set; }

        [Alias("Blood_Group_Nor")]
        public string BloodGroupNor { get; set; }

        [Alias("RH_Factor")]
        public string RHFactor { get; set; }

        [Alias("RH_Factor_Unit")]
        public string RHFactorUnit { get; set; }

        [Alias("RH_Factor_Nor")]
        public string RHFactorNor { get; set; }

        [Alias("Total_R_B_C")]
        public string TotalRBC { get; set; }

        [Alias("Total_R_B_C_Unit")]
        public string TotalRBCUnit { get; set; }

        [Alias("Total_R_B_C_Nor")]
        public string TotalRBCNor { get; set; }

        [Alias("P_V_C_Haematorcrit")]
        public string PVCHaematorcrit { get; set; }

        [Alias("P_V_C_Haematorcrit_Unit")]
        public string PVCHaematorcritUnit { get; set; }

        [Alias("P_V_C_Haematorcrit_Nor")]
        public string PVCHaematorcritNor { get; set; }

        [Alias("M_C_V")]
        public string MCV { get; set; }

        [Alias("M_C_V_Unit")]
        public string MCVUnit { get; set; }

        [Alias("M_C_V_Nor")]
        public string MCVNor { get; set; }

        [Alias("M_C_H")]
        public string MCH { get; set; }

        [Alias("M_C_H_Unit")]
        public string MCHUnit { get; set; }

        [Alias("M_C_H_Nor")]
        public string MCHNor { get; set; }

        [Alias("M_C_H_C")]
        public string MCHC { get; set; }

        [Alias("M_C_H_C_Unit")]
        public string MCHCUnit { get; set; }

        [Alias("M_C_H_C_Nor")]
        public string MCHCNor { get; set; }

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