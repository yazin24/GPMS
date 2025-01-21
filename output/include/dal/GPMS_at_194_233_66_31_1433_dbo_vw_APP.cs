using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_vw_APP : tDALTable
    {
        public XVar Id;
        public XVar EndUser_Unit;
        public XVar SourceOfFund;
        public XVar Code;
        public XVar GeneralDescription;
        public XVar Quantity_Size;
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
        public XVar TotalMOOE_CO;
        public XVar ProjectDescription;
        public XVar PreparedBy;
        public XVar SubmittedBy;
        public static void Init()
        {
            XVar dalTablevw_APP = XVar.Array();
            dalTablevw_APP["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTablevw_APP["EndUser/Unit"] = new XVar("type", 3, "varname", "EndUser_Unit", "name", "EndUser/Unit", "autoInc", "0");
            dalTablevw_APP["SourceOfFund"] = new XVar("type", 200, "varname", "SourceOfFund", "name", "SourceOfFund", "autoInc", "0");
            dalTablevw_APP["Code"] = new XVar("type", 200, "varname", "Code", "name", "Code", "autoInc", "0");
            dalTablevw_APP["GeneralDescription"] = new XVar("type", 201, "varname", "GeneralDescription", "name", "GeneralDescription", "autoInc", "0");
            dalTablevw_APP["Quantity/Size"] = new XVar("type", 200, "varname", "Quantity_Size", "name", "Quantity/Size", "autoInc", "0");
            dalTablevw_APP["EstimatedBudget"] = new XVar("type", 14, "varname", "EstimatedBudget", "name", "EstimatedBudget", "autoInc", "0");
            dalTablevw_APP["ModeOfProcurement"] = new XVar("type", 200, "varname", "ModeOfProcurement", "name", "ModeOfProcurement", "autoInc", "0");
            dalTablevw_APP["TypeOfProcurement"] = new XVar("type", 200, "varname", "TypeOfProcurement", "name", "TypeOfProcurement", "autoInc", "0");
            dalTablevw_APP["Advertisement"] = new XVar("type", 7, "varname", "Advertisement", "name", "Advertisement", "autoInc", "0");
            dalTablevw_APP["OpeningOfBid"] = new XVar("type", 7, "varname", "OpeningOfBid", "name", "OpeningOfBid", "autoInc", "0");
            dalTablevw_APP["NoticeOfAward"] = new XVar("type", 7, "varname", "NoticeOfAward", "name", "NoticeOfAward", "autoInc", "0");
            dalTablevw_APP["ContractSigning"] = new XVar("type", 7, "varname", "ContractSigning", "name", "ContractSigning", "autoInc", "0");
            dalTablevw_APP["MOOE"] = new XVar("type", 14, "varname", "MOOE", "name", "MOOE", "autoInc", "0");
            dalTablevw_APP["CO"] = new XVar("type", 14, "varname", "CO", "name", "CO", "autoInc", "0");
            dalTablevw_APP["January"] = new XVar("type", 11, "varname", "January", "name", "January", "autoInc", "0");
            dalTablevw_APP["February"] = new XVar("type", 11, "varname", "February", "name", "February", "autoInc", "0");
            dalTablevw_APP["March"] = new XVar("type", 11, "varname", "March", "name", "March", "autoInc", "0");
            dalTablevw_APP["April"] = new XVar("type", 11, "varname", "April", "name", "April", "autoInc", "0");
            dalTablevw_APP["May"] = new XVar("type", 11, "varname", "May", "name", "May", "autoInc", "0");
            dalTablevw_APP["June"] = new XVar("type", 11, "varname", "June", "name", "June", "autoInc", "0");
            dalTablevw_APP["July"] = new XVar("type", 11, "varname", "July", "name", "July", "autoInc", "0");
            dalTablevw_APP["August"] = new XVar("type", 11, "varname", "August", "name", "August", "autoInc", "0");
            dalTablevw_APP["September"] = new XVar("type", 11, "varname", "September", "name", "September", "autoInc", "0");
            dalTablevw_APP["October"] = new XVar("type", 11, "varname", "October", "name", "October", "autoInc", "0");
            dalTablevw_APP["November"] = new XVar("type", 11, "varname", "November", "name", "November", "autoInc", "0");
            dalTablevw_APP["December"] = new XVar("type", 11, "varname", "December", "name", "December", "autoInc", "0");
            dalTablevw_APP["TotalMOOE+CO"] = new XVar("type", 14, "varname", "TotalMOOE_CO", "name", "TotalMOOE+CO", "autoInc", "0");
            dalTablevw_APP["ProjectDescription"] = new XVar("type", 200, "varname", "ProjectDescription", "name", "ProjectDescription", "autoInc", "0");
            dalTablevw_APP["PreparedBy"] = new XVar("type", 200, "varname", "PreparedBy", "name", "PreparedBy", "autoInc", "0");
            dalTablevw_APP["SubmittedBy"] = new XVar("type", 200, "varname", "SubmittedBy", "name", "SubmittedBy", "autoInc", "0");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_vw_APP"] = dalTablevw_APP;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_vw_APP()
        {
            			this.m_TableName = "dbo.vw_APP";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_vw_APP";
        }
    }
}