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
	public static partial class Settings_personnel
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["personnel"] = SettingsMap.GetArray();
			tdataArray["personnel"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["personnel"][".ShortName"] = "personnel";
			tdataArray["personnel"][".OwnerID"] = "";
			tdataArray["personnel"][".OriginalTable"] = "dbo.Personnel";
			tdataArray["personnel"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["personnel"][".originalPagesByType"] = tdataArray["personnel"][".pagesByType"];
			tdataArray["personnel"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"masterlist\":[\"masterlist\"],\"masterprint\":[\"masterprint\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["personnel"][".originalPages"] = tdataArray["personnel"][".pages"];
			tdataArray["personnel"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"list\":\"list\",\"masterlist\":\"masterlist\",\"masterprint\":\"masterprint\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["personnel"][".originalDefaultPages"] = tdataArray["personnel"][".defaultPages"];
			fieldLabelsArray["personnel"] = SettingsMap.GetArray();
			fieldToolTipsArray["personnel"] = SettingsMap.GetArray();
			pageTitlesArray["personnel"] = SettingsMap.GetArray();
			placeHoldersArray["personnel"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["personnel"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["personnel"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["personnel"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["personnel"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["personnel"]["English"]["Name"] = "Full Name";
				fieldToolTipsArray["personnel"]["English"]["Name"] = "";
				placeHoldersArray["personnel"]["English"]["Name"] = "";
				fieldLabelsArray["personnel"]["English"]["Integrity"] = "Integrity";
				fieldToolTipsArray["personnel"]["English"]["Integrity"] = "";
				placeHoldersArray["personnel"]["English"]["Integrity"] = "";
				fieldLabelsArray["personnel"]["English"]["Proficiency"] = "Proficiency";
				fieldToolTipsArray["personnel"]["English"]["Proficiency"] = "";
				placeHoldersArray["personnel"]["English"]["Proficiency"] = "";
				fieldLabelsArray["personnel"]["English"]["CivilServiceQualification"] = "Civil Service Qualification";
				fieldToolTipsArray["personnel"]["English"]["CivilServiceQualification"] = "";
				placeHoldersArray["personnel"]["English"]["CivilServiceQualification"] = "";
				fieldLabelsArray["personnel"]["English"]["Rank"] = "Rank";
				fieldToolTipsArray["personnel"]["English"]["Rank"] = "";
				placeHoldersArray["personnel"]["English"]["Rank"] = "";
				fieldLabelsArray["personnel"]["English"]["TrainingDetails"] = "Training Details";
				fieldToolTipsArray["personnel"]["English"]["TrainingDetails"] = "";
				placeHoldersArray["personnel"]["English"]["TrainingDetails"] = "";
				fieldLabelsArray["personnel"]["English"]["Id"] = "Id";
				fieldToolTipsArray["personnel"]["English"]["Id"] = "";
				placeHoldersArray["personnel"]["English"]["Id"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["personnel"]["English"])))
				{
					tdataArray["personnel"][".isUseToolTips"] = true;
				}
			}
			tdataArray["personnel"][".NCSearch"] = true;
			tdataArray["personnel"][".shortTableName"] = "personnel";
			tdataArray["personnel"][".nSecOptions"] = 0;
			tdataArray["personnel"][".mainTableOwnerID"] = "";
			tdataArray["personnel"][".entityType"] = 0;
			tdataArray["personnel"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["personnel"][".strOriginalTableName"] = "dbo.Personnel";
			tdataArray["personnel"][".showAddInPopup"] = false;
			tdataArray["personnel"][".showEditInPopup"] = false;
			tdataArray["personnel"][".showViewInPopup"] = false;
			tdataArray["personnel"][".listAjax"] = false;
			tdataArray["personnel"][".audit"] = false;
			tdataArray["personnel"][".locking"] = false;
			GlobalVars.pages = tdataArray["personnel"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["personnel"][".edit"] = true;
				tdataArray["personnel"][".afterEditAction"] = 0;
				tdataArray["personnel"][".closePopupAfterEdit"] = 1;
				tdataArray["personnel"][".afterEditActionDetTable"] = "dbo.BidsAndAwardsCommittee";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["personnel"][".add"] = true;
				tdataArray["personnel"][".afterAddAction"] = 0;
				tdataArray["personnel"][".closePopupAfterAdd"] = 1;
				tdataArray["personnel"][".afterAddActionDetTable"] = "dbo.BidsAndAwardsCommittee";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["personnel"][".list"] = true;
			}
			tdataArray["personnel"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["personnel"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["personnel"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["personnel"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["personnel"][".printFriendly"] = true;
			}
			tdataArray["personnel"][".showSimpleSearchOptions"] = true;
			tdataArray["personnel"][".allowShowHideFields"] = true;
			tdataArray["personnel"][".allowFieldsReordering"] = true;
			tdataArray["personnel"][".isUseAjaxSuggest"] = true;


			tdataArray["personnel"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["personnel"][".buttonsAdded"] = false;
			tdataArray["personnel"][".addPageEvents"] = true;
			tdataArray["personnel"][".isUseTimeForSearch"] = false;
			tdataArray["personnel"][".badgeColor"] = "E8926F";
			tdataArray["personnel"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["personnel"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["personnel"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["personnel"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["personnel"][".googleLikeFields"].Add("Id");
			tdataArray["personnel"][".googleLikeFields"].Add("Name");
			tdataArray["personnel"][".googleLikeFields"].Add("Integrity");
			tdataArray["personnel"][".googleLikeFields"].Add("Proficiency");
			tdataArray["personnel"][".googleLikeFields"].Add("CivilServiceQualification");
			tdataArray["personnel"][".googleLikeFields"].Add("Rank");
			tdataArray["personnel"][".googleLikeFields"].Add("TrainingDetails");
			tdataArray["personnel"][".tableType"] = "list";
			tdataArray["personnel"][".printerPageOrientation"] = 0;
			tdataArray["personnel"][".nPrinterPageScale"] = 100;
			tdataArray["personnel"][".nPrinterSplitRecords"] = 40;
			tdataArray["personnel"][".geocodingEnabled"] = false;
			tdataArray["personnel"][".pageSize"] = 20;
			tdataArray["personnel"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["personnel"][".strOrderBy"] = tstrOrderBy;
			tdataArray["personnel"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["personnel"][".sqlHead"] = "SELECT Id,  	Name,  	Integrity,  	Proficiency,  	CivilServiceQualification,  	Rank,  	TrainingDetails";
			tdataArray["personnel"][".sqlFrom"] = "FROM dbo.Personnel";
			tdataArray["personnel"][".sqlWhereExpr"] = "";
			tdataArray["personnel"][".sqlTail"] = "";
			arrGridTabs = SettingsMap.GetArray();
			arrGridTabs.Add(new XVar("tabId", "", "name", "All data", "nameType", "Text", "where", "", "showRowCount", 0, "hideEmpty", 0));
			tdataArray["personnel"][".arrGridTabs"] = arrGridTabs;
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["personnel"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["personnel"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["personnel"][".highlightSearchResults"] = true;
			tableKeysArray["personnel"] = SettingsMap.GetArray();
			tableKeysArray["personnel"].Add("Id");
			tdataArray["personnel"][".Keys"] = tableKeysArray["personnel"];
			tdataArray["personnel"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Id";
			fdata["GoodName"] = "Id";
			fdata["ownerTable"] = "dbo.Personnel";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Personnel","Id");
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
			tdataArray["personnel"]["Id"] = fdata;
			tdataArray["personnel"][".searchableFields"].Add("Id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "Name";
			fdata["GoodName"] = "Name";
			fdata["ownerTable"] = "dbo.Personnel";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Personnel","Name");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Name";
			fdata["sourceSingle"] = "Name";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Name";
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
			tdataArray["personnel"]["Name"] = fdata;
			tdataArray["personnel"][".searchableFields"].Add("Name");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "Integrity";
			fdata["GoodName"] = "Integrity";
			fdata["ownerTable"] = "dbo.Personnel";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Personnel","Integrity");
			fdata["FieldType"] = 11;
			fdata["strField"] = "Integrity";
			fdata["sourceSingle"] = "Integrity";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Integrity";
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
			tdataArray["personnel"]["Integrity"] = fdata;
			tdataArray["personnel"][".searchableFields"].Add("Integrity");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "Proficiency";
			fdata["GoodName"] = "Proficiency";
			fdata["ownerTable"] = "dbo.Personnel";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Personnel","Proficiency");
			fdata["FieldType"] = 11;
			fdata["strField"] = "Proficiency";
			fdata["sourceSingle"] = "Proficiency";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Proficiency";
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
			tdataArray["personnel"]["Proficiency"] = fdata;
			tdataArray["personnel"][".searchableFields"].Add("Proficiency");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "CivilServiceQualification";
			fdata["GoodName"] = "CivilServiceQualification";
			fdata["ownerTable"] = "dbo.Personnel";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Personnel","CivilServiceQualification");
			fdata["FieldType"] = 11;
			fdata["strField"] = "CivilServiceQualification";
			fdata["sourceSingle"] = "CivilServiceQualification";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "CivilServiceQualification";
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
			tdataArray["personnel"]["CivilServiceQualification"] = fdata;
			tdataArray["personnel"][".searchableFields"].Add("CivilServiceQualification");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "Rank";
			fdata["GoodName"] = "Rank";
			fdata["ownerTable"] = "dbo.Personnel";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Personnel","Rank");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Rank";
			fdata["sourceSingle"] = "Rank";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Rank";
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
			tdataArray["personnel"]["Rank"] = fdata;
			tdataArray["personnel"][".searchableFields"].Add("Rank");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "TrainingDetails";
			fdata["GoodName"] = "TrainingDetails";
			fdata["ownerTable"] = "dbo.Personnel";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_Personnel","TrainingDetails");
			fdata["FieldType"] = 200;
			fdata["strField"] = "TrainingDetails";
			fdata["sourceSingle"] = "TrainingDetails";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "TrainingDetails";
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
			tdataArray["personnel"]["TrainingDetails"] = fdata;
			tdataArray["personnel"][".searchableFields"].Add("TrainingDetails");
			GlobalVars.tables_data["dbo.Personnel"] = tdataArray["personnel"];
			GlobalVars.field_labels["dbo_Personnel"] = fieldLabelsArray["personnel"];
			GlobalVars.fieldToolTips["dbo_Personnel"] = fieldToolTipsArray["personnel"];
			GlobalVars.placeHolders["dbo_Personnel"] = placeHoldersArray["personnel"];
			GlobalVars.page_titles["dbo_Personnel"] = pageTitlesArray["personnel"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.Personnel"));
			GlobalVars.detailsTablesData["dbo.Personnel"] = SettingsMap.GetArray();


			dIndex = 0;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.BidsAndAwardsCommittee";
			detailsParam["dOriginalTable"] = "dbo.BidsAndAwardsCommittee";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "bidsandawardscommittee";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_BidsAndAwardsCommittee"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex]["masterKeys"].Add("Id");
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex]["detailKeys"].Add("ChairpersonId");


			dIndex = 1;
			detailsParam = SettingsMap.GetArray();
			detailsParam["dDataSourceTable"] = "dbo.HeadOfProcuringEntity";
			detailsParam["dOriginalTable"] = "dbo.HeadOfProcuringEntity";
			detailsParam["dType"] = Constants.PAGE_LIST;
			detailsParam["dShortTable"] = "headofprocuringentity";
			detailsParam["dCaptionTable"] = CommonFunctions.GetTableCaption(new XVar("dbo_HeadOfProcuringEntity"));
			detailsParam["masterKeys"] = SettingsMap.GetArray();
			detailsParam["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex] = detailsParam;
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex]["masterKeys"].Add("Id");
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.detailsTablesData["dbo.Personnel"][dIndex]["detailKeys"].Add("PersonnelId");
			GlobalVars.masterTablesData["dbo.Personnel"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Id,  	Name,  	Integrity,  	Proficiency,  	CivilServiceQualification,  	Rank,  	TrainingDetails";
protoArray["0"]["m_strFrom"] = "FROM dbo.Personnel";
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
obj = new SQLField(new XVar("m_strName", "Id", "m_strTable", "dbo.Personnel", "m_srcTableName", "dbo.Personnel"));

protoArray["6"]["m_sql"] = "Id";
protoArray["6"]["m_srcTableName"] = "dbo.Personnel";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Name", "m_strTable", "dbo.Personnel", "m_srcTableName", "dbo.Personnel"));

protoArray["8"]["m_sql"] = "Name";
protoArray["8"]["m_srcTableName"] = "dbo.Personnel";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Integrity", "m_strTable", "dbo.Personnel", "m_srcTableName", "dbo.Personnel"));

protoArray["10"]["m_sql"] = "Integrity";
protoArray["10"]["m_srcTableName"] = "dbo.Personnel";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Proficiency", "m_strTable", "dbo.Personnel", "m_srcTableName", "dbo.Personnel"));

protoArray["12"]["m_sql"] = "Proficiency";
protoArray["12"]["m_srcTableName"] = "dbo.Personnel";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "CivilServiceQualification", "m_strTable", "dbo.Personnel", "m_srcTableName", "dbo.Personnel"));

protoArray["14"]["m_sql"] = "CivilServiceQualification";
protoArray["14"]["m_srcTableName"] = "dbo.Personnel";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Rank", "m_strTable", "dbo.Personnel", "m_srcTableName", "dbo.Personnel"));

protoArray["16"]["m_sql"] = "Rank";
protoArray["16"]["m_srcTableName"] = "dbo.Personnel";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "TrainingDetails", "m_strTable", "dbo.Personnel", "m_srcTableName", "dbo.Personnel"));

protoArray["18"]["m_sql"] = "TrainingDetails";
protoArray["18"]["m_srcTableName"] = "dbo.Personnel";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_link"] = "SQLL_MAIN";
protoArray["21"] = SettingsMap.GetArray();
protoArray["21"]["m_strName"] = "dbo.Personnel";
protoArray["21"]["m_srcTableName"] = "dbo.Personnel";
protoArray["21"]["m_columns"] = SettingsMap.GetArray();
protoArray["21"]["m_columns"].Add("Id");
protoArray["21"]["m_columns"].Add("Name");
protoArray["21"]["m_columns"].Add("Integrity");
protoArray["21"]["m_columns"].Add("Proficiency");
protoArray["21"]["m_columns"].Add("CivilServiceQualification");
protoArray["21"]["m_columns"].Add("Rank");
protoArray["21"]["m_columns"].Add("TrainingDetails");
obj = new SQLTable(protoArray["21"]);

protoArray["20"]["m_table"] = obj;
protoArray["20"]["m_sql"] = "dbo.Personnel";
protoArray["20"]["m_alias"] = "";
protoArray["20"]["m_srcTableName"] = "dbo.Personnel";
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
protoArray["0"]["m_srcTableName"] = "dbo.Personnel";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["personnel"] = obj;

				
		
			tdataArray["personnel"][".sqlquery"] = queryData_Array["personnel"];
			tdataArray["personnel"][".hasEvents"] = true;
		}
	}

}
