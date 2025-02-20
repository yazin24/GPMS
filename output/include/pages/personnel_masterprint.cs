
		// dbo.Personnel
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
			public static partial class Options_personnel_masterprint
			{
				static public XVar options()
				{
					return new XVar( "fields", new XVar( "gridFields", new XVar( 0, "Name",
1, "Integrity",
2, "Proficiency",
3, "CivilServiceQualification",
4, "Rank",
5, "TrainingDetails",
6, "Id" ),
"searchRequiredFields", XVar.Array(),
"searchPanelFields", XVar.Array(),
"fieldItems", new XVar( "Name", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field8" ),
"Integrity", new XVar( 0, "simple_grid_field3",
1, "simple_grid_field9" ),
"Proficiency", new XVar( 0, "simple_grid_field4",
1, "simple_grid_field10" ),
"CivilServiceQualification", new XVar( 0, "simple_grid_field5",
1, "simple_grid_field11" ),
"Rank", new XVar( 0, "simple_grid_field6",
1, "simple_grid_field12" ),
"TrainingDetails", new XVar( 0, "simple_grid_field7",
1, "simple_grid_field13" ),
"Id", new XVar( 0, "simple_grid_field",
1, "simple_grid_field1" ) ) ),
"pageLinks", new XVar( "edit", false,
"add", false,
"view", false,
"print", false ),
"layoutHelper", new XVar( "formItems", new XVar( "formItems", new XVar( "above-grid", XVar.Array(),
"below-grid", XVar.Array(),
"top", new XVar( 0, "masterprint_header" ),
"grid", new XVar( 0, "simple_grid_field8",
1, "simple_grid_field2",
2, "simple_grid_field9",
3, "simple_grid_field3",
4, "simple_grid_field10",
5, "simple_grid_field4",
6, "simple_grid_field11",
7, "simple_grid_field5",
8, "simple_grid_field12",
9, "simple_grid_field6",
10, "simple_grid_field13",
11, "simple_grid_field7",
12, "simple_grid_field1",
13, "simple_grid_field" ) ),
"formXtTags", new XVar( "above-grid", XVar.Array(),
"below-grid", XVar.Array() ),
"itemForms", new XVar( "masterprint_header", "top",
"simple_grid_field8", "grid",
"simple_grid_field2", "grid",
"simple_grid_field9", "grid",
"simple_grid_field3", "grid",
"simple_grid_field10", "grid",
"simple_grid_field4", "grid",
"simple_grid_field11", "grid",
"simple_grid_field5", "grid",
"simple_grid_field12", "grid",
"simple_grid_field6", "grid",
"simple_grid_field13", "grid",
"simple_grid_field7", "grid",
"simple_grid_field1", "grid",
"simple_grid_field", "grid" ),
"itemLocations", new XVar( "simple_grid_field8", new XVar( "location", "grid",
"cellId", "headcell_field" ),
"simple_grid_field2", new XVar( "location", "grid",
"cellId", "cell_field" ),
"simple_grid_field9", new XVar( "location", "grid",
"cellId", "headcell_field1" ),
"simple_grid_field3", new XVar( "location", "grid",
"cellId", "cell_field1" ),
"simple_grid_field10", new XVar( "location", "grid",
"cellId", "headcell_field2" ),
"simple_grid_field4", new XVar( "location", "grid",
"cellId", "cell_field2" ),
"simple_grid_field11", new XVar( "location", "grid",
"cellId", "headcell_field3" ),
"simple_grid_field5", new XVar( "location", "grid",
"cellId", "cell_field3" ),
"simple_grid_field12", new XVar( "location", "grid",
"cellId", "headcell_field4" ),
"simple_grid_field6", new XVar( "location", "grid",
"cellId", "cell_field4" ),
"simple_grid_field13", new XVar( "location", "grid",
"cellId", "headcell_field5" ),
"simple_grid_field7", new XVar( "location", "grid",
"cellId", "cell_field5" ),
"simple_grid_field1", new XVar( "location", "grid",
"cellId", "headcell_field6" ),
"simple_grid_field", new XVar( "location", "grid",
"cellId", "cell_field6" ) ),
"itemVisiblity", new XVar(  ) ),
"itemsByType", new XVar( "masterprint_header", new XVar( 0, "masterprint_header" ),
"grid_field", new XVar( 0, "simple_grid_field2",
1, "simple_grid_field3",
2, "simple_grid_field4",
3, "simple_grid_field5",
4, "simple_grid_field6",
5, "simple_grid_field7",
6, "simple_grid_field" ),
"grid_field_label", new XVar( 0, "simple_grid_field8",
1, "simple_grid_field9",
2, "simple_grid_field10",
3, "simple_grid_field11",
4, "simple_grid_field12",
5, "simple_grid_field13",
6, "simple_grid_field1" ) ),
"cellMaps", new XVar( "grid", new XVar( "cells", new XVar( "headcell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "Name_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field8" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "Integrity_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field9" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "Proficiency_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field10" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "CivilServiceQualification_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field11" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "Rank_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field12" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field5", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "TrainingDetails_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field13" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"headcell_field6", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 0 ),
"tags", new XVar( 0, "Id_fieldheadercolumn" ),
"items", new XVar( 0, "simple_grid_field1" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "Name_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field2" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field1", new XVar( "cols", new XVar( 0, 1 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "Integrity_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field3" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field2", new XVar( "cols", new XVar( 0, 2 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "Proficiency_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field4" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "CivilServiceQualification_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field5" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "Rank_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field6" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field5", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "TrainingDetails_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field7" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"cell_field6", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 1 ),
"tags", new XVar( 0, "Id_fieldcolumn" ),
"items", new XVar( 0, "simple_grid_field" ),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field", new XVar( "cols", new XVar( 0, 0 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field1", new XVar( "cols", new XVar( 0, 1 ),
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
"footcell_field3", new XVar( "cols", new XVar( 0, 3 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field4", new XVar( "cols", new XVar( 0, 4 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field5", new XVar( "cols", new XVar( 0, 5 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ),
"footcell_field6", new XVar( "cols", new XVar( 0, 6 ),
"rows", new XVar( 0, 2 ),
"tags", XVar.Array(),
"items", XVar.Array(),
"fixedAtServer", false,
"fixedAtClient", false ) ),
"width", 7,
"height", 3 ) ) ),
"page", new XVar( "verticalBar", false,
"labeledButtons", new XVar( "update_records", new XVar(  ),
"print_pages", new XVar(  ),
"register_activate_message", new XVar(  ),
"details_found", new XVar(  ) ),
"gridType", 0,
"hasCustomButtons", false,
"customButtons", XVar.Array(),
"hasNotifications", false,
"menus", XVar.Array(),
"calcTotalsFor", 1 ),
"misc", new XVar( "type", "masterprint",
"breadcrumb", false ),
"events", new XVar( "maps", XVar.Array(),
"mapsData", new XVar(  ),
"buttons", XVar.Array() ) );
				}
				static public XVar page()
				{
					return new XVar( "id", "masterprint",
"type", "masterprint",
"layoutId", "masterprint",
"disabled", 0,
"default", 0,
"forms", new XVar( "above-grid", new XVar( "modelId", "empty-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"below-grid", new XVar( "modelId", "empty-above-grid",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"top", new XVar( "modelId", "masterlist-top",
"grid", new XVar( 0, new XVar( "cells", new XVar( 0, new XVar( "cell", "c1" ) ),
"section", "" ) ),
"cells", new XVar( "c1", new XVar( "model", "c1",
"items", new XVar( 0, "masterprint_header" ) ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ),
"grid", new XVar( "modelId", "horizontal-grid",
"grid", new XVar( 0, new XVar( "section", "head",
"cells", new XVar( 0, new XVar( "cell", "headcell_field" ),
1, new XVar( "cell", "headcell_field1" ),
2, new XVar( "cell", "headcell_field2" ),
3, new XVar( "cell", "headcell_field3" ),
4, new XVar( "cell", "headcell_field4" ),
5, new XVar( "cell", "headcell_field5" ),
6, new XVar( "cell", "headcell_field6" ) ) ),
1, new XVar( "section", "body",
"cells", new XVar( 0, new XVar( "cell", "cell_field" ),
1, new XVar( "cell", "cell_field1" ),
2, new XVar( "cell", "cell_field2" ),
3, new XVar( "cell", "cell_field3" ),
4, new XVar( "cell", "cell_field4" ),
5, new XVar( "cell", "cell_field5" ),
6, new XVar( "cell", "cell_field6" ) ) ),
2, new XVar( "section", "foot",
"cells", new XVar( 0, new XVar( "cell", "footcell_field" ),
1, new XVar( "cell", "footcell_field1" ),
2, new XVar( "cell", "footcell_field2" ),
3, new XVar( "cell", "footcell_field3" ),
4, new XVar( "cell", "footcell_field4" ),
5, new XVar( "cell", "footcell_field5" ),
6, new XVar( "cell", "footcell_field6" ) ) ) ),
"cells", new XVar( "headcell_field", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field8" ),
"field", "Name",
"columnName", "field" ),
"cell_field", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field2" ),
"field", "Name",
"columnName", "field" ),
"footcell_field", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field1", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field9" ),
"field", "Integrity",
"columnName", "field" ),
"cell_field1", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field3" ),
"field", "Integrity",
"columnName", "field" ),
"footcell_field1", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field2", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field10" ),
"field", "Proficiency",
"columnName", "field" ),
"cell_field2", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field4" ),
"field", "Proficiency",
"columnName", "field" ),
"footcell_field2", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field3", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field11" ),
"field", "CivilServiceQualification",
"columnName", "field" ),
"cell_field3", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field5" ),
"field", "CivilServiceQualification",
"columnName", "field" ),
"footcell_field3", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field4", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field12" ),
"field", "Rank",
"columnName", "field" ),
"cell_field4", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field6" ),
"field", "Rank",
"columnName", "field" ),
"footcell_field4", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field5", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field13" ),
"field", "TrainingDetails",
"columnName", "field" ),
"cell_field5", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field7" ),
"field", "TrainingDetails",
"columnName", "field" ),
"footcell_field5", new XVar( "model", "footcell_field",
"items", XVar.Array() ),
"headcell_field6", new XVar( "model", "headcell_field",
"items", new XVar( 0, "simple_grid_field1" ),
"field", "Id",
"columnName", "field" ),
"cell_field6", new XVar( "model", "cell_field",
"items", new XVar( 0, "simple_grid_field" ),
"field", "Id",
"columnName", "field" ),
"footcell_field6", new XVar( "model", "footcell_field",
"items", XVar.Array() ) ),
"deferredItems", XVar.Array(),
"recsPerRow", 1 ) ),
"items", new XVar( "masterprint_header", new XVar( "type", "masterprint_header" ),
"simple_grid_field2", new XVar( "field", "Name",
"type", "grid_field" ),
"simple_grid_field8", new XVar( "type", "grid_field_label",
"field", "Name" ),
"simple_grid_field3", new XVar( "field", "Integrity",
"type", "grid_field" ),
"simple_grid_field9", new XVar( "type", "grid_field_label",
"field", "Integrity" ),
"simple_grid_field4", new XVar( "field", "Proficiency",
"type", "grid_field" ),
"simple_grid_field10", new XVar( "type", "grid_field_label",
"field", "Proficiency" ),
"simple_grid_field5", new XVar( "field", "CivilServiceQualification",
"type", "grid_field" ),
"simple_grid_field11", new XVar( "type", "grid_field_label",
"field", "CivilServiceQualification" ),
"simple_grid_field6", new XVar( "field", "Rank",
"type", "grid_field" ),
"simple_grid_field12", new XVar( "type", "grid_field_label",
"field", "Rank" ),
"simple_grid_field7", new XVar( "field", "TrainingDetails",
"type", "grid_field" ),
"simple_grid_field13", new XVar( "type", "grid_field_label",
"field", "TrainingDetails" ),
"simple_grid_field", new XVar( "field", "Id",
"type", "grid_field" ),
"simple_grid_field1", new XVar( "type", "grid_field_label",
"field", "Id" ) ),
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