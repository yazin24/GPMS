using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_HeadOfProcuringEntity_HOPE_ : tDALTable
    {
        public XVar HopeId;
        public XVar EntityId;
        public XVar HopeName;
        public XVar HopeType;
        public XVar DelegationDetails;
        public static void Init()
        {
            XVar dalTableHeadOfProcuringEntity_HOPE_ = XVar.Array();
            dalTableHeadOfProcuringEntity_HOPE_["HopeId"] = new XVar("type", 3, "varname", "HopeId", "name", "HopeId", "autoInc", "1");
            dalTableHeadOfProcuringEntity_HOPE_["EntityId"] = new XVar("type", 3, "varname", "EntityId", "name", "EntityId", "autoInc", "0");
            dalTableHeadOfProcuringEntity_HOPE_["HopeName"] = new XVar("type", 200, "varname", "HopeName", "name", "HopeName", "autoInc", "0");
            dalTableHeadOfProcuringEntity_HOPE_["HopeType"] = new XVar("type", 200, "varname", "HopeType", "name", "HopeType", "autoInc", "0");
            dalTableHeadOfProcuringEntity_HOPE_["DelegationDetails"] = new XVar("type", 201, "varname", "DelegationDetails", "name", "DelegationDetails", "autoInc", "0");
	        dalTableHeadOfProcuringEntity_HOPE_.InitAndSetArrayItem(true, "HopeId", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_HeadOfProcuringEntity_HOPE_"] = dalTableHeadOfProcuringEntity_HOPE_;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_HeadOfProcuringEntity_HOPE_()
        {
            			this.m_TableName = "dbo.HeadOfProcuringEntity(HOPE)";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_HeadOfProcuringEntity_HOPE_";
        }
    }
}