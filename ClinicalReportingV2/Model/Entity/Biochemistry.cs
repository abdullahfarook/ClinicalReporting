using System;
using ClinicalReporting.Common;
using ServiceStack.DataAnnotations;

namespace ClinicalReporting.Model
{
    [Alias("Biochemistry")]
    public class Biochemistry : IModelCommon
    {
        [PrimaryKey]
        [Alias("SerialNo")]
        public long SerialNo { get; set; }

        [Alias("PatientID")]
        public long PatientID { get; set; }

        [Alias("TDate")]
        public DateTime TDate { get; set; }

        [Alias("Blood_Sugar_Fasting")]
        public string BloodSugarFasting { get; set; }

        [Alias("Blood_Sugar_Fasting_Unit")]
        public string BloodSugarFastingUnit { get; set; }

        [Alias("Blood_Sugar_Fasting_Nor")]
        public string BloodSugarFastingNor { get; set; }

        [Alias("Blood_Sugar_2HPP")]
        public string BloodSugar2HPP { get; set; }

        [Alias("Blood_Sugar_2HPP_Unit")]
        public string BloodSugar2HPPUnit { get; set; }

        [Alias("Blood_Sugar_2HPP_Nor")]
        public string BloodSugar2HPPNor { get; set; }

        [Alias("Blood_Sugar_Random")]
        public string BloodSugarRandom { get; set; }

        [Alias("Blood_Sugar_Random_Unit")]
        public string BloodSugarRandomUnit { get; set; }

        [Alias("Blood_Sugar_Random_Nor")]
        public string BloodSugarRandomNor { get; set; }

        [Alias("Blood_Urea")]
        public string BloodUrea { get; set; }

        [Alias("Blood_Urea_Unit")]
        public string BloodUreaUnit { get; set; }

        [Alias("Blood_Urea_Nor")]
        public string BloodUreaNor { get; set; }

        [Alias("BUN")]
        public string Bun { get; set; }

        [Alias("BUN_Unit")]
        public string BUNUnit { get; set; }

        [Alias("BUN_Nor")]
        public string BUNNor { get; set; }

        [Alias("S_Creatinine")]
        public string SCreatinine { get; set; }

        [Alias("S_Creatinine_Unit")]
        public string SCreatinineUnit { get; set; }

        [Alias("S_Creatinine_Nor")]
        public string SCreatinineNor { get; set; }

        [Alias("S_Uric_Acid")]
        public string SUricAcid { get; set; }

        [Alias("S_Uric_Acid_Unit")]
        public string SUricAcidUnit { get; set; }

        [Alias("S_Uric_Acid_Nor")]
        public string SUricAcidNor { get; set; }

        [Alias("S_Cholestrol")]
        public string SCholestrol { get; set; }

        [Alias("S_Cholestrol_Unit")]
        public string SCholestrolUnit { get; set; }

        [Alias("S_Cholestrol_Nor")]
        public string SCholestrolNor { get; set; }

        [Alias("S_Triglycerides")]
        public string STriglycerides { get; set; }

        [Alias("S_Triglycerides_Unit")]
        public string STriglyceridesUnit { get; set; }

        [Alias("S_Triglycerides_Nor")]
        public string STriglyceridesNor { get; set; }

        [Alias("HDL_Cholestrol")]
        public string HDLCholestrol { get; set; }

        [Alias("HDL_Cholestrol_Unit")]
        public string HDLCholestrolUnit { get; set; }

        [Alias("HDL_Cholestrol_Nor")]
        public string HDLCholestrolNor { get; set; }

        [Alias("LDL_Cholestrol")]
        public string LDLCholestrol { get; set; }

        [Alias("LDL_Cholestrol_Unit")]
        public string LDLCholestrolUnit { get; set; }

        [Alias("LDL_Cholestrol_Nor")]
        public string LDLCholestrolNor { get; set; }

        [Alias("SGOT_AST")]
        public string SgotAst { get; set; }

        [Alias("SGOT_AST_Unit")]
        public string SGOTASTUnit { get; set; }

        [Alias("SGOT_Nor")]
        public string SGOTNor { get; set; }

