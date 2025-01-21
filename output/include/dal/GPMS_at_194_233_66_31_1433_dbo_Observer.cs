using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_Observer : tDALTable
    {
        public XVar ObserverId;
        public XVar PersonnelId;
        public XVar ObserverName;
        public XVar ObserverOrganization;
        public XVar ContactDetails;
        public XVar DateJoined;
        public XVar ConfidentialityAgreement;
        public static void Init()
        {
            XVar dalTableObserver = XVar.Array();
            dalTableObserver["ObserverId"] = new XVar("type", 3, "varname", "ObserverId", "name", "ObserverId", "autoInc", "1");
            dalTableObserver["PersonnelId"] = new XVar("type", 3, "varname", "PersonnelId", "name", "PersonnelId", "autoInc", "0");
            dalTableObserver["ObserverName"] = new XVar("type", 200, "varname", "ObserverName", "name", "ObserverName", "autoInc", "0");
            dalTableObserver["ObserverOrganization"] = new XVar("type", 200, "varname", "ObserverOrganization", "name", "ObserverOrganization", "autoInc", "0");
            dalTableObserver["ContactDetails"] = new XVar("type", 200, "varname", "ContactDetails", "name", "ContactDetails", "autoInc", "0");
            dalTableObserver["DateJoined"] = new XVar("type", 7, "varname", "DateJoined", "name", "DateJoined", "autoInc", "0");
            dalTableObserver["ConfidentialityAgreement"] = new XVar("type", 11, "varname", "ConfidentialityAgreement", "name", "ConfidentialityAgreement", "autoInc", "0");
	        dalTableObserver.InitAndSetArrayItem(true, "ObserverId", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_Observer"] = dalTableObserver;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_Observer()
        {
            			this.m_TableName = "dbo.Observer";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_Observer";
        }
    }
}