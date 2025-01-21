using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_BidsAndAwardsCommittee : tDALTable
    {
        public XVar Id;
        public XVar EntityId;
        public XVar BacName;
        public XVar CreationReason;
        public XVar ChairpersonId;
        public XVar ViceChairpersonId;
        public XVar Location;
        public XVar MinBacMember;
        public XVar MaxBacMember;
        public static void Init()
        {
            XVar dalTableBidsAndAwardsCommittee = XVar.Array();
            dalTableBidsAndAwardsCommittee["Id"] = new XVar("type", 3, "varname", "Id", "name", "Id", "autoInc", "1");
            dalTableBidsAndAwardsCommittee["EntityId"] = new XVar("type", 3, "varname", "EntityId", "name", "EntityId", "autoInc", "0");
            dalTableBidsAndAwardsCommittee["BacName"] = new XVar("type", 200, "varname", "BacName", "name", "BacName", "autoInc", "0");
            dalTableBidsAndAwardsCommittee["CreationReason"] = new XVar("type", 200, "varname", "CreationReason", "name", "CreationReason", "autoInc", "0");
            dalTableBidsAndAwardsCommittee["ChairpersonId"] = new XVar("type", 3, "varname", "ChairpersonId", "name", "ChairpersonId", "autoInc", "0");
            dalTableBidsAndAwardsCommittee["ViceChairpersonId"] = new XVar("type", 3, "varname", "ViceChairpersonId", "name", "ViceChairpersonId", "autoInc", "0");
            dalTableBidsAndAwardsCommittee["Location"] = new XVar("type", 200, "varname", "Location", "name", "Location", "autoInc", "0");
            dalTableBidsAndAwardsCommittee["MinBacMember"] = new XVar("type", 3, "varname", "MinBacMember", "name", "MinBacMember", "autoInc", "0");
            dalTableBidsAndAwardsCommittee["MaxBacMember"] = new XVar("type", 3, "varname", "MaxBacMember", "name", "MaxBacMember", "autoInc", "0");
	        dalTableBidsAndAwardsCommittee.InitAndSetArrayItem(true, "Id", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_BidsAndAwardsCommittee"] = dalTableBidsAndAwardsCommittee;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_BidsAndAwardsCommittee()
        {
            			this.m_TableName = "dbo.BidsAndAwardsCommittee";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_BidsAndAwardsCommittee";
        }
    }
}