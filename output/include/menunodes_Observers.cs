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
		public static XVar GetMenuNodesObservers()
		{
			dynamic menuNode = XVar.Array(), menuNodes = XVar.Array();
			menuNodes = XVar.Clone(XVar.Array());
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("5", "id");
			menuNode.InitAndSetArrayItem("", "name");
			menuNode.InitAndSetArrayItem("mypage.htm", "href");
			menuNode.InitAndSetArrayItem("Leaf", "type");
			menuNode.InitAndSetArrayItem("dbo.Observer", "table");
			menuNode.InitAndSetArrayItem("", "style");
			menuNode.InitAndSetArrayItem("", "params");
			menuNode.InitAndSetArrayItem("0", "parent");
			menuNode.InitAndSetArrayItem("Text", "nameType");
			menuNode.InitAndSetArrayItem("Internal", "linkType");
			menuNode.InitAndSetArrayItem(MVCFunctions.strtolower(new XVar("List")), "pageType");
			menuNode.InitAndSetArrayItem("", "pageId");
			menuNode.InitAndSetArrayItem("None", "openType");
			menuNode.InitAndSetArrayItem("", "icon");
			menuNode.InitAndSetArrayItem("0", "iconType");
			menuNode.InitAndSetArrayItem("1", "iconShow");
			menuNode.InitAndSetArrayItem("", "color");
			menuNode.InitAndSetArrayItem("Observer", "title");
			menuNodes.InitAndSetArrayItem(menuNode, null);
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("6", "id");
			menuNode.InitAndSetArrayItem("", "name");
			menuNode.InitAndSetArrayItem("mypage.htm", "href");
			menuNode.InitAndSetArrayItem("Leaf", "type");
			menuNode.InitAndSetArrayItem("dbo.ObserverInterest", "table");
			menuNode.InitAndSetArrayItem("", "style");
			menuNode.InitAndSetArrayItem("", "params");
			menuNode.InitAndSetArrayItem("0", "parent");
			menuNode.InitAndSetArrayItem("Text", "nameType");
			menuNode.InitAndSetArrayItem("Internal", "linkType");
			menuNode.InitAndSetArrayItem(MVCFunctions.strtolower(new XVar("List")), "pageType");
			menuNode.InitAndSetArrayItem("", "pageId");
			menuNode.InitAndSetArrayItem("None", "openType");
			menuNode.InitAndSetArrayItem("", "icon");
			menuNode.InitAndSetArrayItem("0", "iconType");
			menuNode.InitAndSetArrayItem("1", "iconShow");
			menuNode.InitAndSetArrayItem("", "color");
			menuNode.InitAndSetArrayItem("Observer Interest", "title");
			menuNodes.InitAndSetArrayItem(menuNode, null);
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("7", "id");
			menuNode.InitAndSetArrayItem("", "name");
			menuNode.InitAndSetArrayItem("mypage.htm", "href");
			menuNode.InitAndSetArrayItem("Leaf", "type");
			menuNode.InitAndSetArrayItem("dbo.ObserverReport", "table");
			menuNode.InitAndSetArrayItem("", "style");
			menuNode.InitAndSetArrayItem("", "params");
			menuNode.InitAndSetArrayItem("0", "parent");
			menuNode.InitAndSetArrayItem("Text", "nameType");
			menuNode.InitAndSetArrayItem("Internal", "linkType");
			menuNode.InitAndSetArrayItem(MVCFunctions.strtolower(new XVar("List")), "pageType");
			menuNode.InitAndSetArrayItem("", "pageId");
			menuNode.InitAndSetArrayItem("None", "openType");
			menuNode.InitAndSetArrayItem("", "icon");
			menuNode.InitAndSetArrayItem("0", "iconType");
			menuNode.InitAndSetArrayItem("1", "iconShow");
			menuNode.InitAndSetArrayItem("", "color");
			menuNode.InitAndSetArrayItem("Observer Report", "title");
			menuNodes.InitAndSetArrayItem(menuNode, null);
			GlobalVars.menuNodesCache.InitAndSetArrayItem(menuNodes, "Observers");
			return null;
		}
	}
}
