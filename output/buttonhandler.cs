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
	public partial class GlobalController : BaseController
	{
		public XVar buttonhandler()
		{
			try
			{
				dynamic buttId = null, eventId = null, i = null, page = null, table = null, var_params = XVar.Array();
				ProjectSettings pSet;
				GlobalVars.init_dbcommon();
				if(XVar.Pack(!(XVar)(CommonFunctions.isPostRequest())))
				{
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				var_params = XVar.Clone(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("params")))));
				if(XVar.Pack(var_params["_base64fields"]))
				{
					foreach (KeyValuePair<XVar, dynamic> f in var_params["_base64fields"].GetEnumerator())
					{
						var_params.InitAndSetArrayItem(MVCFunctions.base64_str2bin((XVar)(var_params[f.Value])), f.Value);
					}
				}
				buttId = XVar.Clone(var_params["buttId"]);
				eventId = XVar.Clone(MVCFunctions.postvalue(new XVar("event")));
				table = XVar.Clone(var_params["table"]);
				if(XVar.Pack(!(XVar)(CommonFunctions.GetTableURL((XVar)(table)))))
				{
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				page = XVar.Clone(var_params["page"]);
				if(XVar.Pack(!(XVar)(Security.userCanSeePage((XVar)(table), (XVar)(page)))))
				{
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				pSet = XVar.UnPackProjectSettings(new ProjectSettings((XVar)(table), new XVar(""), (XVar)(page)));
				if(XVar.Pack(buttId))
				{
					dynamic pageButtons = null;
					pageButtons = XVar.Clone(pSet.customButtons());
					if(XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(buttId), (XVar)(pageButtons))), XVar.Pack(false)))
					{
						MVCFunctions.Echo(new XVar(""));
						return MVCFunctions.GetBuferContentAndClearBufer();
					}
				}
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("masterTable")), "masterTable");
				var_params.InitAndSetArrayItem(XVar.Array(), "masterKeys");
				i = new XVar(1);
				while(XVar.Pack(MVCFunctions.REQUESTKeyExists(MVCFunctions.Concat("masterkey", i))))
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(MVCFunctions.Concat("masterkey", i)), "masterKeys", i);
					i++;
				}
				if(buttId == "ViewDetailsButton")
				{
					if(table != Constants.GLOBAL_PAGES)
					{
						Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", CommonFunctions.GetTableURL((XVar)(table)), ""),
							"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
						GlobalVars.cipherer = XVar.Clone(new RunnerCipherer((XVar)(table)));
					}
					buttonHandler_ViewDetailsButton((XVar)(var_params));
				}
				if(buttId == "Print_PPMP_Button")
				{
					if(table != Constants.GLOBAL_PAGES)
					{
						Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", CommonFunctions.GetTableURL((XVar)(table)), ""),
							"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
						GlobalVars.cipherer = XVar.Clone(new RunnerCipherer((XVar)(table)));
					}
					buttonHandler_Print_PPMP_Button((XVar)(var_params));
				}
				if(buttId == "PrintProcurementMonitoringReportButton")
				{
					if(table != Constants.GLOBAL_PAGES)
					{
						Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", CommonFunctions.GetTableURL((XVar)(table)), ""),
							"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
						GlobalVars.cipherer = XVar.Clone(new RunnerCipherer((XVar)(table)));
					}
					buttonHandler_PrintProcurementMonitoringReportButton((XVar)(var_params));
				}
				if(buttId == "PrintAPPReportButton")
				{
					if(table != Constants.GLOBAL_PAGES)
					{
						Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", CommonFunctions.GetTableURL((XVar)(table)), ""),
							"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
						GlobalVars.cipherer = XVar.Clone(new RunnerCipherer((XVar)(table)));
					}
					buttonHandler_PrintAPPReportButton((XVar)(var_params));
				}
				if(buttId == "New_Button")
				{
					if(table != Constants.GLOBAL_PAGES)
					{
						Assembly.GetExecutingAssembly().GetType(MVCFunctions.Concat("runnerDotNet.", MVCFunctions.Concat("", CommonFunctions.GetTableURL((XVar)(table)), ""),
							"_Variables")).InvokeMember("Apply", BindingFlags.InvokeMethod, null, null, null);
						GlobalVars.cipherer = XVar.Clone(new RunnerCipherer((XVar)(table)));
					}
					buttonHandler_New_Button((XVar)(var_params));
				}
				return MVCFunctions.GetBuferContentAndClearBufer();
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
		public static XVar buttonHandler_ViewDetailsButton(dynamic _param_params)
		{
			#region pass-by-value parameters
			dynamic var_params = XVar.Clone(_param_params);
			#endregion

			dynamic ajax = null, button = null, contextParams = XVar.Array(), keys = null, masterData = null, result = null;
			result = XVar.Clone(XVar.Array());
			var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("keys")))), "keys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("isManyKeys")), "isManyKeys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("location")), "location");
			button = XVar.Clone(new Button((XVar)(var_params)));
			ajax = XVar.Clone(button);
			keys = XVar.Clone(button.getKeys());
			masterData = new XVar(false);
			if((XVar)(var_params.KeyExists("masterData"))  && (XVar)(0 < MVCFunctions.count(var_params["masterData"])))
			{
				masterData = XVar.Clone(var_params["masterData"]);
			}
			else
			{
				if(XVar.Pack(var_params.KeyExists("masterTable")))
				{
					masterData = XVar.Clone(button.getMasterData((XVar)(var_params["masterTable"])));
				}
			}
			contextParams = XVar.Clone(XVar.Array());
			if(var_params["location"] == Constants.PAGE_VIEW)
			{
				contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
				contextParams.InitAndSetArrayItem(masterData, "masterData");
			}
			else
			{
				if(var_params["location"] == Constants.PAGE_EDIT)
				{
					contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
					contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
					contextParams.InitAndSetArrayItem(masterData, "masterData");
				}
				else
				{
					if(var_params["location"] == "grid")
					{
						var_params.InitAndSetArrayItem("list", "location");
						contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
						contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
					else
					{
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
				}
			}
			RunnerContext.push((XVar)(new RunnerContextItem((XVar)(var_params["location"]), (XVar)(contextParams))));
			
var eventContext = XVar.Array();
eventContext["var_params"] = var_params;
eventContext["result"] = result;
eventContext["keys"] = keys;
eventContext["button"] = button;
GlobalVars.globalEvents.event_ViewDetailsButton(eventContext);
result = eventContext["result"];

			RunnerContext.pop();
			MVCFunctions.Echo(MVCFunctions.my_json_encode((XVar)(result)));
			button.deleteTempFiles();
			return null;
		}
		public static XVar buttonHandler_Print_PPMP_Button(dynamic _param_params)
		{
			#region pass-by-value parameters
			dynamic var_params = XVar.Clone(_param_params);
			#endregion

			dynamic ajax = null, button = null, contextParams = XVar.Array(), keys = null, masterData = null, result = null;
			result = XVar.Clone(XVar.Array());
			var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("keys")))), "keys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("isManyKeys")), "isManyKeys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("location")), "location");
			button = XVar.Clone(new Button((XVar)(var_params)));
			ajax = XVar.Clone(button);
			keys = XVar.Clone(button.getKeys());
			masterData = new XVar(false);
			if((XVar)(var_params.KeyExists("masterData"))  && (XVar)(0 < MVCFunctions.count(var_params["masterData"])))
			{
				masterData = XVar.Clone(var_params["masterData"]);
			}
			else
			{
				if(XVar.Pack(var_params.KeyExists("masterTable")))
				{
					masterData = XVar.Clone(button.getMasterData((XVar)(var_params["masterTable"])));
				}
			}
			contextParams = XVar.Clone(XVar.Array());
			if(var_params["location"] == Constants.PAGE_VIEW)
			{
				contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
				contextParams.InitAndSetArrayItem(masterData, "masterData");
			}
			else
			{
				if(var_params["location"] == Constants.PAGE_EDIT)
				{
					contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
					contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
					contextParams.InitAndSetArrayItem(masterData, "masterData");
				}
				else
				{
					if(var_params["location"] == "grid")
					{
						var_params.InitAndSetArrayItem("list", "location");
						contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
						contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
					else
					{
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
				}
			}
			RunnerContext.push((XVar)(new RunnerContextItem((XVar)(var_params["location"]), (XVar)(contextParams))));
			
var eventContext = XVar.Array();
eventContext["var_params"] = var_params;
eventContext["result"] = result;
eventContext["keys"] = keys;
eventContext["button"] = button;
GlobalVars.globalEvents.event_Print_PPMP_Button(eventContext);
result = eventContext["result"];

			RunnerContext.pop();
			MVCFunctions.Echo(MVCFunctions.my_json_encode((XVar)(result)));
			button.deleteTempFiles();
			return null;
		}
		public static XVar buttonHandler_PrintProcurementMonitoringReportButton(dynamic _param_params)
		{
			#region pass-by-value parameters
			dynamic var_params = XVar.Clone(_param_params);
			#endregion

			dynamic ajax = null, button = null, contextParams = XVar.Array(), keys = null, masterData = null, result = null;
			result = XVar.Clone(XVar.Array());
			var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("keys")))), "keys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("isManyKeys")), "isManyKeys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("location")), "location");
			button = XVar.Clone(new Button((XVar)(var_params)));
			ajax = XVar.Clone(button);
			keys = XVar.Clone(button.getKeys());
			masterData = new XVar(false);
			if((XVar)(var_params.KeyExists("masterData"))  && (XVar)(0 < MVCFunctions.count(var_params["masterData"])))
			{
				masterData = XVar.Clone(var_params["masterData"]);
			}
			else
			{
				if(XVar.Pack(var_params.KeyExists("masterTable")))
				{
					masterData = XVar.Clone(button.getMasterData((XVar)(var_params["masterTable"])));
				}
			}
			contextParams = XVar.Clone(XVar.Array());
			if(var_params["location"] == Constants.PAGE_VIEW)
			{
				contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
				contextParams.InitAndSetArrayItem(masterData, "masterData");
			}
			else
			{
				if(var_params["location"] == Constants.PAGE_EDIT)
				{
					contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
					contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
					contextParams.InitAndSetArrayItem(masterData, "masterData");
				}
				else
				{
					if(var_params["location"] == "grid")
					{
						var_params.InitAndSetArrayItem("list", "location");
						contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
						contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
					else
					{
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
				}
			}
			RunnerContext.push((XVar)(new RunnerContextItem((XVar)(var_params["location"]), (XVar)(contextParams))));
			
var eventContext = XVar.Array();
eventContext["var_params"] = var_params;
eventContext["result"] = result;
eventContext["keys"] = keys;
eventContext["button"] = button;
GlobalVars.globalEvents.event_PrintProcurementMonitoringReportButton(eventContext);
result = eventContext["result"];

			RunnerContext.pop();
			MVCFunctions.Echo(MVCFunctions.my_json_encode((XVar)(result)));
			button.deleteTempFiles();
			return null;
		}
		public static XVar buttonHandler_PrintAPPReportButton(dynamic _param_params)
		{
			#region pass-by-value parameters
			dynamic var_params = XVar.Clone(_param_params);
			#endregion

			dynamic ajax = null, button = null, contextParams = XVar.Array(), keys = null, masterData = null, result = null;
			result = XVar.Clone(XVar.Array());
			var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("keys")))), "keys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("isManyKeys")), "isManyKeys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("location")), "location");
			button = XVar.Clone(new Button((XVar)(var_params)));
			ajax = XVar.Clone(button);
			keys = XVar.Clone(button.getKeys());
			masterData = new XVar(false);
			if((XVar)(var_params.KeyExists("masterData"))  && (XVar)(0 < MVCFunctions.count(var_params["masterData"])))
			{
				masterData = XVar.Clone(var_params["masterData"]);
			}
			else
			{
				if(XVar.Pack(var_params.KeyExists("masterTable")))
				{
					masterData = XVar.Clone(button.getMasterData((XVar)(var_params["masterTable"])));
				}
			}
			contextParams = XVar.Clone(XVar.Array());
			if(var_params["location"] == Constants.PAGE_VIEW)
			{
				contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
				contextParams.InitAndSetArrayItem(masterData, "masterData");
			}
			else
			{
				if(var_params["location"] == Constants.PAGE_EDIT)
				{
					contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
					contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
					contextParams.InitAndSetArrayItem(masterData, "masterData");
				}
				else
				{
					if(var_params["location"] == "grid")
					{
						var_params.InitAndSetArrayItem("list", "location");
						contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
						contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
					else
					{
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
				}
			}
			RunnerContext.push((XVar)(new RunnerContextItem((XVar)(var_params["location"]), (XVar)(contextParams))));
			
var eventContext = XVar.Array();
eventContext["var_params"] = var_params;
eventContext["result"] = result;
eventContext["keys"] = keys;
eventContext["button"] = button;
GlobalVars.globalEvents.event_PrintAPPReportButton(eventContext);
result = eventContext["result"];

			RunnerContext.pop();
			MVCFunctions.Echo(MVCFunctions.my_json_encode((XVar)(result)));
			button.deleteTempFiles();
			return null;
		}
		public static XVar buttonHandler_New_Button(dynamic _param_params)
		{
			#region pass-by-value parameters
			dynamic var_params = XVar.Clone(_param_params);
			#endregion

			dynamic ajax = null, button = null, contextParams = XVar.Array(), keys = null, masterData = null, result = null;
			result = XVar.Clone(XVar.Array());
			var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("keys")))), "keys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("isManyKeys")), "isManyKeys");
			var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("location")), "location");
			button = XVar.Clone(new Button((XVar)(var_params)));
			ajax = XVar.Clone(button);
			keys = XVar.Clone(button.getKeys());
			masterData = new XVar(false);
			if((XVar)(var_params.KeyExists("masterData"))  && (XVar)(0 < MVCFunctions.count(var_params["masterData"])))
			{
				masterData = XVar.Clone(var_params["masterData"]);
			}
			else
			{
				if(XVar.Pack(var_params.KeyExists("masterTable")))
				{
					masterData = XVar.Clone(button.getMasterData((XVar)(var_params["masterTable"])));
				}
			}
			contextParams = XVar.Clone(XVar.Array());
			if(var_params["location"] == Constants.PAGE_VIEW)
			{
				contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
				contextParams.InitAndSetArrayItem(masterData, "masterData");
			}
			else
			{
				if(var_params["location"] == Constants.PAGE_EDIT)
				{
					contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
					contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
					contextParams.InitAndSetArrayItem(masterData, "masterData");
				}
				else
				{
					if(var_params["location"] == "grid")
					{
						var_params.InitAndSetArrayItem("list", "location");
						contextParams.InitAndSetArrayItem(button.getRecordData(), "data");
						contextParams.InitAndSetArrayItem(var_params["fieldsData"], "newData");
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
					else
					{
						contextParams.InitAndSetArrayItem(masterData, "masterData");
					}
				}
			}
			RunnerContext.push((XVar)(new RunnerContextItem((XVar)(var_params["location"]), (XVar)(contextParams))));
			
var eventContext = XVar.Array();
eventContext["var_params"] = var_params;
eventContext["result"] = result;
eventContext["keys"] = keys;
eventContext["button"] = button;
GlobalVars.globalEvents.event_New_Button(eventContext);
result = eventContext["result"];

			RunnerContext.pop();
			MVCFunctions.Echo(MVCFunctions.my_json_encode((XVar)(result)));
			button.deleteTempFiles();
			return null;
		}
	}
}
