
		// dbo.PhilippineBiddingDocument
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
			public static partial class Options_philippinebiddingdocument_search
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "Id",
1, "ProcuringEntity",
2, "ProjectName",
3, "BidReferenceNo",
4, "ApprovedBudget",
5, "DeliveryDays",
6, "DatePosted",
7, "BidDocsAvailabilityStart",
8, "BidDocsAvailabilityEnd",
9, "BidSubmissionDeadline",
10, "BidDocsCost",
11, "PreBidConferenceDate",
12, "PreBidConferenceVenue",
13, "SimilarProjects",
14, "BidSecurity",
15, "BidOpeningdate",
16, "BidOpeningVenue",
17, "ContactPersonName",
18, "ContactPersonOffice",
19, "ContactPersonAddress",
20, "ContactPersonPhone",
21, "Website",
22, "IssuanceDate",
23, "BACChairperson",
24, "ProjectDescription",
25, "FundingSource",
26, "SLCCRequirement",
27, "SubContractingAllowed",
28, "BidCurrencies",
29, "PaymentCurrency",
30, "BidSecuritySubDays",
31, "ContractSimilarToProject",
32, "SimilarProjectYears",
33, "BidSecurityCashAmount",
34, "BidSecurityCashPercent",
35, "BidSecuritySuretyBondAmount",
36, "BidSecuritySuretyBondPercent" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "Id", new XVar( 0, "integrated_search_field" ),
"ProcuringEntity", new XVar( 0, "integrated_search_field1" ),
"ProjectName", new XVar( 0, "integrated_search_field2" ),
"BidReferenceNo", new XVar( 0, "integrated_search_field3" ),
"ApprovedBudget", new XVar( 0, "integrated_search_field4" ),
"DeliveryDays", new XVar( 0, "integrated_search_field5" ),
"DatePosted", new XVar( 0, "integrated_search_field6" ),
"BidDocsAvailabilityStart", new XVar( 0, "integrated_search_field7" ),
"BidDocsAvailabilityEnd", new XVar( 0, "integrated_search_field8" ),
"BidSubmissionDeadline", new XVar( 0, "integrated_search_field9" ),
"BidDocsCost", new XVar( 0, "integrated_search_field10" ),
"PreBidConferenceDate", new XVar( 0, "integrated_search_field11" ),
"PreBidConferenceVenue", new XVar( 0, "integrated_search_field12" ),
"SimilarProjects", new XVar( 0, "integrated_search_field13" ),
"BidSecurity", new XVar( 0, "integrated_search_field14" ),
"BidOpeningdate", new XVar( 0, "integrated_search_field15" ),
"BidOpeningVenue", new XVar( 0, "integrated_search_field16" ),
"ContactPersonName", new XVar( 0, "integrated_search_field17" ),
"ContactPersonOffice", new XVar( 0, "integrated_search_field18" ),
"ContactPersonAddress", new XVar( 0, "integrated_search_field19" ),
"ContactPersonPhone", new XVar( 0, "integrated_search_field20" ),
"Website", new XVar( 0, "integrated_search_field21" ),
"IssuanceDate", new XVar( 0, "integrated_search_field22" ),
"BACChairperson", new XVar( 0, "integrated_search_field23" ),
"ProjectDescription", new XVar( 0, "integrated_search_field24" ),
"FundingSource", new XVar( 0, "integrated_search_field25" ),
"SLCCRequirement", new XVar( 0, "integrated_search_field26" ),
"SubContractingAllowed", new XVar( 0, "integrated_search_field27" ),
"BidCurrencies", new XVar( 0, "integrated_search_field28" ),
"PaymentCurrency", new XVar( 0, "integrated_search_field29" ),
"BidSecuritySubDays", new XVar( 0, "integrated_search_field30" ),
"ContractSimilarToProject", new XVar( 0, "integrated_search_field31" ),
"SimilarProjectYears", new XVar( 0, "integrated_search_field32" ),
"BidSecurityCashAmount", new XVar( 0, "integrated_search_field33" ),
"BidSecurityCashPercent", new XVar( 0, "integrated_search_field34" ),
"BidSecuritySuretyBondAmount", new XVar( 0, "integrated_search_field35" ),
"BidSecuritySuretyBondPercent", new XVar( 0, "integrated_search_field36" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", XVar.Array(),
"below-grid", new XVar( 0, "search_search",
1, "search_reset",
2, "search_back_list",
3, "search_cancel" ),
"supertop", new XVar( 0, "expand_menu_button",
1, "collapse_button" ),
"left", new XVar( 0, "logo",
1, "expand_button",
2, "menu" ),
"top", new XVar( 0, "search_header" ),
"grid", new XVar( 0, "integrated_search_field",
1, "integrated_search_field2",
2, "integrated_search_field3",
3, "integrated_search_field4",
4, "integrated_search_field5",
5, "integrated_search_field6",
6, "integrated_search_field7",
7, "integrated_search_field8",
8, "integrated_search_field9",
9, "integrated_search_field10",
10, "integrated_search_field11",
11, "integrated_search_field12",
12, "integrated_search_field13",
13, "integrated_search_field14",
14, "integrated_search_field15",
15, "integrated_search_field16",
16, "integrated_search_field17",
17, "integrated_search_field18",
18, "integrated_search_field19",
19, "integrated_search_field20",
20, "integrated_search_field21",
21, "integrated_search_field22",
22, "integrated_search_field23",
23, "integrated_search_field24",
24, "integrated_search_field25",
25, "integrated_search_field26",
26, "integrated_search_field27",
27, "integrated_search_field28",
28, "integrated_search_field29",
29, "integrated_search_field30",
30, "integrated_search_field31",
31, "integrated_search_field32",
32, "integrated_search_field33",
33, "integrated_search_field34",
34, "integrated_search_field35",
35, "integrated_search_field36",
36, "integrated_search_field1" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array() ),
"itemForms", new XVar( "search_search", "below-grid",
"search_reset", "below-grid",
"search_back_list", "below-grid",
"search_cancel", "below-grid",
"expand_menu_button", "supertop",
"collapse_button", "supertop",
"logo", "left",
"expand_button", "left",
"menu", "left",
"search_header", "top",
"integrated_search_field", "grid",
"integrated_search_field2", "grid",
"integrated_search_field3", "grid",
"integrated_search_field4", "grid",
"integrated_search_field5", "grid",
"integrated_search_field6", "grid",
"integrated_search_field7", "grid",
"integrated_search_field8", "grid",
"integrated_search_field9", "grid",
"integrated_search_field10", "grid",
"integrated_search_field11", "grid",
"integrated_search_field12", "grid",
"integrated_search_field13", "grid",
"integrated_search_field14", "grid",
"integrated_search_field15", "grid",
"integrated_search_field16", "grid",
"integrated_search_field17", "grid",
"integrated_search_field18", "grid",
"integrated_search_field19", "grid",
"integrated_search_field20", "grid",
"integrated_search_field21", "grid",
"integrated_search_field22", "grid",
"integrated_search_field23", "grid",
"integrated_search_field24", "grid",
"integrated_search_field25", "grid",
"integrated_search_field26", "grid",
"integrated_search_field27", "grid",
"integrated_search_field28", "grid",
"integrated_search_field29", "grid",
"integrated_search_field30", "grid",
"integrated_search_field31", "grid",
"integrated_search_field32", "grid",
"integrated_search_field33", "grid",
"integrated_search_field34", "grid",
"integrated_search_field35", "grid",
"integrated_search_field36", "grid",
"integrated_search_field1", "grid" ),
"itemLocations", new XVar( "integrated_search_field", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field2", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field3", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field4", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field5", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field6", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field7", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field8", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field9", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field10", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field11", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field12", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field13", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field14", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field15", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field16", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field17", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field18", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field19", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field20", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field21", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field22", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field23", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field24", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field25", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field26", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field27", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field28", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field29", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field30", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field31", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field32", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field33", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field34", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field35", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field36", new XVar( "location", "grid",
"cellId", "c3" ),
"integrated_search_field1", new XVar( "location", "grid",
"cellId", "c3" ) ),
"itemVisiblity", new XVar( "expand_menu_button", 2,
"expand_button", 5 ) ),
"itemsByType", new XVar( "search_header", new XVar( 0, "search_header" ),
"search_reset", new XVar( 0, "search_reset" ),
"search_back_list", new XVar( 0, "search_back_list" ),
"search_search", new XVar( 0, "search_search" ),
"search_cancel", new XVar( 0, "search_cancel" ),
"logo", new XVar( 0, "logo" ),
"menu", new XVar( 0, "menu" ),
"expand_menu_button", new XVar( 0, "expand_menu_button" ),
"collapse_button", new XVar( 0, "collapse_button" ),
"integrated_search_field", new XVar( 0, "integrated_search_field",
1, "integrated_search_field1",
2, "integrated_search_field2",
3, "integrated_search_field3",
4, "integrated_search_field4",
5, "integrated_search_field5",
6, "integrated_search_field6",
7, "integrated_search_field7",
8, "integrated_search_field8",
9, "integrated_search_field9",
10, "integrated_search_field10",
11, "integrated_search_field11",
12, "integrated_search_field12",
13, "integrated_search_field13",
14, "integrated_search_field14",
15, "integrated_search_field15",
16, "integrated_search_field16",
17, "integrated_search_field17",
18, "integrated_search_field18",
19, "integrated_search_field19",
20, "integrated_search_field20",
21, "integrated_search_field21",
22, "integrated_search_field22",
23, "integrated_search_field23",
24, "integrated_search_field24",
25, "integrated_search_field25",
26, "integrated_search_field26",
27, "integrated_search_field27",
28, "integrated_search_field28",
29, "integrated_search_field29",
30, "integrated_search_field30",
31, "integrated_search_field31",
32, "integrated_search_field32",
33, "integrated_search_field33",
34, "integrated_search_field34",
35, "integrated_search_field35",
36, "integrated_search_field36" ),
"expand_button", new XVar( 0, "expand_button" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "c3", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", XVar.Array(),
"items", new XVar( 0, "integrated_search_field",
1, "integrated_search_field2",
2, "integrated_search_field3",
3, "integrated_search_field4",
4, "integrated_search_field5",
5, "integrated_search_field6",
6, "integrated_search_field7",
7, "integrated_search_field8",
8, "integrated_search_field9",
9, "integrated_search_field10",
10, "integrated_search_field11",
11, "integrated_search_field12",
12, "integrated_search_field13",
13, "integrated_search_field14",
14, "integrated_search_field15",
15, "integrated_search_field16",
16, "integrated_search_field17",
17, "integrated_search_field18",
18, "integrated_search_field19",
19, "integrated_search_field20",
20, "integrated_search_field21",
21, "integrated_search_field22",
22, "integrated_search_field23",
23, "integrated_search_field24",
24, "integrated_search_field25",
25, "integrated_search_field26",
26, "integrated_search_field27",
27, "integrated_search_field28",
28, "integrated_search_field29",
29, "integrated_search_field30",
30, "integrated_search_field31",
31, "integrated_search_field32",
32, "integrated_search_field33",
33, "integrated_search_field34",
34, "integrated_search_field35",
35, "integrated_search_field36",
36, "integrated_search_field1" ),
"fixedAtServer", true,
"fixedAtClient", false ) ),
"width", 1,
"height", 1 ) ) ),
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
"misc", new XVar( "type", "search",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "search",
"type", "search",
"layoutId", "leftbar",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "search-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1",
"colspan", 2 ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "search-below-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_search",
1, "search_reset",
2, "search_back_list",
3, "search_cancel" ) ) ),
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
"items", new XVar( 0, "menu" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "search-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "search_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "simple-search",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c3" ) ),
"section", "" ) ),
"cells", new XVar( "c3", new XVar( "model", "c3",
"items", new XVar( 0, "integrated_search_field",
1, "integrated_search_field2",
2, "integrated_search_field3",
3, "integrated_search_field4",
4, "integrated_search_field5",
5, "integrated_search_field6",
6, "integrated_search_field7",
7, "integrated_search_field8",
8, "integrated_search_field9",
9, "integrated_search_field10",
10, "integrated_search_field11",
11, "integrated_search_field12",
12, "integrated_search_field13",
13, "integrated_search_field14",
14, "integrated_search_field15",
15, "integrated_search_field16",
16, "integrated_search_field17",
17, "integrated_search_field18",
18, "integrated_search_field19",
19, "integrated_search_field20",
20, "integrated_search_field21",
21, "integrated_search_field22",
22, "integrated_search_field23",
23, "integrated_search_field24",
24, "integrated_search_field25",
25, "integrated_search_field26",
26, "integrated_search_field27",
27, "integrated_search_field28",
28, "integrated_search_field29",
29, "integrated_search_field30",
30, "integrated_search_field31",
31, "integrated_search_field32",
32, "integrated_search_field33",
33, "integrated_search_field34",
34, "integrated_search_field35",
35, "integrated_search_field36",
36, "integrated_search_field1" ) ) ),
"deferredItems", XVar.Array(),
"separateLabels", false ) ),
"items", new XVar( "search_header", new XVar( "type", "search_header" ),
"search_reset", new XVar( "type", "search_reset" ),
"search_back_list", new XVar( "type", "search_back_list" ),
"search_search", new XVar( "type", "search_search" ),
"search_cancel", new XVar( "type", "search_cancel" ),
"logo", new XVar( "type", "logo" ),
"menu", new XVar( "type", "menu" ),
"expand_menu_button", new XVar( "type", "expand_menu_button" ),
"collapse_button", new XVar( "type", "collapse_button" ),
"integrated_search_field", new XVar( "field", "Id",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field1", new XVar( "field", "ProcuringEntity",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field2", new XVar( "field", "ProjectName",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field3", new XVar( "field", "BidReferenceNo",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field4", new XVar( "field", "ApprovedBudget",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field5", new XVar( "field", "DeliveryDays",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field6", new XVar( "field", "DatePosted",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field7", new XVar( "field", "BidDocsAvailabilityStart",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field8", new XVar( "field", "BidDocsAvailabilityEnd",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field9", new XVar( "field", "BidSubmissionDeadline",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field10", new XVar( "field", "BidDocsCost",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field11", new XVar( "field", "PreBidConferenceDate",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field12", new XVar( "field", "PreBidConferenceVenue",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field13", new XVar( "field", "SimilarProjects",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field14", new XVar( "field", "BidSecurity",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field15", new XVar( "field", "BidOpeningdate",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field16", new XVar( "field", "BidOpeningVenue",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field17", new XVar( "field", "ContactPersonName",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field18", new XVar( "field", "ContactPersonOffice",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field19", new XVar( "field", "ContactPersonAddress",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field20", new XVar( "field", "ContactPersonPhone",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field21", new XVar( "field", "Website",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field22", new XVar( "field", "IssuanceDate",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field23", new XVar( "field", "BACChairperson",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field24", new XVar( "field", "ProjectDescription",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field25", new XVar( "field", "FundingSource",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field26", new XVar( "field", "SLCCRequirement",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field27", new XVar( "field", "SubContractingAllowed",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field28", new XVar( "field", "BidCurrencies",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field29", new XVar( "field", "PaymentCurrency",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field30", new XVar( "field", "BidSecuritySubDays",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field31", new XVar( "field", "ContractSimilarToProject",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field32", new XVar( "field", "SimilarProjectYears",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field33", new XVar( "field", "BidSecurityCashAmount",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field34", new XVar( "field", "BidSecurityCashPercent",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field35", new XVar( "field", "BidSecuritySuretyBondAmount",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"integrated_search_field36", new XVar( "field", "BidSecuritySuretyBondPercent",
"type", "integrated_search_field",
"orientation", 0,
"required", false ),
"expand_button", new XVar( "type", "expand_button" ) ),
"dbProps", new XVar(  ),
"version", 14,
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"listTotals", 1 );
				}
			}
		}