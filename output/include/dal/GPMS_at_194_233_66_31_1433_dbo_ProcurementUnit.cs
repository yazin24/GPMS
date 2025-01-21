using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_ProcurementUnit : tDALTable
    {
        public XVar UnitId;
        public XVar EntityId;
        public XVar UnitName;
        public XVar AnnualBudget;
        public XVar OrganizationalLevel;
        public XVar AverageBudget3Years;
        public static void Init()
        {
            XVar dalTableProcurementUnit = XVar.Array();
            dalTableProcurementUnit["UnitId"] = new XVar("type", 3, "varname", "UnitId", "name", "UnitId", "autoInc", "1");
            dalTableProcurementUnit["EntityId"] = new XVar("type", 3, "varname", "EntityId", "name", "EntityId", "autoInc", "0");
            dalTableProcurementUnit["UnitName"] = new XVar("type", 200, "varname", "UnitName", "name", "UnitName", "autoInc", "0");
            dalTableProcurementUnit["AnnualBudget"] = new XVar("type", 14, "varname", "AnnualBudget", "name", "AnnualBudget", "autoInc", "0");
            dalTableProcurementUnit["OrganizationalLevel"] = new XVar("type", 200, "varname", "OrganizationalLevel", "name", "OrganizationalLevel", "autoInc", "0");
            dalTableProcurementUnit["AverageBudget3Years"] = new XVar("type", 14, "varname", "AverageBudget3Years", "name", "AverageBudget3Years", "autoInc", "0");
	        dalTableProcurementUnit.InitAndSetArrayItem(true, "UnitId", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_ProcurementUnit"] = dalTableProcurementUnit;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_ProcurementUnit()
        {
            			this.m_TableName = "dbo.ProcurementUnit";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_ProcurementUnit";
        }
    }
}