using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_ProcuringEntity : tDALTable
    {
        public XVar Id;
        public XVar EntityName;
        public XVar EntityType;
        public XVar IsAuthorized;
        public XVar AuthorityDetails;
        public static void Init()
        {
            XVar dalTableProcuringEntity = XVar.Array();
            dalTableProcuringEntity["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTableProcuringEntity["EntityName"] = new XVar("type", 200, "varname", "EntityName", "name", "EntityName", "autoInc", "0");
            dalTableProcuringEntity["EntityType"] = new XVar("type", 200, "varname", "EntityType", "name", "EntityType", "autoInc", "0");
            dalTableProcuringEntity["IsAuthorized"] = new XVar("type", 11, "varname", "IsAuthorized", "name", "IsAuthorized", "autoInc", "0");
            dalTableProcuringEntity["AuthorityDetails"] = new XVar("type", 200, "varname", "AuthorityDetails", "name", "AuthorityDetails", "autoInc", "0");
	        dalTableProcuringEntity.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_ProcuringEntity"] = dalTableProcuringEntity;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_ProcuringEntity()
        {
            			this.m_TableName = "dbo.ProcuringEntity";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_ProcuringEntity";
        }
    }
}