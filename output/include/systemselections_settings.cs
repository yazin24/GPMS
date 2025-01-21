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
	public static partial class Settings_systemselections
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["systemselections"] = SettingsMap.GetArray();
			tdataArray["systemselections"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["systemselections"][".ShortName"] = "systemselections";
			tdataArray["systemselections"][".OwnerID"] = "";
			tdataArray["systemselections"][".OriginalTable"] = "dbo.SystemSelections";
			tdataArray["systemselections"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"list\":[\"list\"],\"search\":[\"search\"]}"));
			tdataArray["systemselections"][".originalPagesByType"] = tdataArray["systemselections"][".pagesByType"];
			tdataArray["systemselections"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"list\":[\"list\"],\"search\":[\"search\"]}")));
			tdataArray["systemselections"][".originalPages"] = tdataArray["systemselections"][".pages"];
			tdataArray["systemselections"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"list\":\"list\",\"search\":\"search\"}"));
			tdataArray["systemselections"][".originalDefaultPages"] = tdataArray["systemselections"][".defaultPages"];
			fieldLabelsArray["systemselections"] = SettingsMap.GetArray();
			fieldToolTipsArray["systemselections"] = SettingsMap.GetArray();
			pageTitlesArray["systemselections"] = SettingsMap.GetArray();
			placeHoldersArray["systemselections"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["systemselections"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["systemselections"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["systemselections"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["systemselections"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["systemselections"]["English"]["Id"] = "Id";
				fieldToolTipsArray["systemselections"]["English"]["Id"] = "";
				placeHoldersArray["systemselections"]["English"]["Id"] = "";
				fieldLabelsArray["systemselections"]["English"]["NumericValue"] = "Numeric Value";
				fieldToolTipsArray["systemselections"]["English"]["NumericValue"] = "";
				placeHoldersArray["systemselections"]["English"]["NumericValue"] = "";
				fieldLabelsArray["systemselections"]["English"]["DisplayValue"] = "Display Value";
				fieldToolTipsArray["systemselections"]["English"]["DisplayValue"] = "";
				placeHoldersArray["systemselections"]["English"]["DisplayValue"] = "";
				fieldLabelsArray["systemselections"]["English"]["PurposeValue"] = "Purpose Value";
				fieldToolTipsArray["systemselections"]["English"]["PurposeValue"] = "";
				placeHoldersArray["systemselections"]["English"]["PurposeValue"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["systemselections"]["English"])))
				{
					tdataArray["systemselections"][".isUseToolTips"] = true;
				}
			}
			tdataArray["systemselections"][".NCSearch"] = true;
			tdataArray["systemselections"][".shortTableName"] = "systemselections";
			tdataArray["systemselections"][".nSecOptions"] = 0;
			tdataArray["systemselections"][".mainTableOwnerID"] = "";
			tdataArray["systemselections"][".entityType"] = 0;
			tdataArray["systemselections"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["systemselections"][".strOriginalTableName"] = "dbo.SystemSelections";
			tdataArray["systemselections"][".showAddInPopup"] = false;
			tdataArray["systemselections"][".showEditInPopup"] = false;
			tdataArray["systemselections"][".showViewInPopup"] = false;
			tdataArray["systemselections"][".listAjax"] = false;
			tdataArray["systemselections"][".audit"] = false;
			tdataArray["systemselections"][".locking"] = false;
			GlobalVars.pages = tdataArray["systemselections"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["systemselections"][".edit"] = true;
				tdataArray["systemselections"][".afterEditAction"] = 0;
				tdataArray["systemselections"][".closePopupAfterEdit"] = 1;
				tdataArray["systemselections"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["systemselections"][".add"] = true;
				tdataArray["systemselections"][".afterAddAction"] = 0;
				tdataArray["systemselections"][".closePopupAfterAdd"] = 1;
				tdataArray["systemselections"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["systemselections"][".list"] = true;
			}
			tdataArray["systemselections"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["systemselections"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["systemselections"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["systemselections"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["systemselections"][".printFriendly"] = true;
			}
			tdataArray["systemselections"][".showSimpleSearchOptions"] = true;
			tdataArray["systemselections"][".allowShowHideFields"] = true;
			tdataArray["systemselections"][".allowFieldsReordering"] = true;
			tdataArray["systemselections"][".isUseAjaxSuggest"] = true;


			tdataArray["systemselections"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["systemselections"][".buttonsAdded"] = false;
			tdataArray["systemselections"][".addPageEvents"] = false;
			tdataArray["systemselections"][".isUseTimeForSearch"] = false;
			tdataArray["systemselections"][".badgeColor"] = "E8926F";
			tdataArray["systemselections"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["systemselections"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["systemselections"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["systemselections"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["systemselections"][".googleLikeFields"].Add("Id");
			tdataArray["systemselections"][".googleLikeFields"].Add("NumericValue");
			tdataArray["systemselections"][".googleLikeFields"].Add("DisplayValue");
			tdataArray["systemselections"][".googleLikeFields"].Add("PurposeValue");
			tdataArray["systemselections"][".tableType"] = "list";
			tdataArray["systemselections"][".printerPageOrientation"] = 0;
			tdataArray["systemselections"][".nPrinterPageScale"] = 100;
			tdataArray["systemselections"][".nPrinterSplitRecords"] = 40;
			tdataArray["systemselections"][".geocodingEnabled"] = false;
			tdataArray["systemselections"][".pageSize"] = 20;
			tdataArray["systemselections"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["systemselections"][".strOrderBy"] = tstrOrderBy;
			tdataArray["systemselections"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["systemselections"][".sqlHead"] = "SELECT Id,  	NumericValue,  	DisplayValue,  	PurposeValue";
			tdataArray["systemselections"][".sqlFrom"] = "FROM dbo.SystemSelections";
			tdataArray["systemselections"][".sqlWhereExpr"] = "";
			tdataArray["systemselections"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["systemselections"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["systemselections"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["systemselections"][".highlightSearchResults"] = true;
			tableKeysArray["systemselections"] = SettingsMap.GetArray();
			tableKeysArray["systemselections"].Add("Id");
			tdataArray["systemselections"][".Keys"] = tableKeysArray["systemselections"];
			tdataArray["systemselections"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Id";
			fdata["GoodName"] = "Id";
			fdata["ownerTable"] = "dbo.SystemSelections";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SystemSelections","Id");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "Id";
			fdata["sourceSingle"] = "Id";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Id";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["IsRequired"] = true;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["systemselections"]["Id"] = fdata;
			tdataArray["systemselections"][".searchableFields"].Add("Id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "NumericValue";
			fdata["GoodName"] = "NumericValue";
			fdata["ownerTable"] = "dbo.SystemSelections";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SystemSelections","NumericValue");
			fdata["FieldType"] = 3;
			fdata["strField"] = "NumericValue";
			fdata["sourceSingle"] = "NumericValue";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "NumericValue";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add(CommonFunctions.getJsValidatorName(new XVar("Number")));
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["systemselections"]["NumericValue"] = fdata;
			tdataArray["systemselections"][".searchableFields"].Add("NumericValue");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "DisplayValue";
			fdata["GoodName"] = "DisplayValue";
			fdata["ownerTable"] = "dbo.SystemSelections";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SystemSelections","DisplayValue");
			fdata["FieldType"] = 200;
			fdata["strField"] = "DisplayValue";
			fdata["sourceSingle"] = "DisplayValue";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "DisplayValue";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text area");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 0;
			edata["nRows"] = 100;
			edata["nCols"] = 200;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["CreateThumbnail"] = true;
			edata["StrThumbnail"] = "th";
			edata["ThumbnailSize"] = 600;
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["systemselections"]["DisplayValue"] = fdata;
			tdataArray["systemselections"][".searchableFields"].Add("DisplayValue");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "PurposeValue";
			fdata["GoodName"] = "PurposeValue";
			fdata["ownerTable"] = "dbo.SystemSelections";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SystemSelections","PurposeValue");
			fdata["FieldType"] = 200;
			fdata["strField"] = "PurposeValue";
			fdata["sourceSingle"] = "PurposeValue";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "PurposeValue";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text area");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 0;
			edata["nRows"] = 100;
			edata["nCols"] = 200;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["CreateThumbnail"] = true;
			edata["StrThumbnail"] = "th";
			edata["ThumbnailSize"] = 600;
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["systemselections"]["PurposeValue"] = fdata;
			tdataArray["systemselections"][".searchableFields"].Add("PurposeValue");
			GlobalVars.tables_data["dbo.SystemSelections"] = tdataArray["systemselections"];
			GlobalVars.field_labels["dbo_SystemSelections"] = fieldLabelsArray["systemselections"];
			GlobalVars.fieldToolTips["dbo_SystemSelections"] = fieldToolTipsArray["systemselections"];
			GlobalVars.placeHolders["dbo_SystemSelections"] = placeHoldersArray["systemselections"];
			GlobalVars.page_titles["dbo_SystemSelections"] = pageTitlesArray["systemselections"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.SystemSelections"));
			GlobalVars.detailsTablesData["dbo.SystemSelections"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.SystemSelections"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Id,  	NumericValue,  	DisplayValue,  	PurposeValue";
protoArray["0"]["m_strFrom"] = "FROM dbo.SystemSelections";
protoArray["0"]["m_strWhere"] = "";
protoArray["0"]["m_strOrderBy"] = "";
	
		
protoArray["0"]["cipherer"] = null;
protoArray["2"] = SettingsMap.GetArray();
protoArray["2"]["m_sql"] = "";
protoArray["2"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["2"]["m_column"] = obj;
protoArray["2"]["m_contained"] = SettingsMap.GetArray();
protoArray["2"]["m_strCase"] = "";
protoArray["2"]["m_havingmode"] = false;
protoArray["2"]["m_inBrackets"] = false;
protoArray["2"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["2"]);

protoArray["0"]["m_where"] = obj;
protoArray["4"] = SettingsMap.GetArray();
protoArray["4"]["m_sql"] = "";
protoArray["4"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["4"]["m_column"] = obj;
protoArray["4"]["m_contained"] = SettingsMap.GetArray();
protoArray["4"]["m_strCase"] = "";
protoArray["4"]["m_havingmode"] = false;
protoArray["4"]["m_inBrackets"] = false;
protoArray["4"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["4"]);

protoArray["0"]["m_having"] = obj;
protoArray["0"]["m_fieldlist"] = SettingsMap.GetArray();
protoArray["6"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Id", "m_strTable", "dbo.SystemSelections", "m_srcTableName", "dbo.SystemSelections"));

protoArray["6"]["m_sql"] = "Id";
protoArray["6"]["m_srcTableName"] = "dbo.SystemSelections";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "NumericValue", "m_strTable", "dbo.SystemSelections", "m_srcTableName", "dbo.SystemSelections"));

protoArray["8"]["m_sql"] = "NumericValue";
protoArray["8"]["m_srcTableName"] = "dbo.SystemSelections";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "DisplayValue", "m_strTable", "dbo.SystemSelections", "m_srcTableName", "dbo.SystemSelections"));

protoArray["10"]["m_sql"] = "DisplayValue";
protoArray["10"]["m_srcTableName"] = "dbo.SystemSelections";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "PurposeValue", "m_strTable", "dbo.SystemSelections", "m_srcTableName", "dbo.SystemSelections"));

protoArray["12"]["m_sql"] = "PurposeValue";
protoArray["12"]["m_srcTableName"] = "dbo.SystemSelections";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "dbo.SystemSelections";
protoArray["15"]["m_srcTableName"] = "dbo.SystemSelections";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("Id");
protoArray["15"]["m_columns"].Add("NumericValue");
protoArray["15"]["m_columns"].Add("DisplayValue");
protoArray["15"]["m_columns"].Add("PurposeValue");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "dbo.SystemSelections";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "dbo.SystemSelections";
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_sql"] = "";
protoArray["16"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["16"]["m_column"] = obj;
protoArray["16"]["m_contained"] = SettingsMap.GetArray();
protoArray["16"]["m_strCase"] = "";
protoArray["16"]["m_havingmode"] = false;
protoArray["16"]["m_inBrackets"] = false;
protoArray["16"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["16"]);

protoArray["14"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["14"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.SystemSelections";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["systemselections"] = obj;

				
		
			tdataArray["systemselections"][".sqlquery"] = queryData_Array["systemselections"];
			tdataArray["systemselections"][".hasEvents"] = false;
		}
	}

}
