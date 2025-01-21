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
	[Export(typeof(IGlobalEventProviderCS))]
	public class CommonEventsCS : IGlobalEventProviderCS
	{

		// handlers

// Modify Menu
		public XVar ModifyMenu(dynamic menu)
		{
if( menu.name() == "main" ) {
    // modify main menu here
}
return null;

		} // ModifyMenu


		// onscreen events

		// table maps, buttons
		public XVar event_ViewDetailsButton(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
// Put your code here.
result["txt"] = parameters["txt"].ToString() + " world";


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_Print_PPMP_Button(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
// Put your code here.
//result["txt"] = parameters["txt"].ToString() + " world";

XVar data = button.getCurrentRecord();
string id = data["Id"];
result["ReportLink"] = CrystalReports.PrintPPMP(id);

			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_PrintProcurementMonitoringReportButton(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code

XVar ProcurementMonitoringReportData = button.getCurrentRecord();

string id = ProcurementMonitoringReportData["Id"];

result["ReportLink"] = CrystalReports.PrintProcurementMonitoringReport(id);


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_PrintAPPReportButton(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
//XVar APPReportData = button.getCurrentRecord();
//string id = APPReportData["Id"];
//result["ReportLink"] = CrystalReports.PrintAPPReport(id);


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}
		public XVar event_New_Button(dynamic context)
		{
			// context unpacking
			var parameters = context["var_params"];
			var result = context["result"];
			var keys = context["keys"];
			var button = context["button"];
			var ajax = button;
			// event code
// Put your code here.
result["txt"] = parameters["txt"].ToString() + " world";


			// context packing
			context["var_params"] = parameters;
			context["result"] = result;
			context["keys"] = keys;
			context["button"] = button;
			return null;
		}




		public XVar AfterTableInit(dynamic context)
		{
			var table = context["table"];
			var query = context["query"];
			context["query"] = query;
			return null;
		}

		public XVar GetTablePermissions(dynamic permissions, dynamic table = null)
		{
			return permissions;
		}

		public XVar IsRecordEditable(dynamic values, dynamic isEditable, dynamic table = null)
		{
			return isEditable;
		}
	}
}