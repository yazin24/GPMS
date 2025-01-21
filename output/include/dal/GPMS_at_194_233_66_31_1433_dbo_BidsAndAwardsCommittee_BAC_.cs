using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_BidsAndAwardsCommittee_BAC_ : tDALTable
    {
        public XVar BacId;
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
            XVar dalTableBidsAndAwardsCommittee_BAC_ = XVar.Array();
            dalTableBidsAndAwardsCommittee_BAC_["BacId"] = new XVar("type", 3, "varname", "BacId", "name", "BacId", "autoInc", "1");
            dalTableBidsAndAwardsCommittee_BAC_["EntityId"] = new XVar("type", 3, "varname", "EntityId", "name", "EntityId", "autoInc", "0");
            dalTableBidsAndAwardsCommittee_BAC_["BacName"] = new XVar("type", 200, "varname", "BacName", "name", "BacName", "autoInc", "0");
            dalTableBidsAndAwardsCommittee_BAC_["CreationReason"] = new XVar("type", 201, "varname", "CreationReason", "name", "CreationReason", "autoInc", "0");
            dalTableBidsAndAwardsCommittee_BAC_["ChairpersonId"] = new XVar("type", 3, "varname", "ChairpersonId", "name", "ChairpersonId", "autoInc", "0");
            dalTableBidsAndAwardsCommittee_BAC_["ViceChairpersonId"] = new XVar("type", 3, "varname", "ViceChairpersonId", "name", "ViceChairpersonId", "autoInc", "0");
            dalTableBidsAndAwardsCommittee_BAC_["Location"] = new XVar("type", 200, "varname", "Location", "name", "Location", "autoInc", "0");
            dalTableBidsAndAwardsCommittee_BAC_["MinBacMember"] = new XVar("type", 3, "varname", "MinBacMember", "name", "MinBacMember", "autoInc", "0");
            dalTableBidsAndAwardsCommittee_BAC_["MaxBacMember"] = new XVar("type", 3, "varname", "MaxBacMember", "name", "MaxBacMember", "autoInc", "0");
	        dalTableBidsAndAwardsCommittee_BAC_.InitAndSetArrayItem(true, "BacId", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_BidsAndAwardsCommittee_BAC_"] = dalTableBidsAndAwardsCommittee_BAC_;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_BidsAndAwardsCommittee_BAC_()
        {
            			this.m_TableName = "dbo.BidsAndAwardsCommittee(BAC)";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_BidsAndAwardsCommittee_BAC_";
        }
    }
}