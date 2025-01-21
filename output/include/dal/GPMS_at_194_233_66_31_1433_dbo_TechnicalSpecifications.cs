using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_TechnicalSpecifications : tDALTable
    {
        public XVar Id;
        public XVar PbdId;
        public XVar ItemSpecification;
        public XVar ComplianceStatement;
        public static void Init()
        {
            XVar dalTableTechnicalSpecifications = XVar.Array();
            dalTableTechnicalSpecifications["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTableTechnicalSpecifications["PbdId"] = new XVar("type", 3, "varname", "PbdId", "name", "PbdId", "autoInc", "0");
            dalTableTechnicalSpecifications["ItemSpecification"] = new XVar("type", 200, "varname", "ItemSpecification", "name", "ItemSpecification", "autoInc", "0");
            dalTableTechnicalSpecifications["ComplianceStatement"] = new XVar("type", 11, "varname", "ComplianceStatement", "name", "ComplianceStatement", "autoInc", "0");
	        dalTableTechnicalSpecifications.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_TechnicalSpecifications"] = dalTableTechnicalSpecifications;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_TechnicalSpecifications()
        {
            			this.m_TableName = "dbo.TechnicalSpecifications";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_TechnicalSpecifications";
        }
    }
}