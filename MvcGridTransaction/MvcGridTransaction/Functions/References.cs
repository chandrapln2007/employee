using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEMS_SAP.Functions
{
    public class References
    {
        public const string DATE_FORMAT_YMD2 = "yy-MM-dd";
        public const string DATE_FORMAT_YEAR = "yyyy";
        public const string DATE_FORMAT = "dd MMM yyyy";
        public const string DATE_FORMAT_DD_MM_YYYY = "dd-MMM-yyyy";
        public const string DATE_FORMAT_MMM = "MMM/dd/yyyy";
        public const string DATE_FORMAT_XLS = "yyyyMMddhhmmss";
        public const string DATE_FORMAT_STANDARD = "MMM dd yyyy h:mmtt";
        public const string DATE_FORMAT_TIME = "yyyy-MM-dd hh:mm:ss";

        public const string DATE_FORMAT_YMD = "yyyy/MM/dd";
        public const string DATE_FORMAT_M = "MM";
        public const string DATE_FORMAT_Y = "yy";

        public const string DATE_FORMAT_Y_M_D = "yyyy-MM-dd";
        public const string DATE_FORMAT_M_Y = "MMyy";
        public const string DATE_FORMAT_Y_M = "yyMM";

        public const string TIME_FORMAT = "HH:mm";
        public const string NUMBER_FORMAT = "#,##0";
        public const string NUMBER_FORMAT_TWO_DIGIT = "#,##0.00";
        public const string NUMBER_FORMAT_4_DIGIT = "#,##0.0000";
        public const string NUMBER_FORMAT_6_DIGIT = "#,##0.000000";
        public const string NUMBER_FORMAT_8_DIGIT = "#,##0.00000000";

        public const string NUMBER_FORMAT_COMA = "#,##0";
        public const string NUMBER_FORMAT_COMA_TWO_DIGIT = "#.##0,00";
        public const string NUMBER_FORMAT_COMA_4_DIGIT = "#.##0,0000";
        public const string NUMBER_FORMAT_COMA_6_DIGIT = "#.##0,000000";
        public const string NUMBER_FORMAT_COMA_8_DIGIT = "#.##0,00000000";

        public const string url = "http://192.168.5.7:90/";
        public const string urlLogin = "http://192.168.5.7:90/Account/Login";
        public const string urlAttached = "http://192.168.5.7:90/Content/FileUploadPR/";
        public const int builtProgram = 1;

        #region GR-Roles
        public string GR_MDL = "TRS02";
        public string GR_CRT_WH = "TRS02-01";
        public string GR_DISP_TSON = "TRS02-03";
        public string GR_DISP_TSOF = "TRS02-04";
        public string GR_ADM_SAP_TSON = "TRS02-05";
        public string GR_ADM_SAP_TSOF = "TRS02-06";

        //Group Roles
        public int GR_ROLES_GRP_WH = 1001;
        public int GR_ROLES_GRP_ADM_INV_SAP = 1002;

        public string WH_CRT = "MST09-01";
        public string WH_OFFSHORE = "MST09-02";
        public string WH_ONSHORE = "MST09-03";

        #endregion
    }

    public enum statusGR : int
    {
        DRAFT = 0, // INI JIKA SAVE DRAFT
        OPEN = 1, // INI JIKA KLIK TOMBOL SEND
        ON_PROGRESS = 2, // INI JIKA ADA COMMENT DARI SAP ADMIN
        CLOSED = 3, // INI JIKA SDH DI BUATKAN GR SAP NO
        REVISI = 4, // INI JIKA SDH DI BUATKAN GR SAP NO DAN MELAKUKAN REVISI OLEH ADMIN
        DisplayDataForView=5, // INI JIKA KLIK DISPAY DI LIST
        CANCELLED = -1 // INI JIKA MELAKUKAN REJECT DARI LIST
    }
    public enum statusGI_Return : int
    {
        DRAFT = 0, // INI JIKA SAVE DRAFT
        OPEN = 1, // INI JIKA KLIK TOMBOL SEND
        ON_PROGRESS = 2, // INI JIKA ADA COMMENT DARI SAP ADMIN
        CLOSED = 3, // INI JIKA SDH DI BUATKAN GR SAP NO
        REVISI = 4, // INI JIKA SDH DI BUATKAN GR SAP NO DAN MELAKUKAN REVISI OLEH ADMIN
        DisplayDataForView = 5, // INI JIKA KLIK DISPAY DI LIST
        CANCELLED = -1 // INI JIKA MELAKUKAN REJECT DARI LIST
    }
    public enum statusEventGRPO : int
    {
        DRAFT = 0, // INI JIKA SAVE DRAFT
        OPEN = 1, // INI JIKA KLIK TOMBOL SEND
        GR_UNDER_VERIFY = 10, // INI JIKA GR SDNG DI VERIFY OLEH ADMIN SAP, SBLM DI INPUT SAP
        ON_PROGRESS = 2, // INI JIKA ADA COMMENT DARI SAP ADMIN        
        CLOSED = 3, // INI JIKA SDH DI BUATKAN GR SAP NO
        REVISI = 4, // INI JIKA SDH DI BUATKAN GR SAP NO DAN MELAKUKAN REVISI OLEH ADMIN
        DisplayDataForView = 5, // INI JIKA KLIK DISPAY DI LIST
        UNDO_REVISI = 6, // INI JIKA UNDO REVISI
        CANCELLED = -1 // INI JIKA MELAKUKAN REJECT DARI LIST
    }
    public enum statusGI_PRJCT : int
    {
        Draft = 0,
        Register = 1,
        SubmitSend = 2,
        Comment = 3,
        Complete = 4,
        DisplayDataForView = 5,
        CANCELLED = -1
    }
    public enum statusTransfer : int
    {
        Draft = 0,
        Register = 1,
        SubmitSend = 2,
        Comment = 3,
        Complete = 4,
        DisplayDataForView = 5,
        CANCELLED = -1
    }



}