
		// dbo.TWG
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
			public static partial class Options_twg_edit
			{
				static public XVar options()
				{
					return new XVar( "details", new XVar( "dbo.TWGExpertise", new XVar( "displayPreview", 2,
"previewPageId", "" ) ),
"master", new XVar( "dbo.BidsAndAwardsCommittee", new XVar( "preview", false ) ),
"captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", new XVar( 0, "TWGType",
1, "BacId",
2, "EndUserRepresentative",
3, "CreationDate",
4, "ModificationDate",
5, "TWGName" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"updateOnEditFields", XVar.Array(),
"fieldItems", new XVar( "TWGType", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field8",
2, "integrated_edit_field9" ),
"BacId", new XVar( 0, "integrated_edit_field2",
1, "integrated_edit_field6",
2, "integrated_edit_field7" ),
"EndUserRepresentative", new XVar( 0, "integrated_edit_field3",
1, "integrated_edit_field12",
2, "integrated_edit_field13" ),
"CreationDate", new XVar( 0, "integrated_edit_field4",
1, "integrated_edit_field14",
2, "integrated_edit_field15" ),
"ModificationDate", new XVar( 0, "integrated_edit_field5",
1, "integrated_edit_field16",
2, "integrated_edit_field17" ),
"TWGName", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field10",
2, "integrated_edit_field11" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", XVar.Array(),
"below-grid", new XVar( 0, "edit_save",
1, "edit_back_list",
2, "edit_close" ),
"supertop", new XVar( 0, "expand_menu_button",
1, "collapse_button",
2, "breadcrumb" ),
"left", new XVar( 0, "logo",
1, "expand_button",
2, "menu" ),
"top", XVar.Array(),
"grid", new XVar( 0, "tabs" ),
"section", new XVar( 0, "integrated_edit_field6",
1, "integrated_edit_field2",
2, "integrated_edit_field7",
3, "integrated_edit_field8",
4, "integrated_edit_field1",
5, "integrated_edit_field9",
6, "integrated_edit_field10",
7, "integrated_edit_field",
8, "integrated_edit_field11",
9, "integrated_edit_field12",
10, "integrated_edit_field3",
11, "integrated_edit_field13",
12, "integrated_edit_field14",
13, "integrated_edit_field4",
14, "integrated_edit_field15",
15, "integrated_edit_field16",
16, "integrated_edit_field5",
17, "integrated_edit_field17" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array(),
"below-grid", new XVar( 0, "save_edit",
1, "back_button",
2, "close_button" ),
"top", XVar.Array() ),
"itemForms", new XVar( "edit_save", "below-grid",
"edit_back_list", "below-grid",
"edit_close", "below-grid",
"expand_menu_button", "supertop",
"collapse_button", "supertop",
"breadcrumb", "supertop",
"logo", "left",
"expand_button", "left",
"menu", "left",
"tabs", "grid",
"integrated_edit_field6", "section",
"integrated_edit_field2", "section",
"integrated_edit_field7", "section",
"integrated_edit_field8", "section",
"integrated_edit_field1", "section",
"integrated_edit_field9", "section",
"integrated_edit_field10", "section",
"integrated_edit_field", "section",
"integrated_edit_field11", "section",
"integrated_edit_field12", "section",
"integrated_edit_field3", "section",
"integrated_edit_field13", "section",
"integrated_edit_field14", "section",
"integrated_edit_field4", "section",
"integrated_edit_field15", "section",
"integrated_edit_field16", "section",
"integrated_edit_field5", "section",
"integrated_edit_field17", "section" ),
"itemLocations", new XVar( "tabs", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field6", new XVar( "location", "section",
"cellId", "c1" ),
"integrated_edit_field2", new XVar( "location", "section",
"cellId", "c1" ),
"integrated_edit_field7", new XVar( "location", "section",
"cellId", "c1" ),
"integrated_edit_field8", new XVar( "location", "section",
"cellId", "c" ),
"integrated_edit_field1", new XVar( "location", "section",
"cellId", "c" ),
"integrated_edit_field9", new XVar( "location", "section",
"cellId", "c" ),
"integrated_edit_field10", new XVar( "location", "section",
"cellId", "c2" ),
"integrated_edit_field", new XVar( "location", "section",
"cellId", "c2" ),
"integrated_edit_field11", new XVar( "location", "section",
"cellId", "c2" ),
"integrated_edit_field12", new XVar( "location", "section",
"cellId", "c3" ),
"integrated_edit_field3", new XVar( "location", "section",
"cellId", "c3" ),
"integrated_edit_field13", new XVar( "location", "section",
"cellId", "c3" ),
"integrated_edit_field14", new XVar( "location", "section",
"cellId", "c4" ),
"integrated_edit_field4", new XVar( "location", "section",
"cellId", "c4" ),
"integrated_edit_field15", new XVar( "location", "section",
"cellId", "c4" ),
"integrated_edit_field16", new XVar( "location", "section",
"cellId", "c5" ),
"integrated_edit_field5", new XVar( "location", "section",
"cellId", "c5" ),
"integrated_edit_field17", new XVar( "location", "section",
"cellId", "c5" ) ),
"itemVisiblity", new XVar( "expand_menu_button", 2,
"breadcrumb", 5,
"expand_button", 5 ) ),
"itemsByType", new XVar( "edit_save", new XVar( 0, "edit_save" ),
"edit_back_list", new XVar( 0, "edit_back_list" ),
"edit_close", new XVar( 0, "edit_close" ),
"edit_field", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field3",
3, "integrated_edit_field4",
4, "integrated_edit_field5",
5, "integrated_edit_field" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"expand_menu_button", new XVar( 0, "expand_menu_button" ),
"collapse_button", new XVar( 0, "collapse_button" ),
"tabs", new XVar( 0, "tabs" ),
"edit_field_label", new XVar( 0, "integrated_edit_field6",
1, "integrated_edit_field8",
2, "integrated_edit_field10",
3, "integrated_edit_field12",
4, "integrated_edit_field14",
5, "integrated_edit_field16" ),
"edit_field_tooltip", new XVar( 0, "integrated_edit_field7",
1, "integrated_edit_field9",
2, "integrated_edit_field11",
3, "integrated_edit_field13",
4, "integrated_edit_field15",
5, "integrated_edit_field17" ),
"breadcrumb", new XVar( 0, "breadcrumb" ),
"expand_button", new XVar( 0, "expand_button" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "tabs" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ),
"section", new XVar( "cells", new XVar( "c1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field6",
1, "integrated_edit_field2",
2, "integrated_edit_field7" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field8",
1, "integrated_edit_field1",
2, "integrated_edit_field9" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c2", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field10",
1, "integrated_edit_field",
2, "integrated_edit_field11" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field12",
1, "integrated_edit_field3",
2, "integrated_edit_field13" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c4", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 4 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field14",
1, "integrated_edit_field4",
2, "integrated_edit_field15" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c5", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 5 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field16",
1, "integrated_edit_field5",
2, "integrated_edit_field17" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 6 ) ) ),
"page", new XVar( "verticalBar", true,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ),
"details_found", new XVar(  ) ),
"hasCustomButtons", false,
"customButtons", XVar.Array(),
"hasNotifications", false,
"menus", new XVar( 0, new XVar( "id", "main",
"horizontal", false ) ),
"calcTotalsFor", 1 ),
"misc", new XVar( "type", "edit",
"breadcrumb", true,
"nextPrev", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"edit", new XVar( "updateSelected", false ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "edit",
"type", "edit",
"layoutId", "leftbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "edit-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "edit-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1",
"colspan", 1 ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "edit_save",
1, "edit_back_list",
2, "edit_close" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"supertop", new XVar( "modelId", "leftbar-top-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "expand_menu_button",
1, "collapse_button",
2, "breadcrumb" ) ),
"c2", new XVar( "model", "c2",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"left", new XVar( "modelId", "leftbar-menu",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c0" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c0", new XVar( "model", "c0",
"items", new XVar( 0, "logo",
1, "expand_button" ) ),
"c1", new XVar( "model", "c1",
"items", new XVar( 0, "menu" ),
"bold", true ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "edit-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array(),
"padding", new XVar( "top", "15px",
"bottom", "75px",
"left", "50px" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3",
"colspan", 1 ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "tabs" ),
"padding", new XVar( "left", "35px" ),
"font-size", "12px" ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ),
"section", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c" ) ),
"section", "" ),
2, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ),
3, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ),
4, new XVar( "cells", new XVar( 0, new XVar( "cell", "c4" ) ),
"section", "" ),
5, new XVar( "cells", new XVar( 0, new XVar( "cell", "c5" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field6",
1, "integrated_edit_field2",
2, "integrated_edit_field7" ),
"field", "BacId" ),
"c", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field8",
1, "integrated_edit_field1",
2, "integrated_edit_field9" ),
"field", "TWGType" ),
"c2", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field10",
1, "integrated_edit_field",
2, "integrated_edit_field11" ),
"field", "TWGName" ),
"c3", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field12",
1, "integrated_edit_field3",
2, "integrated_edit_field13" ),
"field", "EndUserRepresentative" ),
"c4", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field14",
1, "integrated_edit_field4",
2, "integrated_edit_field15" ),
"field", "CreationDate" ),
"c5", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field16",
1, "integrated_edit_field5",
2, "integrated_edit_field17" ),
"field", "ModificationDate" ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", true ) ),
"items", new XVar( "edit_save", new XVar( "type", "edit_save",
"background", "#efb11d" ),
"edit_back_list", new XVar( "type", "edit_back_list" ),
"edit_close", new XVar( "type", "edit_close" ),
"integrated_edit_field1", new XVar( "field", "TWGType",
"type", "edit_field" ),
"integrated_edit_field2", new XVar( "field", "BacId",
"type", "edit_field",
"label", new XVar( "field", "BacId",
"table", "dbo.TWG",
"type", 3 ) ),
"integrated_edit_field3", new XVar( "field", "EndUserRepresentative",
"type", "edit_field" ),
"integrated_edit_field4", new XVar( "field", "CreationDate",
"type", "edit_field",
"updateOnEdit", false ),
"integrated_edit_field5", new XVar( "field", "ModificationDate",
"type", "edit_field" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"expand_menu_button", new XVar( "type", "expand_menu_button" ),
"collapse_button", new XVar( "type", "collapse_button" ),
"integrated_edit_field", new XVar( "field", "TWGName",
"type", "edit_field",
"updateOnEdit", false ),
"tabs", new XVar( "type", "tabs",
"titles", new XVar( 0, new XVar( "text", "Edit Record",
"type", 0 ) ),
"locations", new XVar( 0, "section" ),
"bsStyle", "default",
"panelType", 2 ),
"integrated_edit_field6", new XVar( "type", "edit_field_label",
"field", "BacId" ),
"integrated_edit_field7", new XVar( "type", "edit_field_tooltip",
"field", "BacId" ),
"integrated_edit_field8", new XVar( "type", "edit_field_label",
"field", "TWGType" ),
"integrated_edit_field9", new XVar( "type", "edit_field_tooltip",
"field", "TWGType" ),
"integrated_edit_field10", new XVar( "type", "edit_field_label",
"field", "TWGName" ),
"integrated_edit_field11", new XVar( "type", "edit_field_tooltip",
"field", "TWGName" ),
"integrated_edit_field12", new XVar( "type", "edit_field_label",
"field", "EndUserRepresentative" ),
"integrated_edit_field13", new XVar( "type", "edit_field_tooltip",
"field", "EndUserRepresentative" ),
"integrated_edit_field14", new XVar( "type", "edit_field_label",
"field", "CreationDate" ),
"integrated_edit_field15", new XVar( "type", "edit_field_tooltip",
"field", "CreationDate" ),
"integrated_edit_field16", new XVar( "type", "edit_field_label",
"field", "ModificationDate" ),
"integrated_edit_field17", new XVar( "type", "edit_field_tooltip",
"field", "ModificationDate" ),
"breadcrumb", new XVar( "type", "breadcrumb" ),
"expand_button", new XVar( "type", "expand_button" ) ),
"dbProps", new XVar(  ),
"version", 14,
"pageWidth", "full",
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"listTotals", 1 );
				}
			}
		}