using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYUniversities.Models
{
    public class UnivSurvey
    {

        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public int UNITID { get; set; }
            public string INSTNM { get; set; }
            public string ADDR { get; set; }
            public string CITY { get; set; }
            public string STABBR { get; set; }
            public string ZIP { get; set; }
            public int FIPS { get; set; }
            public int OBEREG { get; set; }
            public string CHFNM { get; set; }
            public string CHFTITLE { get; set; }
            public long? GENTELE { get; set; }
            public long? FAXTELE { get; set; }
            public int EIN { get; set; }
            public int OPEID { get; set; }
            public int OPEFLAG { get; set; }
            public string WEBADDR { get; set; }
            public string ADMINURL { get; set; }
            public string FAIDURL { get; set; }
            public string APPLURL { get; set; }
            public string NPRICURL { get; set; }
            public int SECTOR { get; set; }
            public int ICLEVEL { get; set; }
            public int CONTROL { get; set; }
            public int HLOFFER { get; set; }
            public int UGOFFER { get; set; }
            public int GROFFER { get; set; }
            public int HDEGOFR1 { get; set; }
            public int DEGGRANT { get; set; }
            public int HBCU { get; set; }
            public int HOSPITAL { get; set; }
            public int MEDICAL { get; set; }
            public int TRIBAL { get; set; }
            public int LOCALE { get; set; }
            public int OPENPUBL { get; set; }
            public string ACT { get; set; }
            public int NEWID { get; set; }
            public int DEATHYR { get; set; }
            public string CLOSEDAT { get; set; }
            public int CYACTIVE { get; set; }
            public int POSTSEC { get; set; }
            public int PSEFLAG { get; set; }
            public int PSET4FLG { get; set; }
            public int RPTMTH { get; set; }
            public string IALIAS { get; set; }
            public int INSTCAT { get; set; }
            public int CCBASIC { get; set; }
            public int CCIPUG { get; set; }
            public int CCIPGRAD { get; set; }
            public int CCUGPROF { get; set; }
            public int CCENRPRF { get; set; }
            public int CCSIZSET { get; set; }
            public int CARNEGIE { get; set; }
            public int LANDGRNT { get; set; }
            public int INSTSIZE { get; set; }
            public int CBSA { get; set; }
            public int CBSATYPE { get; set; }
            public int CSA { get; set; }
            public int NECTA { get; set; }
            public int F1SYSTYP { get; set; }
            public string F1SYSNAM { get; set; }
            public int F1SYSCOD { get; set; }
            public int COUNTYCD { get; set; }
            public string COUNTYNM { get; set; }
            public int CNGDSTCD { get; set; }
            public float LONGITUD { get; set; }
            public float LATITUDE { get; set; }
        }

    }
}