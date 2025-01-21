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
	public partial class specialconditionsofcontractController : BaseController
	{
		public ActionResult search()
		{
			try
			{
				dynamic accessGranted = null, cname = null, id = null, layoutVersion = null, pageMode = null, pageObject = null, rname = null, templatefile = null, var_params = XVar.Array();
				XTempl xt;
				GlobalVars.init_dbcommon();
				CommonFunctions.add_nocache_headers();
				specialconditionsofcontract_Variables.Apply();
				xt = XVar.UnPackXTempl(new XTempl());
				pageMode = XVar.Clone(SearchPage.readSearchModeFromRequest());
				if(pageMode == Constants.SEARCH_LOAD_CONTROL)
				{
					layoutVersion = XVar.Clone(MVCFunctions.postvalue(new XVar("layoutVersion")));
				}
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(CommonFunctions.postvalue_number(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(pageMode, "mode");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				var_params.InitAndSetArrayItem(Constants.PAGE_SEARCH, "pageType");
				var_params.InitAndSetArrayItem(cname, "chartName");
				var_params.InitAndSetArrayItem(rname, "reportName");
				var_params.InitAndSetArrayItem(templatefile, "templatefile");
				var_params.InitAndSetArrayItem("specialconditionsofcontract", "shortTableName");
				var_params.InitAndSetArrayItem(layoutVersion, "layoutVersion");
				var_params.InitAndSetArrayItem((XVar.Pack(MVCFunctions.postvalue(new XVar("searchControllerId"))) ? XVar.Pack(MVCFunctions.postvalue(new XVar("searchControllerId"))) : XVar.Pack(id)), "searchControllerId");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("ctrlField")), "ctrlField");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("isNeedSettings")), "needSettings");
				if(pageMode == Constants.SEARCH_DASHBOARD)
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("table")), "dashTName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashelement")), "dashElementName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashPage")), "dashPage");
				}
				var_params.InitAndSetArrayItem(SearchPage.getExtraPageParams(), "extraPageParams");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("mastertable")), "masterTable");
				if(XVar.Pack(var_params["masterTable"]))
				{
					var_params.InitAndSetArrayItem(RunnerPage.readMasterKeysFromRequest(), "masterKeysReq");
				}
				GlobalVars.pageObject = XVar.Clone(new SearchPage((XVar)(var_params)));
				if(pageMode == Constants.SEARCH_LOAD_CONTROL)
				{
					GlobalVars.pageObject.displaySearchControl();
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				GlobalVars.pageObject.init();
				GlobalVars.pageObject.process();
				if(pageMode == Constants.SEARCH_DASHBOARD)
				{
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
