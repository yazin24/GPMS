
		// dbo.BidsAndAwardsCommittee(BAC)
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
			public static partial class Options_bidsandawardscommittee_bac__edit
			{
				static public XVar options()
				{
					return new XVar( "details", new XVar( "dbo.BACMembers", new XVar( "displayPreview", 2,
"previewPageId", "" ) ),
"master", new XVar( "dbo.ProcuringEntity", new XVar( "preview", false ),
"dbo.Personnel", new XVar( "preview", false ),
"dbo.TWG", new XVar( "preview", false ) ),
"captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", new XVar( 0, "CreationReason",
1, "ChairpersonId",
2, "ViceChairpersonId",
3, "Location",
4, "MinBacMember",
5, "MaxBacMember",
6, "BacName",
7, "EntityId" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"updateOnEditFields", XVar.Array(),
"fieldItems", new XVar( "CreationReason", new XVar( 0, "integrated_edit_field2",
1, "integrated_edit_field18",
2, "integrated_edit_field19" ),
"ChairpersonId", new XVar( 0, "integrated_edit_field3",
1, "integrated_edit_field12",
2, "integrated_edit_field13" ),
"ViceChairpersonId", new XVar( 0, "integrated_edit_field4",
1, "integrated_edit_field14",
2, "integrated_edit_field15" ),
"Location", new XVar( 0, "integrated_edit_field5",
1, "integrated_edit_field16",
2, "integrated_edit_field17" ),
"MinBacMember", new XVar( 0, "integrated_edit_field6",
1, "integrated_edit_field20",
2, "integrated_edit_field21" ),
"MaxBacMember", new XVar( 0, "integrated_edit_field7",
1, "integrated_edit_field22",
2, "integrated_edit_field23" ),
"BacName", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field10",
2, "integrated_edit_field11" ),
"EntityId", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field8",
2, "integrated_edit_field9" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", XVar.Array(),
"below-grid", new XVar( 0, "edit_save",
1, "edit_back_list",
2, "edit_close" ),
"supertop", new XVar( 0, "expand_menu_button",
1, "collapse_button" ),
"left", new XVar( 0, "logo",
1, "expand_button",
2, "menu" ),
"top", XVar.Array(),
"grid", new XVar( 0, "tabs" ),
"section", new XVar( 0, "integrated_edit_field8",
1, "integrated_edit_field",
2, "integrated_edit_field9",
3, "integrated_edit_field10",
4, "integrated_edit_field1",
5, "integrated_edit_field11",
6, "integrated_edit_field12",
7, "integrated_edit_field3",
8, "integrated_edit_field13",
9, "integrated_edit_field14",
10, "integrated_edit_field4",
11, "integrated_edit_field15",
12, "integrated_edit_field16",
13, "integrated_edit_field5",
14, "integrated_edit_field17",
15, "integrated_edit_field18",
16, "integrated_edit_field2",
17, "integrated_edit_field19",
18, "integrated_edit_field20",
19, "integrated_edit_field6",
20, "integrated_edit_field21",
21, "integrated_edit_field22",
22, "integrated_edit_field7",
23, "integrated_edit_field23" ) ),
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
"logo", "left",
"expand_button", "left",
"menu", "left",
"tabs", "grid",
"integrated_edit_field8", "section",
"integrated_edit_field", "section",
"integrated_edit_field9", "section",
"integrated_edit_field10", "section",
"integrated_edit_field1", "section",
"integrated_edit_field11", "section",
"integrated_edit_field12", "section",
"integrated_edit_field3", "section",
"integrated_edit_field13", "section",
"integrated_edit_field14", "section",
"integrated_edit_field4", "section",
"integrated_edit_field15", "section",
"integrated_edit_field16", "section",
"integrated_edit_field5", "section",
"integrated_edit_field17", "section",
"integrated_edit_field18", "section",
"integrated_edit_field2", "section",
"integrated_edit_field19", "section",
"integrated_edit_field20", "section",
"integrated_edit_field6", "section",
"integrated_edit_field21", "section",
"integrated_edit_field22", "section",
"integrated_edit_field7", "section",
"integrated_edit_field23", "section" ),
"itemLocations", new XVar( "tabs", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field8", new XVar( "location", "section",
"cellId", "c4" ),
"integrated_edit_field", new XVar( "location", "section",
"cellId", "c2" ),
"integrated_edit_field9", new XVar( "location", "section",
"cellId", "c" ),
"integrated_edit_field10", new XVar( "location", "section",
"cellId", "c5" ),
"integrated_edit_field1", new XVar( "location", "section",
"cellId", "c3" ),
"integrated_edit_field11", new XVar( "location", "section",
"cellId", "c6" ),
"integrated_edit_field12", new XVar( "location", "section",
"cellId", "c7" ),
"integrated_edit_field3", new XVar( "location", "section",
"cellId", "c8" ),
"integrated_edit_field13", new XVar( "location", "section",
"cellId", "c9" ),
"integrated_edit_field14", new XVar( "location", "section",
"cellId", "c10" ),
"integrated_edit_field4", new XVar( "location", "section",
"cellId", "c11" ),
"integrated_edit_field15", new XVar( "location", "section",
"cellId", "c12" ),
"integrated_edit_field16", new XVar( "location", "section",
"cellId", "c13" ),
"integrated_edit_field5", new XVar( "location", "section",
"cellId", "c14" ),
"integrated_edit_field17", new XVar( "location", "section",
"cellId", "c15" ),
"integrated_edit_field18", new XVar( "location", "section",
"cellId", "c16" ),
"integrated_edit_field2", new XVar( "location", "section",
"cellId", "c17" ),
"integrated_edit_field19", new XVar( "location", "section",
"cellId", "c18" ),
"integrated_edit_field20", new XVar( "location", "section",
"cellId", "c19" ),
"integrated_edit_field6", new XVar( "location", "section",
"cellId", "c20" ),
"integrated_edit_field21", new XVar( "location", "section",
"cellId", "c21" ),
"integrated_edit_field22", new XVar( "location", "section",
"cellId", "c22" ),
"integrated_edit_field7", new XVar( "location", "section",
"cellId", "c23" ),
"integrated_edit_field23", new XVar( "location", "section",
"cellId", "c24" ) ),
"itemVisiblity", new XVar( "expand_menu_button", 2,
"expand_button", 5 ) ),
"itemsByType", new XVar( "edit_save", new XVar( 0, "edit_save" ),
"edit_back_list", new XVar( 0, "edit_back_list" ),
"edit_close", new XVar( 0, "edit_close" ),
"edit_field", new XVar( 0, "integrated_edit_field2",
1, "integrated_edit_field3",
2, "integrated_edit_field4",
3, "integrated_edit_field5",
4, "integrated_edit_field6",
5, "integrated_edit_field7",
6, "integrated_edit_field1",
7, "integrated_edit_field" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"expand_menu_button", new XVar( 0, "expand_menu_button" ),
"collapse_button", new XVar( 0, "collapse_button" ),
"tabs", new XVar( 0, "tabs" ),
"edit_field_label", new XVar( 0, "integrated_edit_field8",
1, "integrated_edit_field10",
2, "integrated_edit_field12",
3, "integrated_edit_field14",
4, "integrated_edit_field16",
5, "integrated_edit_field18",
6, "integrated_edit_field20",
7, "integrated_edit_field22" ),
"edit_field_tooltip", new XVar( 0, "integrated_edit_field9",
1, "integrated_edit_field11",
2, "integrated_edit_field13",
3, "integrated_edit_field15",
4, "integrated_edit_field17",
5, "integrated_edit_field19",
6, "integrated_edit_field21",
7, "integrated_edit_field23" ),
"expand_button", new XVar( 0, "expand_button" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "tabs" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ),
"section", new XVar( "cells", new XVar( "c4", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "EntityId_fieldblock" ),
"items", new XVar( 0, "integrated_edit_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"c2", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field9" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c5", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "BacName_fieldblock" ),
"items", new XVar( 0, "integrated_edit_field10" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"c3", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field1" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c6", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field11" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c7", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", new XVar( 0, "ChairpersonId_fieldblock" ),
"items", new XVar( 0, "integrated_edit_field12" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"c8", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field3" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c9", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field13" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c10", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 3 ),
"tags", new XVar( 0, "ViceChairpersonId_fieldblock" ),
"items", new XVar( 0, "integrated_edit_field14" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"c11", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field4" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c12", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field15" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c13", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 4 ),
"tags", new XVar( 0, "Location_fieldblock" ),
"items", new XVar( 0, "integrated_edit_field16" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"c14", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 4 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field5" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c15", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 4 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field17" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c16", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 5 ),
"tags", new XVar( 0, "CreationReason_fieldblock" ),
"items", new XVar( 0, "integrated_edit_field18" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"c17", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 5 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field2" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c18", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 5 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field19" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c19", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 6 ),
"tags", new XVar( 0, "MinBacMember_fieldblock" ),
"items", new XVar( 0, "integrated_edit_field20" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"c20", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 6 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field6" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c21", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 6 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field21" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c22", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 7 ),
"tags", new XVar( 0, "MaxBacMember_fieldblock" ),
"items", new XVar( 0, "integrated_edit_field22" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"c23", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 7 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field7" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c24", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 7 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field23" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 3,
"height", 8 ) ) ),
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
"breadcrumb", false,
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
2, "edit_close" ),
"padding", new XVar( "top", "10px" ),
"font-size", "9px",
"bold", true ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"supertop", new XVar( "modelId", "leftbar-top-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "expand_menu_button",
1, "collapse_button" ) ),
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
"left", "50px" ),
"font-size", "15px" ) ),
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
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c4" ),
1, new XVar( "cell", "c2" ),
2, new XVar( "cell", "c" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c5" ),
1, new XVar( "cell", "c3" ),
2, new XVar( "cell", "c6" ) ),
"section", "" ),
2, new XVar( "cells", new XVar( 0, new XVar( "cell", "c7" ),
1, new XVar( "cell", "c8" ),
2, new XVar( "cell", "c9" ) ),
"section", "" ),
3, new XVar( "cells", new XVar( 0, new XVar( "cell", "c10" ),
1, new XVar( "cell", "c11" ),
2, new XVar( "cell", "c12" ) ),
"section", "" ),
4, new XVar( "cells", new XVar( 0, new XVar( "cell", "c13" ),
1, new XVar( "cell", "c14" ),
2, new XVar( "cell", "c15" ) ),
"section", "" ),
5, new XVar( "cells", new XVar( 0, new XVar( "cell", "c16" ),
1, new XVar( "cell", "c17" ),
2, new XVar( "cell", "c18" ) ),
"section", "" ),
6, new XVar( "cells", new XVar( 0, new XVar( "cell", "c19" ),
1, new XVar( "cell", "c20" ),
2, new XVar( "cell", "c21" ) ),
"section", "" ),
7, new XVar( "cells", new XVar( 0, new XVar( "cell", "c22" ),
1, new XVar( "cell", "c23" ),
2, new XVar( "cell", "c24" ) ),
"section", "" ) ),
"cells", new XVar( "c4", new XVar( "model", "c4",
"items", new XVar( 0, "integrated_edit_field8" ),
"field", "EntityId",
"padding", new XVar( "top", "30px" ),
"align", "left" ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field" ),
"field", "EntityId",
"padding", new XVar( "top", "30px" ),
"align", "left" ),
"c", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field9" ),
"field", "EntityId",
"padding", new XVar( "top", "30px" ),
"align", "left" ),
"c5", new XVar( "model", "c4",
"items", new XVar( 0, "integrated_edit_field10" ),
"field", "BacName",
"align", "left" ),
"c3", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field1" ),
"field", "BacName",
"align", "left" ),
"c6", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field11" ),
"field", "BacName",
"align", "left" ),
"c7", new XVar( "model", "c4",
"items", new XVar( 0, "integrated_edit_field12" ),
"field", "ChairpersonId",
"align", "left" ),
"c8", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field3" ),
"field", "ChairpersonId",
"align", "left" ),
"c9", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field13" ),
"field", "ChairpersonId",
"align", "left" ),
"c10", new XVar( "model", "c4",
"items", new XVar( 0, "integrated_edit_field14" ),
"field", "ViceChairpersonId",
"align", "left" ),
"c11", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field4" ),
"field", "ViceChairpersonId",
"align", "left" ),
"c12", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field15" ),
"field", "ViceChairpersonId",
"align", "left" ),
"c13", new XVar( "model", "c4",
"items", new XVar( 0, "integrated_edit_field16" ),
"field", "Location",
"align", "left" ),
"c14", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field5" ),
"field", "Location",
"align", "left" ),
"c15", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field17" ),
"field", "Location",
"align", "left" ),
"c16", new XVar( "model", "c4",
"items", new XVar( 0, "integrated_edit_field18" ),
"field", "CreationReason",
"align", "left" ),
"c17", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field2" ),
"field", "CreationReason",
"align", "left" ),
"c18", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field19" ),
"field", "CreationReason",
"align", "left" ),
"c19", new XVar( "model", "c4",
"items", new XVar( 0, "integrated_edit_field20" ),
"field", "MinBacMember",
"align", "left" ),
"c20", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field6" ),
"field", "MinBacMember",
"align", "left" ),
"c21", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field21" ),
"field", "MinBacMember",
"align", "left" ),
"c22", new XVar( "model", "c4",
"items", new XVar( 0, "integrated_edit_field22" ),
"field", "MaxBacMember",
"align", "left" ),
"c23", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field7" ),
"field", "MaxBacMember",
"align", "left" ),
"c24", new XVar( "model", "c2",
"items", new XVar( 0, "integrated_edit_field23" ),
"field", "MaxBacMember",
"align", "left" ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", true,
"separateLabels", true ) ),
"items", new XVar( "edit_save", new XVar( "type", "edit_save",
"background", "#efb11d",
"font-size", "9px" ),
"edit_back_list", new XVar( "type", "edit_back_list",
"font-size", "9px" ),
"edit_close", new XVar( "type", "edit_close",
"font-size", "9px" ),
"integrated_edit_field2", new XVar( "field", "CreationReason",
"type", "edit_field" ),
"integrated_edit_field3", new XVar( "field", "ChairpersonId",
"type", "edit_field" ),
"integrated_edit_field4", new XVar( "field", "ViceChairpersonId",
"type", "edit_field" ),
"integrated_edit_field5", new XVar( "field", "Location",
"type", "edit_field" ),
"integrated_edit_field6", new XVar( "field", "MinBacMember",
"type", "edit_field",
"label", new XVar( "field", "MinBacMember",
"table", "dbo.BidsAndAwardsCommittee(BAC)",
"type", 3 ),
"updateOnEdit", false ),
"integrated_edit_field7", new XVar( "field", "MaxBacMember",
"type", "edit_field",
"label", new XVar( "field", "MaxBacMember",
"table", "dbo.BidsAndAwardsCommittee(BAC)",
"type", 3 ),
"updateOnEdit", false ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"expand_menu_button", new XVar( "type", "expand_menu_button" ),
"collapse_button", new XVar( "type", "collapse_button" ),
"integrated_edit_field1", new XVar( "field", "BacName",
"type", "edit_field",
"label", new XVar( "field", "BacName",
"table", "dbo.BidsAndAwardsCommittee(BAC)",
"type", 3 ) ),
"integrated_edit_field", new XVar( "field", "EntityId",
"type", "edit_field",
"label", new XVar( "field", "EntityId",
"table", "dbo.BidsAndAwardsCommittee(BAC)",
"type", 3 ) ),
"tabs", new XVar( "type", "tabs",
"titles", new XVar( 0, new XVar( "text", "Edit Details",
"type", 0 ) ),
"locations", new XVar( 0, "section" ),
"bsStyle", "default",
"panelType", 2 ),
"integrated_edit_field8", new XVar( "type", "edit_field_label",
"field", "EntityId" ),
"integrated_edit_field9", new XVar( "type", "edit_field_tooltip",
"field", "EntityId" ),
"integrated_edit_field10", new XVar( "type", "edit_field_label",
"field", "BacName" ),
"integrated_edit_field11", new XVar( "type", "edit_field_tooltip",
"field", "BacName" ),
"integrated_edit_field12", new XVar( "type", "edit_field_label",
"field", "ChairpersonId" ),
"integrated_edit_field13", new XVar( "type", "edit_field_tooltip",
"field", "ChairpersonId" ),
"integrated_edit_field14", new XVar( "type", "edit_field_label",
"field", "ViceChairpersonId" ),
"integrated_edit_field15", new XVar( "type", "edit_field_tooltip",
"field", "ViceChairpersonId" ),
"integrated_edit_field16", new XVar( "type", "edit_field_label",
"field", "Location" ),
"integrated_edit_field17", new XVar( "type", "edit_field_tooltip",
"field", "Location" ),
"integrated_edit_field18", new XVar( "type", "edit_field_label",
"field", "CreationReason" ),
"integrated_edit_field19", new XVar( "type", "edit_field_tooltip",
"field", "CreationReason" ),
"integrated_edit_field20", new XVar( "type", "edit_field_label",
"field", "MinBacMember" ),
"integrated_edit_field21", new XVar( "type", "edit_field_tooltip",
"field", "MinBacMember" ),
"integrated_edit_field22", new XVar( "type", "edit_field_label",
"field", "MaxBacMember" ),
"integrated_edit_field23", new XVar( "type", "edit_field_tooltip",
"field", "MaxBacMember" ),
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