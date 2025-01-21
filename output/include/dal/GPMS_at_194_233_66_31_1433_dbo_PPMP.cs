using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_PPMP : tDALTable
    {
        public XVar Id;
        public XVar EndUserUnit;
        public XVar SourceOfFund;
        public XVar Code;
        public XVar GeneralDescription;
        public XVar QuantitySize;
        public XVar EstimatedBudget;
        public XVar ModeOfProcurement;
        public XVar TypeOfProcurement;
        public XVar Advertisement;
        public XVar OpeningOfBid;
        public XVar NoticeOfAward;
        public XVar ContractSigning;
        public XVar MOOE;
        public XVar CO;
        public XVar January;
        public XVar February;
        public XVar March;
        public XVar April;
        public XVar May;
        public XVar June;
        public XVar July;
        public XVar August;
        public XVar September;
        public XVar October;
        public XVar November;
        public XVar December;
        public XVar TotalMOOEAndCO;
        public XVar ProjectDescription;
        public XVar PreparedBy;
        public XVar SubmittedBy;
        public static void Init()
        {
            XVar dalTablePPMP = XVar.Array();
            dalTablePPMP["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTablePPMP["EndUserUnit"] = new XVar("type", 3, "varname", "EndUserUnit", "name", "EndUserUnit", "autoInc", "0");
            dalTablePPMP["SourceOfFund"] = new XVar("type", 200, "varname", "SourceOfFund", "name", "SourceOfFund", "autoInc", "0");
            dalTablePPMP["Code"] = new XVar("type", 200, "varname", "Code", "name", "Code", "autoInc", "0");
            dalTablePPMP["GeneralDescription"] = new XVar("type", 200, "varname", "GeneralDescription", "name", "GeneralDescription", "autoInc", "0");
            dalTablePPMP["QuantitySize"] = new XVar("type", 200, "varname", "QuantitySize", "name", "QuantitySize", "autoInc", "0");
            dalTablePPMP["EstimatedBudget"] = new XVar("type", 14, "varname", "EstimatedBudget", "name", "EstimatedBudget", "autoInc", "0");
            dalTablePPMP["ModeOfProcurement"] = new XVar("type", 200, "varname", "ModeOfProcurement", "name", "ModeOfProcurement", "autoInc", "0");
            dalTablePPMP["TypeOfProcurement"] = new XVar("type", 200, "varname", "TypeOfProcurement", "name", "TypeOfProcurement", "autoInc", "0");
            dalTablePPMP["Advertisement"] = new XVar("type", 7, "varname", "Advertisement", "name", "Advertisement", "autoInc", "0");
            dalTablePPMP["OpeningOfBid"] = new XVar("type", 7, "varname", "OpeningOfBid", "name", "OpeningOfBid", "autoInc", "0");
            dalTablePPMP["NoticeOfAward"] = new XVar("type", 7, "varname", "NoticeOfAward", "name", "NoticeOfAward", "autoInc", "0");
            dalTablePPMP["ContractSigning"] = new XVar("type", 7, "varname", "ContractSigning", "name", "ContractSigning", "autoInc", "0");
            dalTablePPMP["MOOE"] = new XVar("type", 14, "varname", "MOOE", "name", "MOOE", "autoInc", "0");
            dalTablePPMP["CO"] = new XVar("type", 14, "varname", "CO", "name", "CO", "autoInc", "0");
            dalTablePPMP["January"] = new XVar("type", 11, "varname", "January", "name", "January", "autoInc", "0");
            dalTablePPMP["February"] = new XVar("type", 11, "varname", "February", "name", "February", "autoInc", "0");
            dalTablePPMP["March"] = new XVar("type", 11, "varname", "March", "name", "March", "autoInc", "0");
            dalTablePPMP["April"] = new XVar("type", 11, "varname", "April", "name", "April", "autoInc", "0");
            dalTablePPMP["May"] = new XVar("type", 11, "varname", "May", "name", "May", "autoInc", "0");
            dalTablePPMP["June"] = new XVar("type", 11, "varname", "June", "name", "June", "autoInc", "0");
            dalTablePPMP["July"] = new XVar("type", 11, "varname", "July", "name", "July", "autoInc", "0");
            dalTablePPMP["August"] = new XVar("type", 11, "varname", "August", "name", "August", "autoInc", "0");
            dalTablePPMP["September"] = new XVar("type", 11, "varname", "September", "name", "September", "autoInc", "0");
            dalTablePPMP["October"] = new XVar("type", 11, "varname", "October", "name", "October", "autoInc", "0");
            dalTablePPMP["November"] = new XVar("type", 11, "varname", "November", "name", "November", "autoInc", "0");
            dalTablePPMP["December"] = new XVar("type", 11, "varname", "December", "name", "December", "autoInc", "0");
            dalTablePPMP["TotalMOOEAndCO"] = new XVar("type", 14, "varname", "TotalMOOEAndCO", "name", "TotalMOOEAndCO", "autoInc", "0");
            dalTablePPMP["ProjectDescription"] = new XVar("type", 200, "varname", "ProjectDescription", "name", "ProjectDescription", "autoInc", "0");
            dalTablePPMP["PreparedBy"] = new XVar("type", 200, "varname", "PreparedBy", "name", "PreparedBy", "autoInc", "0");
            dalTablePPMP["SubmittedBy"] = new XVar("type", 200, "varname", "SubmittedBy", "name", "SubmittedBy", "autoInc", "0");
	        dalTablePPMP.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_PPMP"] = dalTablePPMP;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_PPMP()
        {
            			this.m_TableName = "dbo.PPMP";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_PPMP";
        }
    }
}