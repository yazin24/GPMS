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
	public static partial class Settings_procurementunit
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["procurementunit"] = SettingsMap.GetArray();
			tdataArray["procurementunit"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["procurementunit"][".ShortName"] = "procurementunit";
			tdataArray["procurementunit"][".OwnerID"] = "";
			tdataArray["procurementunit"][".OriginalTable"] = "dbo.ProcurementUnit";
			tdataArray["procurementunit"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["procurementunit"][".originalPagesByType"] = tdataArray["procurementunit"][".pagesByType"];
			tdataArray["procurementunit"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["procurementunit"][".originalPages"] = tdataArray["procurementunit"][".pages"];
			tdataArray["procurementunit"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["procurementunit"][".originalDefaultPages"] = tdataArray["procurementunit"][".defaultPages"];
			fieldLabelsArray["procurementunit"] = SettingsMap.GetArray();
			fieldToolTipsArray["procurementunit"] = SettingsMap.GetArray();
			pageTitlesArray["procurementunit"] = SettingsMap.GetArray();
			placeHoldersArray["procurementunit"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["procurementunit"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["procurementunit"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["procurementunit"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["procurementunit"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["procurementunit"]["English"]["UnitId"] = "Unit Id";
				fieldToolTipsArray["procurementunit"]["English"]["UnitId"] = "";
				placeHoldersArray["procurementunit"]["English"]["UnitId"] = "";
				fieldLabelsArray["procurementunit"]["English"]["EntityId"] = "Entity";
				fieldToolTipsArray["procurementunit"]["English"]["EntityId"] = "";
				placeHoldersArray["procurementunit"]["English"]["EntityId"] = "";
				fieldLabelsArray["procurementunit"]["English"]["UnitName"] = "Unit Name";
				fieldToolTipsArray["procurementunit"]["English"]["UnitName"] = "";
				placeHoldersArray["procurementunit"]["English"]["UnitName"] = "";
				fieldLabelsArray["procurementunit"]["English"]["AnnualBudget"] = "Annual Budget";
				fieldToolTipsArray["procurementunit"]["English"]["AnnualBudget"] = "";
				placeHoldersArray["procurementunit"]["English"]["AnnualBudget"] = "";
				fieldLabelsArray["procurementunit"]["English"]["OrganizationalLevel"] = "Organizational Level";
				fieldToolTipsArray["procurementunit"]["English"]["OrganizationalLevel"] = "";
				placeHoldersArray["procurementunit"]["English"]["OrganizationalLevel"] = "";
				fieldLabelsArray["procurementunit"]["English"]["AverageBudget3Years"] = "Average Budget (3 Years)";
				fieldToolTipsArray["procurementunit"]["English"]["AverageBudget3Years"] = "";
				placeHoldersArray["procurementunit"]["English"]["AverageBudget3Years"] = "";
				pageTitlesArray["procurementunit"]["English"]["add"] = " Add new record here";
				pageTitlesArray["procurementunit"]["English"]["edit"] = "Edit details as";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["procurementunit"]["English"])))
				{
					tdataArray["procurementunit"][".isUseToolTips"] = true;
				}
			}
			tdataArray["procurementunit"][".NCSearch"] = true;
			tdataArray["procurementunit"][".shortTableName"] = "procurementunit";
			tdataArray["procurementunit"][".nSecOptions"] = 0;
			tdataArray["procurementunit"][".mainTableOwnerID"] = "";
			tdataArray["procurementunit"][".entityType"] = 0;
			tdataArray["procurementunit"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["procurementunit"][".strOriginalTableName"] = "dbo.ProcurementUnit";
			tdataArray["procurementunit"][".showAddInPopup"] = false;
			tdataArray["procurementunit"][".showEditInPopup"] = false;
			tdataArray["procurementunit"][".showViewInPopup"] = false;
			tdataArray["procurementunit"][".listAjax"] = false;
			tdataArray["procurementunit"][".audit"] = false;
			tdataArray["procurementunit"][".locking"] = false;
			GlobalVars.pages = tdataArray["procurementunit"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["procurementunit"][".edit"] = true;
				tdataArray["procurementunit"][".afterEditAction"] = 0;
				tdataArray["procurementunit"][".closePopupAfterEdit"] = 1;
				tdataArray["procurementunit"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["procurementunit"][".add"] = true;
				tdataArray["procurementunit"][".afterAddAction"] = 0;
				tdataArray["procurementunit"][".closePopupAfterAdd"] = 1;
				tdataArray["procurementunit"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["procurementunit"][".list"] = true;
			}
			tdataArray["procurementunit"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["procurementunit"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["procurementunit"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["procurementunit"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["procurementunit"][".printFriendly"] = true;
			}
			tdataArray["procurementunit"][".showSimpleSearchOptions"] = true;
			tdataArray["procurementunit"][".allowShowHideFields"] = true;
			tdataArray["procurementunit"][".allowFieldsReordering"] = true;
			tdataArray["procurementunit"][".isUseAjaxSuggest"] = true;


			tdataArray["procurementunit"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["procurementunit"][".buttonsAdded"] = false;
			tdataArray["procurementunit"][".addPageEvents"] = true;
			tdataArray["procurementunit"][".isUseTimeForSearch"] = false;
			tdataArray["procurementunit"][".badgeColor"] = "008b8b";
			tdataArray["procurementunit"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["procurementunit"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["procurementunit"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["procurementunit"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["procurementunit"][".googleLikeFields"].Add("UnitId");
			tdataArray["procurementunit"][".googleLikeFields"].Add("EntityId");
			tdataArray["procurementunit"][".googleLikeFields"].Add("UnitName");
			tdataArray["procurementunit"][".googleLikeFields"].Add("AnnualBudget");
			tdataArray["procurementunit"][".googleLikeFields"].Add("OrganizationalLevel");
			tdataArray["procurementunit"][".googleLikeFields"].Add("AverageBudget3Years");
			tdataArray["procurementunit"][".tableType"] = "list";
			tdataArray["procurementunit"][".printerPageOrientation"] = 0;
			tdataArray["procurementunit"][".nPrinterPageScale"] = 100;
			tdataArray["procurementunit"][".nPrinterSplitRecords"] = 40;
			tdataArray["procurementunit"][".geocodingEnabled"] = false;
			tdataArray["procurementunit"][".pageSize"] = 20;
			tdataArray["procurementunit"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["procurementunit"][".strOrderBy"] = tstrOrderBy;
			tdataArray["procurementunit"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["procurementunit"][".sqlHead"] = "SELECT UnitId,  	EntityId,  	UnitName,  	AnnualBudget,  	OrganizationalLevel,  	AverageBudget3Years";
			tdataArray["procurementunit"][".sqlFrom"] = "FROM dbo.ProcurementUnit";
			tdataArray["procurementunit"][".sqlWhereExpr"] = "";
			tdataArray["procurementunit"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["procurementunit"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["procurementunit"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["procurementunit"][".highlightSearchResults"] = true;
			tableKeysArray["procurementunit"] = SettingsMap.GetArray();
			tableKeysArray["procurementunit"].Add("UnitId");
			tdataArray["procurementunit"][".Keys"] = tableKeysArray["procurementunit"];
			tdataArray["procurementunit"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "UnitId";
			fdata["GoodName"] = "UnitId";
			fdata["ownerTable"] = "dbo.ProcurementUnit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcurementUnit","UnitId");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "UnitId";
			fdata["sourceSingle"] = "UnitId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "UnitId";
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
			tdataArray["procurementunit"]["UnitId"] = fdata;
			tdataArray["procurementunit"][".searchableFields"].Add("UnitId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "EntityId";
			fdata["GoodName"] = "EntityId";
			fdata["ownerTable"] = "dbo.ProcurementUnit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcurementUnit","EntityId");
			fdata["FieldType"] = 3;
			fdata["strField"] = "EntityId";
			fdata["sourceSingle"] = "EntityId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "EntityId";
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
			edata["LookupTable"] = "dbo.ProcuringEntity";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "Id";
			edata["LinkFieldType"] = 3;
			edata["DisplayField"] = "EntityName";
			edata["LookupOrderBy"] = "";
			edata["SelectSize"] = 1;
			edata["IsRequired"] = true;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"].Add("IsRequired");
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["procurementunit"]["EntityId"] = fdata;
			tdataArray["procurementunit"][".searchableFields"].Add("EntityId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "UnitName";
			fdata["GoodName"] = "UnitName";
			fdata["ownerTable"] = "dbo.ProcurementUnit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcurementUnit","UnitName");
			fdata["FieldType"] = 200;
			fdata["strField"] = "UnitName";
			fdata["sourceSingle"] = "UnitName";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "UnitName";
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
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=50");
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
			tdataArray["procurementunit"]["UnitName"] = fdata;
			tdataArray["procurementunit"][".searchableFields"].Add("UnitName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "AnnualBudget";
			fdata["GoodName"] = "AnnualBudget";
			fdata["ownerTable"] = "dbo.ProcurementUnit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcurementUnit","AnnualBudget");
			fdata["FieldType"] = 14;
			fdata["strField"] = "AnnualBudget";
			fdata["sourceSingle"] = "AnnualBudget";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "AnnualBudget";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Number");
			vdata["DecimalDigits"] = 2;
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
			tdataArray["procurementunit"]["AnnualBudget"] = fdata;
			tdataArray["procurementunit"][".searchableFields"].Add("AnnualBudget");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "OrganizationalLevel";
			fdata["GoodName"] = "OrganizationalLevel";
			fdata["ownerTable"] = "dbo.ProcurementUnit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcurementUnit","OrganizationalLevel");
			fdata["FieldType"] = 200;
			fdata["strField"] = "OrganizationalLevel";
			fdata["sourceSingle"] = "OrganizationalLevel";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "OrganizationalLevel";
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
			edata["maxNumberOfFiles"] = 1;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=50");
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
			tdataArray["procurementunit"]["OrganizationalLevel"] = fdata;
			tdataArray["procurementunit"][".searchableFields"].Add("OrganizationalLevel");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "AverageBudget3Years";
			fdata["GoodName"] = "AverageBudget3Years";
			fdata["ownerTable"] = "dbo.ProcurementUnit";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcurementUnit","AverageBudget3Years");
			fdata["FieldType"] = 14;
			fdata["strField"] = "AverageBudget3Years";
			fdata["sourceSingle"] = "AverageBudget3Years";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "AverageBudget3Years";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Number");
			vdata["DecimalDigits"] = 2;
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
			tdataArray["procurementunit"]["AverageBudget3Years"] = fdata;
			tdataArray["procurementunit"][".searchableFields"].Add("AverageBudget3Years");
			GlobalVars.tables_data["dbo.ProcurementUnit"] = tdataArray["procurementunit"];
			GlobalVars.field_labels["dbo_ProcurementUnit"] = fieldLabelsArray["procurementunit"];
			GlobalVars.fieldToolTips["dbo_ProcurementUnit"] = fieldToolTipsArray["procurementunit"];
			GlobalVars.placeHolders["dbo_ProcurementUnit"] = placeHoldersArray["procurementunit"];
			GlobalVars.page_titles["dbo_ProcurementUnit"] = pageTitlesArray["procurementunit"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.ProcurementUnit"));
			GlobalVars.detailsTablesData["dbo.ProcurementUnit"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.BACSecretariat";
			detailsParam["dOriginalTable"] = "dbo.BACSecretariat";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "bacsecretariat";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_BACSecretariat"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ProcurementUnit"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ProcurementUnit"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ProcurementUnit"][dIndex]["masterKeys"].Add("UnitId");
			GlobalVars.detailsTablesData["dbo.ProcurementUnit"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ProcurementUnit"][dIndex]["detailKeys"].Add("UnitId");
			GlobalVars.masterTablesData["dbo.ProcurementUnit"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.PPMP";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.PPMP";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "ppmp";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.ProcurementUnit"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.ProcurementUnit"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.ProcurementUnit"][0]["masterKeys"].Add("EndUserUnit");
			GlobalVars.masterTablesData["dbo.ProcurementUnit"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.ProcurementUnit"][0]["detailKeys"].Add("UnitId");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "UnitId,  	EntityId,  	UnitName,  	AnnualBudget,  	OrganizationalLevel,  	AverageBudget3Years";
protoArray["0"]["m_strFrom"] = "FROM dbo.ProcurementUnit";
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
obj = new SQLField(new XVar("m_strName", "UnitId", "m_strTable", "dbo.ProcurementUnit", "m_srcTableName", "dbo.ProcurementUnit"));

protoArray["6"]["m_sql"] = "UnitId";
protoArray["6"]["m_srcTableName"] = "dbo.ProcurementUnit";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "EntityId", "m_strTable", "dbo.ProcurementUnit", "m_srcTableName", "dbo.ProcurementUnit"));

protoArray["8"]["m_sql"] = "EntityId";
protoArray["8"]["m_srcTableName"] = "dbo.ProcurementUnit";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "UnitName", "m_strTable", "dbo.ProcurementUnit", "m_srcTableName", "dbo.ProcurementUnit"));

protoArray["10"]["m_sql"] = "UnitName";
protoArray["10"]["m_srcTableName"] = "dbo.ProcurementUnit";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "AnnualBudget", "m_strTable", "dbo.ProcurementUnit", "m_srcTableName", "dbo.ProcurementUnit"));

protoArray["12"]["m_sql"] = "AnnualBudget";
protoArray["12"]["m_srcTableName"] = "dbo.ProcurementUnit";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "OrganizationalLevel", "m_strTable", "dbo.ProcurementUnit", "m_srcTableName", "dbo.ProcurementUnit"));

protoArray["14"]["m_sql"] = "OrganizationalLevel";
protoArray["14"]["m_srcTableName"] = "dbo.ProcurementUnit";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "AverageBudget3Years", "m_strTable", "dbo.ProcurementUnit", "m_srcTableName", "dbo.ProcurementUnit"));

protoArray["16"]["m_sql"] = "AverageBudget3Years";
protoArray["16"]["m_srcTableName"] = "dbo.ProcurementUnit";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "dbo.ProcurementUnit";
protoArray["19"]["m_srcTableName"] = "dbo.ProcurementUnit";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("UnitId");
protoArray["19"]["m_columns"].Add("EntityId");
protoArray["19"]["m_columns"].Add("UnitName");
protoArray["19"]["m_columns"].Add("AnnualBudget");
protoArray["19"]["m_columns"].Add("OrganizationalLevel");
protoArray["19"]["m_columns"].Add("AverageBudget3Years");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "dbo.ProcurementUnit";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "dbo.ProcurementUnit";
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_sql"] = "";
protoArray["20"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["20"]["m_column"] = obj;
protoArray["20"]["m_contained"] = SettingsMap.GetArray();
protoArray["20"]["m_strCase"] = "";
protoArray["20"]["m_havingmode"] = false;
protoArray["20"]["m_inBrackets"] = false;
protoArray["20"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["20"]);

protoArray["18"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["18"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.ProcurementUnit";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["procurementunit"] = obj;

				
		
			tdataArray["procurementunit"][".sqlquery"] = queryData_Array["procurementunit"];
			tdataArray["procurementunit"][".hasEvents"] = true;
		}
	}

}
