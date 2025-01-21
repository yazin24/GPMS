using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_PhilippineBiddingDocument : tDALTable
    {
        public XVar Id;
        public XVar ProcuringEntity;
        public XVar ProjectName;
        public XVar BidReferenceNo;
        public XVar ApprovedBudget;
        public XVar DeliveryDays;
        public XVar DatePosted;
        public XVar BidDocsAvailabilityStart;
        public XVar BidDocsAvailabilityEnd;
        public XVar BidSubmissionDeadline;
        public XVar BidDocsCost;
        public XVar PreBidConferenceDate;
        public XVar PreBidConferenceVenue;
        public XVar SimilarProjects;
        public XVar BidSecurity;
        public XVar BidOpeningdate;
        public XVar BidOpeningVenue;
        public XVar ContactPersonName;
        public XVar ContactPersonOffice;
        public XVar ContactPersonAddress;
        public XVar ContactPersonPhone;
        public XVar Website;
        public XVar IssuanceDate;
        public XVar BACChairperson;
        public XVar ProjectDescription;
        public XVar FundingSource;
        public XVar SLCCRequirement;
        public XVar SubContractingAllowed;
        public XVar BidCurrencies;
        public XVar PaymentCurrency;
        public XVar BidSecuritySubDays;
        public XVar ContractSimilarToProject;
        public XVar SimilarProjectYears;
        public XVar BidSecurityCashAmount;
        public XVar BidSecurityCashPercent;
        public XVar BidSecuritySuretyBondAmount;
        public XVar BidSecuritySuretyBondPercent;
        public static void Init()
        {
            XVar dalTablePhilippineBiddingDocument = XVar.Array();
            dalTablePhilippineBiddingDocument["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTablePhilippineBiddingDocument["ProcuringEntity"] = new XVar("type", 3, "varname", "ProcuringEntity", "name", "ProcuringEntity", "autoInc", "0");
            dalTablePhilippineBiddingDocument["ProjectName"] = new XVar("type", 200, "varname", "ProjectName", "name", "ProjectName", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidReferenceNo"] = new XVar("type", 200, "varname", "BidReferenceNo", "name", "BidReferenceNo", "autoInc", "0");
            dalTablePhilippineBiddingDocument["ApprovedBudget"] = new XVar("type", 14, "varname", "ApprovedBudget", "name", "ApprovedBudget", "autoInc", "0");
            dalTablePhilippineBiddingDocument["DeliveryDays"] = new XVar("type", 3, "varname", "DeliveryDays", "name", "DeliveryDays", "autoInc", "0");
            dalTablePhilippineBiddingDocument["DatePosted"] = new XVar("type", 7, "varname", "DatePosted", "name", "DatePosted", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidDocsAvailabilityStart"] = new XVar("type", 7, "varname", "BidDocsAvailabilityStart", "name", "BidDocsAvailabilityStart", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidDocsAvailabilityEnd"] = new XVar("type", 7, "varname", "BidDocsAvailabilityEnd", "name", "BidDocsAvailabilityEnd", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidSubmissionDeadline"] = new XVar("type", 7, "varname", "BidSubmissionDeadline", "name", "BidSubmissionDeadline", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidDocsCost"] = new XVar("type", 14, "varname", "BidDocsCost", "name", "BidDocsCost", "autoInc", "0");
            dalTablePhilippineBiddingDocument["PreBidConferenceDate"] = new XVar("type", 135, "varname", "PreBidConferenceDate", "name", "PreBidConferenceDate", "autoInc", "0");
            dalTablePhilippineBiddingDocument["PreBidConferenceVenue"] = new XVar("type", 200, "varname", "PreBidConferenceVenue", "name", "PreBidConferenceVenue", "autoInc", "0");
            dalTablePhilippineBiddingDocument["SimilarProjects"] = new XVar("type", 200, "varname", "SimilarProjects", "name", "SimilarProjects", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidSecurity"] = new XVar("type", 200, "varname", "BidSecurity", "name", "BidSecurity", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidOpeningdate"] = new XVar("type", 7, "varname", "BidOpeningdate", "name", "BidOpeningdate", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidOpeningVenue"] = new XVar("type", 200, "varname", "BidOpeningVenue", "name", "BidOpeningVenue", "autoInc", "0");
            dalTablePhilippineBiddingDocument["ContactPersonName"] = new XVar("type", 200, "varname", "ContactPersonName", "name", "ContactPersonName", "autoInc", "0");
            dalTablePhilippineBiddingDocument["ContactPersonOffice"] = new XVar("type", 200, "varname", "ContactPersonOffice", "name", "ContactPersonOffice", "autoInc", "0");
            dalTablePhilippineBiddingDocument["ContactPersonAddress"] = new XVar("type", 200, "varname", "ContactPersonAddress", "name", "ContactPersonAddress", "autoInc", "0");
            dalTablePhilippineBiddingDocument["ContactPersonPhone"] = new XVar("type", 200, "varname", "ContactPersonPhone", "name", "ContactPersonPhone", "autoInc", "0");
            dalTablePhilippineBiddingDocument["Website"] = new XVar("type", 200, "varname", "Website", "name", "Website", "autoInc", "0");
            dalTablePhilippineBiddingDocument["IssuanceDate"] = new XVar("type", 7, "varname", "IssuanceDate", "name", "IssuanceDate", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BACChairperson"] = new XVar("type", 3, "varname", "BACChairperson", "name", "BACChairperson", "autoInc", "0");
            dalTablePhilippineBiddingDocument["ProjectDescription"] = new XVar("type", 200, "varname", "ProjectDescription", "name", "ProjectDescription", "autoInc", "0");
            dalTablePhilippineBiddingDocument["FundingSource"] = new XVar("type", 200, "varname", "FundingSource", "name", "FundingSource", "autoInc", "0");
            dalTablePhilippineBiddingDocument["SLCCRequirement"] = new XVar("type", 200, "varname", "SLCCRequirement", "name", "SLCCRequirement", "autoInc", "0");
            dalTablePhilippineBiddingDocument["SubContractingAllowed"] = new XVar("type", 200, "varname", "SubContractingAllowed", "name", "SubContractingAllowed", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidCurrencies"] = new XVar("type", 200, "varname", "BidCurrencies", "name", "BidCurrencies", "autoInc", "0");
            dalTablePhilippineBiddingDocument["PaymentCurrency"] = new XVar("type", 200, "varname", "PaymentCurrency", "name", "PaymentCurrency", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidSecuritySubDays"] = new XVar("type", 3, "varname", "BidSecuritySubDays", "name", "BidSecuritySubDays", "autoInc", "0");
            dalTablePhilippineBiddingDocument["ContractSimilarToProject"] = new XVar("type", 200, "varname", "ContractSimilarToProject", "name", "ContractSimilarToProject", "autoInc", "0");
            dalTablePhilippineBiddingDocument["SimilarProjectYears"] = new XVar("type", 3, "varname", "SimilarProjectYears", "name", "SimilarProjectYears", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidSecurityCashAmount"] = new XVar("type", 14, "varname", "BidSecurityCashAmount", "name", "BidSecurityCashAmount", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidSecurityCashPercent"] = new XVar("type", 3, "varname", "BidSecurityCashPercent", "name", "BidSecurityCashPercent", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidSecuritySuretyBondAmount"] = new XVar("type", 14, "varname", "BidSecuritySuretyBondAmount", "name", "BidSecuritySuretyBondAmount", "autoInc", "0");
            dalTablePhilippineBiddingDocument["BidSecuritySuretyBondPercent"] = new XVar("type", 14, "varname", "BidSecuritySuretyBondPercent", "name", "BidSecuritySuretyBondPercent", "autoInc", "0");
	        dalTablePhilippineBiddingDocument.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_PhilippineBiddingDocument"] = dalTablePhilippineBiddingDocument;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_PhilippineBiddingDocument()
        {
            			this.m_TableName = "dbo.PhilippineBiddingDocument";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_PhilippineBiddingDocument";
        }
    }
}