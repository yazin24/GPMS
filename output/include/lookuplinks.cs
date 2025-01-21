using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using runnerDotNet;
namespace runnerDotNet
{
	public partial class CommonFunctions
	{
		public static XVar getLookupMainTableSettings(dynamic _param_lookupTable, dynamic _param_mainTableShortName, dynamic _param_mainField, dynamic _param_desiredPage = null)
		{
			#region default values
			if(_param_desiredPage as Object == null) _param_desiredPage = new XVar("");
			#endregion

			#region pass-by-value parameters
			dynamic lookupTable = XVar.Clone(_param_lookupTable);
			dynamic mainTableShortName = XVar.Clone(_param_mainTableShortName);
			dynamic mainField = XVar.Clone(_param_mainField);
			dynamic desiredPage = XVar.Clone(_param_desiredPage);
			#endregion

			dynamic arr = XVar.Array(), effectivePage = null;
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists(lookupTable))))
			{
				return null;
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks[lookupTable].KeyExists(MVCFunctions.Concat(mainTableShortName, ".", mainField)))))
			{
				return null;
			}
			arr = GlobalVars.lookupTableLinks[lookupTable][MVCFunctions.Concat(mainTableShortName, ".", mainField)];
			effectivePage = XVar.Clone(desiredPage);
			if(XVar.Pack(!(XVar)(arr.KeyExists(effectivePage))))
			{
				effectivePage = new XVar(Constants.PAGE_EDIT);
				if(XVar.Pack(!(XVar)(arr.KeyExists(effectivePage))))
				{
					if((XVar)(desiredPage == XVar.Pack(""))  && (XVar)(0 < MVCFunctions.count(arr)))
					{
						effectivePage = XVar.Clone(arr[0]);
					}
					else
					{
						return null;
					}
				}
			}
			return new ProjectSettings((XVar)(arr[effectivePage]["table"]), (XVar)(effectivePage));
		}
		public static XVar InitLookupLinks()
		{
			GlobalVars.lookupTableLinks = XVar.Clone(XVar.Array());
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("procuringentity.IsAuthorized"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "procuringentity.IsAuthorized");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ProcuringEntity", "field", "IsAuthorized", "page", "edit"), "dbo.SystemSelections", "procuringentity.IsAuthorized", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.ProcuringEntity"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcuringEntity");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.ProcuringEntity"].KeyExists("procurementunit.EntityId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcuringEntity", "procurementunit.EntityId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ProcurementUnit", "field", "EntityId", "page", "edit"), "dbo.ProcuringEntity", "procurementunit.EntityId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("bacsecretariat.PersonnelId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "bacsecretariat.PersonnelId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BACSecretariat", "field", "PersonnelId", "page", "edit"), "dbo.Personnel", "bacsecretariat.PersonnelId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.ProcurementUnit"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.ProcurementUnit"].KeyExists("bacsecretariat.UnitId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit", "bacsecretariat.UnitId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BACSecretariat", "field", "UnitId", "page", "edit"), "dbo.ProcurementUnit", "bacsecretariat.UnitId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.HeadOfProcuringEntity"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.HeadOfProcuringEntity");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.HeadOfProcuringEntity"].KeyExists("bacsecretariat.HopeId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.HeadOfProcuringEntity", "bacsecretariat.HopeId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BACSecretariat", "field", "HopeId", "page", "edit"), "dbo.HeadOfProcuringEntity", "bacsecretariat.HopeId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("bacsecretariat.FullTimeStaff"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "bacsecretariat.FullTimeStaff");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BACSecretariat", "field", "FullTimeStaff", "page", "edit"), "dbo.SystemSelections", "bacsecretariat.FullTimeStaff", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("bacsecretariat.CheckBalance"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "bacsecretariat.CheckBalance");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BACSecretariat", "field", "CheckBalance", "page", "edit"), "dbo.SystemSelections", "bacsecretariat.CheckBalance", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("personnel.Integrity"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "personnel.Integrity");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.Personnel", "field", "Integrity", "page", "edit"), "dbo.SystemSelections", "personnel.Integrity", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("personnel.Proficiency"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "personnel.Proficiency");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.Personnel", "field", "Proficiency", "page", "edit"), "dbo.SystemSelections", "personnel.Proficiency", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("personnel.CivilServiceQualification"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "personnel.CivilServiceQualification");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.Personnel", "field", "CivilServiceQualification", "page", "edit"), "dbo.SystemSelections", "personnel.CivilServiceQualification", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.BidsAndAwardsCommittee"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.BidsAndAwardsCommittee");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.BidsAndAwardsCommittee"].KeyExists("bacmembers.BacId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.BidsAndAwardsCommittee", "bacmembers.BacId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BACMembers", "field", "BacId", "page", "edit"), "dbo.BidsAndAwardsCommittee", "bacmembers.BacId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("bacmembers.PersonnelId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "bacmembers.PersonnelId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BACMembers", "field", "PersonnelId", "page", "edit"), "dbo.Personnel", "bacmembers.PersonnelId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.BidsAndAwardsCommittee"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.BidsAndAwardsCommittee");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.BidsAndAwardsCommittee"].KeyExists("twg.BacId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.BidsAndAwardsCommittee", "twg.BacId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.TWG", "field", "BacId", "page", "edit"), "dbo.BidsAndAwardsCommittee", "twg.BacId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("observer.PersonnelId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "observer.PersonnelId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.Observer", "field", "PersonnelId", "page", "edit"), "dbo.Personnel", "observer.PersonnelId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("observer.ObserverName"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "observer.ObserverName");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.Observer", "field", "ObserverName", "page", "edit"), "dbo.Personnel", "observer.ObserverName", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Observer"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Observer");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Observer"].KeyExists("observerinterest.ObserverId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Observer", "observerinterest.ObserverId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverInterest", "field", "ObserverId", "page", "edit"), "dbo.Observer", "observerinterest.ObserverId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.ProcurementUnit"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.ProcurementUnit"].KeyExists("observerinterest.ProcurementActivityId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit", "observerinterest.ProcurementActivityId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverInterest", "field", "ProcurementActivityId", "page", "edit"), "dbo.ProcurementUnit", "observerinterest.ProcurementActivityId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Observer"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Observer");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Observer"].KeyExists("observerreport.ObserverId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Observer", "observerreport.ObserverId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "ObserverId", "page", "edit"), "dbo.Observer", "observerreport.ObserverId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.ProcurementUnit"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.ProcurementUnit"].KeyExists("observerreport.ProcurementActivityId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit", "observerreport.ProcurementActivityId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "ProcurementActivityId", "page", "edit"), "dbo.ProcurementUnit", "observerreport.ProcurementActivityId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("observerreport.BACMeetingsMinutes"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "observerreport.BACMeetingsMinutes");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "BACMeetingsMinutes", "page", "edit"), "dbo.SystemSelections", "observerreport.BACMeetingsMinutes", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("observerreport.AbstractOfBids"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "observerreport.AbstractOfBids");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "AbstractOfBids", "page", "edit"), "dbo.SystemSelections", "observerreport.AbstractOfBids", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("observerreport.PostQualificationReport"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "observerreport.PostQualificationReport");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "PostQualificationReport", "page", "edit"), "dbo.SystemSelections", "observerreport.PostQualificationReport", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("observerreport.APPPPMPDocuments"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "observerreport.APPPPMPDocuments");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "APPPPMPDocuments", "page", "edit"), "dbo.SystemSelections", "observerreport.APPPPMPDocuments", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("observerreport.OpenedProposals"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "observerreport.OpenedProposals");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "OpenedProposals", "page", "edit"), "dbo.SystemSelections", "observerreport.OpenedProposals", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("observerreport.AbstractSigned"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "observerreport.AbstractSigned");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "AbstractSigned", "page", "edit"), "dbo.SystemSelections", "observerreport.AbstractSigned", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("observerreport.PostQualificationSigned"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "observerreport.PostQualificationSigned");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "PostQualificationSigned", "page", "edit"), "dbo.SystemSelections", "observerreport.PostQualificationSigned", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("observerreport.WrittenDissent"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "observerreport.WrittenDissent");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ObserverReport", "field", "WrittenDissent", "page", "edit"), "dbo.SystemSelections", "observerreport.WrittenDissent", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.TWG"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.TWG");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.TWG"].KeyExists("twgexpertise.TWGId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.TWG", "twgexpertise.TWGId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.TWGExpertise", "field", "TWGId", "page", "edit"), "dbo.TWG", "twgexpertise.TWGId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("twgexpertise.PersonnelId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "twgexpertise.PersonnelId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.TWGExpertise", "field", "PersonnelId", "page", "edit"), "dbo.Personnel", "twgexpertise.PersonnelId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("twgexpertise.FundAvailability"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "twgexpertise.FundAvailability");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.TWGExpertise", "field", "FundAvailability", "page", "edit"), "dbo.SystemSelections", "twgexpertise.FundAvailability", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.ProcurementUnit"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.ProcurementUnit"].KeyExists("ppmp.EndUserUnit"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit", "ppmp.EndUserUnit");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "EndUserUnit", "page", "edit"), "dbo.ProcurementUnit", "ppmp.EndUserUnit", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.January"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.January");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "January", "page", "edit"), "dbo.SystemSelections", "ppmp.January", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.February"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.February");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "February", "page", "edit"), "dbo.SystemSelections", "ppmp.February", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.March"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.March");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "March", "page", "edit"), "dbo.SystemSelections", "ppmp.March", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.April"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.April");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "April", "page", "edit"), "dbo.SystemSelections", "ppmp.April", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.May"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.May");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "May", "page", "edit"), "dbo.SystemSelections", "ppmp.May", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.June"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.June");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "June", "page", "edit"), "dbo.SystemSelections", "ppmp.June", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.July"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.July");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "July", "page", "edit"), "dbo.SystemSelections", "ppmp.July", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.August"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.August");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "August", "page", "edit"), "dbo.SystemSelections", "ppmp.August", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.September"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.September");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "September", "page", "edit"), "dbo.SystemSelections", "ppmp.September", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.October"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.October");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "October", "page", "edit"), "dbo.SystemSelections", "ppmp.October", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.November"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.November");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "November", "page", "edit"), "dbo.SystemSelections", "ppmp.November", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("ppmp.December"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "ppmp.December");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PPMP", "field", "December", "page", "edit"), "dbo.SystemSelections", "ppmp.December", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.PPMP"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.PPMP");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.PPMP"].KeyExists("procurementmonitoring.PpmpId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.PPMP", "procurementmonitoring.PpmpId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ProcurementMonitoring", "field", "PpmpId", "page", "edit"), "dbo.PPMP", "procurementmonitoring.PpmpId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.ProcurementUnit"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.ProcurementUnit"].KeyExists("vw_app.EndUser/Unit"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcurementUnit", "vw_app.EndUser/Unit");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.vw_APP", "field", "EndUser/Unit", "page", "edit"), "dbo.ProcurementUnit", "vw_app.EndUser/Unit", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.ProcuringEntity"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcuringEntity");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.ProcuringEntity"].KeyExists("philippinebiddingdocument.ProcuringEntity"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcuringEntity", "philippinebiddingdocument.ProcuringEntity");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PhilippineBiddingDocument", "field", "ProcuringEntity", "page", "edit"), "dbo.ProcuringEntity", "philippinebiddingdocument.ProcuringEntity", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("philippinebiddingdocument.BACChairperson"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "philippinebiddingdocument.BACChairperson");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.PhilippineBiddingDocument", "field", "BACChairperson", "page", "edit"), "dbo.Personnel", "philippinebiddingdocument.BACChairperson", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.PhilippineBiddingDocument"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.PhilippineBiddingDocument");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.PhilippineBiddingDocument"].KeyExists("scheduleofrequirements.PbdId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.PhilippineBiddingDocument", "scheduleofrequirements.PbdId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.ScheduleOfRequirements", "field", "PbdId", "page", "edit"), "dbo.PhilippineBiddingDocument", "scheduleofrequirements.PbdId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.PhilippineBiddingDocument"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.PhilippineBiddingDocument");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.PhilippineBiddingDocument"].KeyExists("technicalspecifications.PbdId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.PhilippineBiddingDocument", "technicalspecifications.PbdId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.TechnicalSpecifications", "field", "PbdId", "page", "edit"), "dbo.PhilippineBiddingDocument", "technicalspecifications.PbdId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.SystemSelections"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.SystemSelections"].KeyExists("technicalspecifications.ComplianceStatement"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.SystemSelections", "technicalspecifications.ComplianceStatement");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.TechnicalSpecifications", "field", "ComplianceStatement", "page", "edit"), "dbo.SystemSelections", "technicalspecifications.ComplianceStatement", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.PhilippineBiddingDocument"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.PhilippineBiddingDocument");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.PhilippineBiddingDocument"].KeyExists("specialconditionsofcontract.PbdId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.PhilippineBiddingDocument", "specialconditionsofcontract.PbdId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.SpecialConditionsOfContract", "field", "PbdId", "page", "edit"), "dbo.PhilippineBiddingDocument", "specialconditionsofcontract.PbdId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.ProcuringEntity"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcuringEntity");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.ProcuringEntity"].KeyExists("bidsandawardscommittee.EntityId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcuringEntity", "bidsandawardscommittee.EntityId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BidsAndAwardsCommittee", "field", "EntityId", "page", "edit"), "dbo.ProcuringEntity", "bidsandawardscommittee.EntityId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("bidsandawardscommittee.ChairpersonId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "bidsandawardscommittee.ChairpersonId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BidsAndAwardsCommittee", "field", "ChairpersonId", "page", "edit"), "dbo.Personnel", "bidsandawardscommittee.ChairpersonId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("bidsandawardscommittee.ViceChairpersonId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "bidsandawardscommittee.ViceChairpersonId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.BidsAndAwardsCommittee", "field", "ViceChairpersonId", "page", "edit"), "dbo.Personnel", "bidsandawardscommittee.ViceChairpersonId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("headofprocuringentity.PersonnelId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "headofprocuringentity.PersonnelId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.HeadOfProcuringEntity", "field", "PersonnelId", "page", "edit"), "dbo.Personnel", "headofprocuringentity.PersonnelId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.ProcuringEntity"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcuringEntity");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.ProcuringEntity"].KeyExists("headofprocuringentity.EntityId"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.ProcuringEntity", "headofprocuringentity.EntityId");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.HeadOfProcuringEntity", "field", "EntityId", "page", "edit"), "dbo.ProcuringEntity", "headofprocuringentity.EntityId", "edit");
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks.KeyExists("dbo.Personnel"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel");
			}
			if(XVar.Pack(!(XVar)(GlobalVars.lookupTableLinks["dbo.Personnel"].KeyExists("headofprocuringentity.HopeName"))))
			{
				GlobalVars.lookupTableLinks.InitAndSetArrayItem(XVar.Array(), "dbo.Personnel", "headofprocuringentity.HopeName");
			}
			GlobalVars.lookupTableLinks.InitAndSetArrayItem(new XVar("table", "dbo.HeadOfProcuringEntity", "field", "HopeName", "page", "edit"), "dbo.Personnel", "headofprocuringentity.HopeName", "edit");
			return null;
		}
	}
}
