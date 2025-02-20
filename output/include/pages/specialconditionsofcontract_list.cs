
		// dbo.SpecialConditionsOfContract
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
			public static partial class Options_specialconditionsofcontract_list
			{
				static public XVar options()
				{
					return new XVar( "list", new XVar( "inlineAdd", false,
"detailsAdd", true,
"inlineEdit", true,
"spreadsheetMode", false,
"addToBottom", false,
"delete", false,
"updateSelected", false,
"addInPopup", null,
"editInPopup", null,
"viewInPopup", null,
"clickSort", true,
"sortDropdown", false,
"showHideFields", false,
"reorderFields", false,
"fieldFilter", false,
"hideNumberOfRecords", false ),
"master", new XVar( "dbo.PhilippineBiddingDocument", new XVar( "preview", false ) ),
"listSearch", new XVar( "alwaysOnPanelFields", XVar.Array(),
"searchPanel", true,
"fixedSearchPanel", false,
"simpleSearchOptions", false,
"searchSaving", false ),
"totals", new XVar( "Id", new XVar( "totalsType", "" ),
"PbdId", new XVar( "totalsType", "" ),
"MilestoneDescription", new XVar( "totalsType", "" ),
"Deliverable", new XVar( "totalsType", "" ),
"PaymentPercentage", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "MilestoneDescription",
1, "Deliverable",
2, "PaymentPercentage" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", new XVar( 0, "Deliverable",
1, "PbdId",
2, "PaymentPercentage",
3, "MilestoneDescription",
4, "Id" ),
"filterFields", XVar.Array(),
"inlineAddFields", new XVar( 0, "MilestoneDescription",
1, "Deliverable",
2, "PaymentPercentage" ),
"inlineEditFields", new XVar( 0, "MilestoneDescription",
1, "Deliverable",
2, "PaymentPercentage" ),
"fieldItems", new XVar( "MilestoneDescription", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field6" ),
"Deliverable", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field7" ),
"PaymentPercentage", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field8" ) ),
"hideEmptyFields", XVar.Array(),
"fieldFilterFields", XVar.Array() ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", new XVar( 0, "inline_add",
1, "inline_save_all",
2, "inline_cancel_all",
3, "details_found",
4, "page_size" ),
"below-grid", XVar.Array(),
"left", new XVar( 0, "logo",
1, "expand_button",
2, "menu",
3, "search_panel" ),
"supertop", new XVar( 0, "expand_menu_button",
1, "collapse_button",
2, "breadcrumb",
3, "simple_search",
4, "list_options" ),
"grid", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field3",
2, "simple_grid_field7",
3, "simple_grid_field4",
4, "simple_grid_field8",
5, "simple_grid_field5",
6, "grid_checkbox_head",
7, "grid_inline_edit",
8, "grid_inline_save",
9, "grid_inline_cancel",
10, "grid_checkbox" ),
"top", XVar.Array() ),
"formXtTags", new XVar( "above-grid", new XVar( 0, "inlineadd_link",
1, "saveall_link",
2, "cancelall_link",
3, "details_found",
4, "recsPerPage" ),
"below-grid", XVar.Array(),
"top", XVar.Array() ),
"itemForms", new XVar( "inline_add", "above-grid",
"inline_save_all", "above-grid",
"inline_cancel_all", "above-grid",
"details_found", "above-grid",
"page_size", "above-grid",
"logo", "left",
"expand_button", "left",
"menu", "left",
"search_panel", "left",
"expand_menu_button", "supertop",
"collapse_button", "supertop",
"breadcrumb", "supertop",
"simple_search", "supertop",
"list_options", "supertop",
"simple_grid_field6", "grid",
"simple_grid_field3", "grid",
"simple_grid_field7", "grid",
"simple_grid_field4", "grid",
"simple_grid_field8", "grid",
"simple_grid_field5", "grid",
"grid_checkbox_head", "grid",
"grid_inline_edit", "grid",
"grid_inline_save", "grid",
"grid_inline_cancel", "grid",
"grid_checkbox", "grid" ),
"itemLocations", new XVar( "simple_grid_field6", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field8", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"grid_checkbox_head", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"grid_inline_edit", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"grid_inline_save", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"grid_inline_cancel", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"grid_checkbox", new XVar( "location", "grid",
"cellId", "headcell_field4" ) ),
"itemVisiblity", new XVar( "breadcrumb", 5,
"expand_menu_button", 2,
"expand_button", 5 ) ),
"itemsByType", new XVar( "page_size", new XVar( 0, "page_size" ),
"breadcrumb", new XVar( 0, "breadcrumb" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"simple_search", new XVar( 0, "simple_search" ),
"details_found", new XVar( 0, "details_found" ),
"search_panel", new XVar( 0, "search_panel" ),
"list_options", new XVar( 0, "list_options" ),
"show_search_panel", new XVar( 0, "show_search_panel" ),
"hide_search_panel", new XVar( 0, "hide_search_panel" ),
"search_panel_field", new XVar( 0, "search_panel_field",
1, "search_panel_field1",
2, "search_panel_field2",
3, "search_panel_field4",
4, "search_panel_field5" ),
"expand_menu_button", new XVar( 0, "expand_menu_button" ),
"collapse_button", new XVar( 0, "collapse_button" ),
"-", new XVar( 0, "-",
1, "-1",
2, "-2",
3, "-3",
4, "-4" ),
"advsearch_link", new XVar( 0, "advsearch_link" ),
"grid_field", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field4",
2, "simple_grid_field5" ),
"grid_field_label", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field7",
2, "simple_grid_field8" ),
"edit_selected", new XVar( 0, "edit_selected" ),
"grid_inline_edit", new XVar( 0, "grid_inline_edit" ),
"grid_inline_save", new XVar( 0, "grid_inline_save" ),
"grid_inline_cancel", new XVar( 0, "grid_inline_cancel" ),
"grid_checkbox_head", new XVar( 0, "grid_checkbox_head" ),
"grid_checkbox", new XVar( 0, "grid_checkbox" ),
"inline_save_all", new XVar( 0, "inline_save_all" ),
"inline_cancel_all", new XVar( 0, "inline_cancel_all" ),
"expand_button", new XVar( 0, "expand_button" ),
"inline_add", new XVar( 0, "inline_add" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_field1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "MilestoneDescription_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "Deliverable_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "PaymentPercentage_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "checkbox_column" ),
"items", new XVar( 0, "grid_checkbox_head" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "MilestoneDescription_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "Deliverable_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "PaymentPercentage_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "inlineedit_column",
1, "inline_save",
2, "inline_cancel",
3, "checkbox_column" ),
"items", new XVar( 0, "grid_inline_edit",
1, "grid_inline_save",
2, "grid_inline_cancel",
3, "grid_checkbox" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field2", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field3", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 4,
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
"items", new XVar( 0, "inline_add",
1, "inline_save_all",
2, "inline_cancel_all" ) ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "details_found",
1, "page_size" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "list-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array(),
"padding", new XVar( "bottom", "20px" ) ) ),
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
"items", new XVar( 0, "menu",
1, "search_panel" ) ) ),
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
"cells", new XVar( 0, new XVar( "cell", "headcell_field1" ),
1, new XVar( "cell", "headcell_field2" ),
2, new XVar( "cell", "headcell_field3" ),
3, new XVar( "cell", "headcell_field" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_field1" ),
1, new XVar( "cell", "cell_field2" ),
2, new XVar( "cell", "cell_field3" ),
3, new XVar( "cell", "headcell_field4" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_field1" ),
1, new XVar( "cell", "footcell_field2" ),
2, new XVar( "cell", "footcell_field3" ),
3, new XVar( "cell", "headcell_field5" ) ) ) ),
"cells", new XVar( "headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"align", "left",
"width", "25%",
"background", "#ffffff",
"color", "#535353",
"font-size", "10px",
"field", "MilestoneDescription",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"align", "left",
"width", "25%",
"field", "MilestoneDescription",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array(),
"align", "left",
"width", "25%" ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"align", "left",
"width", "25%",
"background", "#ffffff",
"color", "#535353",
"font-size", "10px",
"field", "Deliverable",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"align", "left",
"width", "25%",
"field", "Deliverable",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array(),
"align", "left",
"width", "25%" ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"align", "left",
"width", "25%",
"background", "#ffffff",
"color", "#535353",
"font-size", "10px",
"field", "PaymentPercentage",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"align", "left",
"width", "25%",
"field", "PaymentPercentage",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array(),
"align", "left",
"width", "25%" ),
"headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "grid_checkbox_head" ),
"align", "right",
"width", "25%",
"background", "#ffffff",
"color", "#535353",
"font-size", "10px" ),
"headcell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "grid_inline_edit",
1, "grid_inline_save",
2, "grid_inline_cancel",
3, "grid_checkbox" ),
"align", "right",
"width", "25%" ),
"headcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array(),
"align", "right",
"width", "25%" ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "list-sidebar-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c2", new XVar( "model", "c2",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "page_size", new XVar( "type", "page_size" ),
"breadcrumb", new XVar( "type", "breadcrumb" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"simple_search", new XVar( "type", "simple_search" ),
"details_found", new XVar( "type", "details_found" ),
"search_panel", new XVar( "type", "search_panel",
"items", new XVar( 0, "search_panel_field",
1, "search_panel_field5",
2, "search_panel_field4",
3, "search_panel_field2",
4, "search_panel_field1" ) ),
"list_options", new XVar( "type", "list_options",
"items", new XVar( 0, "edit_selected",
1, "-4",
2, "advsearch_link",
3, "show_search_panel",
4, "hide_search_panel" ) ),
"show_search_panel", new XVar( "type", "show_search_panel" ),
"hide_search_panel", new XVar( "type", "hide_search_panel" ),
"search_panel_field", new XVar( "field", "Deliverable",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field1", new XVar( "field", "Id",
"type", "search_panel_field",
"required", false ),
"search_panel_field2", new XVar( "field", "MilestoneDescription",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field4", new XVar( "field", "PaymentPercentage",
"type", "search_panel_field",
"required", false,
"alwaysOnPanel", false ),
"search_panel_field5", new XVar( "field", "PbdId",
"type", "search_panel_field",
"required", false ),
"expand_menu_button", new XVar( "type", "expand_menu_button" ),
"collapse_button", new XVar( "type", "collapse_button" ),
"-", new XVar( "type", "-" ),
"-1", new XVar( "type", "-" ),
"-2", new XVar( "type", "-" ),
"advsearch_link", new XVar( "type", "advsearch_link" ),
"-3", new XVar( "type", "-" ),
"simple_grid_field3", new XVar( "field", "MilestoneDescription",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field4", new XVar( "field", "Deliverable",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field5", new XVar( "field", "PaymentPercentage",
"type", "grid_field",
"inlineAdd", true,
"inlineEdit", true ),
"simple_grid_field6", new XVar( "type", "grid_field_label",
"field", "MilestoneDescription" ),
"simple_grid_field7", new XVar( "type", "grid_field_label",
"field", "Deliverable" ),
"simple_grid_field8", new XVar( "type", "grid_field_label",
"field", "PaymentPercentage" ),
"edit_selected", new XVar( "type", "edit_selected" ),
"-4", new XVar( "type", "-" ),
"grid_inline_edit", new XVar( "type", "grid_inline_edit" ),
"grid_inline_save", new XVar( "type", "grid_inline_save" ),
"grid_inline_cancel", new XVar( "type", "grid_inline_cancel" ),
"grid_checkbox_head", new XVar( "type", "grid_checkbox_head" ),
"grid_checkbox", new XVar( "type", "grid_checkbox" ),
"inline_save_all", new XVar( "type", "inline_save_all" ),
"inline_cancel_all", new XVar( "type", "inline_cancel_all" ),
"expand_button", new XVar( "type", "expand_button" ),
"inline_add", new XVar( "type", "inline_add",
"detailsOnly", true ) ),
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