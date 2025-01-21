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
	public partial class ListPage_DPDash : ListPage_Dashboard
	{
		public dynamic dpMasterKey = XVar.Array();
		public dynamic showDetails = XVar.Pack(false);
		protected static bool skipListPage_DPDashCtor = false;
		public ListPage_DPDash(dynamic var_params)
			:base((XVar)var_params)
		{
			if(skipListPage_DPDashCtor)
			{
				skipListPage_DPDashCtor = false;
				return;
			}
			dynamic dashDetails = XVar.Array();
			dashDetails = XVar.Clone(this.dashElementData["details"][this.tName]);
			this.showAddInPopup = XVar.Clone(dashDetails["add"]);
			this.showEditInPopup = XVar.Clone(dashDetails["edit"]);
			this.showViewInPopup = XVar.Clone(dashDetails["view"]);
			this.searchClauseObj.clearSearch();
			this.jsSettings.InitAndSetArrayItem(this.masterTable, "tableSettings", this.tName, "masterTable");
			this.jsSettings.InitAndSetArrayItem(this.firstTime, "tableSettings", this.tName, "firstTime");
			this.jsSettings.InitAndSetArrayItem(this.getStrMasterKey(), "tableSettings", this.tName, "strKey");
		}
		public override XVar importLinksAttrs()
		{
			return null;
		}
		public override XVar displayMasterTableInfo()
		{
			return null;
		}
		public override XVar processMasterKeyValue()
		{
			dynamic i = null;
			base.processMasterKeyValue();
			i = new XVar(1);
			for(;i <= MVCFunctions.count(this.masterKeysReq); i++)
			{
				this.dpMasterKey.InitAndSetArrayItem(this.masterKeysReq[i], null);
			}
			return null;
		}
		public virtual XVar getStrMasterKey()
		{
			dynamic i = null, strkey = XVar.Array();
			strkey = XVar.Clone(XVar.Array());
			i = new XVar(0);
			for(;i < MVCFunctions.count(this.dpMasterKey); i++)
			{
				strkey.InitAndSetArrayItem(this.dpMasterKey[i], i);
			}
			return strkey;
		}
		public override XVar buildSearchPanel()
		{
			return null;
		}
		public override XVar assignSimpleSearch()
		{
			return null;
		}
		public override XVar deleteAvailable()
		{
			return (XVar)(RunnerPage.deleteAvailable(this))  && (XVar)(this.dashElementData["details"][this.tName]["delete"]);
		}
		public override XVar editAvailable()
		{
			return (XVar)(RunnerPage.editAvailable(this))  && (XVar)(this.dashElementData["details"][this.tName]["edit"]);
		}
		public override XVar addAvailable()
		{
			return (XVar)(RunnerPage.addAvailable(this))  && (XVar)(this.dashElementData["details"][this.tName]["add"]);
		}
		public override XVar viewAvailable()
		{
			return (XVar)(RunnerPage.viewAvailable(this))  && (XVar)(this.dashElementData["details"][this.tName]["view"]);
		}
		public override XVar inlineEditAvailable()
		{
			return false;
		}
		public override XVar inlineAddAvailable()
		{
			return false;
		}
		public override XVar displayTabsInPage()
		{
			return false;
		}
	}
}
