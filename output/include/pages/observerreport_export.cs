
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
			public static partial class Options_observerreport_export
			{
				static public XVar options()
				{
					return new XVar( "totals", new XVar( "ReportId", new XVar( "totalsType", "" ),
"ObserverId", new XVar( "totalsType", "" ),
"ProcurementActivityId", new XVar( "totalsType", "" ),
"ReportDate", new XVar( "totalsType", "" ),
"ComplianceAssesment", new XVar( "totalsType", "" ),
"AreasOfImprovement", new XVar( "totalsType", "" ),
"BACMeetingsMinutes", new XVar( "totalsType", "" ),
"AbstractOfBids", new XVar( "totalsType", "" ),
"PostQualificationReport", new XVar( "totalsType", "" ),
"APPPPMPDocuments", new XVar( "totalsType", "" ),
"OpenedProposals", new XVar( "totalsType", "" ),
"ReportSubmittedto", new XVar( "totalsType", "" ),
"ReportStatus", new XVar( "totalsType", "" ),
"AbstractSigned", new XVar( "totalsType", "" ),
"PostQualificationSigned", new XVar( "totalsType", "" ),
"WrittenDissent", new XVar( "totalsType", "" ) ),
"fields", new XVar( "gridFields", new XVar( 0, "ObserverId",
1, "ProcurementActivityId",
2, "ReportDate",
3, "ComplianceAssesment",
4, "AreasOfImprovement",
5, "BACMeetingsMinutes",
6, "AbstractOfBids",
7, "PostQualificationReport",
8, "APPPPMPDocuments",
9, "OpenedProposals",
10, "ReportSubmittedto",
11, "ReportStatus",
12, "AbstractSigned",
13, "PostQualificationSigned",
14, "WrittenDissent" ),
"exportFields", new XVar( 0, "ObserverId",
1, "ProcurementActivityId",
2, "ReportDate",
3, "ComplianceAssesment",
4, "AreasOfImprovement",
5, "BACMeetingsMinutes",
6, "AbstractOfBids",
7, "PostQualificationReport",
8, "APPPPMPDocuments",
9, "OpenedProposals",
10, "ReportSubmittedto",
11, "ReportStatus",
12, "AbstractSigned",
13, "PostQualificationSigned",
14, "WrittenDissent" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "ObserverId", new XVar( 0, "export_field1" ),
"ProcurementActivityId", new XVar( 0, "export_field2" ),
"ReportDate", new XVar( 0, "export_field3" ),
"ComplianceAssesment", new XVar( 0, "export_field4" ),
"AreasOfImprovement", new XVar( 0, "export_field5" ),
"BACMeetingsMinutes", new XVar( 0, "export_field6" ),
"AbstractOfBids", new XVar( 0, "export_field7" ),
"PostQualificationReport", new XVar( 0, "export_field8" ),
"APPPPMPDocuments", new XVar( 0, "export_field9" ),
"OpenedProposals", new XVar( 0, "export_field10" ),
"ReportSubmittedto", new XVar( 0, "export_field11" ),
"ReportStatus", new XVar( 0, "export_field12" ),
"AbstractSigned", new XVar( 0, "export_field13" ),
"PostQualificationSigned", new XVar( 0, "export_field14" ),
"WrittenDissent", new XVar( 0, "export_field15" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "supertop", XVar.Array(),
"top", new XVar( 0, "export_header" ),
"grid", new XVar( 0, "export_field1",
1, "export_field2",
2, "export_field3",
3, "export_field4",
4, "export_field5",
5, "export_field6",
6, "export_field7",
7, "export_field8",
8, "export_field9",
9, "export_field10",
10, "export_field11",
11, "export_field12",
12, "export_field13",
13, "export_field14",
14, "export_field15" ),
"footer", new XVar( 0, "export_export",
1, "export_cancel" ) ),
"formXtTags", new XVar( "supertop", XVar.Array() ),
"itemForms", new XVar( "export_header", "top",
"export_field1", "grid",
"export_field2", "grid",
"export_field3", "grid",
"export_field4", "grid",
"export_field5", "grid",
"export_field6", "grid",
"export_field7", "grid",
"export_field8", "grid",
"export_field9", "grid",
"export_field10", "grid",
"export_field11", "grid",
"export_field12", "grid",
"export_field13", "grid",
"export_field14", "grid",
"export_field15", "grid",
"export_export", "footer",
"export_cancel", "footer" ),
"itemLocations", new XVar(  ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "export_header", new XVar( 0, "export_header" ),
"export_export", new XVar( 0, "export_export" ),
"export_cancel", new XVar( 0, "export_cancel" ),
"export_field", new XVar( 0, "export_field1",
1, "export_field2",
2, "export_field3",
3, "export_field4",
4, "export_field5",
5, "export_field6",
6, "export_field7",
7, "export_field8",
8, "export_field9",
9, "export_field10",
10, "export_field11",
11, "export_field12",
12, "export_field13",
13, "export_field14",
14, "export_field15" ) ),
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
"items", new XVar( 0, "export_field1",
1, "export_field2",
2, "export_field3",
3, "export_field4",
4, "export_field5",
5, "export_field6",
6, "export_field7",
7, "export_field8",
8, "export_field9",
9, "export_field10",
10, "export_field11",
11, "export_field12",
12, "export_field13",
13, "export_field14",
14, "export_field15" ) ) ),
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
"export_field1", new XVar( "field", "ObserverId",
"type", "export_field" ),
"export_field2", new XVar( "field", "ProcurementActivityId",
"type", "export_field" ),
"export_field3", new XVar( "field", "ReportDate",
"type", "export_field" ),
"export_field4", new XVar( "field", "ComplianceAssesment",
"type", "export_field" ),
"export_field5", new XVar( "field", "AreasOfImprovement",
"type", "export_field" ),
"export_field6", new XVar( "field", "BACMeetingsMinutes",
"type", "export_field" ),
"export_field7", new XVar( "field", "AbstractOfBids",
"type", "export_field" ),
"export_field8", new XVar( "field", "PostQualificationReport",
"type", "export_field" ),
"export_field9", new XVar( "field", "APPPPMPDocuments",
"type", "export_field" ),
"export_field10", new XVar( "field", "OpenedProposals",
"type", "export_field" ),
"export_field11", new XVar( "field", "ReportSubmittedto",
"type", "export_field" ),
"export_field12", new XVar( "field", "ReportStatus",
"type", "export_field" ),
"export_field13", new XVar( "field", "AbstractSigned",
"type", "export_field" ),
"export_field14", new XVar( "field", "PostQualificationSigned",
"type", "export_field" ),
"export_field15", new XVar( "field", "WrittenDissent",
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