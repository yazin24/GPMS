using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_TWGExpertise : tDALTable
    {
        public XVar ExpertiseId;
        public XVar TWGId;
        public XVar PersonnelId;
        public XVar ExpertiseType;
        public XVar ExpertName;
        public XVar ExpertPosition;
        public XVar ExpertDepartment;
        public XVar ConsultantsEngaged;
        public XVar ConsultantsEngagement_Reason;
        public XVar FundAvailability;
        public static void Init()
        {
            XVar dalTableTWGExpertise = XVar.Array();
            dalTableTWGExpertise["ExpertiseId"] = new XVar("type", 3, "varname", "ExpertiseId", "name", "ExpertiseId", "autoInc", "1");
            dalTableTWGExpertise["TWGId"] = new XVar("type", 3, "varname", "TWGId", "name", "TWGId", "autoInc", "0");
            dalTableTWGExpertise["PersonnelId"] = new XVar("type", 3, "varname", "PersonnelId", "name", "PersonnelId", "autoInc", "0");
            dalTableTWGExpertise["ExpertiseType"] = new XVar("type", 200, "varname", "ExpertiseType", "name", "ExpertiseType", "autoInc", "0");
            dalTableTWGExpertise["ExpertName"] = new XVar("type", 200, "varname", "ExpertName", "name", "ExpertName", "autoInc", "0");
            dalTableTWGExpertise["ExpertPosition"] = new XVar("type", 200, "varname", "ExpertPosition", "name", "ExpertPosition", "autoInc", "0");
            dalTableTWGExpertise["ExpertDepartment"] = new XVar("type", 200, "varname", "ExpertDepartment", "name", "ExpertDepartment", "autoInc", "0");
            dalTableTWGExpertise["ConsultantsEngaged"] = new XVar("type", 200, "varname", "ConsultantsEngaged", "name", "ConsultantsEngaged", "autoInc", "0");
            dalTableTWGExpertise["ConsultantsEngagement_Reason"] = new XVar("type", 200, "varname", "ConsultantsEngagement_Reason", "name", "ConsultantsEngagement_Reason", "autoInc", "0");
            dalTableTWGExpertise["FundAvailability"] = new XVar("type", 11, "varname", "FundAvailability", "name", "FundAvailability", "autoInc", "0");
	        dalTableTWGExpertise.InitAndSetArrayItem(true, "ExpertiseId", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_TWGExpertise"] = dalTableTWGExpertise;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_TWGExpertise()
        {
            			this.m_TableName = "dbo.TWGExpertise";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_TWGExpertise";
        }
    }
}