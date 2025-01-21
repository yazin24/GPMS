using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_ScheduleOfRequirements : tDALTable
    {
        public XVar Id;
        public XVar PbdId;
        public XVar Description;
        public XVar Quantity;
        public XVar DeliverySchedule;
        public static void Init()
        {
            XVar dalTableScheduleOfRequirements = XVar.Array();
            dalTableScheduleOfRequirements["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTableScheduleOfRequirements["PbdId"] = new XVar("type", 3, "varname", "PbdId", "name", "PbdId", "autoInc", "0");
            dalTableScheduleOfRequirements["Description"] = new XVar("type", 200, "varname", "Description", "name", "Description", "autoInc", "0");
            dalTableScheduleOfRequirements["Quantity"] = new XVar("type", 200, "varname", "Quantity", "name", "Quantity", "autoInc", "0");
            dalTableScheduleOfRequirements["DeliverySchedule"] = new XVar("type", 200, "varname", "DeliverySchedule", "name", "DeliverySchedule", "autoInc", "0");
	        dalTableScheduleOfRequirements.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_ScheduleOfRequirements"] = dalTableScheduleOfRequirements;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_ScheduleOfRequirements()
        {
            			this.m_TableName = "dbo.ScheduleOfRequirements";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_ScheduleOfRequirements";
        }
    }
}