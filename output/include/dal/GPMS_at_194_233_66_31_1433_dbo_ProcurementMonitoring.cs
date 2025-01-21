using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_ProcurementMonitoring : tDALTable
    {
        public XVar Id;
        public XVar PpmpId;
        public XVar CodePAP;
        public XVar IsthisAnEarlyProcurementActivity;
        public XVar ModeOfProcurement;
        public XVar PreProcConference;
        public XVar AdsPostOfIB;
        public XVar PreBidConf;
        public XVar EligibilityCheck;
        public XVar SubOpenOfBids;
        public XVar BidEvaluation;
        public XVar PostQual;
        public XVar DateOfBACResolutionRecommendingAward;
        public XVar NoticeOfAward;
        public XVar ContractSigning;
        public XVar NoticeToProceed;
        public XVar DeliveryCompletion;
        public XVar InspectionAndAcceptance;
        public XVar SourceOfFunds;
        public XVar TotalABCPhp;
        public XVar ABCMOOE;
        public XVar ABCCO;
        public XVar TotalContractCostPhp;
        public XVar ContractCostMOOE;
        public XVar ContractCostCO;
        public XVar ListOfInvitedObservers;
        public XVar PreBidConfObservers;
        public XVar EligibilityCheckObservers;
        public XVar SubOpenOfBidsObservers;
        public XVar BidEvaluationObservers;
        public XVar PostQualObservers;
        public XVar DeliveryCompletionAcceptanceIfApplicable;
        public XVar RemarksExplainingChangesFromTheAPP;
        public static void Init()
        {
            XVar dalTableProcurementMonitoring = XVar.Array();
            dalTableProcurementMonitoring["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTableProcurementMonitoring["PpmpId"] = new XVar("type", 3, "varname", "PpmpId", "name", "PpmpId", "autoInc", "0");
            dalTableProcurementMonitoring["CodePAP"] = new XVar("type", 200, "varname", "CodePAP", "name", "CodePAP", "autoInc", "0");
            dalTableProcurementMonitoring["IsthisAnEarlyProcurementActivity"] = new XVar("type", 11, "varname", "IsthisAnEarlyProcurementActivity", "name", "IsthisAnEarlyProcurementActivity", "autoInc", "0");
            dalTableProcurementMonitoring["ModeOfProcurement"] = new XVar("type", 200, "varname", "ModeOfProcurement", "name", "ModeOfProcurement", "autoInc", "0");
            dalTableProcurementMonitoring["PreProcConference"] = new XVar("type", 7, "varname", "PreProcConference", "name", "PreProcConference", "autoInc", "0");
            dalTableProcurementMonitoring["AdsPostOfIB"] = new XVar("type", 7, "varname", "AdsPostOfIB", "name", "AdsPostOfIB", "autoInc", "0");
            dalTableProcurementMonitoring["PreBidConf"] = new XVar("type", 7, "varname", "PreBidConf", "name", "PreBidConf", "autoInc", "0");
            dalTableProcurementMonitoring["EligibilityCheck"] = new XVar("type", 7, "varname", "EligibilityCheck", "name", "EligibilityCheck", "autoInc", "0");
            dalTableProcurementMonitoring["SubOpenOfBids"] = new XVar("type", 7, "varname", "SubOpenOfBids", "name", "SubOpenOfBids", "autoInc", "0");
            dalTableProcurementMonitoring["BidEvaluation"] = new XVar("type", 7, "varname", "BidEvaluation", "name", "BidEvaluation", "autoInc", "0");
            dalTableProcurementMonitoring["PostQual"] = new XVar("type", 7, "varname", "PostQual", "name", "PostQual", "autoInc", "0");
            dalTableProcurementMonitoring["DateOfBACResolutionRecommendingAward"] = new XVar("type", 7, "varname", "DateOfBACResolutionRecommendingAward", "name", "DateOfBACResolutionRecommendingAward", "autoInc", "0");
            dalTableProcurementMonitoring["NoticeOfAward"] = new XVar("type", 7, "varname", "NoticeOfAward", "name", "NoticeOfAward", "autoInc", "0");
            dalTableProcurementMonitoring["ContractSigning"] = new XVar("type", 7, "varname", "ContractSigning", "name", "ContractSigning", "autoInc", "0");
            dalTableProcurementMonitoring["NoticeToProceed"] = new XVar("type", 7, "varname", "NoticeToProceed", "name", "NoticeToProceed", "autoInc", "0");
            dalTableProcurementMonitoring["DeliveryCompletion"] = new XVar("type", 7, "varname", "DeliveryCompletion", "name", "DeliveryCompletion", "autoInc", "0");
            dalTableProcurementMonitoring["InspectionAndAcceptance"] = new XVar("type", 7, "varname", "InspectionAndAcceptance", "name", "InspectionAndAcceptance", "autoInc", "0");
            dalTableProcurementMonitoring["SourceOfFunds"] = new XVar("type", 200, "varname", "SourceOfFunds", "name", "SourceOfFunds", "autoInc", "0");
            dalTableProcurementMonitoring["TotalABCPhp"] = new XVar("type", 14, "varname", "TotalABCPhp", "name", "TotalABCPhp", "autoInc", "0");
            dalTableProcurementMonitoring["ABCMOOE"] = new XVar("type", 14, "varname", "ABCMOOE", "name", "ABCMOOE", "autoInc", "0");
            dalTableProcurementMonitoring["ABCCO"] = new XVar("type", 14, "varname", "ABCCO", "name", "ABCCO", "autoInc", "0");
            dalTableProcurementMonitoring["TotalContractCostPhp"] = new XVar("type", 14, "varname", "TotalContractCostPhp", "name", "TotalContractCostPhp", "autoInc", "0");
            dalTableProcurementMonitoring["ContractCostMOOE"] = new XVar("type", 14, "varname", "ContractCostMOOE", "name", "ContractCostMOOE", "autoInc", "0");
            dalTableProcurementMonitoring["ContractCostCO"] = new XVar("type", 14, "varname", "ContractCostCO", "name", "ContractCostCO", "autoInc", "0");
            dalTableProcurementMonitoring["ListOfInvitedObservers"] = new XVar("type", 200, "varname", "ListOfInvitedObservers", "name", "ListOfInvitedObservers", "autoInc", "0");
            dalTableProcurementMonitoring["PreBidConfObservers"] = new XVar("type", 200, "varname", "PreBidConfObservers", "name", "PreBidConfObservers", "autoInc", "0");
            dalTableProcurementMonitoring["EligibilityCheckObservers"] = new XVar("type", 200, "varname", "EligibilityCheckObservers", "name", "EligibilityCheckObservers", "autoInc", "0");
            dalTableProcurementMonitoring["SubOpenOfBidsObservers"] = new XVar("type", 200, "varname", "SubOpenOfBidsObservers", "name", "SubOpenOfBidsObservers", "autoInc", "0");
            dalTableProcurementMonitoring["BidEvaluationObservers"] = new XVar("type", 200, "varname", "BidEvaluationObservers", "name", "BidEvaluationObservers", "autoInc", "0");
            dalTableProcurementMonitoring["PostQualObservers"] = new XVar("type", 200, "varname", "PostQualObservers", "name", "PostQualObservers", "autoInc", "0");
            dalTableProcurementMonitoring["DeliveryCompletionAcceptanceIfApplicable"] = new XVar("type", 200, "varname", "DeliveryCompletionAcceptanceIfApplicable", "name", "DeliveryCompletionAcceptanceIfApplicable", "autoInc", "0");
            dalTableProcurementMonitoring["RemarksExplainingChangesFromTheAPP"] = new XVar("type", 200, "varname", "RemarksExplainingChangesFromTheAPP", "name", "RemarksExplainingChangesFromTheAPP", "autoInc", "0");
	        dalTableProcurementMonitoring.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_ProcurementMonitoring"] = dalTableProcurementMonitoring;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_ProcurementMonitoring()
        {
            			this.m_TableName = "dbo.ProcurementMonitoring";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_ProcurementMonitoring";
        }
    }
}