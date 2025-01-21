using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_BACSecretariat : tDALTable
    {
        public XVar Id;
        public XVar PersonnelId;
        public XVar SecretariatName;
        public XVar UnitId;
        public XVar HopeId;
        public XVar SecretariatType;
        public XVar HeadRank;
        public XVar FullTimeStaff;
        public XVar CheckBalance;
        public static void Init()
        {
            XVar dalTableBACSecretariat = XVar.Array();
            dalTableBACSecretariat["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTableBACSecretariat["PersonnelId"] = new XVar("type", 3, "varname", "PersonnelId", "name", "PersonnelId", "autoInc", "0");
            dalTableBACSecretariat["SecretariatName"] = new XVar("type", 200, "varname", "SecretariatName", "name", "SecretariatName", "autoInc", "0");
            dalTableBACSecretariat["UnitId"] = new XVar("type", 3, "varname", "UnitId", "name", "UnitId", "autoInc", "0");
            dalTableBACSecretariat["HopeId"] = new XVar("type", 3, "varname", "HopeId", "name", "HopeId", "autoInc", "0");
            dalTableBACSecretariat["SecretariatType"] = new XVar("type", 200, "varname", "SecretariatType", "name", "SecretariatType", "autoInc", "0");
            dalTableBACSecretariat["HeadRank"] = new XVar("type", 200, "varname", "HeadRank", "name", "HeadRank", "autoInc", "0");
            dalTableBACSecretariat["FullTimeStaff"] = new XVar("type", 11, "varname", "FullTimeStaff", "name", "FullTimeStaff", "autoInc", "0");
            dalTableBACSecretariat["CheckBalance"] = new XVar("type", 11, "varname", "CheckBalance", "name", "CheckBalance", "autoInc", "0");
	        dalTableBACSecretariat.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_BACSecretariat"] = dalTableBACSecretariat;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_BACSecretariat()
        {
            			this.m_TableName = "dbo.BACSecretariat";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_BACSecretariat";
        }
    }
}