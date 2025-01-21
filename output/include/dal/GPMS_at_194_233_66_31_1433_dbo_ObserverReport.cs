using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace runnerDotNet
{
    public class dalTable_GPMS_at_194_233_66_31_1433_dbo_ObserverReport : tDALTable
    {
        public XVar ReportId;
        public XVar ObserverId;
        public XVar ProcurementActivityId;
        public XVar ReportDate;
        public XVar ComplianceAssesment;
        public XVar AreasOfImprovement;
        public XVar BACMeetingsMinutes;
        public XVar AbstractOfBids;
        public XVar PostQualificationReport;
        public XVar APPPPMPDocuments;
        public XVar OpenedProposals;
        public XVar ReportSubmittedto;
        public XVar ReportStatus;
        public XVar AbstractSigned;
        public XVar PostQualificationSigned;
        public XVar WrittenDissent;
        public static void Init()
        {
            XVar dalTableObserverReport = XVar.Array();
            dalTableObserverReport["ReportId"] = new XVar("type", 3, "varname", "ReportId", "name", "ReportId", "autoInc", "1");
            dalTableObserverReport["ObserverId"] = new XVar("type", 3, "varname", "ObserverId", "name", "ObserverId", "autoInc", "0");
            dalTableObserverReport["ProcurementActivityId"] = new XVar("type", 3, "varname", "ProcurementActivityId", "name", "ProcurementActivityId", "autoInc", "0");
            dalTableObserverReport["ReportDate"] = new XVar("type", 7, "varname", "ReportDate", "name", "ReportDate", "autoInc", "0");
            dalTableObserverReport["ComplianceAssesment"] = new XVar("type", 200, "varname", "ComplianceAssesment", "name", "ComplianceAssesment", "autoInc", "0");
            dalTableObserverReport["AreasOfImprovement"] = new XVar("type", 200, "varname", "AreasOfImprovement", "name", "AreasOfImprovement", "autoInc", "0");
            dalTableObserverReport["BACMeetingsMinutes"] = new XVar("type", 11, "varname", "BACMeetingsMinutes", "name", "BACMeetingsMinutes", "autoInc", "0");
            dalTableObserverReport["AbstractOfBids"] = new XVar("type", 11, "varname", "AbstractOfBids", "name", "AbstractOfBids", "autoInc", "0");
            dalTableObserverReport["PostQualificationReport"] = new XVar("type", 11, "varname", "PostQualificationReport", "name", "PostQualificationReport", "autoInc", "0");
            dalTableObserverReport["APPPPMPDocuments"] = new XVar("type", 11, "varname", "APPPPMPDocuments", "name", "APPPPMPDocuments", "autoInc", "0");
            dalTableObserverReport["OpenedProposals"] = new XVar("type", 11, "varname", "OpenedProposals", "name", "OpenedProposals", "autoInc", "0");
            dalTableObserverReport["ReportSubmittedto"] = new XVar("type", 200, "varname", "ReportSubmittedto", "name", "ReportSubmittedto", "autoInc", "0");
            dalTableObserverReport["ReportStatus"] = new XVar("type", 200, "varname", "ReportStatus", "name", "ReportStatus", "autoInc", "0");
            dalTableObserverReport["AbstractSigned"] = new XVar("type", 11, "varname", "AbstractSigned", "name", "AbstractSigned", "autoInc", "0");
            dalTableObserverReport["PostQualificationSigned"] = new XVar("type", 11, "varname", "PostQualificationSigned", "name", "PostQualificationSigned", "autoInc", "0");
            dalTableObserverReport["WrittenDissent"] = new XVar("type", 11, "varname", "WrittenDissent", "name", "WrittenDissent", "autoInc", "0");
	        dalTableObserverReport.InitAndSetArrayItem(true, "ReportId", "key");
            GlobalVars.dal_info["GPMS_at_194_233_66_31_1433_dbo_ObserverReport"] = dalTableObserverReport;
        }

        public  dalTable_GPMS_at_194_233_66_31_1433_dbo_ObserverReport()
        {
            			this.m_TableName = "dbo.ObserverReport";
            this.m_infoKey = "GPMS_at_194_233_66_31_1433_dbo_ObserverReport";
        }
    }
}