
		// dbo.ObserverReport
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
			public static partial class Options_observerreport_edit
			{
				static public XVar options()
				{
					return new XVar( "master", new XVar( "dbo.Observer", new XVar( "preview", false ) ),
"captcha", new XVar( "captcha", false ),
"fields", new XVar( "gridFields", new XVar( 0, "ObserverId",
1, "ProcurementActivityId",
2, "ReportDate",
3, "WrittenDissent",
4, "PostQualificationSigned",
5, "ComplianceAssesment",
6, "AreasOfImprovement",
7, "AbstractSigned",
8, "OpenedProposals",
9, "APPPPMPDocuments",
10, "PostQualificationReport",
11, "AbstractOfBids",
12, "BACMeetingsMinutes",
13, "ReportStatus",
14, "ReportSubmittedto" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"updateOnEditFields", XVar.Array(),
"fieldItems", new XVar( "ObserverId", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field16" ),
"ProcurementActivityId", new XVar( 0, "integrated_edit_field17",
1, "integrated_edit_field2",
2, "integrated_edit_field18" ),
"ReportDate", new XVar( 0, "integrated_edit_field19",
1, "integrated_edit_field3",
2, "integrated_edit_field20" ),
"ComplianceAssesment", new XVar( 0, "integrated_edit_field21",
1, "integrated_edit_field4",
2, "integrated_edit_field22" ),
"WrittenDissent", new XVar( 0, "integrated_edit_field44",
1, "integrated_edit_field15",
2, "integrated_edit_field43" ),
"PostQualificationSigned", new XVar( 0, "integrated_edit_field42",
1, "integrated_edit_field14",
2, "integrated_edit_field41" ),
"AreasOfImprovement", new XVar( 0, "integrated_edit_field23",
1, "integrated_edit_field5",
2, "integrated_edit_field24" ),
"AbstractSigned", new XVar( 0, "integrated_edit_field40",
1, "integrated_edit_field13",
2, "integrated_edit_field39" ),
"OpenedProposals", new XVar( 0, "integrated_edit_field38",
1, "integrated_edit_field10",
2, "integrated_edit_field37" ),
"APPPPMPDocuments", new XVar( 0, "integrated_edit_field36",
1, "integrated_edit_field9",
2, "integrated_edit_field35" ),
"PostQualificationReport", new XVar( 0, "integrated_edit_field34",
1, "integrated_edit_field8",
2, "integrated_edit_field33" ),
"AbstractOfBids", new XVar( 0, "integrated_edit_field32",
1, "integrated_edit_field7",
2, "integrated_edit_field31" ),
"BACMeetingsMinutes", new XVar( 0, "integrated_edit_field30",
1, "integrated_edit_field6",
2, "integrated_edit_field29" ),
"ReportStatus", new XVar( 0, "integrated_edit_field28",
1, "integrated_edit_field12",
2, "integrated_edit_field27" ),
"ReportSubmittedto", new XVar( 0, "integrated_edit_field26",
1, "integrated_edit_field11",
2, "integrated_edit_field25" ) ) ),
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
"section", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field16",
3, "integrated_edit_field17",
4, "integrated_edit_field2",
5, "integrated_edit_field18",
6, "integrated_edit_field19",
7, "integrated_edit_field3",
8, "integrated_edit_field20",
9, "integrated_edit_field21",
10, "integrated_edit_field4",
11, "integrated_edit_field22",
12, "integrated_edit_field23",
13, "integrated_edit_field5",
14, "integrated_edit_field24",
15, "integrated_edit_field25",
16, "integrated_edit_field11",
17, "integrated_edit_field26",
18, "integrated_edit_field27",
19, "integrated_edit_field12",
20, "integrated_edit_field28",
21, "integrated_edit_field29",
22, "integrated_edit_field6",
23, "integrated_edit_field30",
24, "integrated_edit_field31",
25, "integrated_edit_field7",
26, "integrated_edit_field32",
27, "integrated_edit_field33",
28, "integrated_edit_field8",
29, "integrated_edit_field34",
30, "integrated_edit_field35",
31, "integrated_edit_field9",
32, "integrated_edit_field36",
33, "integrated_edit_field37",
34, "integrated_edit_field10",
35, "integrated_edit_field38",
36, "integrated_edit_field39",
37, "integrated_edit_field13",
38, "integrated_edit_field40",
39, "integrated_edit_field41",
40, "integrated_edit_field14",
41, "integrated_edit_field42",
42, "integrated_edit_field43",
43, "integrated_edit_field15",
44, "integrated_edit_field44" ) ),
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
"integrated_edit_field", "section",
"integrated_edit_field1", "section",
"integrated_edit_field16", "section",
"integrated_edit_field17", "section",
"integrated_edit_field2", "section",
"integrated_edit_field18", "section",
"integrated_edit_field19", "section",
"integrated_edit_field3", "section",
"integrated_edit_field20", "section",
"integrated_edit_field21", "section",
"integrated_edit_field4", "section",
"integrated_edit_field22", "section",
"integrated_edit_field23", "section",
"integrated_edit_field5", "section",
"integrated_edit_field24", "section",
"integrated_edit_field25", "section",
"integrated_edit_field11", "section",
"integrated_edit_field26", "section",
"integrated_edit_field27", "section",
"integrated_edit_field12", "section",
"integrated_edit_field28", "section",
"integrated_edit_field29", "section",
"integrated_edit_field6", "section",
"integrated_edit_field30", "section",
"integrated_edit_field31", "section",
"integrated_edit_field7", "section",
"integrated_edit_field32", "section",
"integrated_edit_field33", "section",
"integrated_edit_field8", "section",
"integrated_edit_field34", "section",
"integrated_edit_field35", "section",
"integrated_edit_field9", "section",
"integrated_edit_field36", "section",
"integrated_edit_field37", "section",
"integrated_edit_field10", "section",
"integrated_edit_field38", "section",
"integrated_edit_field39", "section",
"integrated_edit_field13", "section",
"integrated_edit_field40", "section",
"integrated_edit_field41", "section",
"integrated_edit_field14", "section",
"integrated_edit_field42", "section",
"integrated_edit_field43", "section",
"integrated_edit_field15", "section",
"integrated_edit_field44", "section" ),
"itemLocations", new XVar( "tabs", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_edit_field", new XVar( "location", "section",
"cellId", "c1" ),
"integrated_edit_field1", new XVar( "location", "section",
"cellId", "c1" ),
"integrated_edit_field16", new XVar( "location", "section",
"cellId", "c1" ),
"integrated_edit_field17", new XVar( "location", "section",
"cellId", "c" ),
"integrated_edit_field2", new XVar( "location", "section",
"cellId", "c" ),
"integrated_edit_field18", new XVar( "location", "section",
"cellId", "c" ),
"integrated_edit_field19", new XVar( "location", "section",
"cellId", "c2" ),
"integrated_edit_field3", new XVar( "location", "section",
"cellId", "c2" ),
"integrated_edit_field20", new XVar( "location", "section",
"cellId", "c2" ),
"integrated_edit_field21", new XVar( "location", "section",
"cellId", "c3" ),
"integrated_edit_field4", new XVar( "location", "section",
"cellId", "c3" ),
"integrated_edit_field22", new XVar( "location", "section",
"cellId", "c3" ),
"integrated_edit_field23", new XVar( "location", "section",
"cellId", "c4" ),
"integrated_edit_field5", new XVar( "location", "section",
"cellId", "c4" ),
"integrated_edit_field24", new XVar( "location", "section",
"cellId", "c4" ),
"integrated_edit_field25", new XVar( "location", "section",
"cellId", "c5" ),
"integrated_edit_field11", new XVar( "location", "section",
"cellId", "c5" ),
"integrated_edit_field26", new XVar( "location", "section",
"cellId", "c5" ),
"integrated_edit_field27", new XVar( "location", "section",
"cellId", "c6" ),
"integrated_edit_field12", new XVar( "location", "section",
"cellId", "c6" ),
"integrated_edit_field28", new XVar( "location", "section",
"cellId", "c6" ),
"integrated_edit_field29", new XVar( "location", "section",
"cellId", "c7" ),
"integrated_edit_field6", new XVar( "location", "section",
"cellId", "c7" ),
"integrated_edit_field30", new XVar( "location", "section",
"cellId", "c7" ),
"integrated_edit_field31", new XVar( "location", "section",
"cellId", "c8" ),
"integrated_edit_field7", new XVar( "location", "section",
"cellId", "c8" ),
"integrated_edit_field32", new XVar( "location", "section",
"cellId", "c8" ),
"integrated_edit_field33", new XVar( "location", "section",
"cellId", "c9" ),
"integrated_edit_field8", new XVar( "location", "section",
"cellId", "c9" ),
"integrated_edit_field34", new XVar( "location", "section",
"cellId", "c9" ),
"integrated_edit_field35", new XVar( "location", "section",
"cellId", "c10" ),
"integrated_edit_field9", new XVar( "location", "section",
"cellId", "c10" ),
"integrated_edit_field36", new XVar( "location", "section",
"cellId", "c10" ),
"integrated_edit_field37", new XVar( "location", "section",
"cellId", "c11" ),
"integrated_edit_field10", new XVar( "location", "section",
"cellId", "c11" ),
"integrated_edit_field38", new XVar( "location", "section",
"cellId", "c11" ),
"integrated_edit_field39", new XVar( "location", "section",
"cellId", "c12" ),
"integrated_edit_field13", new XVar( "location", "section",
"cellId", "c12" ),
"integrated_edit_field40", new XVar( "location", "section",
"cellId", "c12" ),
"integrated_edit_field41", new XVar( "location", "section",
"cellId", "c13" ),
"integrated_edit_field14", new XVar( "location", "section",
"cellId", "c13" ),
"integrated_edit_field42", new XVar( "location", "section",
"cellId", "c13" ),
"integrated_edit_field43", new XVar( "location", "section",
"cellId", "c14" ),
"integrated_edit_field15", new XVar( "location", "section",
"cellId", "c14" ),
"integrated_edit_field44", new XVar( "location", "section",
"cellId", "c14" ) ),
"itemVisiblity", new XVar( "expand_menu_button", 2,
"breadcrumb", 5,
"expand_button", 5 ) ),
"itemsByType", new XVar( "edit_save", new XVar( 0, "edit_save" ),
"edit_back_list", new XVar( 0, "edit_back_list" ),
"edit_close", new XVar( 0, "edit_close" ),
"edit_field_label", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field17",
2, "integrated_edit_field19",
3, "integrated_edit_field21",
4, "integrated_edit_field43",
5, "integrated_edit_field23",
6, "integrated_edit_field41",
7, "integrated_edit_field39",
8, "integrated_edit_field37",
9, "integrated_edit_field35",
10, "integrated_edit_field33",
11, "integrated_edit_field31",
12, "integrated_edit_field29",
13, "integrated_edit_field27",
14, "integrated_edit_field25" ),
"edit_field", new XVar( 0, "integrated_edit_field1",
1, "integrated_edit_field2",
2, "integrated_edit_field3",
3, "integrated_edit_field15",
4, "integrated_edit_field14",
5, "integrated_edit_field4",
6, "integrated_edit_field5",
7, "integrated_edit_field13",
8, "integrated_edit_field10",
9, "integrated_edit_field9",
10, "integrated_edit_field8",
11, "integrated_edit_field7",
12, "integrated_edit_field6",
13, "integrated_edit_field12",
14, "integrated_edit_field11" ),
"edit_field_tooltip", new XVar( 0, "integrated_edit_field16",
1, "integrated_edit_field18",
2, "integrated_edit_field20",
3, "integrated_edit_field44",
4, "integrated_edit_field42",
5, "integrated_edit_field22",
6, "integrated_edit_field40",
7, "integrated_edit_field38",
8, "integrated_edit_field36",
9, "integrated_edit_field34",
10, "integrated_edit_field32",
11, "integrated_edit_field30",
12, "integrated_edit_field28",
13, "integrated_edit_field26",
14, "integrated_edit_field24" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"expand_menu_button", new XVar( 0, "expand_menu_button" ),
"collapse_button", new XVar( 0, "collapse_button" ),
"tabs", new XVar( 0, "tabs" ),
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
"items", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field16" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field17",
1, "integrated_edit_field2",
2, "integrated_edit_field18" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c2", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field19",
1, "integrated_edit_field3",
2, "integrated_edit_field20" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c3", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field21",
1, "integrated_edit_field4",
2, "integrated_edit_field22" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c4", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field23",
1, "integrated_edit_field5",
2, "integrated_edit_field24" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c5", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field25",
1, "integrated_edit_field11",
2, "integrated_edit_field26" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c6", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field27",
1, "integrated_edit_field12",
2, "integrated_edit_field28" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c7", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 3 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field29",
1, "integrated_edit_field6",
2, "integrated_edit_field30" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c8", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 4 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field31",
1, "integrated_edit_field7",
2, "integrated_edit_field32" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c9", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 4 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field33",
1, "integrated_edit_field8",
2, "integrated_edit_field34" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c10", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 5 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field35",
1, "integrated_edit_field9",
2, "integrated_edit_field36" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c11", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 5 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field37",
1, "integrated_edit_field10",
2, "integrated_edit_field38" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c12", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 6 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field39",
1, "integrated_edit_field13",
2, "integrated_edit_field40" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c13", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 6 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field41",
1, "integrated_edit_field14",
2, "integrated_edit_field42" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c14", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 7 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_edit_field43",
1, "integrated_edit_field15",
2, "integrated_edit_field44" ),
"fixedAtServer", true,
"fixedAtClient", false ),
"c15", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 7 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 2,
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
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "edit_save",
1, "edit_back_list",
2, "edit_close" ) ),
"c2", new XVar( "model", "c2",
"items", XVar.Array() ) ),
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
1, "expand_button" ),
"bold", true ),
"c1", new XVar( "model", "c1",
"items", new XVar( 0, "menu" ),
"bold", true ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "edit-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "tabs" ) ) ),
"deferredItems", XVar.Array(),
"columnCount", 1,
"inlineLabels", false,
"separateLabels", false ),
"section", new XVar( "modelId", "simple-edit",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c" ) ),
"section", "" ),
1, new XVar( "cells", new XVar( 0, new XVar( "cell", "c2" ),
1, new XVar( "cell", "c3" ) ),
"section", "" ),
2, new XVar( "cells", new XVar( 0, new XVar( "cell", "c4" ),
1, new XVar( "cell", "c5" ) ),
"section", "" ),
3, new XVar( "cells", new XVar( 0, new XVar( "cell", "c6" ),
1, new XVar( "cell", "c7" ) ),
"section", "" ),
4, new XVar( "cells", new XVar( 0, new XVar( "cell", "c8" ),
1, new XVar( "cell", "c9" ) ),
"section", "" ),
5, new XVar( "cells", new XVar( 0, new XVar( "cell", "c10" ),
1, new XVar( "cell", "c11" ) ),
"section", "" ),
6, new XVar( "cells", new XVar( 0, new XVar( "cell", "c12" ),
1, new XVar( "cell", "c13" ) ),
"section", "" ),
7, new XVar( "cells", new XVar( 0, new XVar( "cell", "c14" ),
1, new XVar( "cell", "c15" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field",
1, "integrated_edit_field1",
2, "integrated_edit_field16" ),
"field", "ObserverId",
"align", "left" ),
"c", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field17",
1, "integrated_edit_field2",
2, "integrated_edit_field18" ),
"field", "ProcurementActivityId",
"align", "left" ),
"c2", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field19",
1, "integrated_edit_field3",
2, "integrated_edit_field20" ),
"field", "ReportDate",
"align", "left" ),
"c3", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field21",
1, "integrated_edit_field4",
2, "integrated_edit_field22" ),
"field", "ComplianceAssesment",
"align", "left" ),
"c4", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field23",
1, "integrated_edit_field5",
2, "integrated_edit_field24" ),
"field", "AreasOfImprovement",
"align", "left" ),
"c5", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field25",
1, "integrated_edit_field11",
2, "integrated_edit_field26" ),
"field", "ReportSubmittedto",
"align", "left" ),
"c6", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field27",
1, "integrated_edit_field12",
2, "integrated_edit_field28" ),
"field", "ReportStatus",
"align", "left" ),
"c7", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field29",
1, "integrated_edit_field6",
2, "integrated_edit_field30" ),
"field", "BACMeetingsMinutes",
"align", "left" ),
"c8", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field31",
1, "integrated_edit_field7",
2, "integrated_edit_field32" ),
"field", "AbstractOfBids",
"align", "left" ),
"c9", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field33",
1, "integrated_edit_field8",
2, "integrated_edit_field34" ),
"field", "PostQualificationReport",
"align", "left" ),
"c10", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field35",
1, "integrated_edit_field9",
2, "integrated_edit_field36" ),
"field", "APPPPMPDocuments",
"align", "left" ),
"c11", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field37",
1, "integrated_edit_field10",
2, "integrated_edit_field38" ),
"field", "OpenedProposals",
"align", "left" ),
"c12", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field39",
1, "integrated_edit_field13",
2, "integrated_edit_field40" ),
"field", "AbstractSigned",
"align", "left" ),
"c13", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field41",
1, "integrated_edit_field14",
2, "integrated_edit_field42" ),
"field", "PostQualificationSigned",
"align", "left" ),
"c14", new XVar( "model", "c1",
"items", new XVar( 0, "integrated_edit_field43",
1, "integrated_edit_field15",
2, "integrated_edit_field44" ),
"field", "WrittenDissent",
"align", "left" ),
"c15", new XVar( "model", "c1",
"items", XVar.Array(),
"align", "left" ) ),
"deferredItems", XVar.Array(),
"columnCount", 2,
"inlineLabels", false,
"separateLabels", true ) ),
"items", new XVar( "edit_save", new XVar( "type", "edit_save",
"background", "#efb11d" ),
"edit_back_list", new XVar( "type", "edit_back_list" ),
"edit_close", new XVar( "type", "edit_close" ),
"integrated_edit_field", new XVar( "type", "edit_field_label",
"field", "ObserverId" ),
"integrated_edit_field1", new XVar( "field", "ObserverId",
"type", "edit_field" ),
"integrated_edit_field16", new XVar( "type", "edit_field_tooltip",
"field", "ObserverId" ),
"integrated_edit_field17", new XVar( "type", "edit_field_label",
"field", "ProcurementActivityId" ),
"integrated_edit_field2", new XVar( "field", "ProcurementActivityId",
"type", "edit_field" ),
"integrated_edit_field18", new XVar( "type", "edit_field_tooltip",
"field", "ProcurementActivityId" ),
"integrated_edit_field19", new XVar( "type", "edit_field_label",
"field", "ReportDate" ),
"integrated_edit_field3", new XVar( "field", "ReportDate",
"type", "edit_field" ),
"integrated_edit_field20", new XVar( "type", "edit_field_tooltip",
"field", "ReportDate" ),
"integrated_edit_field21", new XVar( "type", "edit_field_label",
"field", "ComplianceAssesment" ),
"integrated_edit_field44", new XVar( "type", "edit_field_tooltip",
"field", "WrittenDissent" ),
"integrated_edit_field15", new XVar( "field", "WrittenDissent",
"type", "edit_field" ),
"integrated_edit_field43", new XVar( "type", "edit_field_label",
"field", "WrittenDissent" ),
"integrated_edit_field42", new XVar( "type", "edit_field_tooltip",
"field", "PostQualificationSigned" ),
"integrated_edit_field14", new XVar( "field", "PostQualificationSigned",
"type", "edit_field" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"expand_menu_button", new XVar( "type", "expand_menu_button" ),
"collapse_button", new XVar( "type", "collapse_button" ),
"tabs", new XVar( "type", "tabs",
"titles", new XVar( 0, new XVar( "text", "Edit Record",
"type", 0 ) ),
"locations", new XVar( 0, "section" ),
"bsStyle", "default",
"panelType", 2 ),
"integrated_edit_field4", new XVar( "field", "ComplianceAssesment",
"type", "edit_field" ),
"integrated_edit_field22", new XVar( "type", "edit_field_tooltip",
"field", "ComplianceAssesment" ),
"integrated_edit_field23", new XVar( "type", "edit_field_label",
"field", "AreasOfImprovement" ),
"integrated_edit_field5", new XVar( "field", "AreasOfImprovement",
"type", "edit_field" ),
"integrated_edit_field41", new XVar( "type", "edit_field_label",
"field", "PostQualificationSigned" ),
"integrated_edit_field40", new XVar( "type", "edit_field_tooltip",
"field", "AbstractSigned" ),
"integrated_edit_field13", new XVar( "field", "AbstractSigned",
"type", "edit_field" ),
"integrated_edit_field39", new XVar( "type", "edit_field_label",
"field", "AbstractSigned" ),
"integrated_edit_field38", new XVar( "type", "edit_field_tooltip",
"field", "OpenedProposals" ),
"integrated_edit_field10", new XVar( "field", "OpenedProposals",
"type", "edit_field" ),
"integrated_edit_field37", new XVar( "type", "edit_field_label",
"field", "OpenedProposals" ),
"integrated_edit_field36", new XVar( "type", "edit_field_tooltip",
"field", "APPPPMPDocuments" ),
"integrated_edit_field9", new XVar( "field", "APPPPMPDocuments",
"type", "edit_field" ),
"integrated_edit_field35", new XVar( "type", "edit_field_label",
"field", "APPPPMPDocuments" ),
"integrated_edit_field34", new XVar( "type", "edit_field_tooltip",
"field", "PostQualificationReport" ),
"integrated_edit_field8", new XVar( "field", "PostQualificationReport",
"type", "edit_field" ),
"integrated_edit_field33", new XVar( "type", "edit_field_label",
"field", "PostQualificationReport" ),
"integrated_edit_field32", new XVar( "type", "edit_field_tooltip",
"field", "AbstractOfBids" ),
"integrated_edit_field7", new XVar( "field", "AbstractOfBids",
"type", "edit_field" ),
"integrated_edit_field31", new XVar( "type", "edit_field_label",
"field", "AbstractOfBids" ),
"integrated_edit_field30", new XVar( "type", "edit_field_tooltip",
"field", "BACMeetingsMinutes" ),
"integrated_edit_field6", new XVar( "field", "BACMeetingsMinutes",
"type", "edit_field" ),
"integrated_edit_field29", new XVar( "type", "edit_field_label",
"field", "BACMeetingsMinutes" ),
"integrated_edit_field28", new XVar( "type", "edit_field_tooltip",
"field", "ReportStatus" ),
"integrated_edit_field12", new XVar( "field", "ReportStatus",
"type", "edit_field" ),
"integrated_edit_field27", new XVar( "type", "edit_field_label",
"field", "ReportStatus" ),
"integrated_edit_field26", new XVar( "type", "edit_field_tooltip",
"field", "ReportSubmittedto" ),
"integrated_edit_field11", new XVar( "field", "ReportSubmittedto",
"type", "edit_field" ),
"integrated_edit_field25", new XVar( "type", "edit_field_label",
"field", "ReportSubmittedto" ),
"integrated_edit_field24", new XVar( "type", "edit_field_tooltip",
"field", "AreasOfImprovement" ),
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