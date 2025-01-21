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
	public static partial class Settings_twg
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["twg"] = SettingsMap.GetArray();
			tdataArray["twg"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["twg"][".ShortName"] = "twg";
			tdataArray["twg"][".OwnerID"] = "";
			tdataArray["twg"][".OriginalTable"] = "dbo.TWG";
			tdataArray["twg"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["twg"][".originalPagesByType"] = tdataArray["twg"][".pagesByType"];
			tdataArray["twg"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["twg"][".originalPages"] = tdataArray["twg"][".pages"];
			tdataArray["twg"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["twg"][".originalDefaultPages"] = tdataArray["twg"][".defaultPages"];
			fieldLabelsArray["twg"] = SettingsMap.GetArray();
			fieldToolTipsArray["twg"] = SettingsMap.GetArray();
			pageTitlesArray["twg"] = SettingsMap.GetArray();
			placeHoldersArray["twg"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["twg"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["twg"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["twg"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["twg"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["twg"]["English"]["TWGId"] = "TWGId";
				fieldToolTipsArray["twg"]["English"]["TWGId"] = "";
				placeHoldersArray["twg"]["English"]["TWGId"] = "";
				fieldLabelsArray["twg"]["English"]["TWGName"] = "TWG Name";
				fieldToolTipsArray["twg"]["English"]["TWGName"] = "";
				placeHoldersArray["twg"]["English"]["TWGName"] = "";
				fieldLabelsArray["twg"]["English"]["TWGType"] = "TWG Type";
				fieldToolTipsArray["twg"]["English"]["TWGType"] = "";
				placeHoldersArray["twg"]["English"]["TWGType"] = "";
				fieldLabelsArray["twg"]["English"]["BacId"] = "B.A.C";
				fieldToolTipsArray["twg"]["English"]["BacId"] = "";
				placeHoldersArray["twg"]["English"]["BacId"] = "";
				fieldLabelsArray["twg"]["English"]["EndUserRepresentative"] = "End User Representative";
				fieldToolTipsArray["twg"]["English"]["EndUserRepresentative"] = "";
				placeHoldersArray["twg"]["English"]["EndUserRepresentative"] = "";
				fieldLabelsArray["twg"]["English"]["CreationDate"] = "Creation Date";
				fieldToolTipsArray["twg"]["English"]["CreationDate"] = "";
				placeHoldersArray["twg"]["English"]["CreationDate"] = "";
				fieldLabelsArray["twg"]["English"]["ModificationDate"] = "Modification Date";
				fieldToolTipsArray["twg"]["English"]["ModificationDate"] = "";
				placeHoldersArray["twg"]["English"]["ModificationDate"] = "";
				pageTitlesArray["twg"]["English"]["add"] = "Add new record here";
				pageTitlesArray["twg"]["English"]["edit"] = "Edit details as";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["twg"]["English"])))
				{
					tdataArray["twg"][".isUseToolTips"] = true;
				}
			}
			tdataArray["twg"][".NCSearch"] = true;
			tdataArray["twg"][".shortTableName"] = "twg";
			tdataArray["twg"][".nSecOptions"] = 0;
			tdataArray["twg"][".mainTableOwnerID"] = "";
			tdataArray["twg"][".entityType"] = 0;
			tdataArray["twg"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["twg"][".strOriginalTableName"] = "dbo.TWG";
			tdataArray["twg"][".showAddInPopup"] = false;
			tdataArray["twg"][".showEditInPopup"] = false;
			tdataArray["twg"][".showViewInPopup"] = false;
			tdataArray["twg"][".listAjax"] = false;
			tdataArray["twg"][".audit"] = false;
			tdataArray["twg"][".locking"] = false;
			GlobalVars.pages = tdataArray["twg"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["twg"][".edit"] = true;
				tdataArray["twg"][".afterEditAction"] = 0;
				tdataArray["twg"][".closePopupAfterEdit"] = 1;
				tdataArray["twg"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["twg"][".add"] = true;
				tdataArray["twg"][".afterAddAction"] = 0;
				tdataArray["twg"][".closePopupAfterAdd"] = 1;
				tdataArray["twg"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["twg"][".list"] = true;
			}
			tdataArray["twg"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["twg"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["twg"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["twg"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["twg"][".printFriendly"] = true;
			}
			tdataArray["twg"][".showSimpleSearchOptions"] = true;
			tdataArray["twg"][".allowShowHideFields"] = true;
			tdataArray["twg"][".allowFieldsReordering"] = true;
			tdataArray["twg"][".isUseAjaxSuggest"] = true;


			tdataArray["twg"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["twg"][".buttonsAdded"] = false;
			tdataArray["twg"][".addPageEvents"] = true;
			tdataArray["twg"][".isUseTimeForSearch"] = false;
			tdataArray["twg"][".badgeColor"] = "E8926F";
			tdataArray["twg"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["twg"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["twg"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["twg"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["twg"][".googleLikeFields"].Add("TWGId");
			tdataArray["twg"][".googleLikeFields"].Add("TWGName");
			tdataArray["twg"][".googleLikeFields"].Add("TWGType");
			tdataArray["twg"][".googleLikeFields"].Add("BacId");
			tdataArray["twg"][".googleLikeFields"].Add("EndUserRepresentative");
			tdataArray["twg"][".googleLikeFields"].Add("CreationDate");
			tdataArray["twg"][".googleLikeFields"].Add("ModificationDate");
			tdataArray["twg"][".tableType"] = "list";
			tdataArray["twg"][".printerPageOrientation"] = 0;
			tdataArray["twg"][".nPrinterPageScale"] = 100;
			tdataArray["twg"][".nPrinterSplitRecords"] = 40;
			tdataArray["twg"][".geocodingEnabled"] = false;
			tdataArray["twg"][".pageSize"] = 20;
			tdataArray["twg"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["twg"][".strOrderBy"] = tstrOrderBy;
			tdataArray["twg"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["twg"][".sqlHead"] = "SELECT TWGId,  	TWGName,  	TWGType,  	BacId,  	EndUserRepresentative,  	CreationDate,  	ModificationDate";
			tdataArray["twg"][".sqlFrom"] = "FROM dbo.TWG";
			tdataArray["twg"][".sqlWhereExpr"] = "";
			tdataArray["twg"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["twg"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["twg"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["twg"][".highlightSearchResults"] = true;
			tableKeysArray["twg"] = SettingsMap.GetArray();
			tableKeysArray["twg"].Add("TWGId");
			tdataArray["twg"][".Keys"] = tableKeysArray["twg"];
			tdataArray["twg"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "TWGId";
			fdata["GoodName"] = "TWGId";
			fdata["ownerTable"] = "dbo.TWG";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TWG","TWGId");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "TWGId";
			fdata["sourceSingle"] = "TWGId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "TWGId";
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
			tdataArray["twg"]["TWGId"] = fdata;
			tdataArray["twg"][".searchableFields"].Add("TWGId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "TWGName";
			fdata["GoodName"] = "TWGName";
			fdata["ownerTable"] = "dbo.TWG";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TWG","TWGName");
			fdata["FieldType"] = 200;
			fdata["strField"] = "TWGName";
			fdata["sourceSingle"] = "TWGName";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "TWGName";
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
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["twg"]["TWGName"] = fdata;
			tdataArray["twg"][".searchableFields"].Add("TWGName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "TWGType";
			fdata["GoodName"] = "TWGType";
			fdata["ownerTable"] = "dbo.TWG";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TWG","TWGType");
			fdata["FieldType"] = 200;
			fdata["strField"] = "TWGType";
			fdata["sourceSingle"] = "TWGType";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "TWGType";
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
			tdataArray["twg"]["TWGType"] = fdata;
			tdataArray["twg"][".searchableFields"].Add("TWGType");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "BacId";
			fdata["GoodName"] = "BacId";
			fdata["ownerTable"] = "dbo.TWG";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TWG","BacId");
			fdata["FieldType"] = 3;
			fdata["strField"] = "BacId";
			fdata["sourceSingle"] = "BACId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "BacId";
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
			edata["LookupTable"] = "dbo.BidsAndAwardsCommittee";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "Id";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "BacName";
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
			fdata["defaultSearchOption"] = "Equals";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["twg"]["BacId"] = fdata;
			tdataArray["twg"][".searchableFields"].Add("BacId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "EndUserRepresentative";
			fdata["GoodName"] = "EndUserRepresentative";
			fdata["ownerTable"] = "dbo.TWG";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TWG","EndUserRepresentative");
			fdata["FieldType"] = 200;
			fdata["strField"] = "EndUserRepresentative";
			fdata["sourceSingle"] = "EndUserRepresentative";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "EndUserRepresentative";
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
			tdataArray["twg"]["EndUserRepresentative"] = fdata;
			tdataArray["twg"][".searchableFields"].Add("EndUserRepresentative");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "CreationDate";
			fdata["GoodName"] = "CreationDate";
			fdata["ownerTable"] = "dbo.TWG";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TWG","CreationDate");
			fdata["FieldType"] = 7;
			fdata["strField"] = "CreationDate";
			fdata["sourceSingle"] = "CreationDate";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "CreationDate";
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
			tdataArray["twg"]["CreationDate"] = fdata;
			tdataArray["twg"][".searchableFields"].Add("CreationDate");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "ModificationDate";
			fdata["GoodName"] = "ModificationDate";
			fdata["ownerTable"] = "dbo.TWG";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_TWG","ModificationDate");
			fdata["FieldType"] = 7;
			fdata["strField"] = "ModificationDate";
			fdata["sourceSingle"] = "ModificationDate";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ModificationDate";
			fdata["UploadFolder"] = "files";
			fdata["ViewFormats"] = SettingsMap.GetArray();
			vdata = new XVar("ViewFormat", "Short Date");
			vdata["NeedEncode"] = true;
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
			tdataArray["twg"]["ModificationDate"] = fdata;
			tdataArray["twg"][".searchableFields"].Add("ModificationDate");
			GlobalVars.tables_data["dbo.TWG"] = tdataArray["twg"];
			GlobalVars.field_labels["dbo_TWG"] = fieldLabelsArray["twg"];
			GlobalVars.fieldToolTips["dbo_TWG"] = fieldToolTipsArray["twg"];
			GlobalVars.placeHolders["dbo_TWG"] = placeHoldersArray["twg"];
			GlobalVars.page_titles["dbo_TWG"] = pageTitlesArray["twg"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.TWG"));
			GlobalVars.detailsTablesData["dbo.TWG"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.TWGExpertise";
			detailsParam["dOriginalTable"] = "dbo.TWGExpertise";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "twgexpertise";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_TWGExpertise"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TWG"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.TWG"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TWG"][dIndex]["masterKeys"].Add("TWGId");
			GlobalVars.detailsTablesData["dbo.TWG"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.TWG"][dIndex]["detailKeys"].Add("TWGId");
			GlobalVars.masterTablesData["dbo.TWG"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.BidsAndAwardsCommittee";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.BidsAndAwardsCommittee";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "bidsandawardscommittee";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.TWG"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.TWG"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.TWG"][0]["masterKeys"].Add("Id");
			GlobalVars.masterTablesData["dbo.TWG"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.TWG"][0]["detailKeys"].Add("BacId");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "TWGId,  	TWGName,  	TWGType,  	BacId,  	EndUserRepresentative,  	CreationDate,  	ModificationDate";
protoArray["0"]["m_strFrom"] = "FROM dbo.TWG";
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
obj = new SQLField(new XVar("m_strName", "TWGId", "m_strTable", "dbo.TWG", "m_srcTableName", "dbo.TWG"));

protoArray["6"]["m_sql"] = "TWGId";
protoArray["6"]["m_srcTableName"] = "dbo.TWG";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "TWGName", "m_strTable", "dbo.TWG", "m_srcTableName", "dbo.TWG"));

protoArray["8"]["m_sql"] = "TWGName";
protoArray["8"]["m_srcTableName"] = "dbo.TWG";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "TWGType", "m_strTable", "dbo.TWG", "m_srcTableName", "dbo.TWG"));

protoArray["10"]["m_sql"] = "TWGType";
protoArray["10"]["m_srcTableName"] = "dbo.TWG";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "BacId", "m_strTable", "dbo.TWG", "m_srcTableName", "dbo.TWG"));

protoArray["12"]["m_sql"] = "BacId";
protoArray["12"]["m_srcTableName"] = "dbo.TWG";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "EndUserRepresentative", "m_strTable", "dbo.TWG", "m_srcTableName", "dbo.TWG"));

protoArray["14"]["m_sql"] = "EndUserRepresentative";
protoArray["14"]["m_srcTableName"] = "dbo.TWG";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "CreationDate", "m_strTable", "dbo.TWG", "m_srcTableName", "dbo.TWG"));

protoArray["16"]["m_sql"] = "CreationDate";
protoArray["16"]["m_srcTableName"] = "dbo.TWG";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ModificationDate", "m_strTable", "dbo.TWG", "m_srcTableName", "dbo.TWG"));

protoArray["18"]["m_sql"] = "ModificationDate";
protoArray["18"]["m_srcTableName"] = "dbo.TWG";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_link"] = "SQLL_MAIN";
protoArray["21"] = SettingsMap.GetArray();
protoArray["21"]["m_strName"] = "dbo.TWG";
protoArray["21"]["m_srcTableName"] = "dbo.TWG";
protoArray["21"]["m_columns"] = SettingsMap.GetArray();
protoArray["21"]["m_columns"].Add("TWGId");
protoArray["21"]["m_columns"].Add("TWGName");
protoArray["21"]["m_columns"].Add("TWGType");
protoArray["21"]["m_columns"].Add("BacId");
protoArray["21"]["m_columns"].Add("EndUserRepresentative");
protoArray["21"]["m_columns"].Add("CreationDate");
protoArray["21"]["m_columns"].Add("ModificationDate");
obj = new SQLTable(protoArray["21"]);

protoArray["20"]["m_table"] = obj;
protoArray["20"]["m_sql"] = "dbo.TWG";
protoArray["20"]["m_alias"] = "";
protoArray["20"]["m_srcTableName"] = "dbo.TWG";
protoArray["22"] = SettingsMap.GetArray();
protoArray["22"]["m_sql"] = "";
protoArray["22"]["m_uniontype"] = "SQLL_UNKNOWN";
obj = new SQLNonParsed(new XVar("m_sql", ""));

protoArray["22"]["m_column"] = obj;
protoArray["22"]["m_contained"] = SettingsMap.GetArray();
protoArray["22"]["m_strCase"] = "";
protoArray["22"]["m_havingmode"] = false;
protoArray["22"]["m_inBrackets"] = false;
protoArray["22"]["m_useAlias"] = false;
obj = new SQLLogicalExpr(protoArray["22"]);

protoArray["20"]["m_joinon"] = obj;
obj = new SQLFromListItem(protoArray["20"]);

protoArray["0"]["m_fromlist"].Add(obj);
protoArray["0"]["m_groupby"] = SettingsMap.GetArray();
protoArray["0"]["m_orderby"] = SettingsMap.GetArray();
protoArray["0"]["m_srcTableName"] = "dbo.TWG";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["twg"] = obj;

				
		
			tdataArray["twg"][".sqlquery"] = queryData_Array["twg"];
			tdataArray["twg"][".hasEvents"] = true;
		}
	}

}
