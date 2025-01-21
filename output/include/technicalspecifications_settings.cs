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
	public static partial class Settings_technicalspecifications
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["technicalspecifications"] = SettingsMap.GetArray();
			tdataArray["technicalspecifications"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["technicalspecifications"][".ShortName"] = "technicalspecifications";
			tdataArray["technicalspecifications"][".OwnerID"] = "";
			tdataArray["technicalspecifications"][".OriginalTable"] = "dbo.TechnicalSpecifications";
			tdataArray["technicalspecifications"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["technicalspecifications"][".originalPagesByType"] = tdataArray["technicalspecifications"][".pagesByType"];
			tdataArray["technicalspecifications"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["technicalspecifications"][".originalPages"] = tdataArray["technicalspecifications"][".pages"];
			tdataArray["technicalspecifications"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["technicalspecifications"][".originalDefaultPages"] = tdataArray["technicalspecifications"][".defaultPages"];
			fieldLabelsArray["technicalspecifications"] = SettingsMap.GetArray();
			fieldToolTipsArray["technicalspecifications"] = SettingsMap.GetArray();
			pageTitlesArray["technicalspecifications"] = SettingsMap.GetArray();
			placeHoldersArray["technicalspecifications"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["technicalspecifications"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["technicalspecifications"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["technicalspecifications"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["technicalspecifications"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["technicalspecifications"]["English"]["Id"] = "Id";
				fieldToolTipsArray["technicalspecifications"]["English"]["Id"] = "";
				placeHoldersArray["technicalspecifications"]["English"]["Id"] = "";
				fieldLabelsArray["technicalspecifications"]["English"]["PbdId"] = "Pbd Id";
				fieldToolTipsArray["technicalspecifications"]["English"]["PbdId"] = "";
				placeHoldersArray["technicalspecifications"]["English"]["PbdId"] = "";
				fieldLabelsArray["technicalspecifications"]["English"]["ItemSpecification"] = "Item Specification";
				fieldToolTipsArray["technicalspecifications"]["English"]["ItemSpecification"] = "";
				placeHoldersArray["technicalspecifications"]["English"]["ItemSpecification"] = "";
				fieldLabelsArray["technicalspecifications"]["English"]["ComplianceStatement"] = "Compliance Statement";
				fieldToolTipsArray["technicalspecifications"]["English"]["ComplianceStatement"] = "";
				placeHoldersArray["technicalspecifications"]["English"]["ComplianceStatement"] = "";
				pageTitlesArray["technicalspecifications"]["English"]["list"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["technicalspecifications"]["English"])))
				{
					tdataArray["technicalspecifications"][".isUseToolTips"] = true;
				}
			}
			tdataArray["technicalspecifications"][".NCSearch"] = true;
			tdataArray["technicalspecifications"][".shortTableName"] = "technicalspecifications";
			tdataArray["technicalspecifications"][".nSecOptions"] = 0;
			tdataArray["technicalspecifications"][".mainTableOwnerID"] = "";
			tdataArray["technicalspecifications"][".entityType"] = 0;
			tdataArray["technicalspecifications"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["technicalspecifications"][".strOriginalTableName"] = "dbo.TechnicalSpecifications";
			tdataArray["technicalspecifications"][".showAddInPopup"] = false;
			tdataArray["technicalspecifications"][".showEditInPopup"] = false;
			tdataArray["technicalspecifications"][".showViewInPopup"] = false;
			tdataArray["technicalspecifications"][".listAjax"] = false;
			tdataArray["technicalspecifications"][".audit"] = false;
			tdataArray["technicalspecifications"][".locking"] = false;
			GlobalVars.pages = tdataArray["technicalspecifications"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["technicalspecifications"][".edit"] = true;
				tdataArray["technicalspecifications"][".afterEditAction"] = 0;
				tdataArray["technicalspecifications"][".closePopupAfterEdit"] = 1;
				tdataArray["technicalspecifications"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["technicalspecifications"][".add"] = true;
				tdataArray["technicalspecifications"][".afterAddAction"] = 0;
				tdataArray["technicalspecifications"][".closePopupAfterAdd"] = 1;
				tdataArray["technicalspecifications"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["technicalspecifications"][".list"] = true;
			}
			tdataArray["technicalspecifications"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["technicalspecifications"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["technicalspecifications"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["technicalspecifications"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["technicalspecifications"][".printFriendly"] = true;
			}
			tdataArray["technicalspecifications"][".showSimpleSearchOptions"] = true;
			tdataArray["technicalspecifications"][".allowShowHideFields"] = true;
			tdataArray["technicalspecifications"][".allowFieldsReordering"] = true;
			tdataArray["technicalspecifications"][".isUseAjaxSuggest"] = true;


			tdataArray["technicalspecifications"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["technicalspecifications"][".buttonsAdded"] = false;
			tdataArray["technicalspecifications"][".addPageEvents"] = true;
			tdataArray["technicalspecifications"][".isUseTimeForSearch"] = false;
			tdataArray["technicalspecifications"][".badgeColor"] = "4682B4";
			tdataArray["technicalspecifications"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["technicalspecifications"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["technicalspecifications"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["technicalspecifications"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["technicalspecifications"][".googleLikeFields"].Add("Id");
			tdataArray["technicalspecifications"][".googleLikeFields"].Add("PbdId");
			tdataArray["technicalspecifications"][".googleLikeFields"].Add("ItemSpecification");
			tdataArray["technicalspecifications"][".googleLikeFields"].Add("ComplianceStatement");
			tdataArray["technicalspecifications"][".tableType"] = "list";
			tdataArray["technicalspecifications"][".printerPageOrientation"] = 0;
			tdataArray["technicalspecifications"][".nPrinterPageScale"] = 100;
			tdataArray["technicalspecifications"][".nPrinterSplitRecords"] = 40;
			tdataArray["technicalspecifications"][".geocodingEnabled"] = false;
			tdataArray["technicalspecifications"][".pageSize"] = 20;
			tdataArray["technicalspecifications"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["technicalspecifications"][".strOrderBy"] = tstrOrderBy;
			tdataArray["technicalspecifications"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["technicalspecifications"][".sqlHead"] = "SELECT Id,  	PbdId,  	ItemSpecification,  	ComplianceStatement";
			tdataArray["technicalspecifications"][".sqlFrom"] = "FROM dbo.TechnicalSpecifications";
			tdataArray["technicalspecifications"][".sqlWhereExpr"] = "";
			tdataArray["technicalspecifications"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["technicalspecifications"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["technicalspecifications"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["technicalspecifications"][".highlightSearchResults"] = true;
			tableKeysArray["technicalspecifications"] = SettingsMap.GetArray();
			tableKeysArray["technicalspecifications"].Add("Id");
			tdataArray["technicalspecifications"][".Keys"] = tableKeysArray["technicalspecifications"];
			tdataArray["technicalspecifications"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Id";
			fdata["GoodName"] = "Id";
			fdata["ownerTable"] = "dbo.TechnicalSpecifications";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TechnicalSpecifications","Id");
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
			tdataArray["technicalspecifications"]["Id"] = fdata;
			tdataArray["technicalspecifications"][".searchableFields"].Add("Id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "PbdId";
			fdata["GoodName"] = "PbdId";
			fdata["ownerTable"] = "dbo.TechnicalSpecifications";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TechnicalSpecifications","PbdId");
			fdata["FieldType"] = 3;
			fdata["strField"] = "PbdId";
			fdata["sourceSingle"] = "PbdId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "PbdId";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "");
			vdata["NeedEncode"] = true;
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.PhilippineBiddingDocument";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "Id";
			edata["LinkFieldType"] = 3;
			edata["DisplayField"] = "ProjectName";
			edata["LookupOrderBy"] = "";
			edata["SelectSize"] = 1;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
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
			tdataArray["technicalspecifications"]["PbdId"] = fdata;
			tdataArray["technicalspecifications"][".searchableFields"].Add("PbdId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "ItemSpecification";
			fdata["GoodName"] = "ItemSpecification";
			fdata["ownerTable"] = "dbo.TechnicalSpecifications";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TechnicalSpecifications","ItemSpecification");
			fdata["FieldType"] = 200;
			fdata["strField"] = "ItemSpecification";
			fdata["sourceSingle"] = "ItemSpecification";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ItemSpecification";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Custom");
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Text field");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 0;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
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
			tdataArray["technicalspecifications"]["ItemSpecification"] = fdata;
			tdataArray["technicalspecifications"][".searchableFields"].Add("ItemSpecification");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "ComplianceStatement";
			fdata["GoodName"] = "ComplianceStatement";
			fdata["ownerTable"] = "dbo.TechnicalSpecifications";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TechnicalSpecifications","ComplianceStatement");
			fdata["FieldType"] = 11;
			fdata["strField"] = "ComplianceStatement";
			fdata["sourceSingle"] = "ComplianceStatement";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ComplianceStatement";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Custom");
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.SystemSelections";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 4;
			edata["HorizontalLookup"] = true;
			edata["LinkField"] = "NumericValue";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "DisplayValue";
			edata["LookupWhere"] = "PurposeValue = 'YES AND NO SELECTION'";
			edata["LookupOrderBy"] = "";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterFormat"] = "Options list";
			fdata["showCollapsed"] = false;
			fdata["filterCheckedMessageType"] = "Text";
			fdata["filterCheckedMessageText"] = "Checked";
			fdata["filterUncheckedMessageType"] = "Text";
			fdata["filterUncheckedMessageText"] = "Unchecked";
			tdataArray["technicalspecifications"]["ComplianceStatement"] = fdata;
			tdataArray["technicalspecifications"][".searchableFields"].Add("ComplianceStatement");
			GlobalVars.tables_data["dbo.TechnicalSpecifications"] = tdataArray["technicalspecifications"];
			GlobalVars.field_labels["dbo_TechnicalSpecifications"] = fieldLabelsArray["technicalspecifications"];
			GlobalVars.fieldToolTips["dbo_TechnicalSpecifications"] = fieldToolTipsArray["technicalspecifications"];
			GlobalVars.placeHolders["dbo_TechnicalSpecifications"] = placeHoldersArray["technicalspecifications"];
			GlobalVars.page_titles["dbo_TechnicalSpecifications"] = pageTitlesArray["technicalspecifications"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.TechnicalSpecifications"));
			GlobalVars.detailsTablesData["dbo.TechnicalSpecifications"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.TechnicalSpecifications"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.PhilippineBiddingDocument";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.PhilippineBiddingDocument";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "philippinebiddingdocument";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.TechnicalSpecifications"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.TechnicalSpecifications"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.TechnicalSpecifications"][0]["masterKeys"].Add("Id");
			GlobalVars.masterTablesData["dbo.TechnicalSpecifications"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.TechnicalSpecifications"][0]["detailKeys"].Add("PbdId");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Id,  	PbdId,  	ItemSpecification,  	ComplianceStatement";
protoArray["0"]["m_strFrom"] = "FROM dbo.TechnicalSpecifications";
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
obj = new SQLField(new XVar("m_strName", "Id", "m_strTable", "dbo.TechnicalSpecifications", "m_srcTableName", "dbo.TechnicalSpecifications"));

protoArray["6"]["m_sql"] = "Id";
protoArray["6"]["m_srcTableName"] = "dbo.TechnicalSpecifications";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "PbdId", "m_strTable", "dbo.TechnicalSpecifications", "m_srcTableName", "dbo.TechnicalSpecifications"));

protoArray["8"]["m_sql"] = "PbdId";
protoArray["8"]["m_srcTableName"] = "dbo.TechnicalSpecifications";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ItemSpecification", "m_strTable", "dbo.TechnicalSpecifications", "m_srcTableName", "dbo.TechnicalSpecifications"));

protoArray["10"]["m_sql"] = "ItemSpecification";
protoArray["10"]["m_srcTableName"] = "dbo.TechnicalSpecifications";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ComplianceStatement", "m_strTable", "dbo.TechnicalSpecifications", "m_srcTableName", "dbo.TechnicalSpecifications"));

protoArray["12"]["m_sql"] = "ComplianceStatement";
protoArray["12"]["m_srcTableName"] = "dbo.TechnicalSpecifications";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["14"] = SettingsMap.GetArray();
protoArray["14"]["m_link"] = "SQLL_MAIN";
protoArray["15"] = SettingsMap.GetArray();
protoArray["15"]["m_strName"] = "dbo.TechnicalSpecifications";
protoArray["15"]["m_srcTableName"] = "dbo.TechnicalSpecifications";
protoArray["15"]["m_columns"] = SettingsMap.GetArray();
protoArray["15"]["m_columns"].Add("Id");
protoArray["15"]["m_columns"].Add("PbdId");
protoArray["15"]["m_columns"].Add("ItemSpecification");
protoArray["15"]["m_columns"].Add("ComplianceStatement");
obj = new SQLTable(protoArray["15"]);

protoArray["14"]["m_table"] = obj;
protoArray["14"]["m_sql"] = "dbo.TechnicalSpecifications";
protoArray["14"]["m_alias"] = "";
protoArray["14"]["m_srcTableName"] = "dbo.TechnicalSpecifications";
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
protoArray["0"]["m_srcTableName"] = "dbo.TechnicalSpecifications";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["technicalspecifications"] = obj;

				
		
			tdataArray["technicalspecifications"][".sqlquery"] = queryData_Array["technicalspecifications"];
			tdataArray["technicalspecifications"][".hasEvents"] = true;
		}
	}

}