        [Alias("LDH")]
        public string Ldh { get; set; }

        [Alias("LDH_Unit")]
        public string LDHUnit { get; set; }

        [Alias("LDH_Nor")]
        public string LDHNor { get; set; }

        [Alias("CPK")]
        public string Cpk { get; set; }

        [Alias("CPK_Unit")]
        public string CPKUnit { get; set; }

        [Alias("CPK_Nor")]
        public string CPKNor { get; set; }

        [Alias("CKMB")]
        public string Ckmb { get; set; }

        [Alias("CKMB_Unit")]
        public string CKMBUnit { get; set; }

        [Alias("CKMB_Nor")]
        public string CKMBNor { get; set; }

        [Alias("S_Bilirubin_T")]
        public string SBilirubinT { get; set; }

        [Alias("S_Bilirubin_T_Unit")]
        public string SBilirubinTUnit { get; set; }

        [Alias("S_Bilirubin_T_Nor")]
        public string SBilirubinTNor { get; set; }

        [Alias("S_Bilirubin_D")]
        public string SBilirubinD { get; set; }

        [Alias("S_Bilirubin_D_Unit")]
        public string SBilirubinDUnit { get; set; }

        [Alias("S_Bilirubin_D_Nor")]
        public string SBilirubinDNor { get; set; }

        [Alias("S_Bilirubin_Ind")]
        public string SBilirubinInd { get; set; }

        [Alias("S_Bilirubin_Ind_Unit")]
        public string SBilirubinIndUnit { get; set; }

        [Alias("S_Bilirubin_Ind_Nor")]
        public string SBilirubinIndNor { get; set; }

        [Alias("S_Alk_Phosphatase")]
        public string SAlkPhosphatase { get; set; }

        [Alias("S_Alk_Phosphatase_Unit")]
        public string SAlkPhosphataseUnit { get; set; }

        [Alias("S_Alk_Phosphatase_Nor")]
        public string SAlkPhosphataseNor { get; set; }

        [Alias("SGPT_ALT")]
        public string SgptAlt { get; set; }

        [Alias("SGPT_ALT_Unit")]
        public string SGPTALTUnit { get; set; }

        [Alias("SGPT_ALT_Nor")]
        public string SGPTALTNor { get; set; }

        [Alias("S_Sodium")]
        public string SSodium { get; set; }

        [Alias("S_Sodium_Unit")]
        public string SSodiumUnit { get; set; }

        [Alias("S_Sodium_Nor")]
        public string SSodiumNor { get; set; }

        [Alias("S_Potassium")]
        public string SPotassium { get; set; }

        [Alias("S_Potassium_Unit")]
        public string SPotassiumUnit { get; set; }

        [Alias("S_Potassium_Nor")]
        public string SPotassiumNor { get; set; }

        [Alias("S_Chloride")]
        public string SChloride { get; set; }

        [Alias("S_Chloride_Unit")]
        public string SChlorideUnit { get; set; }

        [Alias("S_Chloride_Nor")]
        public string SChlorideNor { get; set; }

        [Alias("S_Calcium")]
        public string SCalcium { get; set; }

        [Alias("S_Calcium_Unit")]
        public string SCalciumUnit { get; set; }

        [Alias("S_Calcium_Nor")]
        public string SCalciumNor { get; set; }

        [Alias("S_Protein")]
        public string SProtein { get; set; }

        [Alias("S_Protein_Unit")]
        public string SProteinUnit { get; set; }

        [Alias("S_Protein_Nor")]
        public string SProteinNor { get; set; }

        [Alias("S_Albumin")]
        public string SAlbumin { get; set; }

        [Alias("S_Albumin_Unit")]
        public string SAlbuminUnit { get; set; }

        [Alias("S_Albumin_Nor")]
        public string SAlbuminNor { get; set; }

        [Alias("AG_Ratio")]
        public string AGRatio { get; set; }

        [Alias("AG_Ratio_Unit")]
        public string AGRatioUnit { get; set; }

        [Alias("AG_Ratio_Nor")]
        public string AGRatioNor { get; set; }

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