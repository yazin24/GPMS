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
	public static partial class Settings_systemselections1
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["systemselections1"] = SettingsMap.GetArray();
			tdataArray["systemselections1"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["systemselections1"][".ShortName"] = "systemselections1";
			tdataArray["systemselections1"][".OwnerID"] = "";
			tdataArray["systemselections1"][".OriginalTable"] = "dbo.SystemSelections";
			tdataArray["systemselections1"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"list\":[\"list\"],\"search\":[\"search\"]}"));
			tdataArray["systemselections1"][".originalPagesByType"] = tdataArray["systemselections1"][".pagesByType"];
			tdataArray["systemselections1"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"list\":[\"list\"],\"search\":[\"search\"]}")));
			tdataArray["systemselections1"][".originalPages"] = tdataArray["systemselections1"][".pages"];
			tdataArray["systemselections1"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"list\":\"list\",\"search\":\"search\"}"));
			tdataArray["systemselections1"][".originalDefaultPages"] = tdataArray["systemselections1"][".defaultPages"];
			fieldLabelsArray["systemselections1"] = SettingsMap.GetArray();
			fieldToolTipsArray["systemselections1"] = SettingsMap.GetArray();
			pageTitlesArray["systemselections1"] = SettingsMap.GetArray();
			placeHoldersArray["systemselections1"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["systemselections1"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["systemselections1"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["systemselections1"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["systemselections1"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["systemselections1"]["English"]["NumericValue"] = "Numeric Value";
				fieldToolTipsArray["systemselections1"]["English"]["NumericValue"] = "";
				placeHoldersArray["systemselections1"]["English"]["NumericValue"] = "";
				fieldLabelsArray["systemselections1"]["English"]["DisplayValue"] = "Display Value";
				fieldToolTipsArray["systemselections1"]["English"]["DisplayValue"] = "";
				placeHoldersArray["systemselections1"]["English"]["DisplayValue"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["systemselections1"]["English"])))
				{
					tdataArray["systemselections1"][".isUseToolTips"] = true;
				}
			}
			tdataArray["systemselections1"][".NCSearch"] = true;
			tdataArray["systemselections1"][".shortTableName"] = "systemselections1";
			tdataArray["systemselections1"][".nSecOptions"] = 0;
			tdataArray["systemselections1"][".mainTableOwnerID"] = "";
			tdataArray["systemselections1"][".entityType"] = 1;
			tdataArray["systemselections1"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["systemselections1"][".strOriginalTableName"] = "dbo.SystemSelections";
			tdataArray["systemselections1"][".showAddInPopup"] = false;
			tdataArray["systemselections1"][".showEditInPopup"] = false;
			tdataArray["systemselections1"][".showViewInPopup"] = false;
			tdataArray["systemselections1"][".listAjax"] = false;
			tdataArray["systemselections1"][".audit"] = false;
			tdataArray["systemselections1"][".locking"] = false;
			GlobalVars.pages = tdataArray["systemselections1"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["systemselections1"][".edit"] = true;
				tdataArray["systemselections1"][".afterEditAction"] = 1;
				tdataArray["systemselections1"][".closePopupAfterEdit"] = 1;
				tdataArray["systemselections1"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["systemselections1"][".add"] = true;
				tdataArray["systemselections1"][".afterAddAction"] = 1;
				tdataArray["systemselections1"][".closePopupAfterAdd"] = 1;
				tdataArray["systemselections1"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["systemselections1"][".list"] = true;
			}
			tdataArray["systemselections1"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["systemselections1"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["systemselections1"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["systemselections1"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["systemselections1"][".printFriendly"] = true;
			}
			tdataArray["systemselections1"][".showSimpleSearchOptions"] = true;
			tdataArray["systemselections1"][".allowShowHideFields"] = true;
			tdataArray["systemselections1"][".allowFieldsReordering"] = true;
			tdataArray["systemselections1"][".isUseAjaxSuggest"] = true;


			tdataArray["systemselections1"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["systemselections1"][".buttonsAdded"] = false;
			tdataArray["systemselections1"][".addPageEvents"] = false;
			tdataArray["systemselections1"][".isUseTimeForSearch"] = false;
			tdataArray["systemselections1"][".badgeColor"] = "008B8B";
			tdataArray["systemselections1"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["systemselections1"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["systemselections1"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["systemselections1"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["systemselections1"][".googleLikeFields"].Add("NumericValue");
			tdataArray["systemselections1"][".googleLikeFields"].Add("DisplayValue");
			tdataArray["systemselections1"][".tableType"] = "list";
			tdataArray["systemselections1"][".printerPageOrientation"] = 0;
			tdataArray["systemselections1"][".nPrinterPageScale"] = 100;
			tdataArray["systemselections1"][".nPrinterSplitRecords"] = 40;
			tdataArray["systemselections1"][".geocodingEnabled"] = false;
			tdataArray["systemselections1"][".pageSize"] = 20;
			tdataArray["systemselections1"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["systemselections1"][".strOrderBy"] = tstrOrderBy;
			tdataArray["systemselections1"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["systemselections1"][".sqlHead"] = "SELECT NumericValue,  	DisplayValue";
			tdataArray["systemselections1"][".sqlFrom"] = "FROM dbo.SystemSelections";
			tdataArray["systemselections1"][".sqlWhereExpr"] = "";
			tdataArray["systemselections1"][".sqlTail"] = "";
			arrGridTabs = SettingsMap.GetArray();
			arrGridTabs.Add(new XVar("tabId", "", "name", "All data", "nameType", "Text", "where", "", "showRowCount", 0, "hideEmpty", 0));
			tdataArray["systemselections1"][".arrGridTabs"] = arrGridTabs;
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["systemselections1"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["systemselections1"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["systemselections1"][".highlightSearchResults"] = true;
			tableKeysArray["systemselections1"] = SettingsMap.GetArray();
			tdataArray["systemselections1"][".Keys"] = tableKeysArray["systemselections1"];
			tdataArray["systemselections1"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "NumericValue";
			fdata["GoodName"] = "NumericValue";
			fdata["ownerTable"] = "dbo.SystemSelections";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SystemSelections1","NumericValue");
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
			tdataArray["systemselections1"]["NumericValue"] = fdata;
			tdataArray["systemselections1"][".searchableFields"].Add("NumericValue");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "DisplayValue";
			fdata["GoodName"] = "DisplayValue";
			fdata["ownerTable"] = "dbo.SystemSelections";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SystemSelections1","DisplayValue");
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
			tdataArray["systemselections1"]["DisplayValue"] = fdata;
			tdataArray["systemselections1"][".searchableFields"].Add("DisplayValue");
			GlobalVars.tables_data["dbo.SystemSelections1"] = tdataArray["systemselections1"];
			GlobalVars.field_labels["dbo_SystemSelections1"] = fieldLabelsArray["systemselections1"];
			GlobalVars.fieldToolTips["dbo_SystemSelections1"] = fieldToolTipsArray["systemselections1"];
			GlobalVars.placeHolders["dbo_SystemSelections1"] = placeHoldersArray["systemselections1"];
			GlobalVars.page_titles["dbo_SystemSelections1"] = pageTitlesArray["systemselections1"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.SystemSelections1"));
			GlobalVars.detailsTablesData["dbo.SystemSelections1"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.SystemSelections1"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "NumericValue,  	DisplayValue";
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
obj = new SQLField(new XVar("m_strName", "NumericValue", "m_strTable", "dbo.SystemSelections", "m_srcTableName", "dbo.SystemSelections1"));

protoArray["6"]["m_sql"] = "NumericValue";
protoArray["6"]["m_srcTableName"] = "dbo.SystemSelections1";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "DisplayValue", "m_strTable", "dbo.SystemSelections", "m_srcTableName", "dbo.SystemSelections1"));

protoArray["8"]["m_sql"] = "DisplayValue";
protoArray["8"]["m_srcTableName"] = "dbo.SystemSelections1";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["10"] = SettingsMap.GetArray();
protoArray["10"]["m_link"] = "SQLL_MAIN";
protoArray["11"] = SettingsMap.GetArray();
protoArray["11"]["m_strName"] = "dbo.SystemSelections";
protoArray["11"]["m_srcTableName"] = "dbo.SystemSelections1";
protoArray["11"]["m_columns"] = SettingsMap.GetArray();
protoArray["11"]["m_columns"].Add("Id");
protoArray["11"]["m_columns"].Add("NumericValue");
protoArray["11"]["m_columns"].Add("DisplayValue");
protoArray["11"]["m_columns"].Add("PurposeValue");
obj = new SQLTable(protoArray["11"]);

protoArray["10"]["m_table"] = obj;
protoArray["10"]["m_sql"] = "dbo.SystemSelections";
protoArray["10"]["m_alias"] = "";
protoArray["10"]["m_srcTableName"] = "dbo.SystemSelections1";
protoArray["12"] = SettingsMap.GetArray();
protoArray["12"]["m_sql"] = "";
protoArray["12"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["12"]["m_column"] = obj;
protoArray["12"]["m_contained"] = SettingsMap.GetArray();
protoArray["12"]["m_strCase"] = "";
protoArray["12"]["m_havingmode"] = false;
protoArray["12"]["m_inBrackets"] = false;
protoArray["12"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["12"]);

protoArray["10"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["10"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.SystemSelections1";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["systemselections1"] = obj;

				
		
			tdataArray["systemselections1"][".sqlquery"] = queryData_Array["systemselections1"];
			tdataArray["systemselections1"][".hasEvents"] = false;
		}
	}

}
