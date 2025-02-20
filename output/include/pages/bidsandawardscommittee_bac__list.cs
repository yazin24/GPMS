
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
			public static partial class Options_bidsandawardscommittee_bac__list
			{
				static public XVar options()
				{
					return new XVar( "list", new XVar( "inlineAdd", false,
"detailsAdd", true,
"inlineEdit", false,
"spreadsheetMode", false,
"addToBottom", false,
"delete", true,
"updateSelected", false,
"addInPopup", false,
"editInPopup", false,
"viewInPopup", false,
"clickSort", true,
"sortDropdown", false,
"showHideFields", false,
"reorderFields", false,
"fieldFilter", false,
"hideNumberOfRecords", false ),
"allDetails", new XVar( "linkType", 2 ),
"details", new XVar( "dbo.BACMembers", new XVar( "displayPreview", 2,
"previewPageId", "",
"showCount", false,
"badgeColor", "",
"hideEmptyChild", false,
"hideEmptyPreview", null,
"showProceedLink", null,
"printDetails", false ) ),
"master", new XVar( "dbo.ProcuringEntity", new XVar( "preview", false ),
"dbo.Personnel", new XVar( "preview", false ),
"dbo.TWG", new XVar( "preview", false ) ),
"listSearch", new XVar( "alwaysOnPanelFields", XVar.Array(),
"searchPanel", false,
"fixedSearchPanel", false,
"simpleSearchOptions", false,
"searchSaving", false ),
"totals", new XVar( "BacId", new XVar( "totalsType", "" ),
"EntityId", new XVar( "totalsType", "" ),
"BacName", new XVar( "totalsType", "" ),
"CreationReason", new XVar( "totalsType", "" ),
"ChairpersonId", new XVar( "totalsType", "" ),
"ViceChairpersonId", new XVar( "totalsType", "" ),
"Location", new XVar( "totalsType", "" ),
"MinBacMember", new XVar( "totalsType", "" ),
"MaxBacMember", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "BacName",
1, "ChairpersonId",
2, "ViceChairpersonId",
3, "MinBacMember",
4, "MaxBacMember" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"filterFields", XVar.Array(),
"inlineAddFields", XVar.Array(),
"inlineEditFields", XVar.Array(),
"fieldItems", new XVar( "BacName", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field" ),
"ChairpersonId", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field10" ),
"MinBacMember", new XVar( 0, "simple_grid_field7",
1, "simple_grid_field13" ),
"MaxBacMember", new XVar( 0, "simple_grid_field8",
1, "simple_grid_field14" ),
"ViceChairpersonId", new XVar( 0, "grid_field",
1, "grid_field_label" ) ),
"hideEmptyFields", XVar.Array(),
"fieldFilterFields", XVar.Array() ),
"pageLinks", new XVar( "edit", true,
"add", true,
"view", true,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "add",
1, "inline_add",
2, "delete",
3, "details_found" ),
"below-grid", new XVar( 0, "pagination" ),
"left", new XVar( 0, "logo",
1, "expand_button",
2, "menu" ),
"supertop", new XVar( 0, "expand_menu_button",
1, "collapse_button",
2, "breadcrumb",
3, "simple_search",
4, "list_options" ),
"grid", new XVar( 0, "simple_grid_field",
1, "simple_grid_field2",
2, "simple_grid_field10",
3, "simple_grid_field4",
4, "grid_field_label",
5, "grid_field",
6, "simple_grid_field13",
7, "simple_grid_field7",
8, "simple_grid_field14",
9, "simple_grid_field8",
10, "grid_checkbox_head",
11, "grid_edit",
12, "grid_view",
13, "grid_checkbox",
14, "grid_inline_cancel" ),
"top", XVar.Array() ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "add_link",
1, "inlineadd_link",
2, "deleteselected_link",
3, "details_found" ),
"below-grid", new XVar( 0, "pagination" ),
"top", XVar.Array() ),
"itemForms", new XVar( "add", "above-grid",
"inline_add", "above-grid",
"delete", "above-grid",
"details_found", "above-grid",
"pagination", "below-grid",
"logo", "left",
"expand_button", "left",
"menu", "left",
"expand_menu_button", "supertop",
"collapse_button", "supertop",
"breadcrumb", "supertop",
"simple_search", "supertop",
"list_options", "supertop",
"simple_grid_field", "grid",
"simple_grid_field2", "grid",
"simple_grid_field10", "grid",
"simple_grid_field4", "grid",
"grid_field_label", "grid",
"grid_field", "grid",
"simple_grid_field13", "grid",
"simple_grid_field7", "grid",
"simple_grid_field14", "grid",
"simple_grid_field8", "grid",
"grid_checkbox_head", "grid",
"grid_edit", "grid",
"grid_view", "grid",
"grid_checkbox", "grid",
"grid_inline_cancel", "grid" ),
"itemLocations", new XVar( "simple_grid_field", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field10", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"grid_field_label", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"grid_field", new XVar( "location", "grid",
"cellId", "cell_field4" ),
"simple_grid_field13", new XVar( "location", "grid",
"cellId", "headcell_field5" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "cell_field5" ),
"simple_grid_field14", new XVar( "location", "grid",
"cellId", "headcell_field6" ),
"simple_grid_field8", new XVar( "location", "grid",
"cellId", "cell_field6" ),
"grid_checkbox_head", new XVar( "location", "grid",
"cellId", "headcell_field7" ),
"grid_edit", new XVar( "location", "grid",
"cellId", "headcell_field8" ),
"grid_view", new XVar( "location", "grid",
"cellId", "headcell_field8" ),
"grid_checkbox", new XVar( "location", "grid",
"cellId", "headcell_field8" ),
"grid_inline_cancel", new XVar( "location", "grid",
"cellId", "cell_icons" ) ),
"itemVisiblity", new XVar( "breadcrumb", 5,
"expand_menu_button", 2,
"expand_button", 5 ) ),
"itemsByType", new XVar( "breadcrumb", new XVar( 0, "breadcrumb" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"simple_search", new XVar( 0, "simple_search" ),
"pagination", new XVar( 0, "pagination" ),
"grid_checkbox", new XVar( 0, "grid_checkbox" ),
"grid_checkbox_head", new XVar( 0, "grid_checkbox_head" ),
"details_found", new XVar( 0, "details_found" ),
"list_options", new XVar( 0, "list_options" ),
"show_search_panel", new XVar( 0, "show_search_panel" ),
"hide_search_panel", new XVar( 0, "hide_search_panel" ),
"expand_menu_button", new XVar( 0, "expand_menu_button" ),
"collapse_button", new XVar( 0, "collapse_button" ),
"add", new XVar( 0, "add" ),
"grid_edit", new XVar( 0, "grid_edit" ),
"-", new XVar( 0, "-",
1, "-1",
2, "-2",
3, "-3" ),
"delete", new XVar( 0, "delete" ),
"delete_selected", new XVar( 0, "delete_selected" ),
"advsearch_link", new XVar( 0, "advsearch_link" ),
"grid_field", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field4",
2, "simple_grid_field7",
3, "simple_grid_field8",
4, "grid_field" ),
"grid_field_label", new XVar( 0, "simple_grid_field",
1, "simple_grid_field10",
2, "simple_grid_field13",
3, "simple_grid_field14",
4, "grid_field_label" ),
"grid_view", new XVar( 0, "grid_view" ),
"expand_button", new XVar( 0, "expand_button" ),
"inline_add", new XVar( 0, "inline_add" ),
"grid_inline_cancel", new XVar( 0, "grid_inline_cancel" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "BacName_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "ChairpersonId_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field10" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "ViceChairpersonId_fieldheadercolumn" ),
"items", new XVar( 0, "grid_field_label" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "MinBacMember_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field13" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field6", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "MaxBacMember_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field14" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field7", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox_head" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "inline_cancel" ),
"items", new XVar( 0, "grid_inline_cancel" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "BacName_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "ChairpersonId_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "ViceChairpersonId_fieldcolumn" ),
"items", new XVar( 0, "grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field5", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "MinBacMember_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field6", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "MaxBacMember_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field8", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "edit_column",
1, "view_column",
2, "checkbox_column" ),
"items", new XVar( 0, "grid_edit",
1, "grid_view",
2, "grid_checkbox" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_icons", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field4", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field5", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field6", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field9", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 7,
"height", 3 ) ) ),
"page", new XVar( "verticalBar", true,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ),
"details_found", new XVar( "details_found", new XVar( "tag", "DISPLAYING",
"type", 2 ) ) ),
"gridType", 0,
"recsPerRow", 1,
"hasCustomButtons", false,
"customButtons", XVar.Array(),
"hasNotifications", false,
"menus", new XVar( 0, new XVar( "id", "main",
"horizontal", false ) ),
"calcTotalsFor", 1 ),
"misc", new XVar( "type", "list",
"breadcrumb", true ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ),
"dataGrid", new XVar( "groupFields", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "list",
"type", "list",
"layoutId", "leftbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "list-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "add",
1, "inline_add",
2, "delete" ) ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "details_found" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "list-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "pagination" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"left", new XVar( "modelId", "leftbar-menu",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c0" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c0", new XVar( "model", "c0",
"items", new XVar( 0, "logo",
1, "expand_button" ),
"bold", true ),
"c1", new XVar( "model", "c1",
"items", new XVar( 0, "menu" ),
"bold", true ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"supertop", new XVar( "modelId", "leftbar-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "expand_menu_button",
1, "collapse_button",
2, "breadcrumb" ) ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "simple_search",
1, "list_options" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "horizontal-grid",
"grid", new XVar( 0, new XVar( "section", "head",
"cells", new XVar( 0, new XVar( "cell", "headcell_icons" ),
1, new XVar( "cell", "headcell_field",
"colspan", 1 ),
2, new XVar( "cell", "headcell_field2",
"colspan", 1 ),
3, new XVar( "cell", "headcell_field4" ),
4, new XVar( "cell", "headcell_field5" ),
5, new XVar( "cell", "headcell_field6" ),
6, new XVar( "cell", "headcell_field7" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_icons" ),
1, new XVar( "cell", "cell_field",
"colspan", 1 ),
2, new XVar( "cell", "cell_field2",
"colspan", 1 ),
3, new XVar( "cell", "cell_field4" ),
4, new XVar( "cell", "cell_field5" ),
5, new XVar( "cell", "cell_field6" ),
6, new XVar( "cell", "headcell_field8" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_icons" ),
1, new XVar( "cell", "footcell_field",
"colspan", 1 ),
2, new XVar( "cell", "footcell_field2",
"colspan", 1 ),
3, new XVar( "cell", "footcell_field4" ),
4, new XVar( "cell", "footcell_field5" ),
5, new XVar( "cell", "footcell_field6" ),
6, new XVar( "cell", "headcell_field9" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field" ),
"align", "left",
"width", "20%",
"font-size", "1.2em",
"field", "BacName",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"align", "left",
"width", "20%",
"field", "BacName",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array(),
"width", "20%" ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field10" ),
"align", "left",
"width", "20%",
"font-size", "1.2em",
"field", "ChairpersonId",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"align", "left",
"width", "20%",
"field", "ChairpersonId",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "grid_field_label" ),
"align", "left",
"width", "20%",
"font-size", "1.2em",
"field", "ViceChairpersonId",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "grid_field" ),
"align", "left",
"width", "20%",
"field", "ViceChairpersonId",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field5", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field13" ),
"align", "left",
"width", "15%",
"font-size", "1.2em",
"field", "MinBacMember",
"columnName", "field" ),
"cell_field5", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"align", "left",
"width", "15%",
"field", "MinBacMember",
"columnName", "field" ),
"footcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array(),
"width", "15%" ),
"headcell_field6", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field14" ),
"align", "left",
"width", "15%",
"font-size", "1.2em",
"field", "MaxBacMember",
"columnName", "field" ),
"cell_field6", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"align", "left",
"width", "15%",
"field", "MaxBacMember",
"columnName", "field" ),
"footcell_field6", new XVar( "model", "footcell_field",
"items", XVar.Array(),
"width", "15%" ),
"headcell_field7", new XVar( "model", "headcell_field",
"items", new XVar( 0, "grid_checkbox_head" ),
"align", "right",
"width", "10%",
"font-size", "1.2em" ),
"headcell_field8", new XVar( "model", "cell_field",
"items", new XVar( 0, "grid_edit",
1, "grid_view",
2, "grid_checkbox" ),
"align", "right",
"width", "10%" ),
"headcell_field9", new XVar( "model", "footcell_field",
"items", XVar.Array(),
"width", "10%" ),
"headcell_icons", new XVar( "model", "headcell_icons",
"items", XVar.Array() ),
"cell_icons", new XVar( "model", "cell_icons",
"items", new XVar( 0, "grid_inline_cancel" ) ),
"footcell_icons", new XVar( "model", "footcell_icons",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "list-sidebar-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c2", new XVar( "model", "c2",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "breadcrumb", new XVar( "type", "breadcrumb" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu",
"menuId", "main" ),
"simple_search", new XVar( "type", "simple_search" ),
"pagination", new XVar( "type", "pagination" ),
"grid_checkbox", new XVar( "type", "grid_checkbox" ),
"grid_checkbox_head", new XVar( "type", "grid_checkbox_head" ),
"details_found", new XVar( "type", "details_found" ),
"list_options", new XVar( "type", "list_options",
"items", new XVar( 0, "delete_selected",
1, "-3",
2, "advsearch_link",
3, "show_search_panel",
4, "hide_search_panel" ) ),
"show_search_panel", new XVar( "type", "show_search_panel" ),
"hide_search_panel", new XVar( "type", "hide_search_panel" ),
"expand_menu_button", new XVar( "type", "expand_menu_button" ),
"collapse_button", new XVar( "type", "collapse_button" ),
"add", new XVar( "type", "add",
"background", "#efb11d",
"popup", false ),
"grid_edit", new XVar( "type", "grid_edit",
"popup", false ),
"-", new XVar( "type", "-" ),
"-1", new XVar( "type", "-" ),
"-2", new XVar( "type", "-" ),
"delete", new XVar( "type", "delete",
"background", "#ba3a3a" ),
"delete_selected", new XVar( "type", "delete_selected" ),
"advsearch_link", new XVar( "type", "advsearch_link" ),
"-3", new XVar( "type", "-" ),
"simple_grid_field2", new XVar( "field", "BacName",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field4", new XVar( "field", "ChairpersonId",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field7", new XVar( "field", "MinBacMember",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field8", new XVar( "field", "MaxBacMember",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"simple_grid_field", new XVar( "type", "grid_field_label",
"field", "BacName",
"clickSort", true ),
"simple_grid_field10", new XVar( "type", "grid_field_label",
"field", "ChairpersonId",
"clickSort", true ),
"simple_grid_field13", new XVar( "type", "grid_field_label",
"field", "MinBacMember",
"clickSort", true ),
"simple_grid_field14", new XVar( "type", "grid_field_label",
"field", "MaxBacMember",
"clickSort", true ),
"grid_view", new XVar( "type", "grid_view",
"popup", false,
"icon", new XVar( "glyph", "eye-open" ) ),
"grid_field", new XVar( "field", "ViceChairpersonId",
"type", "grid_field",
"inlineAdd", false,
"inlineEdit", false ),
"grid_field_label", new XVar( "type", "grid_field_label",
"field", "ViceChairpersonId",
"clickSort", true ),
"expand_button", new XVar( "type", "expand_button" ),
"inline_add", new XVar( "type", "inline_add",
"detailsOnly", true ),
"grid_inline_cancel", new XVar( "type", "grid_inline_cancel" ) ),
"dbProps", new XVar(  ),
"spreadsheetGrid", false,
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