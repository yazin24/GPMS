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
	public partial class procurementmonitoringController : BaseController
	{
		public ActionResult view()
		{
			try
			{
				dynamic keys = XVar.Array(), pageMode = null, pageObject = null, var_params = XVar.Array();
				XTempl xt;
				GlobalVars.init_dbcommon();
				procurementmonitoring_Variables.Apply();
				CommonFunctions.add_nocache_headers();
				if(XVar.Pack(Security.hasLogin()))
				{
					if(XVar.Pack(!(XVar)(ViewPage.processEditPageSecurity((XVar)(GlobalVars.strTableName)))))
					{
						return MVCFunctions.GetBuferContentAndClearBufer();
					}
				}
				pageMode = XVar.Clone(ViewPage.readViewModeFromRequest());
				xt = XVar.UnPackXTempl(new XTempl());
				keys = XVar.Clone(XVar.Array());
				keys.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("editid1")), "Id");
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(CommonFunctions.postvalue_number(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(keys, "keys");
				var_params.InitAndSetArrayItem(pageMode, "mode");
				var_params.InitAndSetArrayItem(Constants.PAGE_VIEW, "pageType");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("page")), "pageName");
				var_params.InitAndSetArrayItem(GlobalVars.strTableName, "tName");
				var_params.InitAndSetArrayItem(!XVar.Equals(XVar.Pack(MVCFunctions.postvalue(new XVar("mvcPDF"))), XVar.Pack("")), "pdfMode");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("mastertable")), "masterTable");
				if(XVar.Pack(var_params["masterTable"]))
				{
					var_params.InitAndSetArrayItem(RunnerPage.readMasterKeysFromRequest(), "masterKeysReq");
				}
				if(pageMode == Constants.VIEW_DASHBOARD)
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashelement")), "dashElementName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("table")), "dashTName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashPage")), "dashPage");
					if(XVar.Pack(MVCFunctions.postvalue(new XVar("mapRefresh"))))
					{
						var_params.InitAndSetArrayItem(true, "mapRefresh");
						var_params.InitAndSetArrayItem(MVCFunctions.my_json_decode((XVar)(MVCFunctions.postvalue(new XVar("vpCoordinates")))), "vpCoordinates");
					}
				}
				if(pageMode == Constants.VIEW_POPUP)
				{
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashelement")), "dashElementName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashTName")), "dashTName");
					var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("dashPage")), "dashPage");
				}
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("pdfBackgroundImage")), "pdfBackgroundImage");
				GlobalVars.pageObject = XVar.Clone(new ViewPage((XVar)(var_params)));
				GlobalVars.pageObject.init();
				GlobalVars.pageObject.process();
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
