using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_HeadOfProcuringEntity : tDALTable
    {
        public XVar Id;
        public XVar PersonnelId;
        public XVar EntityId;
        public XVar HopeName;
        public XVar HopeType;
        public XVar DelegationDetails;
        public static void Init()
        {
            XVar dalTableHeadOfProcuringEntity = XVar.Array();
            dalTableHeadOfProcuringEntity["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTableHeadOfProcuringEntity["PersonnelId"] = new XVar("type", 3, "varname", "PersonnelId", "name", "PersonnelId", "autoInc", "0");
            dalTableHeadOfProcuringEntity["EntityId"] = new XVar("type", 3, "varname", "EntityId", "name", "EntityId", "autoInc", "0");
            dalTableHeadOfProcuringEntity["HopeName"] = new XVar("type", 200, "varname", "HopeName", "name", "HopeName", "autoInc", "0");
            dalTableHeadOfProcuringEntity["HopeType"] = new XVar("type", 200, "varname", "HopeType", "name", "HopeType", "autoInc", "0");
            dalTableHeadOfProcuringEntity["DelegationDetails"] = new XVar("type", 200, "varname", "DelegationDetails", "name", "DelegationDetails", "autoInc", "0");
	        dalTableHeadOfProcuringEntity.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_HeadOfProcuringEntity"] = dalTableHeadOfProcuringEntity;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_HeadOfProcuringEntity()
        {
            			this.m_TableName = "dbo.HeadOfProcuringEntity";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_HeadOfProcuringEntity";
        }
    }
}