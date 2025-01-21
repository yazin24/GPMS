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
	public static partial class Settings_observerinterest
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["observerinterest"] = SettingsMap.GetArray();
			tdataArray["observerinterest"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["observerinterest"][".ShortName"] = "observerinterest";
			tdataArray["observerinterest"][".OwnerID"] = "";
			tdataArray["observerinterest"][".OriginalTable"] = "dbo.ObserverInterest";
			tdataArray["observerinterest"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["observerinterest"][".originalPagesByType"] = tdataArray["observerinterest"][".pagesByType"];
			tdataArray["observerinterest"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["observerinterest"][".originalPages"] = tdataArray["observerinterest"][".pages"];
			tdataArray["observerinterest"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["observerinterest"][".originalDefaultPages"] = tdataArray["observerinterest"][".defaultPages"];
			fieldLabelsArray["observerinterest"] = SettingsMap.GetArray();
			fieldToolTipsArray["observerinterest"] = SettingsMap.GetArray();
			pageTitlesArray["observerinterest"] = SettingsMap.GetArray();
			placeHoldersArray["observerinterest"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["observerinterest"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["observerinterest"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["observerinterest"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["observerinterest"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["observerinterest"]["English"]["InterestId"] = "Interest Id";
				fieldToolTipsArray["observerinterest"]["English"]["InterestId"] = "";
				placeHoldersArray["observerinterest"]["English"]["InterestId"] = "";
				fieldLabelsArray["observerinterest"]["English"]["ObserverId"] = "Observer Name";
				fieldToolTipsArray["observerinterest"]["English"]["ObserverId"] = "";
				placeHoldersArray["observerinterest"]["English"]["ObserverId"] = "";
				fieldLabelsArray["observerinterest"]["English"]["ProcurementActivityId"] = "Procurement Activity";
				fieldToolTipsArray["observerinterest"]["English"]["ProcurementActivityId"] = "";
				placeHoldersArray["observerinterest"]["English"]["ProcurementActivityId"] = "";
				fieldLabelsArray["observerinterest"]["English"]["InterestType"] = "Interest Type";
				fieldToolTipsArray["observerinterest"]["English"]["InterestType"] = "";
				placeHoldersArray["observerinterest"]["English"]["InterestType"] = "";
				fieldLabelsArray["observerinterest"]["English"]["InterestDescription"] = "Interest Description";
				fieldToolTipsArray["observerinterest"]["English"]["InterestDescription"] = "";
				placeHoldersArray["observerinterest"]["English"]["InterestDescription"] = "";
				fieldLabelsArray["observerinterest"]["English"]["DateReported"] = "Date Reported";
				fieldToolTipsArray["observerinterest"]["English"]["DateReported"] = "";
				placeHoldersArray["observerinterest"]["English"]["DateReported"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["observerinterest"]["English"])))
				{
					tdataArray["observerinterest"][".isUseToolTips"] = true;
				}
			}
			tdataArray["observerinterest"][".NCSearch"] = true;
			tdataArray["observerinterest"][".shortTableName"] = "observerinterest";
			tdataArray["observerinterest"][".nSecOptions"] = 0;
			tdataArray["observerinterest"][".mainTableOwnerID"] = "";
			tdataArray["observerinterest"][".entityType"] = 0;
			tdataArray["observerinterest"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["observerinterest"][".strOriginalTableName"] = "dbo.ObserverInterest";
			tdataArray["observerinterest"][".showAddInPopup"] = false;
			tdataArray["observerinterest"][".showEditInPopup"] = false;
			tdataArray["observerinterest"][".showViewInPopup"] = false;
			tdataArray["observerinterest"][".listAjax"] = false;
			tdataArray["observerinterest"][".audit"] = false;
			tdataArray["observerinterest"][".locking"] = false;
			GlobalVars.pages = tdataArray["observerinterest"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["observerinterest"][".edit"] = true;
				tdataArray["observerinterest"][".afterEditAction"] = 0;
				tdataArray["observerinterest"][".closePopupAfterEdit"] = 1;
				tdataArray["observerinterest"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["observerinterest"][".add"] = true;
				tdataArray["observerinterest"][".afterAddAction"] = 0;
				tdataArray["observerinterest"][".closePopupAfterAdd"] = 1;
				tdataArray["observerinterest"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["observerinterest"][".list"] = true;
			}
			tdataArray["observerinterest"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["observerinterest"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["observerinterest"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["observerinterest"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["observerinterest"][".printFriendly"] = true;
			}
			tdataArray["observerinterest"][".showSimpleSearchOptions"] = true;
			tdataArray["observerinterest"][".allowShowHideFields"] = true;
			tdataArray["observerinterest"][".allowFieldsReordering"] = true;
			tdataArray["observerinterest"][".isUseAjaxSuggest"] = true;


			tdataArray["observerinterest"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["observerinterest"][".buttonsAdded"] = false;
			tdataArray["observerinterest"][".addPageEvents"] = true;
			tdataArray["observerinterest"][".isUseTimeForSearch"] = false;
			tdataArray["observerinterest"][".badgeColor"] = "EDCA00";
			tdataArray["observerinterest"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["observerinterest"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["observerinterest"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["observerinterest"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["observerinterest"][".googleLikeFields"].Add("InterestId");
			tdataArray["observerinterest"][".googleLikeFields"].Add("ObserverId");
			tdataArray["observerinterest"][".googleLikeFields"].Add("ProcurementActivityId");
			tdataArray["observerinterest"][".googleLikeFields"].Add("InterestType");
			tdataArray["observerinterest"][".googleLikeFields"].Add("InterestDescription");
			tdataArray["observerinterest"][".googleLikeFields"].Add("DateReported");
			tdataArray["observerinterest"][".tableType"] = "list";
			tdataArray["observerinterest"][".printerPageOrientation"] = 0;
			tdataArray["observerinterest"][".nPrinterPageScale"] = 100;
			tdataArray["observerinterest"][".nPrinterSplitRecords"] = 40;
			tdataArray["observerinterest"][".geocodingEnabled"] = false;
			tdataArray["observerinterest"][".pageSize"] = 20;
			tdataArray["observerinterest"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["observerinterest"][".strOrderBy"] = tstrOrderBy;
			tdataArray["observerinterest"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["observerinterest"][".sqlHead"] = "SELECT InterestId,  	ObserverId,  	ProcurementActivityId,  	InterestType,  	InterestDescription,  	DateReported";
			tdataArray["observerinterest"][".sqlFrom"] = "FROM dbo.ObserverInterest";
			tdataArray["observerinterest"][".sqlWhereExpr"] = "";
			tdataArray["observerinterest"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["observerinterest"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["observerinterest"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["observerinterest"][".highlightSearchResults"] = true;
			tableKeysArray["observerinterest"] = SettingsMap.GetArray();
			tableKeysArray["observerinterest"].Add("InterestId");
			tdataArray["observerinterest"][".Keys"] = tableKeysArray["observerinterest"];
			tdataArray["observerinterest"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "InterestId";
			fdata["GoodName"] = "InterestId";
			fdata["ownerTable"] = "dbo.ObserverInterest";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ObserverInterest","InterestId");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "InterestId";
			fdata["sourceSingle"] = "InterestId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "InterestId";
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
			tdataArray["observerinterest"]["InterestId"] = fdata;
			tdataArray["observerinterest"][".searchableFields"].Add("InterestId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "ObserverId";
			fdata["GoodName"] = "ObserverId";
			fdata["ownerTable"] = "dbo.ObserverInterest";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ObserverInterest","ObserverId");
			fdata["FieldType"] = 3;
			fdata["strField"] = "ObserverId";
			fdata["sourceSingle"] = "ObserverId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ObserverId";
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
			edata["LookupTable"] = "dbo.Observer";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "ObserverId";
			edata["LinkFieldType"] = 3;
			edata["DisplayField"] = "ObserverName";
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
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["observerinterest"]["ObserverId"] = fdata;
			tdataArray["observerinterest"][".searchableFields"].Add("ObserverId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "ProcurementActivityId";
			fdata["GoodName"] = "ProcurementActivityId";
			fdata["ownerTable"] = "dbo.ObserverInterest";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ObserverInterest","ProcurementActivityId");
			fdata["FieldType"] = 3;
			fdata["strField"] = "ProcurementActivityId";
			fdata["sourceSingle"] = "ProcurementActivityId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ProcurementActivityId";
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
			edata["LookupTable"] = "dbo.ProcurementUnit";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "UnitId";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "UnitName";
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
			tdataArray["observerinterest"]["ProcurementActivityId"] = fdata;
			tdataArray["observerinterest"][".searchableFields"].Add("ProcurementActivityId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "InterestType";
			fdata["GoodName"] = "InterestType";
			fdata["ownerTable"] = "dbo.ObserverInterest";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ObserverInterest","InterestType");
			fdata["FieldType"] = 200;
			fdata["strField"] = "InterestType";
			fdata["sourceSingle"] = "InterestType";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "InterestType";
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
			tdataArray["observerinterest"]["InterestType"] = fdata;
			tdataArray["observerinterest"][".searchableFields"].Add("InterestType");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "InterestDescription";
			fdata["GoodName"] = "InterestDescription";
			fdata["ownerTable"] = "dbo.ObserverInterest";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ObserverInterest","InterestDescription");
			fdata["FieldType"] = 200;
			fdata["strField"] = "InterestDescription";
			fdata["sourceSingle"] = "InterestDescription";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "InterestDescription";
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
			tdataArray["observerinterest"]["InterestDescription"] = fdata;
			tdataArray["observerinterest"][".searchableFields"].Add("InterestDescription");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "DateReported";
			fdata["GoodName"] = "DateReported";
			fdata["ownerTable"] = "dbo.ObserverInterest";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ObserverInterest","DateReported");
			fdata["FieldType"] = 7;
			fdata["strField"] = "DateReported";
			fdata["sourceSingle"] = "DateReported";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "DateReported";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Custom");
			vdata["truncateText"] = true;
			vdata["NumberOfChars"] = 80;
			fdata["ViewFormats"]["view"] = vdata;
			fdata["EditFormats"] = SettingsMap.GetArray();
			edata = new XVar("EditFormat", "Date");
			edata["weekdayMessage"] = new XVar("message", "Invalid week day", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 1;
			edata["DateEditType"] = 2;
			edata["InitialYearFactor"] = 100;
			edata["LastYearFactor"] = 10;
			edata["controlWidth"] = 200;
			edata["validateAs"] = SettingsMap.GetArray();
			edata["validateAs"]["basicValidate"] = SettingsMap.GetArray();
			edata["validateAs"]["customMessages"] = SettingsMap.GetArray();
			fdata["EditFormats"]["edit"] = edata;
			fdata["isSeparate"] = false;
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Equals", 1, "More than", 2, "Less than", 3, "Between", 4, Constants.EMPTY_SEARCH, 5, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["observerinterest"]["DateReported"] = fdata;
			tdataArray["observerinterest"][".searchableFields"].Add("DateReported");
			GlobalVars.tables_data["dbo.ObserverInterest"] = tdataArray["observerinterest"];
			GlobalVars.field_labels["dbo_ObserverInterest"] = fieldLabelsArray["observerinterest"];
			GlobalVars.fieldToolTips["dbo_ObserverInterest"] = fieldToolTipsArray["observerinterest"];
			GlobalVars.placeHolders["dbo_ObserverInterest"] = placeHoldersArray["observerinterest"];
			GlobalVars.page_titles["dbo_ObserverInterest"] = pageTitlesArray["observerinterest"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.ObserverInterest"));
			GlobalVars.detailsTablesData["dbo.ObserverInterest"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.ObserverInterest"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.Observer";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.Observer";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "observer";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.ObserverInterest"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.ObserverInterest"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.ObserverInterest"][0]["masterKeys"].Add("ObserverId");
			GlobalVars.masterTablesData["dbo.ObserverInterest"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.ObserverInterest"][0]["detailKeys"].Add("ObserverId");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "InterestId,  	ObserverId,  	ProcurementActivityId,  	InterestType,  	InterestDescription,  	DateReported";
protoArray["0"]["m_strFrom"] = "FROM dbo.ObserverInterest";
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
obj = new SQLField(new XVar("m_strName", "InterestId", "m_strTable", "dbo.ObserverInterest", "m_srcTableName", "dbo.ObserverInterest"));

protoArray["6"]["m_sql"] = "InterestId";
protoArray["6"]["m_srcTableName"] = "dbo.ObserverInterest";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ObserverId", "m_strTable", "dbo.ObserverInterest", "m_srcTableName", "dbo.ObserverInterest"));

protoArray["8"]["m_sql"] = "ObserverId";
protoArray["8"]["m_srcTableName"] = "dbo.ObserverInterest";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ProcurementActivityId", "m_strTable", "dbo.ObserverInterest", "m_srcTableName", "dbo.ObserverInterest"));

protoArray["10"]["m_sql"] = "ProcurementActivityId";
protoArray["10"]["m_srcTableName"] = "dbo.ObserverInterest";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "InterestType", "m_strTable", "dbo.ObserverInterest", "m_srcTableName", "dbo.ObserverInterest"));

protoArray["12"]["m_sql"] = "InterestType";
protoArray["12"]["m_srcTableName"] = "dbo.ObserverInterest";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "InterestDescription", "m_strTable", "dbo.ObserverInterest", "m_srcTableName", "dbo.ObserverInterest"));

protoArray["14"]["m_sql"] = "InterestDescription";
protoArray["14"]["m_srcTableName"] = "dbo.ObserverInterest";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "DateReported", "m_strTable", "dbo.ObserverInterest", "m_srcTableName", "dbo.ObserverInterest"));

protoArray["16"]["m_sql"] = "DateReported";
protoArray["16"]["m_srcTableName"] = "dbo.ObserverInterest";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "dbo.ObserverInterest";
protoArray["19"]["m_srcTableName"] = "dbo.ObserverInterest";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("InterestId");
protoArray["19"]["m_columns"].Add("ObserverId");
protoArray["19"]["m_columns"].Add("ProcurementActivityId");
protoArray["19"]["m_columns"].Add("InterestType");
protoArray["19"]["m_columns"].Add("InterestDescription");
protoArray["19"]["m_columns"].Add("DateReported");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "dbo.ObserverInterest";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "dbo.ObserverInterest";
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
protoArray["0"]["m_srcTableName"] = "dbo.ObserverInterest";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["observerinterest"] = obj;

				
		
			tdataArray["observerinterest"][".sqlquery"] = queryData_Array["observerinterest"];
			tdataArray["observerinterest"][".hasEvents"] = true;
		}
	}

}
