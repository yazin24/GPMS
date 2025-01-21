using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_BACMembers : tDALTable
    {
        public XVar MemberId;
        public XVar BacId;
        public XVar PersonnelId;
        public XVar BacMemberName;
        public XVar MemberType;
        public XVar Role;
        public XVar ApptTerm;
        public static void Init()
        {
            XVar dalTableBACMembers = XVar.Array();
            dalTableBACMembers["MemberId"] = new XVar("type", 3, "varname", "MemberId", "name", "MemberId", "autoInc", "1");
            dalTableBACMembers["BacId"] = new XVar("type", 3, "varname", "BacId", "name", "BacId", "autoInc", "0");
            dalTableBACMembers["PersonnelId"] = new XVar("type", 3, "varname", "PersonnelId", "name", "PersonnelId", "autoInc", "0");
            dalTableBACMembers["BacMemberName"] = new XVar("type", 200, "varname", "BacMemberName", "name", "BacMemberName", "autoInc", "0");
            dalTableBACMembers["MemberType"] = new XVar("type", 200, "varname", "MemberType", "name", "MemberType", "autoInc", "0");
            dalTableBACMembers["Role"] = new XVar("type", 200, "varname", "Role", "name", "Role", "autoInc", "0");
            dalTableBACMembers["ApptTerm"] = new XVar("type", 3, "varname", "ApptTerm", "name", "ApptTerm", "autoInc", "0");
	        dalTableBACMembers.InitAndSetArrayItem(true, "MemberId", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_BACMembers"] = dalTableBACMembers;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_BACMembers()
        {
            			this.m_TableName = "dbo.BACMembers";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_BACMembers";
        }
    }
}