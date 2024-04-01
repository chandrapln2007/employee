using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEMS_SAP.Functions
{
    public class PopulateInformations
    {
        public int DocType_ZPRM = 1;
        public int DocType_ZPRC = 2;
        public int DocType_ZPRL = 3;
        public int DocType_ZPRP = 4;

        public string TaskTo_PRRequestor = "TaskPRRequestor";
        public string TaskTo_PRadmin = "TaskPRAdmin";
        public string TaskTo_CostCenter = "TaskCostCenter";
        public string TaskTo_IntOrder = "TaskIntOrder";
        public string TaskTo_Asset = "TaskAsset";
        public string TaskTo_WBS = "TaskWBS";
        public string TaskTo_Approval = "TaskApproval";

        public int AccAss_CostCenter = 1;
        public int AccAss_IntOrder = 4;

        public int MailTo_CreateUser = 1;
        //public int MailTo_Requestor = 2;
        //public int MailTo_PRAdmin = 3;
        //public int MailTo_Asset = 4;
        //public int MailTo_WBS = 5;
        public int MailTo_Forgot_Password = 6;
        public int MailTo_UserPR = 7;
        public int MailTo_Approval = 8;
        public int MailTo_Revise = 9;
        public int MailTo_Reject = 10;
        public int MailTo_Approval_Final = 11;
        public int MailTo_Revise_UnLock = 12;
        public int MailTo_Reject_Unlock = 13;

        #region StatusPR
        //Upd Status By Creator
        public int StatusPR_Cancel = 99;
        public int StatusPR_Draft = 0;
        public int StatusPR_Create = 1;
        public int StatusPR_Req_Corr_SAP = 9;
        public int StatusPR_RunToApproval = 10;

        public int StatusPR_SubmitAsset = 2;
        public int StatusPR_SubmitWBS = 3;
        public int StatusPR_SubmitAdmin = 4;
       
        public int StatusPR_Approved = 5;
        public int StatusPR_Revised = 6;
        public int StatusPR_Rejected = 7;
        public int StatusPR_Approved_Final = 8;
        public int StatusPR_RejectedFromUnlockRevised = 11;
        #endregion

        public int StatusMstApproval_Draft = 0;
        public int StatusMstApproval_Create = 1;

        public int StatusRNM_Create = 1;
        public int StatusRNM_Approved = 2;

        public int IsRoleApprove = 1;
        public int IsRoleView = 2;         
        public int DoActionApprove = 1;
        public int DoActionRevise = 2;
        public int DoActionReject = 3;
        public int DoActionJustComment = 4;

        //To Requestor
        public int Rev_NoPRSAP_Not_Insert = 1;  //Revisi PR TEMS sebelum No. PR SAP diinput ke TEMS
        public int Rev_NoPRSAP_Insert = 2;      //Revisi PR TEMS setelah No. PR SAP diinput ke TEMS
        public int Rev_FromAppToReq = 4;        //Revisi PR TEMS dari approval ke requestor
        public int Rev_DraftFromAdmin = 5;      //Revisi PR TEMS dari PR Admin lalu action Draft.
        //To PR Admin
        public int Rev_PRinSAP = 3;      //Admin Revisi PR di SAP, lalu update attachment di PR TEMS 

        //public int Rev_Approval_Running = 3;    //Revisi PR TEMS saat proses Approval TEMS
        //public int Rev_Approval_Finish = 4;     //Revisi PR TEMS setelah Approval SAP

        #region PR-Tracking-Record
        public string Rec_Draft = "Drafting";
        public string Rec_Cancel = "Cancel";
        public string Rec_Submit = "PR is submitted";
        public string Rec_After_ADM_Done = "Requestor is responding to PR";
        public string Rec_Req_Need_Rev_PR_SAP = "PR SAP need to be revised";
        public string Rec_Req_Approval_Process = "Approval on process";

        public string Rec_CC_Ver = "PR is under verification by Cost Control";
        public string Rec_CC_Done_NoChange = "Verification by Cost Control is done";
        public string Rec_CC_Done_Change_CostCenter = "Cost Center has been modified";
        public string Rec_CC_Done_Change_WBS = "WBS has been modified";

        public string Rec_AM_Ver = "PR is under verification by Asset Management";
        public string Rec_AM_Done_NoChange = "Verification by Asset Management is done";
        public string Rec_AM_Done_Change_Int_Ord = "Internal Order has been modified";
        public string Rec_AM_Done_Change_Asset = "Asset Number has been modified";

        public string Rec_ADM_Ver = "SAP Admin is responding to PR";
        public string Rec_ADM_Done = "PR SAP has been uploaded";

        public string Rec_App_Ver = "Approval is responding to PR";
        public string Rec_App_Approved = "PR has been approved";
        public string Rec_App_Revised = "PR need to be revised";
        public string Rec_App_Rejected = "PR was rejected";
        #endregion

        #region PR-Roles
        public string PR_CRT_TSON = "TRS01-01";
        public string PR_CRT_TSOF = "TRS01-02";
        public string PR_DISP_TSON = "TRS01-03";
        public string PR_DISP_TSOF = "TRS01-04";
        public string PR_CC_TSON = "TRS01-05";
        public string PR_CC_TSOF = "TRS01-06";
        public string PR_AMD_TSON = "TRS01-07";
        public string PR_AMD_TSOF = "TRS01-08";
        public string PR_ADM_SAP_TSON = "TRS01-09";
        public string PR_ADM_SAP_TSOF = "TRS01-10";
        //Group Roles
        public int PR_ROLES_GRP_CRT = 1000;
        public int PR_ROLES_GRP_CC = 1001;
        public int PR_ROLES_GRP_AM = 1002;
        public int PR_ROLES_GRP_ADM = 1003;
        #endregion

        #region MasterUser-Roles
        public string MasterUser_CRT = "MST12-01"; 
        #endregion

        #region MMR-Roles
        public string MMR_CRT_TSON = "TRS05-01";
        public string MMR_CRT_TSOF = "TRS05-02";
        public string MMR_DISP_TSON = "TRS05-03";
        public string MMR_DISP_TSOF = "TRS05-04";
        public string MMR_APP_TSON = "TRS05-05";
        public string MMR_APP_TSOF = "TRS05-06";
        //Others Info 
        public int MMR_ROLES_GRP_APP = 1002;
        public string MMR_APP_NAME = "AMD GROUP";
        #endregion

        #region MasterMaterial-Roles
        public string MM_CRT = "MST01-01";
        public string MM_DISP_USERL2_TEMS = "MST01-02";
        public string MM_DISP_USERL1_SAP = "MST01-03"; 
        #endregion

        #region MasterMaterial
        public int IsInActive = 0;
        public int IsActive = 1;
        public int IsGeneral = 1;
        public int IsDetail = 2;
        #endregion

        #region MasterMaterialRequest
        public int StatusMMR_Draft = 0;
        public int StatusMMR_Create = 1;
        public int StatusMMR_Approve = 2;
        public int StatusMMR_DraftByAM = 3;
        public int StatusMMR_Cancel = 4;
        #endregion

        #region eApproval
        //Matriks Approval
        public int PageSetting_First = 1;
        public int PageSetting_Last = 2;
        public int PageSetting_All = 3;

        public int FieldPosition_Bottom = 1;
        public int FieldPosition_Top = 2;

        public int RoleCC = 1;
        public int RoleApproval = 2;
        public int RoleRejectFromAssign = 3;

        //Distribution Documents
        public int MailToApproval = 1;
        public int MailToCC = 2;
        public int MailToNextApproval = 3;
        public int MailIsComplete = 4;
        public int MailIsReject = 5;
        public int MailIsAssignTo = 6;
        //
        public int StatusApp_OnProgress = 1;
        public int StatusApp_Done = 2;
        public int StatusApp_Reject = 3;

        public string HistoryViewAction = "Viewing";
        public string HistoryViewActiviey = "The envelope was viewed";
        public string HistoryViewStatus = "Viewing";

        public int _FlagSignEmpty = 0;
        public int _FlagSignDraw = 1;
        public int _FlagSignAdopt = 2;
        public int _FlagSignUpload = 3;
        #endregion
    }
}