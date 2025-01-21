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
	public static partial class Settings_headofprocuringentity
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["headofprocuringentity"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity"][".ShortName"] = "headofprocuringentity";
			tdataArray["headofprocuringentity"][".OwnerID"] = "";
			tdataArray["headofprocuringentity"][".OriginalTable"] = "dbo.HeadOfProcuringEntity";
			tdataArray["headofprocuringentity"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["headofprocuringentity"][".originalPagesByType"] = tdataArray["headofprocuringentity"][".pagesByType"];
			tdataArray["headofprocuringentity"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["headofprocuringentity"][".originalPages"] = tdataArray["headofprocuringentity"][".pages"];
			tdataArray["headofprocuringentity"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["headofprocuringentity"][".originalDefaultPages"] = tdataArray["headofprocuringentity"][".defaultPages"];
			fieldLabelsArray["headofprocuringentity"] = SettingsMap.GetArray();
			fieldToolTipsArray["headofprocuringentity"] = SettingsMap.GetArray();
			pageTitlesArray["headofprocuringentity"] = SettingsMap.GetArray();
			placeHoldersArray["headofprocuringentity"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["headofprocuringentity"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["headofprocuringentity"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["headofprocuringentity"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["headofprocuringentity"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["headofprocuringentity"]["English"]["Id"] = "Id";
				fieldToolTipsArray["headofprocuringentity"]["English"]["Id"] = "";
				placeHoldersArray["headofprocuringentity"]["English"]["Id"] = "";
				fieldLabelsArray["headofprocuringentity"]["English"]["PersonnelId"] = "Hope Name";
				fieldToolTipsArray["headofprocuringentity"]["English"]["PersonnelId"] = "";
				placeHoldersArray["headofprocuringentity"]["English"]["PersonnelId"] = "";
				fieldLabelsArray["headofprocuringentity"]["English"]["EntityId"] = "Entity Name";
				fieldToolTipsArray["headofprocuringentity"]["English"]["EntityId"] = "";
				placeHoldersArray["headofprocuringentity"]["English"]["EntityId"] = "";
				fieldLabelsArray["headofprocuringentity"]["English"]["HopeName"] = "Hope Name";
				fieldToolTipsArray["headofprocuringentity"]["English"]["HopeName"] = "";
				placeHoldersArray["headofprocuringentity"]["English"]["HopeName"] = "";
				fieldLabelsArray["headofprocuringentity"]["English"]["HopeType"] = "Hope Type";
				fieldToolTipsArray["headofprocuringentity"]["English"]["HopeType"] = "";
				placeHoldersArray["headofprocuringentity"]["English"]["HopeType"] = "";
				fieldLabelsArray["headofprocuringentity"]["English"]["DelegationDetails"] = "Delegation Details";
				fieldToolTipsArray["headofprocuringentity"]["English"]["DelegationDetails"] = "";
				placeHoldersArray["headofprocuringentity"]["English"]["DelegationDetails"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["headofprocuringentity"]["English"])))
				{
					tdataArray["headofprocuringentity"][".isUseToolTips"] = true;
				}
			}
			tdataArray["headofprocuringentity"][".NCSearch"] = true;
			tdataArray["headofprocuringentity"][".shortTableName"] = "headofprocuringentity";
			tdataArray["headofprocuringentity"][".nSecOptions"] = 0;
			tdataArray["headofprocuringentity"][".mainTableOwnerID"] = "";
			tdataArray["headofprocuringentity"][".entityType"] = 0;
			tdataArray["headofprocuringentity"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["headofprocuringentity"][".strOriginalTableName"] = "dbo.HeadOfProcuringEntity";
			tdataArray["headofprocuringentity"][".showAddInPopup"] = false;
			tdataArray["headofprocuringentity"][".showEditInPopup"] = false;
			tdataArray["headofprocuringentity"][".showViewInPopup"] = false;
			tdataArray["headofprocuringentity"][".listAjax"] = false;
			tdataArray["headofprocuringentity"][".audit"] = false;
			tdataArray["headofprocuringentity"][".locking"] = false;
			GlobalVars.pages = tdataArray["headofprocuringentity"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["headofprocuringentity"][".edit"] = true;
				tdataArray["headofprocuringentity"][".afterEditAction"] = 0;
				tdataArray["headofprocuringentity"][".closePopupAfterEdit"] = 1;
				tdataArray["headofprocuringentity"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["headofprocuringentity"][".add"] = true;
				tdataArray["headofprocuringentity"][".afterAddAction"] = 0;
				tdataArray["headofprocuringentity"][".closePopupAfterAdd"] = 1;
				tdataArray["headofprocuringentity"][".afterAddActionDetTable"] = "dbo.BACSecretariat";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["headofprocuringentity"][".list"] = true;
			}
			tdataArray["headofprocuringentity"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["headofprocuringentity"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["headofprocuringentity"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["headofprocuringentity"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["headofprocuringentity"][".printFriendly"] = true;
			}
			tdataArray["headofprocuringentity"][".showSimpleSearchOptions"] = true;
			tdataArray["headofprocuringentity"][".allowShowHideFields"] = true;
			tdataArray["headofprocuringentity"][".allowFieldsReordering"] = true;
			tdataArray["headofprocuringentity"][".isUseAjaxSuggest"] = true;


			tdataArray["headofprocuringentity"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["headofprocuringentity"][".buttonsAdded"] = false;
			tdataArray["headofprocuringentity"][".addPageEvents"] = false;
			tdataArray["headofprocuringentity"][".isUseTimeForSearch"] = false;
			tdataArray["headofprocuringentity"][".badgeColor"] = "1E90FF";
			tdataArray["headofprocuringentity"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity"][".googleLikeFields"].Add("Id");
			tdataArray["headofprocuringentity"][".googleLikeFields"].Add("PersonnelId");
			tdataArray["headofprocuringentity"][".googleLikeFields"].Add("EntityId");
			tdataArray["headofprocuringentity"][".googleLikeFields"].Add("HopeName");
			tdataArray["headofprocuringentity"][".googleLikeFields"].Add("HopeType");
			tdataArray["headofprocuringentity"][".googleLikeFields"].Add("DelegationDetails");
			tdataArray["headofprocuringentity"][".tableType"] = "list";
			tdataArray["headofprocuringentity"][".printerPageOrientation"] = 0;
			tdataArray["headofprocuringentity"][".nPrinterPageScale"] = 100;
			tdataArray["headofprocuringentity"][".nPrinterSplitRecords"] = 40;
			tdataArray["headofprocuringentity"][".geocodingEnabled"] = false;
			tdataArray["headofprocuringentity"][".pageSize"] = 20;
			tdataArray["headofprocuringentity"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["headofprocuringentity"][".strOrderBy"] = tstrOrderBy;
			tdataArray["headofprocuringentity"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["headofprocuringentity"][".sqlHead"] = "SELECT Id,  	PersonnelId,  	EntityId,  	HopeName,  	HopeType,  	DelegationDetails";
			tdataArray["headofprocuringentity"][".sqlFrom"] = "FROM dbo.HeadOfProcuringEntity";
			tdataArray["headofprocuringentity"][".sqlWhereExpr"] = "";
			tdataArray["headofprocuringentity"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["headofprocuringentity"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["headofprocuringentity"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["headofprocuringentity"][".highlightSearchResults"] = true;
			tableKeysArray["headofprocuringentity"] = SettingsMap.GetArray();
			tableKeysArray["headofprocuringentity"].Add("Id");
			tdataArray["headofprocuringentity"][".Keys"] = tableKeysArray["headofprocuringentity"];
			tdataArray["headofprocuringentity"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Id";
			fdata["GoodName"] = "Id";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity","Id");
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
			tdataArray["headofprocuringentity"]["Id"] = fdata;
			tdataArray["headofprocuringentity"][".searchableFields"].Add("Id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "PersonnelId";
			fdata["GoodName"] = "PersonnelId";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity","PersonnelId");
			fdata["FieldType"] = 3;
			fdata["strField"] = "PersonnelId";
			fdata["sourceSingle"] = "PersonnelId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "PersonnelId";
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
			edata["LookupTable"] = "dbo.Personnel";
			edata["autoCompleteFieldsOnEdit"] = 1;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["autoCompleteFields"].Add(new XVar("masterF", "HopeName", "lookupF", "Name"));
			edata["LCType"] = 0;
			edata["LinkField"] = "Id";
			edata["LinkFieldType"] = 3;
			edata["DisplayField"] = "Name + ' ' + '-'  + ' ' + Rank";
			edata["CustomDisplay"] = "true";
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
			tdataArray["headofprocuringentity"]["PersonnelId"] = fdata;
			tdataArray["headofprocuringentity"][".searchableFields"].Add("PersonnelId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "EntityId";
			fdata["GoodName"] = "EntityId";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity","EntityId");
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
			tdataArray["headofprocuringentity"]["EntityId"] = fdata;
			tdataArray["headofprocuringentity"][".searchableFields"].Add("EntityId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "HopeName";
			fdata["GoodName"] = "HopeName";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity","HopeName");
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
			edata = new XVar("EditFormat", "Lookup wizard");
			edata["weekdayMessage"] = new XVar("message", "", "messageType", "Text");
			edata["weekdays"] = "[]";
			edata["LookupType"] = 2;
			edata["LookupTable"] = "dbo.Personnel";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["autoCompleteFields"].Add(new XVar("masterF", "PersonnelId", "lookupF", "Id"));
			edata["LCType"] = 0;
			edata["LinkField"] = "Name";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "Name";
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
			tdataArray["headofprocuringentity"]["HopeName"] = fdata;
			tdataArray["headofprocuringentity"][".searchableFields"].Add("HopeName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "HopeType";
			fdata["GoodName"] = "HopeType";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity","HopeType");
			fdata["FieldType"] = 200;
			fdata["strField"] = "HopeType";
			fdata["sourceSingle"] = "HopeType";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "HopeType";
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
			tdataArray["headofprocuringentity"]["HopeType"] = fdata;
			tdataArray["headofprocuringentity"][".searchableFields"].Add("HopeType");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "DelegationDetails";
			fdata["GoodName"] = "DelegationDetails";
			fdata["ownerTable"] = "dbo.HeadOfProcuringEntity";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_HeadOfProcuringEntity","DelegationDetails");
			fdata["FieldType"] = 200;
			fdata["strField"] = "DelegationDetails";
			fdata["sourceSingle"] = "DelegationDetails";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "DelegationDetails";
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
			tdataArray["headofprocuringentity"]["DelegationDetails"] = fdata;
			tdataArray["headofprocuringentity"][".searchableFields"].Add("DelegationDetails");
			GlobalVars.tables_data["dbo.HeadOfProcuringEntity"] = tdataArray["headofprocuringentity"];
			GlobalVars.field_labels["dbo_HeadOfProcuringEntity"] = fieldLabelsArray["headofprocuringentity"];
			GlobalVars.fieldToolTips["dbo_HeadOfProcuringEntity"] = fieldToolTipsArray["headofprocuringentity"];
			GlobalVars.placeHolders["dbo_HeadOfProcuringEntity"] = placeHoldersArray["headofprocuringentity"];
			GlobalVars.page_titles["dbo_HeadOfProcuringEntity"] = pageTitlesArray["headofprocuringentity"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.HeadOfProcuringEntity"));
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.BACSecretariat";
			detailsParam["dOriginalTable"] = "dbo.BACSecretariat";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "bacsecretariat";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_BACSecretariat"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity"][dIndex]["masterKeys"].Add("Id");
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.HeadOfProcuringEntity"][dIndex]["detailKeys"].Add("HopeId");
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.Personnel";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.Personnel";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "personnel";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][0]["masterKeys"].Add("Id");
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][0]["detailKeys"].Add("PersonnelId");


			strOriginalDetailsTable = "dbo.ProcuringEntity";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.ProcuringEntity";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "procuringentity";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][1] = masterParams;
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][1]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][1]["masterKeys"].Add("Id");
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][1]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.HeadOfProcuringEntity"][1]["detailKeys"].Add("EntityId");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Id,  	PersonnelId,  	EntityId,  	HopeName,  	HopeType,  	DelegationDetails";
protoArray["0"]["m_strFrom"] = "FROM dbo.HeadOfProcuringEntity";
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
obj = new SQLField(new XVar("m_strName", "Id", "m_strTable", "dbo.HeadOfProcuringEntity", "m_srcTableName", "dbo.HeadOfProcuringEntity"));

protoArray["6"]["m_sql"] = "Id";
protoArray["6"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "PersonnelId", "m_strTable", "dbo.HeadOfProcuringEntity", "m_srcTableName", "dbo.HeadOfProcuringEntity"));

protoArray["8"]["m_sql"] = "PersonnelId";
protoArray["8"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "EntityId", "m_strTable", "dbo.HeadOfProcuringEntity", "m_srcTableName", "dbo.HeadOfProcuringEntity"));

protoArray["10"]["m_sql"] = "EntityId";
protoArray["10"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "HopeName", "m_strTable", "dbo.HeadOfProcuringEntity", "m_srcTableName", "dbo.HeadOfProcuringEntity"));

protoArray["12"]["m_sql"] = "HopeName";
protoArray["12"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "HopeType", "m_strTable", "dbo.HeadOfProcuringEntity", "m_srcTableName", "dbo.HeadOfProcuringEntity"));

protoArray["14"]["m_sql"] = "HopeType";
protoArray["14"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "DelegationDetails", "m_strTable", "dbo.HeadOfProcuringEntity", "m_srcTableName", "dbo.HeadOfProcuringEntity"));

protoArray["16"]["m_sql"] = "DelegationDetails";
protoArray["16"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["18"] = SettingsMap.GetArray();
protoArray["18"]["m_link"] = "SQLL_MAIN";
protoArray["19"] = SettingsMap.GetArray();
protoArray["19"]["m_strName"] = "dbo.HeadOfProcuringEntity";
protoArray["19"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity";
protoArray["19"]["m_columns"] = SettingsMap.GetArray();
protoArray["19"]["m_columns"].Add("Id");
protoArray["19"]["m_columns"].Add("PersonnelId");
protoArray["19"]["m_columns"].Add("EntityId");
protoArray["19"]["m_columns"].Add("HopeName");
protoArray["19"]["m_columns"].Add("HopeType");
protoArray["19"]["m_columns"].Add("DelegationDetails");
obj = new SQLTable(protoArray["19"]);

protoArray["18"]["m_table"] = obj;
protoArray["18"]["m_sql"] = "dbo.HeadOfProcuringEntity";
protoArray["18"]["m_alias"] = "";
protoArray["18"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity";
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
protoArray["0"]["m_srcTableName"] = "dbo.HeadOfProcuringEntity";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["headofprocuringentity"] = obj;

				
		
			tdataArray["headofprocuringentity"][".sqlquery"] = queryData_Array["headofprocuringentity"];
			tdataArray["headofprocuringentity"][".hasEvents"] = true;
		}
	}

}
