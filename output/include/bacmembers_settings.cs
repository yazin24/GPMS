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
	public static partial class Settings_bacmembers
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["bacmembers"] = SettingsMap.GetArray();
			tdataArray["bacmembers"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["bacmembers"][".ShortName"] = "bacmembers";
			tdataArray["bacmembers"][".OwnerID"] = "";
			tdataArray["bacmembers"][".OriginalTable"] = "dbo.BACMembers";
			tdataArray["bacmembers"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["bacmembers"][".originalPagesByType"] = tdataArray["bacmembers"][".pagesByType"];
			tdataArray["bacmembers"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"export\":[\"export\"],\"import\":[\"import\"],\"list\":[\"list\"],\"print\":[\"print\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["bacmembers"][".originalPages"] = tdataArray["bacmembers"][".pages"];
			tdataArray["bacmembers"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"export\":\"export\",\"import\":\"import\",\"list\":\"list\",\"print\":\"print\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["bacmembers"][".originalDefaultPages"] = tdataArray["bacmembers"][".defaultPages"];
			fieldLabelsArray["bacmembers"] = SettingsMap.GetArray();
			fieldToolTipsArray["bacmembers"] = SettingsMap.GetArray();
			pageTitlesArray["bacmembers"] = SettingsMap.GetArray();
			placeHoldersArray["bacmembers"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["bacmembers"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["bacmembers"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["bacmembers"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["bacmembers"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["bacmembers"]["English"]["MemberId"] = "Member Id";
				fieldToolTipsArray["bacmembers"]["English"]["MemberId"] = "";
				placeHoldersArray["bacmembers"]["English"]["MemberId"] = "";
				fieldLabelsArray["bacmembers"]["English"]["BacId"] = "Bac Id";
				fieldToolTipsArray["bacmembers"]["English"]["BacId"] = "";
				placeHoldersArray["bacmembers"]["English"]["BacId"] = "";
				fieldLabelsArray["bacmembers"]["English"]["PersonnelId"] = "Personnel Id";
				fieldToolTipsArray["bacmembers"]["English"]["PersonnelId"] = "";
				placeHoldersArray["bacmembers"]["English"]["PersonnelId"] = "";
				fieldLabelsArray["bacmembers"]["English"]["BacMemberName"] = "Bac Member Name";
				fieldToolTipsArray["bacmembers"]["English"]["BacMemberName"] = "";
				placeHoldersArray["bacmembers"]["English"]["BacMemberName"] = "";
				fieldLabelsArray["bacmembers"]["English"]["MemberType"] = "Member Type";
				fieldToolTipsArray["bacmembers"]["English"]["MemberType"] = "";
				placeHoldersArray["bacmembers"]["English"]["MemberType"] = "";
				fieldLabelsArray["bacmembers"]["English"]["Role"] = "Role";
				fieldToolTipsArray["bacmembers"]["English"]["Role"] = "";
				placeHoldersArray["bacmembers"]["English"]["Role"] = "";
				fieldLabelsArray["bacmembers"]["English"]["ApptTerm"] = "Appt Term";
				fieldToolTipsArray["bacmembers"]["English"]["ApptTerm"] = "";
				placeHoldersArray["bacmembers"]["English"]["ApptTerm"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["bacmembers"]["English"])))
				{
					tdataArray["bacmembers"][".isUseToolTips"] = true;
				}
			}
			tdataArray["bacmembers"][".NCSearch"] = true;
			tdataArray["bacmembers"][".shortTableName"] = "bacmembers";
			tdataArray["bacmembers"][".nSecOptions"] = 0;
			tdataArray["bacmembers"][".mainTableOwnerID"] = "";
			tdataArray["bacmembers"][".entityType"] = 0;
			tdataArray["bacmembers"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["bacmembers"][".strOriginalTableName"] = "dbo.BACMembers";
			tdataArray["bacmembers"][".showAddInPopup"] = false;
			tdataArray["bacmembers"][".showEditInPopup"] = false;
			tdataArray["bacmembers"][".showViewInPopup"] = false;
			tdataArray["bacmembers"][".listAjax"] = false;
			tdataArray["bacmembers"][".audit"] = false;
			tdataArray["bacmembers"][".locking"] = false;
			GlobalVars.pages = tdataArray["bacmembers"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["bacmembers"][".edit"] = true;
				tdataArray["bacmembers"][".afterEditAction"] = 1;
				tdataArray["bacmembers"][".closePopupAfterEdit"] = 1;
				tdataArray["bacmembers"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["bacmembers"][".add"] = true;
				tdataArray["bacmembers"][".afterAddAction"] = 1;
				tdataArray["bacmembers"][".closePopupAfterAdd"] = 1;
				tdataArray["bacmembers"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["bacmembers"][".list"] = true;
			}
			tdataArray["bacmembers"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["bacmembers"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["bacmembers"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["bacmembers"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["bacmembers"][".printFriendly"] = true;
			}
			tdataArray["bacmembers"][".showSimpleSearchOptions"] = true;
			tdataArray["bacmembers"][".allowShowHideFields"] = true;
			tdataArray["bacmembers"][".allowFieldsReordering"] = true;
			tdataArray["bacmembers"][".isUseAjaxSuggest"] = true;


			tdataArray["bacmembers"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["bacmembers"][".buttonsAdded"] = false;
			tdataArray["bacmembers"][".addPageEvents"] = false;
			tdataArray["bacmembers"][".isUseTimeForSearch"] = false;
			tdataArray["bacmembers"][".badgeColor"] = "CD853F";
			tdataArray["bacmembers"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["bacmembers"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["bacmembers"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["bacmembers"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["bacmembers"][".googleLikeFields"].Add("MemberId");
			tdataArray["bacmembers"][".googleLikeFields"].Add("BacId");
			tdataArray["bacmembers"][".googleLikeFields"].Add("PersonnelId");
			tdataArray["bacmembers"][".googleLikeFields"].Add("BacMemberName");
			tdataArray["bacmembers"][".googleLikeFields"].Add("MemberType");
			tdataArray["bacmembers"][".googleLikeFields"].Add("Role");
			tdataArray["bacmembers"][".googleLikeFields"].Add("ApptTerm");
			tdataArray["bacmembers"][".tableType"] = "list";
			tdataArray["bacmembers"][".printerPageOrientation"] = 0;
			tdataArray["bacmembers"][".nPrinterPageScale"] = 100;
			tdataArray["bacmembers"][".nPrinterSplitRecords"] = 40;
			tdataArray["bacmembers"][".geocodingEnabled"] = false;
			tdataArray["bacmembers"][".pageSize"] = 20;
			tdataArray["bacmembers"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["bacmembers"][".strOrderBy"] = tstrOrderBy;
			tdataArray["bacmembers"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["bacmembers"][".sqlHead"] = "SELECT MemberId,  	BacId,  	PersonnelId,  	BacMemberName,  	MemberType,  	[Role],  	ApptTerm";
			tdataArray["bacmembers"][".sqlFrom"] = "FROM dbo.BACMembers";
			tdataArray["bacmembers"][".sqlWhereExpr"] = "";
			tdataArray["bacmembers"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["bacmembers"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["bacmembers"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["bacmembers"][".highlightSearchResults"] = true;
			tableKeysArray["bacmembers"] = SettingsMap.GetArray();
			tableKeysArray["bacmembers"].Add("MemberId");
			tdataArray["bacmembers"][".Keys"] = tableKeysArray["bacmembers"];
			tdataArray["bacmembers"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "MemberId";
			fdata["GoodName"] = "MemberId";
			fdata["ownerTable"] = "dbo.BACMembers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_BACMembers","MemberId");
			fdata["FieldType"] = 3;
			fdata["AutoInc"] = true;
			fdata["strField"] = "MemberId";
			fdata["sourceSingle"] = "MemberId";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "MemberId";
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
			tdataArray["bacmembers"]["MemberId"] = fdata;
			tdataArray["bacmembers"][".searchableFields"].Add("MemberId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "BacId";
			fdata["GoodName"] = "BacId";
			fdata["ownerTable"] = "dbo.BACMembers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_BACMembers","BacId");
			fdata["FieldType"] = 3;
			fdata["strField"] = "BacId";
			fdata["sourceSingle"] = "BacId";
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
			edata["LookupType"] = 1;
			edata["LookupTable"] = "dbo.BidsAndAwardsCommittee";
			edata["LookupConnId"] = "GPMS_at_194_233_66_31_1433";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "Id";
			edata["LinkFieldType"] = 3;
			edata["DisplayField"] = "BacName";
			edata["LookupOrderBy"] = "";
			edata["SimpleAdd"] = true;
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
			tdataArray["bacmembers"]["BacId"] = fdata;
			tdataArray["bacmembers"][".searchableFields"].Add("BacId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "PersonnelId";
			fdata["GoodName"] = "PersonnelId";
			fdata["ownerTable"] = "dbo.BACMembers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_BACMembers","PersonnelId");
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
			edata["LookupType"] = 1;
			edata["LookupTable"] = "dbo.Personnel";
			edata["LookupConnId"] = "GPMS_at_194_233_66_31_1433";
			edata["autoCompleteFieldsOnEdit"] = 0;
			edata["autoCompleteFields"] = SettingsMap.GetArray();
			edata["LCType"] = 0;
			edata["LinkField"] = "Id";
			edata["LinkFieldType"] = 3;
			edata["DisplayField"] = "Name";
			edata["LookupOrderBy"] = "";
			edata["SimpleAdd"] = true;
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
			tdataArray["bacmembers"]["PersonnelId"] = fdata;
			tdataArray["bacmembers"][".searchableFields"].Add("PersonnelId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "BacMemberName";
			fdata["GoodName"] = "BacMemberName";
			fdata["ownerTable"] = "dbo.BACMembers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_BACMembers","BacMemberName");
			fdata["FieldType"] = 200;
			fdata["strField"] = "BacMemberName";
			fdata["sourceSingle"] = "BacMemberName";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "BacMemberName";
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
			tdataArray["bacmembers"]["BacMemberName"] = fdata;
			tdataArray["bacmembers"][".searchableFields"].Add("BacMemberName");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "MemberType";
			fdata["GoodName"] = "MemberType";
			fdata["ownerTable"] = "dbo.BACMembers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_BACMembers","MemberType");
			fdata["FieldType"] = 200;
			fdata["strField"] = "MemberType";
			fdata["sourceSingle"] = "MemberType";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "MemberType";
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
			tdataArray["bacmembers"]["MemberType"] = fdata;
			tdataArray["bacmembers"][".searchableFields"].Add("MemberType");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 6;
			fdata["strName"] = "Role";
			fdata["GoodName"] = "Role";
			fdata["ownerTable"] = "dbo.BACMembers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_BACMembers","Role");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Role";
			fdata["sourceSingle"] = "Role";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "[Role]";
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
			tdataArray["bacmembers"]["Role"] = fdata;
			tdataArray["bacmembers"][".searchableFields"].Add("Role");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 7;
			fdata["strName"] = "ApptTerm";
			fdata["GoodName"] = "ApptTerm";
			fdata["ownerTable"] = "dbo.BACMembers";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_BACMembers","ApptTerm");
			fdata["FieldType"] = 3;
			fdata["strField"] = "ApptTerm";
			fdata["sourceSingle"] = "ApptTerm";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "ApptTerm";
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
			tdataArray["bacmembers"]["ApptTerm"] = fdata;
			tdataArray["bacmembers"][".searchableFields"].Add("ApptTerm");
			GlobalVars.tables_data["dbo.BACMembers"] = tdataArray["bacmembers"];
			GlobalVars.field_labels["dbo_BACMembers"] = fieldLabelsArray["bacmembers"];
			GlobalVars.fieldToolTips["dbo_BACMembers"] = fieldToolTipsArray["bacmembers"];
			GlobalVars.placeHolders["dbo_BACMembers"] = placeHoldersArray["bacmembers"];
			GlobalVars.page_titles["dbo_BACMembers"] = pageTitlesArray["bacmembers"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.BACMembers"));
			GlobalVars.detailsTablesData["dbo.BACMembers"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.BACMembers"] = SettingsMap.GetArray();

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "MemberId,  	BacId,  	PersonnelId,  	BacMemberName,  	MemberType,  	[Role],  	ApptTerm";
protoArray["0"]["m_strFrom"] = "FROM dbo.BACMembers";
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
obj = new SQLField(new XVar("m_strName", "MemberId", "m_strTable", "dbo.BACMembers", "m_srcTableName", "dbo.BACMembers"));

protoArray["6"]["m_sql"] = "MemberId";
protoArray["6"]["m_srcTableName"] = "dbo.BACMembers";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "BacId", "m_strTable", "dbo.BACMembers", "m_srcTableName", "dbo.BACMembers"));

protoArray["8"]["m_sql"] = "BacId";
protoArray["8"]["m_srcTableName"] = "dbo.BACMembers";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "PersonnelId", "m_strTable", "dbo.BACMembers", "m_srcTableName", "dbo.BACMembers"));

protoArray["10"]["m_sql"] = "PersonnelId";
protoArray["10"]["m_srcTableName"] = "dbo.BACMembers";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "BacMemberName", "m_strTable", "dbo.BACMembers", "m_srcTableName", "dbo.BACMembers"));

protoArray["12"]["m_sql"] = "BacMemberName";
protoArray["12"]["m_srcTableName"] = "dbo.BACMembers";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "MemberType", "m_strTable", "dbo.BACMembers", "m_srcTableName", "dbo.BACMembers"));

protoArray["14"]["m_sql"] = "MemberType";
protoArray["14"]["m_srcTableName"] = "dbo.BACMembers";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["16"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Role", "m_strTable", "dbo.BACMembers", "m_srcTableName", "dbo.BACMembers"));

protoArray["16"]["m_sql"] = "[Role]";
protoArray["16"]["m_srcTableName"] = "dbo.BACMembers";
protoArray["16"]["m_expr"] = obj;
protoArray["16"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["16"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["18"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "ApptTerm", "m_strTable", "dbo.BACMembers", "m_srcTableName", "dbo.BACMembers"));

protoArray["18"]["m_sql"] = "ApptTerm";
protoArray["18"]["m_srcTableName"] = "dbo.BACMembers";
protoArray["18"]["m_expr"] = obj;
protoArray["18"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["18"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["20"] = SettingsMap.GetArray();
protoArray["20"]["m_link"] = "SQLL_MAIN";
protoArray["21"] = SettingsMap.GetArray();
protoArray["21"]["m_strName"] = "dbo.BACMembers";
protoArray["21"]["m_srcTableName"] = "dbo.BACMembers";
protoArray["21"]["m_columns"] = SettingsMap.GetArray();
protoArray["21"]["m_columns"].Add("MemberId");
protoArray["21"]["m_columns"].Add("BacId");
protoArray["21"]["m_columns"].Add("PersonnelId");
protoArray["21"]["m_columns"].Add("BacMemberName");
protoArray["21"]["m_columns"].Add("MemberType");
protoArray["21"]["m_columns"].Add("Role");
protoArray["21"]["m_columns"].Add("ApptTerm");
obj = new SQLTable(protoArray["21"]);

protoArray["20"]["m_table"] = obj;
protoArray["20"]["m_sql"] = "dbo.BACMembers";
protoArray["20"]["m_alias"] = "";
protoArray["20"]["m_srcTableName"] = "dbo.BACMembers";
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
protoArray["0"]["m_srcTableName"] = "dbo.BACMembers";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["bacmembers"] = obj;

				
		
			tdataArray["bacmembers"][".sqlquery"] = queryData_Array["bacmembers"];
			tdataArray["bacmembers"][".hasEvents"] = false;
		}
	}

}
