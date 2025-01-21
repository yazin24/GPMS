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
	public interface ICustomExpressionProvider
	{
		XVar GetCustomExpression(XVar value, XVar data, XVar field, XVar ptype, XVar table = null);
		XVar GetFileCustomExpression(XVar file, XVar data, XVar field, XVar ptype, XVar table = null);
		XVar GetLWWhere(XVar field, XVar ptype, XVar table = null);
		XVar GetDefaultValue(XVar field, XVar ptype, XVar table = null);
		XVar GetAutoUpdateValue(XVar field, XVar ptype, XVar table = null);
		XVar GetUploadFolderExpression(XVar field, XVar file, XVar table = null);
		XVar GetIntervalLimitsExprs(XVar table, XVar field, XVar idx, XVar isLowerBound);
		XVar getCustomMapIcon(XVar field, XVar table, XVar data);
		XVar getDashMapCustomIcon(XVar dashName, XVar dashElementName, XVar data);
		XVar getDashMapCustomLocationIcon(XVar dashName, XVar dashElementName, XVar data);
	}

	public interface ICustomExpressionProviderVB : ICustomExpressionProvider {}

	public interface ICustomExpressionProviderCS : ICustomExpressionProvider {}

	public class CustomExpressionProvider
	{
		private static CustomExpressionProvider _instance;

		public static CustomExpressionProvider Instance
		{
			get
			{
				if(_instance == null)
					_instance = new CustomExpressionProvider();

				return _instance;
			}
		}

		//[Import(typeof(ICustomExpressionProviderCS))]
		public ICustomExpressionProviderCS CustomExpressionProviderCS;

		//[Import(typeof(ICustomExpressionProviderVB))]
		public ICustomExpressionProviderVB CustomExpressionProviderVB;

        public void CreateEvents()
        {
			CustomExpressionProviderCS = new CustomExpressionProviderCS();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.CustomExpressionProviderVB");
				if(eType != null)
				{
					CustomExpressionProviderVB = (ICustomExpressionProviderVB)Activator.CreateInstance(eType);
				}
			}
        }

		private CustomExpressionProvider()
		{
			CreateEvents();
		}

		public XVar GetCustomExpression(XVar value, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			if(table == "dbo.ProcuringEntity"  &&  field == "IsAuthorized")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementUnit"  &&  field == "OrganizationalLevel")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BACSecretariat"  &&  field == "SecretariatName")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BACSecretariat"  &&  field == "SecretariatType")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BACSecretariat"  &&  field == "HeadRank")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BACSecretariat"  &&  field == "FullTimeStaff")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BACSecretariat"  &&  field == "CheckBalance")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Personnel"  &&  field == "Name")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Personnel"  &&  field == "Integrity")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Personnel"  &&  field == "Proficiency")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Personnel"  &&  field == "CivilServiceQualification")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Personnel"  &&  field == "Rank")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Personnel"  &&  field == "TrainingDetails")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BACMembers"  &&  field == "BacMemberName")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BACMembers"  &&  field == "MemberType")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BACMembers"  &&  field == "Role")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BACMembers"  &&  field == "ApptTerm")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.TWG"  &&  field == "CreationDate")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Observer"  &&  field == "ObserverName")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Observer"  &&  field == "ObserverOrganization")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Observer"  &&  field == "ContactDetails")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Observer"  &&  field == "DateJoined")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.Observer"  &&  field == "ConfidentialityAgreement")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverInterest"  &&  field == "ObserverId")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverInterest"  &&  field == "InterestType")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverInterest"  &&  field == "InterestDescription")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverInterest"  &&  field == "DateReported")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "ReportDate")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "ComplianceAssesment")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "AreasOfImprovement")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "BACMeetingsMinutes")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "AbstractOfBids")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "PostQualificationReport")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "APPPPMPDocuments")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "OpenedProposals")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "ReportSubmittedto")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "ReportStatus")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "AbstractSigned")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "PostQualificationSigned")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "WrittenDissent")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.TWGExpertise"  &&  field == "ExpertiseType")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.TWGExpertise"  &&  field == "ExpertDepartment")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.TWGExpertise"  &&  field == "ConsultantsEngaged")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.TWGExpertise"  &&  field == "ConsultantsEngagement_Reason")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.TWGExpertise"  &&  field == "FundAvailability")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "January")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "February")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "March")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "April")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "May")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "June")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "July")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "August")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "September")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "October")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "November")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "December")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "IsthisAnEarlyProcurementActivity")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "PreProcConference")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "AdsPostOfIB")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "PreBidConf")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "EligibilityCheck")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "SubOpenOfBids")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "BidEvaluation")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "PostQual")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "DateOfBACResolutionRecommendingAward")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "NoticeOfAward")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "ContractSigning")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "NoticeToProceed")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "DeliveryCompletion")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "InspectionAndAcceptance")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "DeliveryCompletionAcceptanceIfApplicable")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ProcurementMonitoring"  &&  field == "RemarksExplainingChangesFromTheAPP")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "January")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "February")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "March")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "April")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "May")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "June")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "July")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "August")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "September")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "October")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "November")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.vw_APP"  &&  field == "December")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ProjectName")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidReferenceNo")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ApprovedBudget")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "DeliveryDays")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "DatePosted")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidDocsAvailabilityStart")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidDocsAvailabilityEnd")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSubmissionDeadline")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidDocsCost")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "PreBidConferenceDate")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "PreBidConferenceVenue")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "SimilarProjects")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecurity")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidOpeningdate")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidOpeningVenue")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContactPersonName")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContactPersonOffice")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContactPersonAddress")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContactPersonPhone")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "Website")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "IssuanceDate")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ProjectDescription")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "FundingSource")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "SLCCRequirement")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "SubContractingAllowed")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidCurrencies")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "PaymentCurrency")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecuritySubDays")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "ContractSimilarToProject")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "SimilarProjectYears")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecurityCashAmount")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecurityCashPercent")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecuritySuretyBondAmount")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BidSecuritySuretyBondPercent")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ScheduleOfRequirements"  &&  field == "Description")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ScheduleOfRequirements"  &&  field == "Quantity")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.ScheduleOfRequirements"  &&  field == "DeliverySchedule")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.TechnicalSpecifications"  &&  field == "ItemSpecification")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.TechnicalSpecifications"  &&  field == "ComplianceStatement")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.SpecialConditionsOfContract"  &&  field == "MilestoneDescription")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.SpecialConditionsOfContract"  &&  field == "Deliverable")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.SpecialConditionsOfContract"  &&  field == "PaymentPercentage")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "BacName")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "CreationReason")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "Location")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "MinBacMember")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "MaxBacMember")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.HeadOfProcuringEntity"  &&  field == "HopeType")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			if(table == "dbo.HeadOfProcuringEntity"  &&  field == "DelegationDetails")
			{
				return CustomExpressionProviderCS.GetCustomExpression(value, data, field, ptype, table);
			}
			return value;
		}

		public XVar GetFileCustomExpression(XVar file, XVar data, XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar GetLWWhere(XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			if(table == "dbo.ProcuringEntity"  &&  field == "IsAuthorized")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.Personnel"  &&  field == "Integrity")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.Personnel"  &&  field == "Proficiency")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.Personnel"  &&  field == "CivilServiceQualification")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "BACMeetingsMinutes")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "AbstractOfBids")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "PostQualificationReport")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "APPPPMPDocuments")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "OpenedProposals")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "AbstractSigned")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "PostQualificationSigned")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.ObserverReport"  &&  field == "WrittenDissent")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.TWGExpertise"  &&  field == "FundAvailability")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "January")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "February")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "March")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "April")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "May")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "June")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "July")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "August")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "September")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "October")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "November")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PPMP"  &&  field == "December")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.PhilippineBiddingDocument"  &&  field == "BACChairperson")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.TechnicalSpecifications"  &&  field == "ComplianceStatement")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "ChairpersonId")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			if(table == "dbo.BidsAndAwardsCommittee"  &&  field == "ViceChairpersonId")
			{
				return CustomExpressionProviderCS.GetLWWhere(field, ptype, table);
			}
			return "";
		}

		public XVar GetDefaultValue(XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar GetAutoUpdateValue(XVar field, XVar ptype, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar getCustomMapIcon(XVar field, XVar ptype, XVar table, XVar data)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar getDashMapCustomIcon(XVar dashName, XVar dashElementName, XVar data)
		{

			return "";
		}

		public XVar getDashMapCustomLocationIcon(XVar dashName, XVar dashElementName, XVar data)
		{

			return "";
		}

		public XVar GetUploadFolderExpression(XVar field, XVar file, XVar table = null)
		{
			if(!table)
			{
				table = GlobalVars.strTableName;
			}

			return "";
		}

		public XVar GetIntervalLimitsExprs(XVar table, XVar field, XVar idx, XVar isLowerBound)
		{
			return "";
		}
	}
}