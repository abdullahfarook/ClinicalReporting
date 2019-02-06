using System;
using ClinicalReporting.Common;
using ServiceStack.DataAnnotations;

namespace ClinicalReporting.Model
{
    [Alias("Serology")]
    public class Serology : IModelCommon
    {
        [PrimaryKey]
        [Alias("SERIALNO")]
        public long Serialno { get; set; }

        [Alias("PATIENTID")]
        public long Patientid { get; set; }

        [Alias("TDATE")]
        public DateTime Tdate { get; set; }

        [Alias("WIDAL_TEST")]
        public string WidalTest { get; set; }

        [Alias("S_TYPHI_TO")]
        public string STyphiTo { get; set; }

        [Alias("S_TYPHI_TH")]
        public string STyphiTh { get; set; }

        [Alias("PARA_THYPHI_AH")]
        public string ParaThyphiAh { get; set; }

        [Alias("PARA_THYPHI_BH")]
        public string ParaThyphiBh { get; set; }

        [Alias("TYPHOID")]
        public string Typhoid { get; set; }

        [Alias("I_G_M")]
        public string IGM { get; set; }

        [Alias("I_G_G")]
        public string IGG { get; set; }

        [Alias("HBS_AG")]
        public string HbsAg { get; set; }

        [Alias("ASO_TITRE")]
        public string AsoTitre { get; set; }

        [Alias("PREGNANCY_TEST")]
        public string PregnancyTest { get; set; }

        [Alias("RA_FACTOR")]
        public string RaFactor { get; set; }

        [Alias("ANTI_HCV")]
        public string AntiHcv { get; set; }

        [Alias("MANTOEX")]
        public string Mantoex { get; set; }

        [Alias("KAHNS_VDRL")]
        public string KahnsVdrl { get; set; }

        [Alias("TB_PLUS")]
        public string TbPlus { get; set; }

        [Alias("IGM")]
        public string Igm { get; set; }

        [Alias("IGG")]
        public string Igg { get; set; }

        [Alias("HELICOBACTER_PYLORI")]
        public string HelicobacterPylori { get; set; }

        [Alias("HIV")]
        public string Hiv { get; set; }

        [Alias("FEE")]
        public long Fee { get; set; }

        [Ignore]
        public virtual Patient Patient { get; set; }

        [Ignore]
        public bool IsNew => Serialno == default(int);

        [Ignore]
        public bool IsDeleted { get; set; }
    }
}