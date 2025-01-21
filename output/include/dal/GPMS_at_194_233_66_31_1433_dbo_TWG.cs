using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_TWG : tDALTable
    {
        public XVar TWGId;
        public XVar TWGName;
        public XVar TWGType;
        public XVar BacId;
        public XVar EndUserRepresentative;
        public XVar CreationDate;
        public XVar ModificationDate;
        public static void Init()
        {
            XVar dalTableTWG = XVar.Array();
            dalTableTWG["TWGId"] = new XVar("type", 3, "varname", "TWGId", "name", "TWGId", "autoInc", "1");
            dalTableTWG["TWGName"] = new XVar("type", 200, "varname", "TWGName", "name", "TWGName", "autoInc", "0");
            dalTableTWG["TWGType"] = new XVar("type", 200, "varname", "TWGType", "name", "TWGType", "autoInc", "0");
            dalTableTWG["BacId"] = new XVar("type", 3, "varname", "BacId", "name", "BacId", "autoInc", "0");
            dalTableTWG["EndUserRepresentative"] = new XVar("type", 200, "varname", "EndUserRepresentative", "name", "EndUserRepresentative", "autoInc", "0");
            dalTableTWG["CreationDate"] = new XVar("type", 7, "varname", "CreationDate", "name", "CreationDate", "autoInc", "0");
            dalTableTWG["ModificationDate"] = new XVar("type", 7, "varname", "ModificationDate", "name", "ModificationDate", "autoInc", "0");
	        dalTableTWG.InitAndSetArrayItem(true, "TWGId", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_TWG"] = dalTableTWG;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_TWG()
        {
            			this.m_TableName = "dbo.TWG";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_TWG";
        }
    }
}