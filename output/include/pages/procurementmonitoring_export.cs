
		// dbo.ProcurementMonitoring
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
			public static partial class Options_procurementmonitoring_export
			{
				static public XVar options()
				{
					return new XVar( "totals", new XVar( "Id", new XVar( "totalsType", "" ),
"PpmpId", new XVar( "totalsType", "" ),
"CodePAP", new XVar( "totalsType", "" ),
"IsthisAnEarlyProcurementActivity", new XVar( "totalsType", "" ),
"ModeOfProcurement", new XVar( "totalsType", "" ),
"PreProcConference", new XVar( "totalsType", "" ),
"AdsPostOfIB", new XVar( "totalsType", "" ),
"PreBidConf", new XVar( "totalsType", "" ),
"EligibilityCheck", new XVar( "totalsType", "" ),
"SubOpenOfBids", new XVar( "totalsType", "" ),
"BidEvaluation", new XVar( "totalsType", "" ),
"PostQual", new XVar( "totalsType", "" ),
"DateOfBACResolutionRecommendingAward", new XVar( "totalsType", "" ),
"NoticeOfAward", new XVar( "totalsType", "" ),
"ContractSigning", new XVar( "totalsType", "" ),
"NoticeToProceed", new XVar( "totalsType", "" ),
"DeliveryCompletion", new XVar( "totalsType", "" ),
"InspectionAndAcceptance", new XVar( "totalsType", "" ),
"SourceOfFunds", new XVar( "totalsType", "" ),
"TotalABCPhp", new XVar( "totalsType", "" ),
"ABCMOOE", new XVar( "totalsType", "" ),
"ABCCO", new XVar( "totalsType", "" ),
"TotalContractCostPhp", new XVar( "totalsType", "" ),
"ContractCostMOOE", new XVar( "totalsType", "" ),
"ContractCostCO", new XVar( "totalsType", "" ),
"ListOfInvitedObservers", new XVar( "totalsType", "" ),
"PreBidConfObservers", new XVar( "totalsType", "" ),
"EligibilityCheckObservers", new XVar( "totalsType", "" ),
"SubOpenOfBidsObservers", new XVar( "totalsType", "" ),
"BidEvaluationObservers", new XVar( "totalsType", "" ),
"PostQualObservers", new XVar( "totalsType", "" ),
"DeliveryCompletionAcceptanceIfApplicable", new XVar( "totalsType", "" ),
"RemarksExplainingChangesFromTheAPP", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "Id",
1, "CodePAP",
2, "IsthisAnEarlyProcurementActivity",
3, "ModeOfProcurement",
4, "PreProcConference",
5, "AdsPostOfIB",
6, "PreBidConf",
7, "EligibilityCheck",
8, "SubOpenOfBids",
9, "BidEvaluation",
10, "PostQual",
11, "DateOfBACResolutionRecommendingAward",
12, "NoticeOfAward",
13, "ContractSigning",
14, "NoticeToProceed",
15, "DeliveryCompletion",
16, "InspectionAndAcceptance",
17, "SourceOfFunds",
18, "TotalABCPhp",
19, "ABCMOOE",
20, "ABCCO",
21, "TotalContractCostPhp",
22, "ContractCostMOOE",
23, "ContractCostCO",
24, "ListOfInvitedObservers",
25, "PreBidConfObservers",
26, "EligibilityCheckObservers",
27, "SubOpenOfBidsObservers",
28, "BidEvaluationObservers",
29, "PostQualObservers",
30, "DeliveryCompletionAcceptanceIfApplicable",
31, "RemarksExplainingChangesFromTheAPP",
32, "PpmpId" ),
"exportFields", new XVar( 0, "Id",
1, "IsthisAnEarlyProcurementActivity",
2, "ModeOfProcurement",
3, "PreProcConference",
4, "PreBidConf",
5, "EligibilityCheck",
6, "BidEvaluation",
7, "PostQual",
8, "DateOfBACResolutionRecommendingAward",
9, "NoticeOfAward",
10, "ContractSigning",
11, "NoticeToProceed",
12, "InspectionAndAcceptance",
13, "SourceOfFunds",
14, "ABCMOOE",
15, "ABCCO",
16, "ContractCostMOOE",
17, "ContractCostCO",
18, "ListOfInvitedObservers",
19, "PreBidConfObservers",
20, "EligibilityCheckObservers",
21, "BidEvaluationObservers",
22, "PostQualObservers",
23, "PpmpId",
24, "CodePAP",
25, "AdsPostOfIB",
26, "SubOpenOfBids",
27, "DeliveryCompletion",
28, "TotalABCPhp",
29, "TotalContractCostPhp",
30, "SubOpenOfBidsObservers",
31, "DeliveryCompletionAcceptanceIfApplicable",
32, "RemarksExplainingChangesFromTheAPP" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "Id", new XVar( 0, "export_field" ),
"CodePAP", new XVar( 0, "export_field1" ),
"IsthisAnEarlyProcurementActivity", new XVar( 0, "export_field2" ),
"ModeOfProcurement", new XVar( 0, "export_field3" ),
"PreProcConference", new XVar( 0, "export_field4" ),
"AdsPostOfIB", new XVar( 0, "export_field5" ),
"PreBidConf", new XVar( 0, "export_field6" ),
"EligibilityCheck", new XVar( 0, "export_field7" ),
"SubOpenOfBids", new XVar( 0, "export_field8" ),
"BidEvaluation", new XVar( 0, "export_field9" ),
"PostQual", new XVar( 0, "export_field10" ),
"DateOfBACResolutionRecommendingAward", new XVar( 0, "export_field11" ),
"NoticeOfAward", new XVar( 0, "export_field12" ),
"ContractSigning", new XVar( 0, "export_field13" ),
"NoticeToProceed", new XVar( 0, "export_field14" ),
"DeliveryCompletion", new XVar( 0, "export_field15" ),
"InspectionAndAcceptance", new XVar( 0, "export_field16" ),
"SourceOfFunds", new XVar( 0, "export_field17" ),
"TotalABCPhp", new XVar( 0, "export_field18" ),
"ABCMOOE", new XVar( 0, "export_field19" ),
"ABCCO", new XVar( 0, "export_field20" ),
"TotalContractCostPhp", new XVar( 0, "export_field21" ),
"ContractCostMOOE", new XVar( 0, "export_field22" ),
"ContractCostCO", new XVar( 0, "export_field23" ),
"ListOfInvitedObservers", new XVar( 0, "export_field24" ),
"PreBidConfObservers", new XVar( 0, "export_field25" ),
"EligibilityCheckObservers", new XVar( 0, "export_field26" ),
"SubOpenOfBidsObservers", new XVar( 0, "export_field27" ),
"BidEvaluationObservers", new XVar( 0, "export_field28" ),
"PostQualObservers", new XVar( 0, "export_field29" ),
"DeliveryCompletionAcceptanceIfApplicable", new XVar( 0, "export_field30" ),
"RemarksExplainingChangesFromTheAPP", new XVar( 0, "export_field31" ),
"PpmpId", new XVar( 0, "export_field32" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", XVar.Array(),
"top", new XVar( 0, "export_header" ),
"grid", new XVar( 0, "export_field",
1, "export_field2",
2, "export_field3",
3, "export_field4",
4, "export_field6",
5, "export_field7",
6, "export_field9",
7, "export_field10",
8, "export_field11",
9, "export_field12",
10, "export_field13",
11, "export_field14",
12, "export_field16",
13, "export_field17",
14, "export_field19",
15, "export_field20",
16, "export_field22",
17, "export_field23",
18, "export_field24",
19, "export_field25",
20, "export_field26",
21, "export_field28",
22, "export_field29",
23, "export_field32",
24, "export_field1",
25, "export_field5",
26, "export_field8",
27, "export_field15",
28, "export_field18",
29, "export_field21",
30, "export_field27",
31, "export_field30",
32, "export_field31" ),
"footer", new XVar( 0, "export_export",
1, "export_cancel" ) ),
"formXtTags", new XVar( "supertop", XVar.Array() ),
"itemForms", new XVar( "export_header", "top",
"export_field", "grid",
"export_field2", "grid",
"export_field3", "grid",
"export_field4", "grid",
"export_field6", "grid",
"export_field7", "grid",
"export_field9", "grid",
"export_field10", "grid",
"export_field11", "grid",
"export_field12", "grid",
"export_field13", "grid",
"export_field14", "grid",
"export_field16", "grid",
"export_field17", "grid",
"export_field19", "grid",
"export_field20", "grid",
"export_field22", "grid",
"export_field23", "grid",
"export_field24", "grid",
"export_field25", "grid",
"export_field26", "grid",
"export_field28", "grid",
"export_field29", "grid",
"export_field32", "grid",
"export_field1", "grid",
"export_field5", "grid",
"export_field8", "grid",
"export_field15", "grid",
"export_field18", "grid",
"export_field21", "grid",
"export_field27", "grid",
"export_field30", "grid",
"export_field31", "grid",
"export_export", "footer",
"export_cancel", "footer" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "export_header", new XVar( 0, "export_header" ),
"export_export", new XVar( 0, "export_export" ),
"export_cancel", new XVar( 0, "export_cancel" ),
"export_field", new XVar( 0, "export_field",
1, "export_field1",
2, "export_field2",
3, "export_field3",
4, "export_field4",
5, "export_field5",
6, "export_field6",
7, "export_field7",
8, "export_field8",
9, "export_field9",
10, "export_field10",
11, "export_field11",
12, "export_field12",
13, "export_field13",
14, "export_field14",
15, "export_field15",
16, "export_field16",
17, "export_field17",
18, "export_field18",
19, "export_field19",
20, "export_field20",
21, "export_field21",
22, "export_field22",
23, "export_field23",
24, "export_field24",
25, "export_field25",
26, "export_field26",
27, "export_field27",
28, "export_field28",
29, "export_field29",
30, "export_field30",
31, "export_field31",
32, "export_field32" ) ),
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
"buttons", XVar.Array() ),
"export", new XVar( "format", 2,
"selectFields", false,
"delimiter", ",",
"selectDelimiter", false,
"exportFileTypes", new XVar( "excel", true,
"word", true,
"csv", true,
"xml", false ) ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "export",
"type", "export",
"layoutId", "first",
"disabled", 0,
"default", 0,
"forms", new XVar( "supertop", new XVar( "modelId", "panel-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "export-header",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "export_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "export-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "export_field",
1, "export_field2",
2, "export_field3",
3, "export_field4",
4, "export_field6",
5, "export_field7",
6, "export_field9",
7, "export_field10",
8, "export_field11",
9, "export_field12",
10, "export_field13",
11, "export_field14",
12, "export_field16",
13, "export_field17",
14, "export_field19",
15, "export_field20",
16, "export_field22",
17, "export_field23",
18, "export_field24",
19, "export_field25",
20, "export_field26",
21, "export_field28",
22, "export_field29",
23, "export_field32",
24, "export_field1",
25, "export_field5",
26, "export_field8",
27, "export_field15",
28, "export_field18",
29, "export_field21",
30, "export_field27",
31, "export_field30",
32, "export_field31" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"footer", new XVar( "modelId", "export-footer",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ),
1, new XVar( "cell", "c2" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ),
"c2", new XVar( "model", "c2",
"items", new XVar( 0, "export_export",
1, "export_cancel" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "export_header", new XVar( "type", "export_header" ),
"export_export", new XVar( "type", "export_export" ),
"export_cancel", new XVar( "type", "export_cancel" ),
"export_field", new XVar( "field", "Id",
"type", "export_field" ),
"export_field1", new XVar( "field", "CodePAP",
"type", "export_field" ),
"export_field2", new XVar( "field", "IsthisAnEarlyProcurementActivity",
"type", "export_field" ),
"export_field3", new XVar( "field", "ModeOfProcurement",
"type", "export_field" ),
"export_field4", new XVar( "field", "PreProcConference",
"type", "export_field" ),
"export_field5", new XVar( "field", "AdsPostOfIB",
"type", "export_field" ),
"export_field6", new XVar( "field", "PreBidConf",
"type", "export_field" ),
"export_field7", new XVar( "field", "EligibilityCheck",
"type", "export_field" ),
"export_field8", new XVar( "field", "SubOpenOfBids",
"type", "export_field" ),
"export_field9", new XVar( "field", "BidEvaluation",
"type", "export_field" ),
"export_field10", new XVar( "field", "PostQual",
"type", "export_field" ),
"export_field11", new XVar( "field", "DateOfBACResolutionRecommendingAward",
"type", "export_field" ),
"export_field12", new XVar( "field", "NoticeOfAward",
"type", "export_field" ),
"export_field13", new XVar( "field", "ContractSigning",
"type", "export_field" ),
"export_field14", new XVar( "field", "NoticeToProceed",
"type", "export_field" ),
"export_field15", new XVar( "field", "DeliveryCompletion",
"type", "export_field" ),
"export_field16", new XVar( "field", "InspectionAndAcceptance",
"type", "export_field" ),
"export_field17", new XVar( "field", "SourceOfFunds",
"type", "export_field" ),
"export_field18", new XVar( "field", "TotalABCPhp",
"type", "export_field" ),
"export_field19", new XVar( "field", "ABCMOOE",
"type", "export_field" ),
"export_field20", new XVar( "field", "ABCCO",
"type", "export_field" ),
"export_field21", new XVar( "field", "TotalContractCostPhp",
"type", "export_field" ),
"export_field22", new XVar( "field", "ContractCostMOOE",
"type", "export_field" ),
"export_field23", new XVar( "field", "ContractCostCO",
"type", "export_field" ),
"export_field24", new XVar( "field", "ListOfInvitedObservers",
"type", "export_field" ),
"export_field25", new XVar( "field", "PreBidConfObservers",
"type", "export_field" ),
"export_field26", new XVar( "field", "EligibilityCheckObservers",
"type", "export_field" ),
"export_field27", new XVar( "field", "SubOpenOfBidsObservers",
"type", "export_field" ),
"export_field28", new XVar( "field", "BidEvaluationObservers",
"type", "export_field" ),
"export_field29", new XVar( "field", "PostQualObservers",
"type", "export_field" ),
"export_field30", new XVar( "field", "DeliveryCompletionAcceptanceIfApplicable",
"type", "export_field" ),
"export_field31", new XVar( "field", "RemarksExplainingChangesFromTheAPP",
"type", "export_field" ),
"export_field32", new XVar( "field", "PpmpId",
"type", "export_field" ) ),
"dbProps", new XVar(  ),
"version", 14,
"imageItem", new XVar( "type", "page_image" ),
"imageBgColor", "#f2f2f2",
"controlsBgColor", "white",
"imagePosition", "right",
"listTotals", 1,
"exportFormat", 2,
"exportDelimiter", ",",
"exportSelectDelimiter", false,
"exportSelectFields", false );
				}
			}
		}