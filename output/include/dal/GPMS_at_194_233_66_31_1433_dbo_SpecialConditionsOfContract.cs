using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_SpecialConditionsOfContract : tDALTable
    {
        public XVar Id;
        public XVar PbdId;
        public XVar MilestoneDescription;
        public XVar Deliverable;
        public XVar PaymentPercentage;
        public static void Init()
        {
            XVar dalTableSpecialConditionsOfContract = XVar.Array();
            dalTableSpecialConditionsOfContract["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTableSpecialConditionsOfContract["PbdId"] = new XVar("type", 3, "varname", "PbdId", "name", "PbdId", "autoInc", "0");
            dalTableSpecialConditionsOfContract["MilestoneDescription"] = new XVar("type", 200, "varname", "MilestoneDescription", "name", "MilestoneDescription", "autoInc", "0");
            dalTableSpecialConditionsOfContract["Deliverable"] = new XVar("type", 200, "varname", "Deliverable", "name", "Deliverable", "autoInc", "0");
            dalTableSpecialConditionsOfContract["PaymentPercentage"] = new XVar("type", 14, "varname", "PaymentPercentage", "name", "PaymentPercentage", "autoInc", "0");
	        dalTableSpecialConditionsOfContract.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_SpecialConditionsOfContract"] = dalTableSpecialConditionsOfContract;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_SpecialConditionsOfContract()
        {
            			this.m_TableName = "dbo.SpecialConditionsOfContract";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_SpecialConditionsOfContract";
        }
    }
}