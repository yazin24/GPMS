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
		public static XVar GetMenuNodesmain()
		{
			dynamic menuNode = XVar.Array(), menuNodes = XVar.Array();
			menuNodes = XVar.Clone(XVar.Array());
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("23", "id");
			menuNode.InitAndSetArrayItem("Procurement Management", "name");
			menuNode.InitAndSetArrayItem("", "href");
			menuNode.InitAndSetArrayItem("Group", "type");
			menuNode.InitAndSetArrayItem("", "table");
			menuNode.InitAndSetArrayItem("", "style");
			menuNode.InitAndSetArrayItem("", "params");
			menuNode.InitAndSetArrayItem("0", "parent");
			menuNode.InitAndSetArrayItem("Text", "nameType");
			menuNode.InitAndSetArrayItem("None", "linkType");
			menuNode.InitAndSetArrayItem(MVCFunctions.strtolower(new XVar("")), "pageType");
			menuNode.InitAndSetArrayItem("", "pageId");
			menuNode.InitAndSetArrayItem("None", "openType");
			menuNode.InitAndSetArrayItem("", "icon");
			menuNode.InitAndSetArrayItem("0", "iconType");
			menuNode.InitAndSetArrayItem("1", "iconShow");
			menuNode.InitAndSetArrayItem("", "color");
			menuNode.InitAndSetArrayItem("Procurement Management", "title");
			menuNodes.InitAndSetArrayItem(menuNode, null);
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("28", "id");
			menuNode.InitAndSetArrayItem("Others", "name");
			menuNode.InitAndSetArrayItem("", "href");
			menuNode.InitAndSetArrayItem("Group", "type");
			menuNode.InitAndSetArrayItem("", "table");
			menuNode.InitAndSetArrayItem("", "style");
			menuNode.InitAndSetArrayItem("", "params");
			menuNode.InitAndSetArrayItem("0", "parent");
			menuNode.InitAndSetArrayItem("Text", "nameType");
			menuNode.InitAndSetArrayItem("None", "linkType");
			menuNode.InitAndSetArrayItem(MVCFunctions.strtolower(new XVar("")), "pageType");
			menuNode.InitAndSetArrayItem("", "pageId");
			menuNode.InitAndSetArrayItem("None", "openType");
			menuNode.InitAndSetArrayItem("", "icon");
			menuNode.InitAndSetArrayItem("0", "iconType");
			menuNode.InitAndSetArrayItem("1", "iconShow");
			menuNode.InitAndSetArrayItem("", "color");
			menuNode.InitAndSetArrayItem("Others", "title");
			menuNodes.InitAndSetArrayItem(menuNode, null);
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("29", "id");
			menuNode.InitAndSetArrayItem("", "name");
			menuNode.InitAndSetArrayItem("mypage.htm", "href");
			menuNode.InitAndSetArrayItem("Leaf", "type");
			menuNode.InitAndSetArrayItem("dbo.BACMembers", "table");
			menuNode.InitAndSetArrayItem("", "style");
			menuNode.InitAndSetArrayItem("", "params");
			menuNode.InitAndSetArrayItem("0", "parent");
			menuNode.InitAndSetArrayItem("Text", "nameType");
			menuNode.InitAndSetArrayItem("Internal", "linkType");
			menuNode.InitAndSetArrayItem(MVCFunctions.strtolower(new XVar("List")), "pageType");
			menuNode.InitAndSetArrayItem("", "pageId");
			menuNode.InitAndSetArrayItem("None", "openType");
			menuNode.InitAndSetArrayItem("glyphicon-camera", "icon");
			menuNode.InitAndSetArrayItem("2", "iconType");
			menuNode.InitAndSetArrayItem("2", "iconShow");
			menuNode.InitAndSetArrayItem("", "color");
			menuNode.InitAndSetArrayItem("BACMembers", "title");
			menuNodes.InitAndSetArrayItem(menuNode, null);
			GlobalVars.menuNodesCache.InitAndSetArrayItem(menuNodes, "main");
			return null;
		}
	}
}
