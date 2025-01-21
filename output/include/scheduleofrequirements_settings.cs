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
	public static partial class Settings_scheduleofrequirements
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["scheduleofrequirements"] = SettingsMap.GetArray();
			tdataArray["scheduleofrequirements"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["scheduleofrequirements"][".ShortName"] = "scheduleofrequirements";
			tdataArray["scheduleofrequirements"][".OwnerID"] = "";
			tdataArray["scheduleofrequirements"][".OriginalTable"] = "dbo.ScheduleOfRequirements";
			tdataArray["scheduleofrequirements"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["scheduleofrequirements"][".originalPagesByType"] = tdataArray["scheduleofrequirements"][".pagesByType"];
			tdataArray["scheduleofrequirements"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["scheduleofrequirements"][".originalPages"] = tdataArray["scheduleofrequirements"][".pages"];
			tdataArray["scheduleofrequirements"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"list\":\"list\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["scheduleofrequirements"][".originalDefaultPages"] = tdataArray["scheduleofrequirements"][".defaultPages"];
			fieldLabelsArray["scheduleofrequirements"] = SettingsMap.GetArray();
			fieldToolTipsArray["scheduleofrequirements"] = SettingsMap.GetArray();
			pageTitlesArray["scheduleofrequirements"] = SettingsMap.GetArray();
			placeHoldersArray["scheduleofrequirements"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["scheduleofrequirements"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["scheduleofrequirements"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["scheduleofrequirements"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["scheduleofrequirements"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["scheduleofrequirements"]["English"]["Id"] = "Id";
				fieldToolTipsArray["scheduleofrequirements"]["English"]["Id"] = "";
				placeHoldersArray["scheduleofrequirements"]["English"]["Id"] = "";
				fieldLabelsArray["scheduleofrequirements"]["English"]["PbdId"] = "Pbd Id";
				fieldToolTipsArray["scheduleofrequirements"]["English"]["PbdId"] = "";
				placeHoldersArray["scheduleofrequirements"]["English"]["PbdId"] = "";
				fieldLabelsArray["scheduleofrequirements"]["English"]["Description"] = "Description";
				fieldToolTipsArray["scheduleofrequirements"]["English"]["Description"] = "";
				placeHoldersArray["scheduleofrequirements"]["English"]["Description"] = "";
				fieldLabelsArray["scheduleofrequirements"]["English"]["Quantity"] = "Quantity";
				fieldToolTipsArray["scheduleofrequirements"]["English"]["Quantity"] = "";
				placeHoldersArray["scheduleofrequirements"]["English"]["Quantity"] = "";
				fieldLabelsArray["scheduleofrequirements"]["English"]["DeliverySchedule"] = "Delivery Schedule";
				fieldToolTipsArray["scheduleofrequirements"]["English"]["DeliverySchedule"] = "";
				placeHoldersArray["scheduleofrequirements"]["English"]["DeliverySchedule"] = "";
				pageTitlesArray["scheduleofrequirements"]["English"]["list"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["scheduleofrequirements"]["English"])))
				{
					tdataArray["scheduleofrequirements"][".isUseToolTips"] = true;
				}
			}
			tdataArray["scheduleofrequirements"][".NCSearch"] = true;
			tdataArray["scheduleofrequirements"][".shortTableName"] = "scheduleofrequirements";
			tdataArray["scheduleofrequirements"][".nSecOptions"] = 0;
			tdataArray["scheduleofrequirements"][".mainTableOwnerID"] = "";
			tdataArray["scheduleofrequirements"][".entityType"] = 0;
			tdataArray["scheduleofrequirements"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["scheduleofrequirements"][".strOriginalTableName"] = "dbo.ScheduleOfRequirements";
			tdataArray["scheduleofrequirements"][".showAddInPopup"] = false;
			tdataArray["scheduleofrequirements"][".showEditInPopup"] = false;
			tdataArray["scheduleofrequirements"][".showViewInPopup"] = false;
			tdataArray["scheduleofrequirements"][".listAjax"] = false;
			tdataArray["scheduleofrequirements"][".audit"] = false;
			tdataArray["scheduleofrequirements"][".locking"] = false;
			GlobalVars.pages = tdataArray["scheduleofrequirements"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["scheduleofrequirements"][".edit"] = true;
				tdataArray["scheduleofrequirements"][".afterEditAction"] = 0;
				tdataArray["scheduleofrequirements"][".closePopupAfterEdit"] = 1;
				tdataArray["scheduleofrequirements"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["scheduleofrequirements"][".add"] = true;
				tdataArray["scheduleofrequirements"][".afterAddAction"] = 0;
				tdataArray["scheduleofrequirements"][".closePopupAfterAdd"] = 1;
				tdataArray["scheduleofrequirements"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["scheduleofrequirements"][".list"] = true;
			}
			tdataArray["scheduleofrequirements"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["scheduleofrequirements"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["scheduleofrequirements"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["scheduleofrequirements"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["scheduleofrequirements"][".printFriendly"] = true;
			}
			tdataArray["scheduleofrequirements"][".showSimpleSearchOptions"] = true;
			tdataArray["scheduleofrequirements"][".allowShowHideFields"] = true;
			tdataArray["scheduleofrequirements"][".allowFieldsReordering"] = true;
			tdataArray["scheduleofrequirements"][".isUseAjaxSuggest"] = true;


			tdataArray["scheduleofrequirements"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["scheduleofrequirements"][".buttonsAdded"] = false;
			tdataArray["scheduleofrequirements"][".addPageEvents"] = true;
			tdataArray["scheduleofrequirements"][".isUseTimeForSearch"] = false;
			tdataArray["scheduleofrequirements"][".badgeColor"] = "6DA5C8";
			tdataArray["scheduleofrequirements"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["scheduleofrequirements"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["scheduleofrequirements"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["scheduleofrequirements"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["scheduleofrequirements"][".googleLikeFields"].Add("Id");
			tdataArray["scheduleofrequirements"][".googleLikeFields"].Add("PbdId");
			tdataArray["scheduleofrequirements"][".googleLikeFields"].Add("Description");
			tdataArray["scheduleofrequirements"][".googleLikeFields"].Add("Quantity");
			tdataArray["scheduleofrequirements"][".googleLikeFields"].Add("DeliverySchedule");
			tdataArray["scheduleofrequirements"][".tableType"] = "list";
			tdataArray["scheduleofrequirements"][".printerPageOrientation"] = 0;
			tdataArray["scheduleofrequirements"][".nPrinterPageScale"] = 100;
			tdataArray["scheduleofrequirements"][".nPrinterSplitRecords"] = 40;
			tdataArray["scheduleofrequirements"][".geocodingEnabled"] = false;
			tdataArray["scheduleofrequirements"][".pageSize"] = 20;
			tdataArray["scheduleofrequirements"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["scheduleofrequirements"][".strOrderBy"] = tstrOrderBy;
			tdataArray["scheduleofrequirements"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["scheduleofrequirements"][".sqlHead"] = "SELECT Id,  	PbdId,  	Description,  	Quantity,  	DeliverySchedule";
			tdataArray["scheduleofrequirements"][".sqlFrom"] = "FROM dbo.ScheduleOfRequirements";
			tdataArray["scheduleofrequirements"][".sqlWhereExpr"] = "";
			tdataArray["scheduleofrequirements"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["scheduleofrequirements"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["scheduleofrequirements"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["scheduleofrequirements"][".highlightSearchResults"] = true;
			tableKeysArray["scheduleofrequirements"] = SettingsMap.GetArray();
			tableKeysArray["scheduleofrequirements"].Add("Id");
			tdataArray["scheduleofrequirements"][".Keys"] = tableKeysArray["scheduleofrequirements"];
			tdataArray["scheduleofrequirements"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Id";
			fdata["GoodName"] = "Id";
			fdata["ownerTable"] = "dbo.ScheduleOfRequirements";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ScheduleOfRequirements","Id");
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
			tdataArray["scheduleofrequirements"]["Id"] = fdata;
			tdataArray["scheduleofrequirements"][".searchableFields"].Add("Id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "PbdId";
			fdata["GoodName"] = "PbdId";
			fdata["ownerTable"] = "dbo.ScheduleOfRequirements";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ScheduleOfRequirements","PbdId");
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
			tdataArray["scheduleofrequirements"]["PbdId"] = fdata;
			tdataArray["scheduleofrequirements"][".searchableFields"].Add("PbdId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "Description";
			fdata["GoodName"] = "Description";
			fdata["ownerTable"] = "dbo.ScheduleOfRequirements";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ScheduleOfRequirements","Description");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Description";
			fdata["sourceSingle"] = "Description";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Description";
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
			tdataArray["scheduleofrequirements"]["Description"] = fdata;
			tdataArray["scheduleofrequirements"][".searchableFields"].Add("Description");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "Quantity";
			fdata["GoodName"] = "Quantity";
			fdata["ownerTable"] = "dbo.ScheduleOfRequirements";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ScheduleOfRequirements","Quantity");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Quantity";
			fdata["sourceSingle"] = "Quantity";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Quantity";
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
			tdataArray["scheduleofrequirements"]["Quantity"] = fdata;
			tdataArray["scheduleofrequirements"][".searchableFields"].Add("Quantity");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "DeliverySchedule";
			fdata["GoodName"] = "DeliverySchedule";
			fdata["ownerTable"] = "dbo.ScheduleOfRequirements";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_ScheduleOfRequirements","DeliverySchedule");
			fdata["FieldType"] = 200;
			fdata["strField"] = "DeliverySchedule";
			fdata["sourceSingle"] = "DeliverySchedule";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "DeliverySchedule";
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
			tdataArray["scheduleofrequirements"]["DeliverySchedule"] = fdata;
			tdataArray["scheduleofrequirements"][".searchableFields"].Add("DeliverySchedule");
			GlobalVars.tables_data["dbo.ScheduleOfRequirements"] = tdataArray["scheduleofrequirements"];
			GlobalVars.field_labels["dbo_ScheduleOfRequirements"] = fieldLabelsArray["scheduleofrequirements"];
			GlobalVars.fieldToolTips["dbo_ScheduleOfRequirements"] = fieldToolTipsArray["scheduleofrequirements"];
			GlobalVars.placeHolders["dbo_ScheduleOfRequirements"] = placeHoldersArray["scheduleofrequirements"];
			GlobalVars.page_titles["dbo_ScheduleOfRequirements"] = pageTitlesArray["scheduleofrequirements"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.ScheduleOfRequirements"));
			GlobalVars.detailsTablesData["dbo.ScheduleOfRequirements"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.ScheduleOfRequirements"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.PhilippineBiddingDocument";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.PhilippineBiddingDocument";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "philippinebiddingdocument";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.ScheduleOfRequirements"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.ScheduleOfRequirements"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.ScheduleOfRequirements"][0]["masterKeys"].Add("Id");
			GlobalVars.masterTablesData["dbo.ScheduleOfRequirements"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.ScheduleOfRequirements"][0]["detailKeys"].Add("PbdId");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Id,  	PbdId,  	Description,  	Quantity,  	DeliverySchedule";
protoArray["0"]["m_strFrom"] = "FROM dbo.ScheduleOfRequirements";
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
obj = new SQLField(new XVar("m_strName", "Id", "m_strTable", "dbo.ScheduleOfRequirements", "m_srcTableName", "dbo.ScheduleOfRequirements"));

protoArray["6"]["m_sql"] = "Id";
protoArray["6"]["m_srcTableName"] = "dbo.ScheduleOfRequirements";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "PbdId", "m_strTable", "dbo.ScheduleOfRequirements", "m_srcTableName", "dbo.ScheduleOfRequirements"));

protoArray["8"]["m_sql"] = "PbdId";
protoArray["8"]["m_srcTableName"] = "dbo.ScheduleOfRequirements";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Description", "m_strTable", "dbo.ScheduleOfRequirements", "m_srcTableName", "dbo.ScheduleOfRequirements"));

protoArray["10"]["m_sql"] = "Description";
protoArray["10"]["m_srcTableName"] = "dbo.ScheduleOfRequirements";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Quantity", "m_strTable", "dbo.ScheduleOfRequirements", "m_srcTableName", "dbo.ScheduleOfRequirements"));

protoArray["12"]["m_sql"] = "Quantity";
protoArray["12"]["m_srcTableName"] = "dbo.ScheduleOfRequirements";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "DeliverySchedule", "m_strTable", "dbo.ScheduleOfRequirements", "m_srcTableName", "dbo.ScheduleOfRequirements"));

protoArray["14"]["m_sql"] = "DeliverySchedule";
protoArray["14"]["m_srcTableName"] = "dbo.ScheduleOfRequirements";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.ScheduleOfRequirements";
protoArray["17"]["m_srcTableName"] = "dbo.ScheduleOfRequirements";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("Id");
protoArray["17"]["m_columns"].Add("PbdId");
protoArray["17"]["m_columns"].Add("Description");
protoArray["17"]["m_columns"].Add("Quantity");
protoArray["17"]["m_columns"].Add("DeliverySchedule");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.ScheduleOfRequirements";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.ScheduleOfRequirements";
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
protoArray["0"]["m_srcTableName"] = "dbo.ScheduleOfRequirements";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["scheduleofrequirements"] = obj;

				
		
			tdataArray["scheduleofrequirements"][".sqlquery"] = queryData_Array["scheduleofrequirements"];
			tdataArray["scheduleofrequirements"][".hasEvents"] = true;
		}
	}

}
