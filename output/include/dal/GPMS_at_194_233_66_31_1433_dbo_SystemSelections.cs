using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_SystemSelections : tDALTable
    {
        public XVar Id;
        public XVar NumericValue;
        public XVar DisplayValue;
        public XVar PurposeValue;
        public static void Init()
        {
            XVar dalTableSystemSelections = XVar.Array();
            dalTableSystemSelections["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTableSystemSelections["NumericValue"] = new XVar("type", 3, "varname", "NumericValue", "name", "NumericValue", "autoInc", "0");
            dalTableSystemSelections["DisplayValue"] = new XVar("type", 200, "varname", "DisplayValue", "name", "DisplayValue", "autoInc", "0");
            dalTableSystemSelections["PurposeValue"] = new XVar("type", 200, "varname", "PurposeValue", "name", "PurposeValue", "autoInc", "0");
	        dalTableSystemSelections.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_SystemSelections"] = dalTableSystemSelections;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_SystemSelections()
        {
            			this.m_TableName = "dbo.SystemSelections";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_SystemSelections";
        }
    }
}