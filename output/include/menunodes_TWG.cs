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
		public static XVar GetMenuNodesTWG()
		{
			dynamic menuNode = XVar.Array(), menuNodes = XVar.Array();
			menuNodes = XVar.Clone(XVar.Array());
			menuNode = XVar.Clone(XVar.Array());
			menuNode.InitAndSetArrayItem("11", "id");
			menuNode.InitAndSetArrayItem("", "name");
			menuNode.InitAndSetArrayItem("mypage.htm", "href");
			menuNode.InitAndSetArrayItem("Leaf", "type");
			menuNode.InitAndSetArrayItem("dbo.TWG", "table");
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
			menuNode.InitAndSetArrayItem("TWG", "title");
			menuNodes.InitAndSetArrayItem(menuNode, null);
			GlobalVars.menuNodesCache.InitAndSetArrayItem(menuNodes, "TWG");
			return null;
		}
	}
}
