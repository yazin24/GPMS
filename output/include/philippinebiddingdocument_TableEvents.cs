using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using System.Web;
using runnerDotNet;


namespace runnerDotNet
{
	[Export(typeof(IEventProviderCS_philippinebiddingdocument))]
	public class eventclassCS_philippinebiddingdocument : IEventProviderCS_philippinebiddingdocument
	{


		//	handlers
// After record added
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{

// Place event code here.
// Use "Add Action" button to add code snippets.

//pageObject.setMessage("");
//XSession.Session["saved"] = true;

int ID = keys["Id"];


dynamic SpecialConditionOfContractData = XVar.Array();

SpecialConditionOfContractData["PbdId"] = ID;
SpecialConditionOfContractData["MilestoneDescription"] = values["MilestoneDescription"];
SpecialConditionOfContractData["Deliverable"] = values["Deliverable"];
SpecialConditionOfContractData["PaymentPercentage"] = values["PaymentPercentage"];

DB.Insert("SpecialConditionOfContract", SpecialConditionOfContractData);

dynamic ScheduleOfRequirementsData = XVar.Array();

ScheduleOfRequirementsData["PbdId"] = ID;
ScheduleOfRequirementsData["Description"] = values["Description"];
ScheduleOfRequirementsData["Quantity"] = values["Quantity"];
ScheduleOfRequirementsData["DeliverySchedule"] = values["DeliverySchedule"];

DB.Insert("ScheduleOfRequirements", ScheduleOfRequirementsData);

dynamic TechnicalSpecificationsData = XVar.Array();

TechnicalSpecificationsData["PbdId"] = ID;
TechnicalSpecificationsData["ItemSpecification"] = values["ItemSpecification"];
TechnicalSpecificationsData["ComplianceStatement"] = values["ComplianceStatement"];

DB.Insert("TechnicalSpecifications", TechnicalSpecificationsData);




return null;

		} // AfterAdd





	}

}