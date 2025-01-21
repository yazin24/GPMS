using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_ObserverInterest : tDALTable
    {
        public XVar InterestId;
        public XVar ObserverId;
        public XVar ProcurementActivityId;
        public XVar InterestType;
        public XVar InterestDescription;
        public XVar DateReported;
        public static void Init()
        {
            XVar dalTableObserverInterest = XVar.Array();
            dalTableObserverInterest["InterestId"] = new XVar("type", 3, "varname", "InterestId", "name", "InterestId", "autoInc", "1");
            dalTableObserverInterest["ObserverId"] = new XVar("type", 3, "varname", "ObserverId", "name", "ObserverId", "autoInc", "0");
            dalTableObserverInterest["ProcurementActivityId"] = new XVar("type", 3, "varname", "ProcurementActivityId", "name", "ProcurementActivityId", "autoInc", "0");
            dalTableObserverInterest["InterestType"] = new XVar("type", 200, "varname", "InterestType", "name", "InterestType", "autoInc", "0");
            dalTableObserverInterest["InterestDescription"] = new XVar("type", 200, "varname", "InterestDescription", "name", "InterestDescription", "autoInc", "0");
            dalTableObserverInterest["DateReported"] = new XVar("type", 7, "varname", "DateReported", "name", "DateReported", "autoInc", "0");
	        dalTableObserverInterest.InitAndSetArrayItem(true, "InterestId", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_ObserverInterest"] = dalTableObserverInterest;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_ObserverInterest()
        {
            			this.m_TableName = "dbo.ObserverInterest";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_ObserverInterest";
        }
    }
}