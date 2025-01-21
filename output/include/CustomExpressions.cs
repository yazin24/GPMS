using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using runnerDotNet;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace runnerDotNet
{
	[Export(typeof(ICustomExpressionProviderCS))]
	public class CustomExpressionProviderCS : ICustomExpressionProviderCS
	{
		public XVar GetCustomExpression(XVar value, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			if(table == "dbo.ProcuringEntity"  &&  field == "IsAuthorized")
			{
value = data["IsAuthorized"] == null ? "N/A" : data["IsAuthorized"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ProcurementUnit"  &&  field == "OrganizationalLevel")
			{
value = data["OrganizationalLevel"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BACSecretariat"  &&  field == "SecretariatName")
			{
value = data["SecretariatName"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BACSecretariat"  &&  field == "SecretariatType")
			{
value = data["SecretariatType"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BACSecretariat"  &&  field == "HeadRank")
			{
value = data["HeadRank"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BACSecretariat"  &&  field == "FullTimeStaff")
			{
value = data["FullTimeStaff"].ToString()== "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.BACSecretariat"  &&  field == "CheckBalance")
			{
value = data["CheckBalance"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.Personnel"  &&  field == "Name")
			{
value = data["Name"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.Personnel"  &&  field == "Integrity")
			{

value = data["Integrity"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.Personnel"  &&  field == "Proficiency")
			{
value = data["Proficiency"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.Personnel"  &&  field == "CivilServiceQualification")
			{

value = data["CivilServiceQualification"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.Personnel"  &&  field == "Rank")
			{
value = data["Rank"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.Personnel"  &&  field == "TrainingDetails")
			{
value = data["TrainingDetails"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BACMembers"  &&  field == "BacMemberName")
			{

value = data["BacMemberName"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BACMembers"  &&  field == "MemberType")
			{
value = data["MemberType"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BACMembers"  &&  field == "Role")
			{
value = data["Role"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BACMembers"  &&  field == "ApptTerm")
			{
value = data["ApptTerm"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.TWG"  &&  field == "CreationDate")
			{
value = data["CreationDate"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}
;return value;
			}
			if(table == "dbo.Observer"  &&  field == "ObserverName")
			{
value = data["ObserverName"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.Observer"  &&  field == "ObserverOrganization")
			{
value = data["ObservationOrganization"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.Observer"  &&  field == "ContactDetails")
			{
value = data["ContactDetails"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.Observer"  &&  field == "DateJoined")
			{
value = data["DateJoined"].ToString();

if (string.IsNullOrEmpty(value))
{
    return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.Observer"  &&  field == "ConfidentialityAgreement")
			{
value = data["ConfidentialityAgreement"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ObserverInterest"  &&  field == "ObserverId")
			{
 //int ID = values["ObserverId"];

 //string sqlQuery = "SELECT Name FROM dbo.Personnel WHERE Id=" + ID;
 //dynamic result = DB.Query(sqlQuery);
 //string FullName = result.fetchAssoc()["Name"];

 //values["ObserverName"] = PersonnelName;

 //return true;

;return value;
			}
			if(table == "dbo.ObserverInterest"  &&  field == "InterestType")
			{
value = data["InterestType"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ObserverInterest"  &&  field == "InterestDescription")
			{
value = data["InterestDescription"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ObserverInterest"  &&  field == "DateReported")
			{
value = data["DateReported"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "ReportDate")
			{
value = data["ReportDate"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "ComplianceAssesment")
			{
value = data["ComplianceAssestment"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "AreasOfImprovement")
			{
value = data["AreasOfImprovement"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "BACMeetingsMinutes")
			{
value = data["BACMeetingsMinutes"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "AbstractOfBids")
			{
value = data["AbstractOfBids"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "PostQualificationReport")
			{
value = data["PostQualificationReport"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "APPPPMPDocuments")
			{
value = data["APPPPMPDocuments"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "OpenedProposals")
			{
value = data["OpenedProposals"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "ReportSubmittedto")
			{
value = data["ReportSubmittedto"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "ReportStatus")
			{
value = data["ReportStatus"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "AbstractSigned")
			{
value = data["AbstractSigned"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "PostQualificationSigned")
			{
value = data["PostQualificationSigned"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ObserverReport"  &&  field == "WrittenDissent")
			{
value = data["WrittenDissent"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.TWGExpertise"  &&  field == "ExpertiseType")
			{
value = data["ExpertiseType"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.TWGExpertise"  &&  field == "ExpertDepartment")
			{
value = data["ExpertDepartment"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.TWGExpertise"  &&  field == "ConsultantsEngaged")
			{
value = data["ConsultantsEngaged"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.TWGExpertise"  &&  field == "ConsultantsEngagement_Reason")
			{
value = data["ConsultantsEngagement_Reason"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.TWGExpertise"  &&  field == "FundAvailability")
			{
value = data["FundAvailability"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "January")
			{

value = data["January"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "February")
			{
value = data["February"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "March")
			{
value = data["March"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "April")
			{
value = data["April"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "May")
			{
value = data["May"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "June")
			{
value = data["June"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "July")
			{
value = data["July"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "August")
			{
value = data["August"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "September")
			{
value = data["September"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "October")
			{
value = data["October"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "November")
			{
value = data["November"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PPMP"  &&  field == "December")
			{
value = data["December"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "IsthisAnEarlyProcurementActivity")
			{
value = data["IsthisAnEarlyProcurementActivity"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "PreProcConference")
			{
value = data["PreProcConference"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "AdsPostOfIB")
			{
value = data["AdsPostOfIB"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "PreBidConf")
			{
value = data["PreBidConf"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "EligibilityCheck")
			{
value = data["EligibilityCheck"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "SubOpenOfBids")
			{
value = data["SubOpenOfBids"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "BidEvaluation")
			{
value = data["BidEvaluation"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "PostQual")
			{
value = data["PostQual"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "DateOfBACResolutionRecommendingAward")
			{
value = data["DateOfBACResolutionRecommendingAward"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "NoticeOfAward")
			{
value = data["NoticeOfAward"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "ContractSigning")
			{
value = data["ContractSigning"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "NoticeToProceed")
			{
value = data["NoticeToProceed"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "DeliveryCompletion")
			{
value = data["DeliveryCompletion"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "InspectionAndAcceptance")
			{
value = data["InspectionAndAcceptance"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "DeliveryCompletionAcceptanceIfApplicable")
			{
value = data["DeliveryCompletionAcceptanceIfApplicable"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "RemarksExplainingChangesFromTheAPP")
			{
value = data["RemarksExplainingChangesFromTheApp"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "January")
			{
value = data["January"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "February")
			{
value = data["February"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "March")
			{
value = data["March"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "April")
			{
value = data["April"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "May")
			{
value = data["May"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "June")
			{
value = data["June"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "July")
			{
value = data["July"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "August")
			{
value = data["August"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "September")
			{
value = data["September"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "October")
			{
value = data["October"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "November")
			{
value = data["November"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.vw_APP"  &&  field == "December")
			{
value = data["December"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ProjectName")
			{
value = data["ProjectName"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidReferenceNo")
			{
value = data["BidReferenceNo"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ApprovedBudget")
			{
value = data["ApprovedBudget"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "DeliveryDays")
			{
value = data["DeliveryDays"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "DatePosted")
			{
value = data["DatePosted"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidDocsAvailabilityStart")
			{
value = data["BidDocsAvailabilityStart"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidDocsAvailabilityEnd")
			{
value = data["BidDocsAvailabilityEnd"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}


DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSubmissionDeadline")
			{
value = data["BidSubmissionDeadline"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}

;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidDocsCost")
			{
value = data["BidDocsCost"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "PreBidConferenceDate")
			{
value = data["PreBidConferenceDate"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "PreBidConferenceVenue")
			{
value = data["PreBidConferenceVenue"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "SimilarProjects")
			{

value = data["SimilarProjects"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecurity")
			{
value = data["BidSecurity"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidOpeningdate")
			{
value = data["BidOpeningDate"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidOpeningVenue")
			{
value = data["BidOpeningVenue"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContactPersonName")
			{
value = data["ContactPersonName"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContactPersonOffice")
			{
value = data["ContactPersonOffice"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContactPersonAddress")
			{
value = data["ContactPersonAddress"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContactPersonPhone")
			{
value = data["ContactPersonPhone"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "Website")
			{
value = data["Website"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "IssuanceDate")
			{
value = data["IssuanceDate"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}

DateTime dateJoined;
if (DateTime.TryParse(value, out dateJoined))
{
    return dateJoined.ToString("MM-dd-yy");
}
else
{
    return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ProjectDescription")
			{
value = data["ProjectDescription"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "FundingSource")
			{
value = data["FundingSource"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "SLCCRequirement")
			{
value = data["SLCCRequirement"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "SubContractingAllowed")
			{
value = data["SubContractingAllowed"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidCurrencies")
			{
value = data["BidCurrencies"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "PaymentCurrency")
			{
value = data["PaymentCurrency"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecuritySubDays")
			{
value = data["BidSecuritySubDays"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContractSimilarToProject")
			{
value = data["ContractSimilarToProject"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "SimilarProjectYears")
			{
value = data["SimilarProjectYears"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecurityCashAmount")
			{
value = data["BidSecurityCashAmount"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecurityCashPercent")
			{
value = data["BidSecurityCashPercent"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecuritySuretyBondAmount")
			{
value = data["BidSecuritySuretyBondAmount"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecuritySuretyBondPercent")
			{
value = data["BidSecuritySuretyBondPercent"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ScheduleOfRequirements"  &&  field == "Description")
			{
value = data["Description"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ScheduleOfRequirements"  &&  field == "Quantity")
			{
value = data["Quantity"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.ScheduleOfRequirements"  &&  field == "DeliverySchedule")
			{
value = data["DeliverySchedule"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.TechnicalSpecifications"  &&  field == "ItemSpecification")
			{
value = data["ItemSpecification"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.TechnicalSpecifications"  &&  field == "ComplianceStatement")
			{
value = data["ComplianceStatement"].ToString() == "1" ? "Yes" : "No";
;return value;
			}
			if(table == "dbo.SpecialConditionsOfContract"  &&  field == "MilestoneDescription")
			{
value = data["MilestoneDescription"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.SpecialConditionsOfContract"  &&  field == "Deliverable")
			{
value = data["Deliverable"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.SpecialConditionsOfContract"  &&  field == "PaymentPercentage")
			{
value = data["PaymentPercentage"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "BacName")
			{
value = data["BacName"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "CreationReason")
			{
value = data["CreationReason"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "Location")
			{
value = data["Location"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "MinBacMember")
			{
value = data["MinBacMember"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "MaxBacMember")
			{
value = data["MaxBacMember"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.HeadOfProcuringEntity"  &&  field == "HopeType")
			{
value = data["HopeType"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			if(table == "dbo.HeadOfProcuringEntity"  &&  field == "DelegationDetails")
			{
value = data["DelegationDetails"].ToString();

if(string.IsNullOrEmpty(value))
{
	return "N/A";
}
;return value;
			}
			return value;
		}

		public XVar GetFileCustomExpression(XVar file, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			XVar value = "";
			return value;
		}

		public XVar GetLWWhere(XVar field, XVar ptype, XVar table = null)
		{
			return "";
		}

		public XVar GetDefaultValue(XVar field, XVar ptype, XVar table = null)
		{
			return "";
		}

		public XVar GetAutoUpdateValue(XVar field, XVar ptype, XVar table = null)
		{
			return "";
		}

		public XVar getCustomMapIcon(XVar field, XVar table, XVar data)
		{
			XVar icon = "";
			return "";
		}

		public XVar getDashMapCustomIcon(XVar dashName, XVar dashElementName, XVar data)
		{
			XVar icon = "";
			return "";
		}

		public XVar getDashMapCustomLocationIcon(XVar dashName, XVar dashElementName, XVar data)
		{
			XVar icon = "";
			return "";
		}

		public XVar GetUploadFolderExpression(XVar field, XVar file, XVar table = null)
		{
			return "";
		}

		public XVar GetIntervalLimitsExprs(XVar table, XVar field, XVar idx, XVar isLowerBound)
		{
			return "";
		}
	}
}