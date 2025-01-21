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
	public static partial class Settings_procuringentity
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["procuringentity"] = SettingsMap.GetArray();
			tdataArray["procuringentity"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["procuringentity"][".ShortName"] = "procuringentity";
			tdataArray["procuringentity"][".OwnerID"] = "";
			tdataArray["procuringentity"][".OriginalTable"] = "dbo.ProcuringEntity";
			tdataArray["procuringentity"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["procuringentity"][".originalPagesByType"] = tdataArray["procuringentity"][".pagesByType"];
			tdataArray["procuringentity"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["procuringentity"][".originalPages"] = tdataArray["procuringentity"][".pages"];
			tdataArray["procuringentity"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["procuringentity"][".originalDefaultPages"] = tdataArray["procuringentity"][".defaultPages"];
			fieldLabelsArray["procuringentity"] = SettingsMap.GetArray();
			fieldToolTipsArray["procuringentity"] = SettingsMap.GetArray();
			pageTitlesArray["procuringentity"] = SettingsMap.GetArray();
			placeHoldersArray["procuringentity"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["procuringentity"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["procuringentity"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["procuringentity"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["procuringentity"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["procuringentity"]["English"]["EntityName"] = "Entity Name";
				fieldToolTipsArray["procuringentity"]["English"]["EntityName"] = "";
				placeHoldersArray["procuringentity"]["English"]["EntityName"] = "";
				fieldLabelsArray["procuringentity"]["English"]["EntityType"] = "Entity Type";
				fieldToolTipsArray["procuringentity"]["English"]["EntityType"] = "";
				placeHoldersArray["procuringentity"]["English"]["EntityType"] = "";
				fieldLabelsArray["procuringentity"]["English"]["IsAuthorized"] = "Is Authorized";
				fieldToolTipsArray["procuringentity"]["English"]["IsAuthorized"] = "";
				placeHoldersArray["procuringentity"]["English"]["IsAuthorized"] = "";
				fieldLabelsArray["procuringentity"]["English"]["AuthorityDetails"] = "Authority Details";
				fieldToolTipsArray["procuringentity"]["English"]["AuthorityDetails"] = "";
				placeHoldersArray["procuringentity"]["English"]["AuthorityDetails"] = "";
				fieldLabelsArray["procuringentity"]["English"]["Id"] = "Id";
				fieldToolTipsArray["procuringentity"]["English"]["Id"] = "";
				placeHoldersArray["procuringentity"]["English"]["Id"] = "";
				pageTitlesArray["procuringentity"]["English"]["add"] = "Add new record here";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["procuringentity"]["English"])))
				{
					tdataArray["procuringentity"][".isUseToolTips"] = true;
				}
			}
			tdataArray["procuringentity"][".NCSearch"] = true;
			tdataArray["procuringentity"][".shortTableName"] = "procuringentity";
			tdataArray["procuringentity"][".nSecOptions"] = 0;
			tdataArray["procuringentity"][".mainTableOwnerID"] = "";
			tdataArray["procuringentity"][".entityType"] = 0;
			tdataArray["procuringentity"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["procuringentity"][".strOriginalTableName"] = "dbo.ProcuringEntity";
			tdataArray["procuringentity"][".showAddInPopup"] = false;
			tdataArray["procuringentity"][".showEditInPopup"] = false;
			tdataArray["procuringentity"][".showViewInPopup"] = false;
			tdataArray["procuringentity"][".listAjax"] = false;
			tdataArray["procuringentity"][".audit"] = false;
			tdataArray["procuringentity"][".locking"] = false;
			GlobalVars.pages = tdataArray["procuringentity"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["procuringentity"][".edit"] = true;
				tdataArray["procuringentity"][".afterEditAction"] = 0;
				tdataArray["procuringentity"][".closePopupAfterEdit"] = 1;
				tdataArray["procuringentity"][".afterEditActionDetTable"] = "dbo.BidsAndAwardsCommittee";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["procuringentity"][".add"] = true;
				tdataArray["procuringentity"][".afterAddAction"] = 0;
				tdataArray["procuringentity"][".closePopupAfterAdd"] = 1;
				tdataArray["procuringentity"][".afterAddActionDetTable"] = "dbo.BidsAndAwardsCommittee";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["procuringentity"][".list"] = true;
			}
			tdataArray["procuringentity"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["procuringentity"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["procuringentity"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["procuringentity"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["procuringentity"][".printFriendly"] = true;
			}
			tdataArray["procuringentity"][".showSimpleSearchOptions"] = true;
			tdataArray["procuringentity"][".allowShowHideFields"] = true;
			tdataArray["procuringentity"][".allowFieldsReordering"] = true;
			tdataArray["procuringentity"][".isUseAjaxSuggest"] = true;


			tdataArray["procuringentity"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["procuringentity"][".buttonsAdded"] = false;
			tdataArray["procuringentity"][".addPageEvents"] = true;
			tdataArray["procuringentity"][".isUseTimeForSearch"] = false;
			tdataArray["procuringentity"][".badgeColor"] = "CD853F";
			tdataArray["procuringentity"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["procuringentity"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["procuringentity"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["procuringentity"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["procuringentity"][".googleLikeFields"].Add("Id");
			tdataArray["procuringentity"][".googleLikeFields"].Add("EntityName");
			tdataArray["procuringentity"][".googleLikeFields"].Add("EntityType");
			tdataArray["procuringentity"][".googleLikeFields"].Add("IsAuthorized");
			tdataArray["procuringentity"][".googleLikeFields"].Add("AuthorityDetails");
			tdataArray["procuringentity"][".tableType"] = "list";
			tdataArray["procuringentity"][".printerPageOrientation"] = 0;
			tdataArray["procuringentity"][".nPrinterPageScale"] = 100;
			tdataArray["procuringentity"][".nPrinterSplitRecords"] = 40;
			tdataArray["procuringentity"][".geocodingEnabled"] = false;
			tdataArray["procuringentity"][".pageSize"] = 20;
			tdataArray["procuringentity"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["procuringentity"][".strOrderBy"] = tstrOrderBy;
			tdataArray["procuringentity"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["procuringentity"][".sqlHead"] = "SELECT Id,  	EntityName,  	EntityType,  	IsAuthorized,  	AuthorityDetails";
			tdataArray["procuringentity"][".sqlFrom"] = "FROM dbo.ProcuringEntity";
			tdataArray["procuringentity"][".sqlWhereExpr"] = "";
			tdataArray["procuringentity"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["procuringentity"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["procuringentity"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["procuringentity"][".highlightSearchResults"] = true;
			tableKeysArray["procuringentity"] = SettingsMap.GetArray();
			tableKeysArray["procuringentity"].Add("Id");
			tdataArray["procuringentity"][".Keys"] = tableKeysArray["procuringentity"];
			tdataArray["procuringentity"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Id";
			fdata["GoodName"] = "Id";
			fdata["ownerTable"] = "dbo.ProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcuringEntity","Id");
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
			tdataArray["procuringentity"]["Id"] = fdata;
			tdataArray["procuringentity"][".searchableFields"].Add("Id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "EntityName";
			fdata["GoodName"] = "EntityName";
			fdata["ownerTable"] = "dbo.ProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcuringEntity","EntityName");
			fdata["FieldType"] = 200;
			fdata["strField"] = "EntityName";
			fdata["sourceSingle"] = "EntityName";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "EntityName";
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
			tdataArray["procuringentity"]["EntityName"] = fdata;
			tdataArray["procuringentity"][".searchableFields"].Add("EntityName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "EntityType";
			fdata["GoodName"] = "EntityType";
			fdata["ownerTable"] = "dbo.ProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcuringEntity","EntityType");
			fdata["FieldType"] = 200;
			fdata["strField"] = "EntityType";
			fdata["sourceSingle"] = "EntityType";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "EntityType";
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
			tdataArray["procuringentity"]["EntityType"] = fdata;
			tdataArray["procuringentity"][".searchableFields"].Add("EntityType");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "IsAuthorized";
			fdata["GoodName"] = "IsAuthorized";
			fdata["ownerTable"] = "dbo.ProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcuringEntity","IsAuthorized");
			fdata["FieldType"] = 11;
			fdata["strField"] = "IsAuthorized";
			fdata["sourceSingle"] = "IsAuthorized";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "IsAuthorized";
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
			tdataArray["procuringentity"]["IsAuthorized"] = fdata;
			tdataArray["procuringentity"][".searchableFields"].Add("IsAuthorized");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "AuthorityDetails";
			fdata["GoodName"] = "AuthorityDetails";
			fdata["ownerTable"] = "dbo.ProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ProcuringEntity","AuthorityDetails");
			fdata["FieldType"] = 200;
			fdata["strField"] = "AuthorityDetails";
			fdata["sourceSingle"] = "AuthorityDetails";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "AuthorityDetails";
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
			edata["maxNumberOfFiles"] = 0;
			edata["HTML5InuptType"] = "text";
			edata["EditParams"] = "";
			edata["EditParams"] = MVCFunctions.Concat(edata["EditParams"], " maxlength=2147483647");
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
			tdataArray["procuringentity"]["AuthorityDetails"] = fdata;
			tdataArray["procuringentity"][".searchableFields"].Add("AuthorityDetails");
			GlobalVars.tables_data["dbo.ProcuringEntity"] = tdataArray["procuringentity"];
			GlobalVars.field_labels["dbo_ProcuringEntity"] = fieldLabelsArray["procuringentity"];
			GlobalVars.fieldToolTips["dbo_ProcuringEntity"] = fieldToolTipsArray["procuringentity"];
			GlobalVars.placeHolders["dbo_ProcuringEntity"] = placeHoldersArray["procuringentity"];
			GlobalVars.page_titles["dbo_ProcuringEntity"] = pageTitlesArray["procuringentity"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.ProcuringEntity"));
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.BidsAndAwardsCommittee";
			detailsParam["dOriginalTable"] = "dbo.BidsAndAwardsCommittee";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "bidsandawardscommittee";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_BidsAndAwardsCommittee"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex]["masterKeys"].Add("Id");
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex]["detailKeys"].Add("EntityId");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.HeadOfProcuringEntity";
			detailsParam["dOriginalTable"] = "dbo.HeadOfProcuringEntity";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "headofprocuringentity";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_HeadOfProcuringEntity"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex]["masterKeys"].Add("Id");
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.ProcuringEntity"][dIndex]["detailKeys"].Add("EntityId");
			GlobalVars.masterTablesData["dbo.ProcuringEntity"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Id,  	EntityName,  	EntityType,  	IsAuthorized,  	AuthorityDetails";
protoArray["0"]["m_strFrom"] = "FROM dbo.ProcuringEntity";
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
obj = new SQLField(new XVar("m_strName", "Id", "m_strTable", "dbo.ProcuringEntity", "m_srcTableName", "dbo.ProcuringEntity"));

protoArray["6"]["m_sql"] = "Id";
protoArray["6"]["m_srcTableName"] = "dbo.ProcuringEntity";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "EntityName", "m_strTable", "dbo.ProcuringEntity", "m_srcTableName", "dbo.ProcuringEntity"));

protoArray["8"]["m_sql"] = "EntityName";
protoArray["8"]["m_srcTableName"] = "dbo.ProcuringEntity";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "EntityType", "m_strTable", "dbo.ProcuringEntity", "m_srcTableName", "dbo.ProcuringEntity"));

protoArray["10"]["m_sql"] = "EntityType";
protoArray["10"]["m_srcTableName"] = "dbo.ProcuringEntity";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "IsAuthorized", "m_strTable", "dbo.ProcuringEntity", "m_srcTableName", "dbo.ProcuringEntity"));

protoArray["12"]["m_sql"] = "IsAuthorized";
protoArray["12"]["m_srcTableName"] = "dbo.ProcuringEntity";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "AuthorityDetails", "m_strTable", "dbo.ProcuringEntity", "m_srcTableName", "dbo.ProcuringEntity"));

protoArray["14"]["m_sql"] = "AuthorityDetails";
protoArray["14"]["m_srcTableName"] = "dbo.ProcuringEntity";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.ProcuringEntity";
protoArray["17"]["m_srcTableName"] = "dbo.ProcuringEntity";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("Id");
protoArray["17"]["m_columns"].Add("EntityName");
protoArray["17"]["m_columns"].Add("EntityType");
protoArray["17"]["m_columns"].Add("IsAuthorized");
protoArray["17"]["m_columns"].Add("AuthorityDetails");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.ProcuringEntity";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.ProcuringEntity";
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_sql"] = "";
protoArray["18"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["18"]["m_column"] = obj;
protoArray["18"]["m_contained"] = SettingsMap.GetArray();
protoArray["18"]["m_strCase"] = "";
protoArray["18"]["m_havingmode"] = false;
protoArray["18"]["m_inBrackets"] = false;
protoArray["18"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["18"]);

protoArray["16"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["16"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.ProcuringEntity";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["procuringentity"] = obj;

				
		
			tdataArray["procuringentity"][".sqlquery"] = queryData_Array["procuringentity"];
			tdataArray["procuringentity"][".hasEvents"] = true;
		}
	}

}
