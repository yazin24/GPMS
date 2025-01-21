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
	public static partial class Settings_headofprocuringentity_hope_
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["headofprocuringentity_hope_"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity_hope_"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity_hope_"][".ShortName"] = "headofprocuringentity_hope_";
			tdataArray["headofprocuringentity_hope_"][".OwnerID"] = "";
			tdataArray["headofprocuringentity_hope_"][".OriginalTable"] = "dbo.HeadOfProcuringEntity(HOPE)";
			tdataArray["headofprocuringentity_hope_"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["headofprocuringentity_hope_"][".originalPagesByType"] = tdataArray["headofprocuringentity_hope_"][".pagesByType"];
			tdataArray["headofprocuringentity_hope_"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["headofprocuringentity_hope_"][".originalPages"] = tdataArray["headofprocuringentity_hope_"][".pages"];
			tdataArray["headofprocuringentity_hope_"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["headofprocuringentity_hope_"][".originalDefaultPages"] = tdataArray["headofprocuringentity_hope_"][".defaultPages"];
			fieldLabelsArray["headofprocuringentity_hope_"] = SettingsMap.GetArray();
			fieldToolTipsArray["headofprocuringentity_hope_"] = SettingsMap.GetArray();
			pageTitlesArray["headofprocuringentity_hope_"] = SettingsMap.GetArray();
			placeHoldersArray["headofprocuringentity_hope_"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["headofprocuringentity_hope_"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["headofprocuringentity_hope_"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["headofprocuringentity_hope_"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["headofprocuringentity_hope_"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["headofprocuringentity_hope_"]["English"]["HopeId"] = "Hope Id";
				fieldToolTipsArray["headofprocuringentity_hope_"]["English"]["HopeId"] = "";
				placeHoldersArray["headofprocuringentity_hope_"]["English"]["HopeId"] = "";
				fieldLabelsArray["headofprocuringentity_hope_"]["English"]["EntityId"] = "Entity";
				fieldToolTipsArray["headofprocuringentity_hope_"]["English"]["EntityId"] = "";
				placeHoldersArray["headofprocuringentity_hope_"]["English"]["EntityId"] = "";
				fieldLabelsArray["headofprocuringentity_hope_"]["English"]["HopeName"] = "Hope Name";
				fieldToolTipsArray["headofprocuringentity_hope_"]["English"]["HopeName"] = "";
				placeHoldersArray["headofprocuringentity_hope_"]["English"]["HopeName"] = "";
				fieldLabelsArray["headofprocuringentity_hope_"]["English"]["HopeType"] = "Hope Type";
				fieldToolTipsArray["headofprocuringentity_hope_"]["English"]["HopeType"] = "";
				placeHoldersArray["headofprocuringentity_hope_"]["English"]["HopeType"] = "";
				fieldLabelsArray["headofprocuringentity_hope_"]["English"]["DelegationDetails"] = "Delegation Details";
				fieldToolTipsArray["headofprocuringentity_hope_"]["English"]["DelegationDetails"] = "";
				placeHoldersArray["headofprocuringentity_hope_"]["English"]["DelegationDetails"] = "";
				pageTitlesArray["headofprocuringentity_hope_"]["English"]["add"] = "Add new record here";
				pageTitlesArray["headofprocuringentity_hope_"]["English"]["edit"] = "Edit details as";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["headofprocuringentity_hope_"]["English"])))
				{
					tdataArray["headofprocuringentity_hope_"][".isUseToolTips"] = true;
				}
			}
			tdataArray["headofprocuringentity_hope_"][".NCSearch"] = true;
			tdataArray["headofprocuringentity_hope_"][".shortTableName"] = "headofprocuringentity_hope_";
			tdataArray["headofprocuringentity_hope_"][".nSecOptions"] = 0;
			tdataArray["headofprocuringentity_hope_"][".mainTableOwnerID"] = "";
			tdataArray["headofprocuringentity_hope_"][".entityType"] = 0;
			tdataArray["headofprocuringentity_hope_"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["headofprocuringentity_hope_"][".strOriginalTableName"] = "dbo.HeadOfProcuringEntity(HOPE)";
			tdataArray["headofprocuringentity_hope_"][".showAddInPopup"] = false;
			tdataArray["headofprocuringentity_hope_"][".showEditInPopup"] = false;
			tdataArray["headofprocuringentity_hope_"][".showViewInPopup"] = false;
			tdataArray["headofprocuringentity_hope_"][".listAjax"] = false;
			tdataArray["headofprocuringentity_hope_"][".audit"] = false;
			tdataArray["headofprocuringentity_hope_"][".locking"] = false;
			GlobalVars.pages = tdataArray["headofprocuringentity_hope_"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["headofprocuringentity_hope_"][".edit"] = true;
				tdataArray["headofprocuringentity_hope_"][".afterEditAction"] = 1;
				tdataArray["headofprocuringentity_hope_"][".closePopupAfterEdit"] = 1;
				tdataArray["headofprocuringentity_hope_"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["headofprocuringentity_hope_"][".add"] = true;
				tdataArray["headofprocuringentity_hope_"][".afterAddAction"] = 0;
				tdataArray["headofprocuringentity_hope_"][".closePopupAfterAdd"] = 1;
				tdataArray["headofprocuringentity_hope_"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["headofprocuringentity_hope_"][".list"] = true;
			}
			tdataArray["headofprocuringentity_hope_"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["headofprocuringentity_hope_"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["headofprocuringentity_hope_"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["headofprocuringentity_hope_"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["headofprocuringentity_hope_"][".printFriendly"] = true;
			}
			tdataArray["headofprocuringentity_hope_"][".showSimpleSearchOptions"] = true;
			tdataArray["headofprocuringentity_hope_"][".allowShowHideFields"] = true;
			tdataArray["headofprocuringentity_hope_"][".allowFieldsReordering"] = true;
			tdataArray["headofprocuringentity_hope_"][".isUseAjaxSuggest"] = true;


			tdataArray["headofprocuringentity_hope_"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["headofprocuringentity_hope_"][".buttonsAdded"] = false;
			tdataArray["headofprocuringentity_hope_"][".addPageEvents"] = true;
			tdataArray["headofprocuringentity_hope_"][".isUseTimeForSearch"] = false;
			tdataArray["headofprocuringentity_hope_"][".badgeColor"] = "5F9EA0";
			tdataArray["headofprocuringentity_hope_"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity_hope_"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity_hope_"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity_hope_"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity_hope_"][".googleLikeFields"].Add("HopeId");
			tdataArray["headofprocuringentity_hope_"][".googleLikeFields"].Add("EntityId");
			tdataArray["headofprocuringentity_hope_"][".googleLikeFields"].Add("HopeName");
			tdataArray["headofprocuringentity_hope_"][".googleLikeFields"].Add("HopeType");
			tdataArray["headofprocuringentity_hope_"][".googleLikeFields"].Add("DelegationDetails");
			tdataArray["headofprocuringentity_hope_"][".tableType"] = "list";
			tdataArray["headofprocuringentity_hope_"][".printerPageOrientation"] = 0;
			tdataArray["headofprocuringentity_hope_"][".nPrinterPageScale"] = 100;
			tdataArray["headofprocuringentity_hope_"][".nPrinterSplitRecords"] = 40;
			tdataArray["headofprocuringentity_hope_"][".geocodingEnabled"] = false;
			tdataArray["headofprocuringentity_hope_"][".pageSize"] = 20;
			tdataArray["headofprocuringentity_hope_"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["headofprocuringentity_hope_"][".strOrderBy"] = tstrOrderBy;
			tdataArray["headofprocuringentity_hope_"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity_hope_"][".sqlHead"] = "SELECT HopeId,  	EntityId,  	HopeName,  	HopeType,  	DelegationDetails";
			tdataArray["headofprocuringentity_hope_"][".sqlFrom"] = "FROM dbo.[HeadOfProcuringEntity(HOPE)]";
			tdataArray["headofprocuringentity_hope_"][".sqlWhereExpr"] = "";
			tdataArray["headofprocuringentity_hope_"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["headofprocuringentity_hope_"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["headofprocuringentity_hope_"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["headofprocuringentity_hope_"][".highlightSearchResults"] = true;
			tableKeysArray["headofprocuringentity_hope_"] = SettingsMap.GetArray();
			tableKeysArray["headofprocuringentity_hope_"].Add("HopeId");
			tdataArray["headofprocuringentity_hope_"][".Keys"] = tableKeysArray["headofprocuringentity_hope_"];
			tdataArray["headofprocuringentity_hope_"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "HopeId";
			fdata["GoodName"] = "HopeId";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity(HOPE)";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity_HOPE_","HopeId");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "HopeId";
			fdata["sourceSingle"] = "HopeId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "HopeId";
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
			tdataArray["headofprocuringentity_hope_"]["HopeId"] = fdata;
			tdataArray["headofprocuringentity_hope_"][".searchableFields"].Add("HopeId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "EntityId";
			fdata["GoodName"] = "EntityId";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity(HOPE)";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity_HOPE_","EntityId");
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
			edata["LinkField"] = "EntityId";
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
			fdata["defaultSearchOption"] = "Contains";
			fdata["searchOptionsList"] = new XVar(0, "Contains", 1, "Equals", 2, "Starts with", 3, "More than", 4, "Less than", 5, "Between", 6, "Empty", 7, Constants.NOT_EMPTY);
			fdata["filterTotals"] = 0;
			fdata["filterMultiSelect"] = 0;
			fdata["filterFormat"] = "Values list";
			fdata["showCollapsed"] = false;
			fdata["sortValueType"] = 0;
			fdata["numberOfVisibleItems"] = 10;
			fdata["filterBy"] = 0;
			tdataArray["headofprocuringentity_hope_"]["EntityId"] = fdata;
			tdataArray["headofprocuringentity_hope_"][".searchableFields"].Add("EntityId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "HopeName";
			fdata["GoodName"] = "HopeName";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity(HOPE)";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity_HOPE_","HopeName");
			fdata["FieldType"] = 200;
			fdata["strField"] = "HopeName";
			fdata["sourceSingle"] = "HopeName";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "HopeName";
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
			tdataArray["headofprocuringentity_hope_"]["HopeName"] = fdata;
			tdataArray["headofprocuringentity_hope_"][".searchableFields"].Add("HopeName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "HopeType";
			fdata["GoodName"] = "HopeType";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity(HOPE)";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity_HOPE_","HopeType");
			fdata["FieldType"] = 200;
			fdata["strField"] = "HopeType";
			fdata["sourceSingle"] = "HopeType";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "HopeType";
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
			tdataArray["headofprocuringentity_hope_"]["HopeType"] = fdata;
			tdataArray["headofprocuringentity_hope_"][".searchableFields"].Add("HopeType");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "DelegationDetails";
			fdata["GoodName"] = "DelegationDetails";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity(HOPE)";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity_HOPE_","DelegationDetails");
			fdata["FieldType"] = 201;
			fdata["strField"] = "DelegationDetails";
			fdata["sourceSingle"] = "DelegationDetails";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "DelegationDetails";
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
			tdataArray["headofprocuringentity_hope_"]["DelegationDetails"] = fdata;
			tdataArray["headofprocuringentity_hope_"][".searchableFields"].Add("DelegationDetails");
			GlobalVars.tables_data["dbo.HeadOfProcuringEntity(HOPE)"] = tdataArray["headofprocuringentity_hope_"];
			GlobalVars.field_labels["dbo_HeadOfProcuringEntity_HOPE_"] = fieldLabelsArray["headofprocuringentity_hope_"];
			GlobalVars.fieldToolTips["dbo_HeadOfProcuringEntity_HOPE_"] = fieldToolTipsArray["headofprocuringentity_hope_"];
			GlobalVars.placeHolders["dbo_HeadOfProcuringEntity_HOPE_"] = placeHoldersArray["headofprocuringentity_hope_"];
			GlobalVars.page_titles["dbo_HeadOfProcuringEntity_HOPE_"] = pageTitlesArray["headofprocuringentity_hope_"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.HeadOfProcuringEntity(HOPE)"));
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity(HOPE)"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.BACSecretariat";
			detailsParam["dOriginalTable"] = "dbo.BACSecretariat";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "bacsecretariat";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_BACSecretariat"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity(HOPE)"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity(HOPE)"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity(HOPE)"][dIndex]["masterKeys"].Add("HopeId");
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity(HOPE)"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity(HOPE)"][dIndex]["detailKeys"].Add("HopeId");
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity(HOPE)"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.ProcuringEntity";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.ProcuringEntity";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "procuringentity";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity(HOPE)"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity(HOPE)"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity(HOPE)"][0]["masterKeys"].Add("EntityId");
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity(HOPE)"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity(HOPE)"][0]["detailKeys"].Add("EntityId");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "HopeId,  	EntityId,  	HopeName,  	HopeType,  	DelegationDetails";
protoArray["0"]["m_strFrom"] = "FROM dbo.[HeadOfProcuringEntity(HOPE)]";
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
obj = new SQLField(new XVar("m_strName", "HopeId", "m_strTable", "dbo.HeadOfProcuringEntity(HOPE)", "m_srcTableName", "dbo.HeadOfProcuringEntity(HOPE)"));

protoArray["6"]["m_sql"] = "HopeId";
protoArray["6"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity(HOPE)";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "EntityId", "m_strTable", "dbo.HeadOfProcuringEntity(HOPE)", "m_srcTableName", "dbo.HeadOfProcuringEntity(HOPE)"));

protoArray["8"]["m_sql"] = "EntityId";
protoArray["8"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity(HOPE)";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "HopeName", "m_strTable", "dbo.HeadOfProcuringEntity(HOPE)", "m_srcTableName", "dbo.HeadOfProcuringEntity(HOPE)"));

protoArray["10"]["m_sql"] = "HopeName";
protoArray["10"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity(HOPE)";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "HopeType", "m_strTable", "dbo.HeadOfProcuringEntity(HOPE)", "m_srcTableName", "dbo.HeadOfProcuringEntity(HOPE)"));

protoArray["12"]["m_sql"] = "HopeType";
protoArray["12"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity(HOPE)";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "DelegationDetails", "m_strTable", "dbo.HeadOfProcuringEntity(HOPE)", "m_srcTableName", "dbo.HeadOfProcuringEntity(HOPE)"));

protoArray["14"]["m_sql"] = "DelegationDetails";
protoArray["14"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity(HOPE)";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.HeadOfProcuringEntity(HOPE)";
protoArray["17"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity(HOPE)";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("HopeId");
protoArray["17"]["m_columns"].Add("EntityId");
protoArray["17"]["m_columns"].Add("HopeName");
protoArray["17"]["m_columns"].Add("HopeType");
protoArray["17"]["m_columns"].Add("DelegationDetails");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.[HeadOfProcuringEntity(HOPE)]";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity(HOPE)";
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
protoArray["0"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity(HOPE)";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["headofprocuringentity_hope_"] = obj;

				
		
			tdataArray["headofprocuringentity_hope_"][".sqlquery"] = queryData_Array["headofprocuringentity_hope_"];
			tdataArray["headofprocuringentity_hope_"][".hasEvents"] = true;
		}
	}

}
