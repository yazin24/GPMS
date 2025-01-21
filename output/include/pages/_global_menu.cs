
		// <global>
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
			public static partial class Options____global____menu
			{
				static public XVar options()
				{
					return new XVar( "welcome", new XVar( "welcomePageSkip", true,
"welcomeItems", new XVar( "logo", new XVar( "menutItem", false ),
"welcome_item", new XVar( "menutItem", true,
"group", false,
"linkType", 0,
"items", null,
"table", "dbo.BACMembers",
"page", "list" ) ) ),
"fields", new XVar( "gridFields", XVar.Array(),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar(  ) ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", XVar.Array(),
"supertop", new XVar( 0, "logo" ),
"grid", new XVar( 0, "welcome_item" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array() ),
"itemForms", new XVar( "logo", "supertop",
"welcome_item", "grid" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "logo", new XVar( 0, "logo" ),
"welcome_item", new XVar( 0, "welcome_item" ) ),
"cellMaps", new XVar(  ) ),
"page", new XVar( "verticalBar", false,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ),
"details_found", new XVar(  ) ),
"hasCustomButtons", false,
"customButtons", XVar.Array(),
"hasNotifications", false,
"menus", XVar.Array(),
"calcTotalsFor", 1 ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "menu",
"type", "menu",
"layoutId", "topbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "empty-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"supertop", new XVar( "modelId", "menu-topbar-menu",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "logo" ) ),
"c2", new XVar( "model", "c2",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "welcome",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c4",
"colspan", 1 ) ),
"section", "" ) ),
"cells", new XVar( "c4", new XVar( "model", "c1",
"items", new XVar( 0, "welcome_item" ),
"font-size", "12px",
"align", "left",
"bold", true,
"underline", false,
"orientation", "vertical" ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "logo", new XVar( "type", "logo" ),
"welcome_item", new XVar( "type", "welcome_item",
"linkUrl", "",
"linkTable", "dbo.BACMembers",
"linkPage", "list",
"linkText", new XVar( "table", "dbo.BACMembers",
"type", 6 ),
"linkIcon", new XVar( "glyph", "camera" ),
"linkComments", new XVar( "text", "BACMembers description",
"type", 0 ),
"background", "#CD853F",
"linkType", 0 ) ),
"dbProps", new XVar(  ),
"version", 14,
"pageWidth", "full",
"menuWidth", "full",
"pageAlign", "left",
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"welcomePageStay", false,
"listTotals", 1 );
				}
			}
		}