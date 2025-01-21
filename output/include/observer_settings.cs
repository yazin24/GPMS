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
	public static partial class Settings_observer
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["observer"] = SettingsMap.GetArray();
			tdataArray["observer"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["observer"][".ShortName"] = "observer";
			tdataArray["observer"][".OwnerID"] = "";
			tdataArray["observer"][".OriginalTable"] = "dbo.Observer";
			tdataArray["observer"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["observer"][".originalPagesByType"] = tdataArray["observer"][".pagesByType"];
			tdataArray["observer"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["observer"][".originalPages"] = tdataArray["observer"][".pages"];
			tdataArray["observer"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["observer"][".originalDefaultPages"] = tdataArray["observer"][".defaultPages"];
			fieldLabelsArray["observer"] = SettingsMap.GetArray();
			fieldToolTipsArray["observer"] = SettingsMap.GetArray();
			pageTitlesArray["observer"] = SettingsMap.GetArray();
			placeHoldersArray["observer"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["observer"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["observer"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["observer"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["observer"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["observer"]["English"]["ObserverId"] = "Observer Id";
				fieldToolTipsArray["observer"]["English"]["ObserverId"] = "";
				placeHoldersArray["observer"]["English"]["ObserverId"] = "";
				fieldLabelsArray["observer"]["English"]["ObserverName"] = "Observer Name";
				fieldToolTipsArray["observer"]["English"]["ObserverName"] = "";
				placeHoldersArray["observer"]["English"]["ObserverName"] = "";
				fieldLabelsArray["observer"]["English"]["ObserverOrganization"] = "Observer Organization";
				fieldToolTipsArray["observer"]["English"]["ObserverOrganization"] = "";
				placeHoldersArray["observer"]["English"]["ObserverOrganization"] = "";
				fieldLabelsArray["observer"]["English"]["ContactDetails"] = "Contact Details";
				fieldToolTipsArray["observer"]["English"]["ContactDetails"] = "";
				placeHoldersArray["observer"]["English"]["ContactDetails"] = "";
				fieldLabelsArray["observer"]["English"]["DateJoined"] = "Date Joined";
				fieldToolTipsArray["observer"]["English"]["DateJoined"] = "";
				placeHoldersArray["observer"]["English"]["DateJoined"] = "";
				fieldLabelsArray["observer"]["English"]["ConfidentialityAgreement"] = "Confidentiality Agreement";
				fieldToolTipsArray["observer"]["English"]["ConfidentialityAgreement"] = "";
				placeHoldersArray["observer"]["English"]["ConfidentialityAgreement"] = "";
				fieldLabelsArray["observer"]["English"]["PersonnelId"] = "Observer Name";
				fieldToolTipsArray["observer"]["English"]["PersonnelId"] = "";
				placeHoldersArray["observer"]["English"]["PersonnelId"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["observer"]["English"])))
				{
					tdataArray["observer"][".isUseToolTips"] = true;
				}
			}
			tdataArray["observer"][".NCSearch"] = true;
			tdataArray["observer"][".shortTableName"] = "observer";
			tdataArray["observer"][".nSecOptions"] = 0;
			tdataArray["observer"][".mainTableOwnerID"] = "";
			tdataArray["observer"][".entityType"] = 0;
			tdataArray["observer"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["observer"][".strOriginalTableName"] = "dbo.Observer";
			tdataArray["observer"][".showAddInPopup"] = false;
			tdataArray["observer"][".showEditInPopup"] = false;
			tdataArray["observer"][".showViewInPopup"] = false;
			tdataArray["observer"][".listAjax"] = false;
			tdataArray["observer"][".audit"] = false;
			tdataArray["observer"][".locking"] = false;
			GlobalVars.pages = tdataArray["observer"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["observer"][".edit"] = true;
				tdataArray["observer"][".afterEditAction"] = 0;
				tdataArray["observer"][".closePopupAfterEdit"] = 1;
				tdataArray["observer"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["observer"][".add"] = true;
				tdataArray["observer"][".afterAddAction"] = 0;
				tdataArray["observer"][".closePopupAfterAdd"] = 1;
				tdataArray["observer"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["observer"][".list"] = true;
			}
			tdataArray["observer"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["observer"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["observer"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["observer"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["observer"][".printFriendly"] = true;
			}
			tdataArray["observer"][".showSimpleSearchOptions"] = true;
			tdataArray["observer"][".allowShowHideFields"] = true;
			tdataArray["observer"][".allowFieldsReordering"] = true;
			tdataArray["observer"][".isUseAjaxSuggest"] = true;


			tdataArray["observer"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["observer"][".buttonsAdded"] = false;
			tdataArray["observer"][".addPageEvents"] = true;
			tdataArray["observer"][".isUseTimeForSearch"] = false;
			tdataArray["observer"][".badgeColor"] = "3CB371";
			tdataArray["observer"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["observer"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["observer"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["observer"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["observer"][".googleLikeFields"].Add("ObserverId");
			tdataArray["observer"][".googleLikeFields"].Add("PersonnelId");
			tdataArray["observer"][".googleLikeFields"].Add("ObserverName");
			tdataArray["observer"][".googleLikeFields"].Add("ObserverOrganization");
			tdataArray["observer"][".googleLikeFields"].Add("ContactDetails");
			tdataArray["observer"][".googleLikeFields"].Add("DateJoined");
			tdataArray["observer"][".googleLikeFields"].Add("ConfidentialityAgreement");
			tdataArray["observer"][".tableType"] = "list";
			tdataArray["observer"][".printerPageOrientation"] = 0;
			tdataArray["observer"][".nPrinterPageScale"] = 100;
			tdataArray["observer"][".nPrinterSplitRecords"] = 40;
			tdataArray["observer"][".geocodingEnabled"] = false;
			tdataArray["observer"][".pageSize"] = 20;
			tdataArray["observer"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["observer"][".strOrderBy"] = tstrOrderBy;
			tdataArray["observer"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["observer"][".sqlHead"] = "SELECT ObserverId,  	PersonnelId,  	ObserverName,  	ObserverOrganization,  	ContactDetails,  	DateJoined,  	ConfidentialityAgreement";
			tdataArray["observer"][".sqlFrom"] = "FROM dbo.Observer";
			tdataArray["observer"][".sqlWhereExpr"] = "";
			tdataArray["observer"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["observer"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["observer"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["observer"][".highlightSearchResults"] = true;
			tableKeysArray["observer"] = SettingsMap.GetArray();
			tableKeysArray["observer"].Add("ObserverId");
			tdataArray["observer"][".Keys"] = tableKeysArray["observer"];
			tdataArray["observer"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "ObserverId";
			fdata["GoodName"] = "ObserverId";
			fdata["ownerTable"] = "dbo.Observer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Observer","ObserverId");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "ObserverId";
			fdata["sourceSingle"] = "ObserverId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ObserverId";
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
			tdataArray["observer"]["ObserverId"] = fdata;
			tdataArray["observer"][".searchableFields"].Add("ObserverId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "PersonnelId";
			fdata["GoodName"] = "PersonnelId";
			fdata["ownerTable"] = "dbo.Observer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Observer","PersonnelId");
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
			edata["autoCompleteFields"].Add(new XVar("masterF", "ObserverName", "lookupF", "Name"));
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
			tdataArray["observer"]["PersonnelId"] = fdata;
			tdataArray["observer"][".searchableFields"].Add("PersonnelId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "ObserverName";
			fdata["GoodName"] = "ObserverName";
			fdata["ownerTable"] = "dbo.Observer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Observer","ObserverName");
			fdata["FieldType"] = 200;
			fdata["strField"] = "ObserverName";
			fdata["sourceSingle"] = "ObserverName";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ObserverName";
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
			edata["LookupTable"] = "dbo.Personnel";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "Name";
			edata["LinkFieldType"] = 0;
			edata["DisplayField"] = "Name";
			edata["LookupOrderBy"] = "";
			edata["SelectSize"] = 1;
			edata["acceptFileTypesHtml"] = "";
			edata["maxNumberOfFiles"] = 0;
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
			tdataArray["observer"]["ObserverName"] = fdata;
			tdataArray["observer"][".searchableFields"].Add("ObserverName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "ObserverOrganization";
			fdata["GoodName"] = "ObserverOrganization";
			fdata["ownerTable"] = "dbo.Observer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Observer","ObserverOrganization");
			fdata["FieldType"] = 200;
			fdata["strField"] = "ObserverOrganization";
			fdata["sourceSingle"] = "ObserverOrganization";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ObserverOrganization";
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
			tdataArray["observer"]["ObserverOrganization"] = fdata;
			tdataArray["observer"][".searchableFields"].Add("ObserverOrganization");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "ContactDetails";
			fdata["GoodName"] = "ContactDetails";
			fdata["ownerTable"] = "dbo.Observer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Observer","ContactDetails");
			fdata["FieldType"] = 200;
			fdata["strField"] = "ContactDetails";
			fdata["sourceSingle"] = "ContactDetails";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ContactDetails";
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
			tdataArray["observer"]["ContactDetails"] = fdata;
			tdataArray["observer"][".searchableFields"].Add("ContactDetails");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "DateJoined";
			fdata["GoodName"] = "DateJoined";
			fdata["ownerTable"] = "dbo.Observer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Observer","DateJoined");
			fdata["FieldType"] = 7;
			fdata["strField"] = "DateJoined";
			fdata["sourceSingle"] = "DateJoined";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "DateJoined";
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
			tdataArray["observer"]["DateJoined"] = fdata;
			tdataArray["observer"][".searchableFields"].Add("DateJoined");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "ConfidentialityAgreement";
			fdata["GoodName"] = "ConfidentialityAgreement";
			fdata["ownerTable"] = "dbo.Observer";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Observer","ConfidentialityAgreement");
			fdata["FieldType"] = 11;
			fdata["strField"] = "ConfidentialityAgreement";
			fdata["sourceSingle"] = "ConfidentialityAgreement";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ConfidentialityAgreement";
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
			edata["LookupType"] = 0;
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 4;
			edata["HorizontalLookup"] = true;
			edata["LookupValues"] = SettingsMap.GetArray();
			edata["LookupValues"].Add("Yes");
			edata["LookupValues"].Add("No");
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
			tdataArray["observer"]["ConfidentialityAgreement"] = fdata;
			tdataArray["observer"][".searchableFields"].Add("ConfidentialityAgreement");
			GlobalVars.tables_data["dbo.Observer"] = tdataArray["observer"];
			GlobalVars.field_labels["dbo_Observer"] = fieldLabelsArray["observer"];
			GlobalVars.fieldToolTips["dbo_Observer"] = fieldToolTipsArray["observer"];
			GlobalVars.placeHolders["dbo_Observer"] = placeHoldersArray["observer"];
			GlobalVars.page_titles["dbo_Observer"] = pageTitlesArray["observer"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.Observer"));
			GlobalVars.detailsTablesData["dbo.Observer"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.ObserverInterest";
			detailsParam["dOriginalTable"] = "dbo.ObserverInterest";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "observerinterest";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_ObserverInterest"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex]["masterKeys"].Add("ObserverId");
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex]["detailKeys"].Add("ObserverId");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.ObserverReport";
			detailsParam["dOriginalTable"] = "dbo.ObserverReport";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "observerreport";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_ObserverReport"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex]["masterKeys"].Add("ObserverId");
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Observer"][dIndex]["detailKeys"].Add("ObserverId");
			GlobalVars.masterTablesData["dbo.Observer"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "ObserverId,  	PersonnelId,  	ObserverName,  	ObserverOrganization,  	ContactDetails,  	DateJoined,  	ConfidentialityAgreement";
protoArray["0"]["m_strFrom"] = "FROM dbo.Observer";
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
obj = new SQLField(new XVar("m_strName", "ObserverId", "m_strTable", "dbo.Observer", "m_srcTableName", "dbo.Observer"));

protoArray["6"]["m_sql"] = "ObserverId";
protoArray["6"]["m_srcTableName"] = "dbo.Observer";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "PersonnelId", "m_strTable", "dbo.Observer", "m_srcTableName", "dbo.Observer"));

protoArray["8"]["m_sql"] = "PersonnelId";
protoArray["8"]["m_srcTableName"] = "dbo.Observer";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ObserverName", "m_strTable", "dbo.Observer", "m_srcTableName", "dbo.Observer"));

protoArray["10"]["m_sql"] = "ObserverName";
protoArray["10"]["m_srcTableName"] = "dbo.Observer";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ObserverOrganization", "m_strTable", "dbo.Observer", "m_srcTableName", "dbo.Observer"));

protoArray["12"]["m_sql"] = "ObserverOrganization";
protoArray["12"]["m_srcTableName"] = "dbo.Observer";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ContactDetails", "m_strTable", "dbo.Observer", "m_srcTableName", "dbo.Observer"));

protoArray["14"]["m_sql"] = "ContactDetails";
protoArray["14"]["m_srcTableName"] = "dbo.Observer";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "DateJoined", "m_strTable", "dbo.Observer", "m_srcTableName", "dbo.Observer"));

protoArray["16"]["m_sql"] = "DateJoined";
protoArray["16"]["m_srcTableName"] = "dbo.Observer";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ConfidentialityAgreement", "m_strTable", "dbo.Observer", "m_srcTableName", "dbo.Observer"));

protoArray["18"]["m_sql"] = "ConfidentialityAgreement";
protoArray["18"]["m_srcTableName"] = "dbo.Observer";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_link"] = "SQLL_MAIN";
protoArray["21"] = SettingsMap.GetArray();
protoArray["21"]["m_strName"] = "dbo.Observer";
protoArray["21"]["m_srcTableName"] = "dbo.Observer";
protoArray["21"]["m_columns"] = SettingsMap.GetArray();
protoArray["21"]["m_columns"].Add("ObserverId");
protoArray["21"]["m_columns"].Add("PersonnelId");
protoArray["21"]["m_columns"].Add("ObserverName");
protoArray["21"]["m_columns"].Add("ObserverOrganization");
protoArray["21"]["m_columns"].Add("ContactDetails");
protoArray["21"]["m_columns"].Add("DateJoined");
protoArray["21"]["m_columns"].Add("ConfidentialityAgreement");
obj = new SQLTable(protoArray["21"]);

protoArray["20"]["m_table"] = obj;
protoArray["20"]["m_sql"] = "dbo.Observer";
protoArray["20"]["m_alias"] = "";
protoArray["20"]["m_srcTableName"] = "dbo.Observer";
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
protoArray["0"]["m_srcTableName"] = "dbo.Observer";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["observer"] = obj;

				
		
			tdataArray["observer"][".sqlquery"] = queryData_Array["observer"];
			tdataArray["observer"][".hasEvents"] = true;
		}
	}

}
