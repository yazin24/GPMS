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
	public static partial class Settings_specialconditionsofcontract
	{
		static public void Apply()
		{
			SettingsMap arrGPP = SettingsMap.GetArray(), arrGridTabs = SettingsMap.GetArray(), arrRPP = SettingsMap.GetArray(), dIndex = null, detailsParam = SettingsMap.GetArray(), edata = SettingsMap.GetArray(), eventsData = SettingsMap.GetArray(), fdata = SettingsMap.GetArray(), fieldLabelsArray = new XVar(), fieldToolTipsArray = new XVar(), hours = null, intervalData = SettingsMap.GetArray(), masterParams = SettingsMap.GetArray(), pageTitlesArray = new XVar(), placeHoldersArray = new XVar(), query = null, queryData_Array = new XVar(), strOriginalDetailsTable = null, table = null, tableKeysArray = new XVar(), tdataArray = new XVar(), tstrOrderBy = null, vdata = SettingsMap.GetArray();
			tdataArray["specialconditionsofcontract"] = SettingsMap.GetArray();
			tdataArray["specialconditionsofcontract"][".searchableFields"] = SettingsMap.GetArray();
			tdataArray["specialconditionsofcontract"][".ShortName"] = "specialconditionsofcontract";
			tdataArray["specialconditionsofcontract"][".OwnerID"] = "";
			tdataArray["specialconditionsofcontract"][".OriginalTable"] = "dbo.SpecialConditionsOfContract";
			tdataArray["specialconditionsofcontract"][".pagesByType"] = MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"search\":[\"search\"],\"view\":[\"view\"]}"));
			tdataArray["specialconditionsofcontract"][".originalPagesByType"] = tdataArray["specialconditionsofcontract"][".pagesByType"];
			tdataArray["specialconditionsofcontract"][".pages"] = CommonFunctions.types2pages(MVCFunctions.my_json_decode(new XVar("{\"add\":[\"add\"],\"edit\":[\"edit\"],\"list\":[\"list\"],\"search\":[\"search\"],\"view\":[\"view\"]}")));
			tdataArray["specialconditionsofcontract"][".originalPages"] = tdataArray["specialconditionsofcontract"][".pages"];
			tdataArray["specialconditionsofcontract"][".defaultPages"] = MVCFunctions.my_json_decode(new XVar("{\"add\":\"add\",\"edit\":\"edit\",\"list\":\"list\",\"search\":\"search\",\"view\":\"view\"}"));
			tdataArray["specialconditionsofcontract"][".originalDefaultPages"] = tdataArray["specialconditionsofcontract"][".defaultPages"];
			fieldLabelsArray["specialconditionsofcontract"] = SettingsMap.GetArray();
			fieldToolTipsArray["specialconditionsofcontract"] = SettingsMap.GetArray();
			pageTitlesArray["specialconditionsofcontract"] = SettingsMap.GetArray();
			placeHoldersArray["specialconditionsofcontract"] = SettingsMap.GetArray();
			if(CommonFunctions.mlang_getcurrentlang() == "English")
			{
				fieldLabelsArray["specialconditionsofcontract"]["English"] = SettingsMap.GetArray();
				fieldToolTipsArray["specialconditionsofcontract"]["English"] = SettingsMap.GetArray();
				placeHoldersArray["specialconditionsofcontract"]["English"] = SettingsMap.GetArray();
				pageTitlesArray["specialconditionsofcontract"]["English"] = SettingsMap.GetArray();
				fieldLabelsArray["specialconditionsofcontract"]["English"]["Id"] = "Id";
				fieldToolTipsArray["specialconditionsofcontract"]["English"]["Id"] = "";
				placeHoldersArray["specialconditionsofcontract"]["English"]["Id"] = "";
				fieldLabelsArray["specialconditionsofcontract"]["English"]["PbdId"] = "Pbd Id";
				fieldToolTipsArray["specialconditionsofcontract"]["English"]["PbdId"] = "";
				placeHoldersArray["specialconditionsofcontract"]["English"]["PbdId"] = "";
				fieldLabelsArray["specialconditionsofcontract"]["English"]["MilestoneDescription"] = "Milestone Description";
				fieldToolTipsArray["specialconditionsofcontract"]["English"]["MilestoneDescription"] = "";
				placeHoldersArray["specialconditionsofcontract"]["English"]["MilestoneDescription"] = "";
				fieldLabelsArray["specialconditionsofcontract"]["English"]["Deliverable"] = "Deliverable";
				fieldToolTipsArray["specialconditionsofcontract"]["English"]["Deliverable"] = "";
				placeHoldersArray["specialconditionsofcontract"]["English"]["Deliverable"] = "";
				fieldLabelsArray["specialconditionsofcontract"]["English"]["PaymentPercentage"] = "Payment Percentage";
				fieldToolTipsArray["specialconditionsofcontract"]["English"]["PaymentPercentage"] = "";
				placeHoldersArray["specialconditionsofcontract"]["English"]["PaymentPercentage"] = "";
				pageTitlesArray["specialconditionsofcontract"]["English"]["list"] = "";
				if(XVar.Pack(MVCFunctions.count(fieldToolTipsArray["specialconditionsofcontract"]["English"])))
				{
					tdataArray["specialconditionsofcontract"][".isUseToolTips"] = true;
				}
			}
			tdataArray["specialconditionsofcontract"][".NCSearch"] = true;
			tdataArray["specialconditionsofcontract"][".shortTableName"] = "specialconditionsofcontract";
			tdataArray["specialconditionsofcontract"][".nSecOptions"] = 0;
			tdataArray["specialconditionsofcontract"][".mainTableOwnerID"] = "";
			tdataArray["specialconditionsofcontract"][".entityType"] = 0;
			tdataArray["specialconditionsofcontract"][".connId"] = "GPMS_at_194_233_66_31_1433";
			tdataArray["specialconditionsofcontract"][".strOriginalTableName"] = "dbo.SpecialConditionsOfContract";
			tdataArray["specialconditionsofcontract"][".showAddInPopup"] = false;
			tdataArray["specialconditionsofcontract"][".showEditInPopup"] = false;
			tdataArray["specialconditionsofcontract"][".showViewInPopup"] = false;
			tdataArray["specialconditionsofcontract"][".listAjax"] = false;
			tdataArray["specialconditionsofcontract"][".audit"] = false;
			tdataArray["specialconditionsofcontract"][".locking"] = false;
			GlobalVars.pages = tdataArray["specialconditionsofcontract"][".defaultPages"];
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EDIT]))
			{
				tdataArray["specialconditionsofcontract"][".edit"] = true;
				tdataArray["specialconditionsofcontract"][".afterEditAction"] = 0;
				tdataArray["specialconditionsofcontract"][".closePopupAfterEdit"] = 1;
				tdataArray["specialconditionsofcontract"][".afterEditActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_ADD]))
			{
				tdataArray["specialconditionsofcontract"][".add"] = true;
				tdataArray["specialconditionsofcontract"][".afterAddAction"] = 0;
				tdataArray["specialconditionsofcontract"][".closePopupAfterAdd"] = 1;
				tdataArray["specialconditionsofcontract"][".afterAddActionDetTable"] = "";
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_LIST]))
			{
				tdataArray["specialconditionsofcontract"][".list"] = true;
			}
			tdataArray["specialconditionsofcontract"][".strSortControlSettingsJSON"] = "";
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_VIEW]))
			{
				tdataArray["specialconditionsofcontract"][".view"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_IMPORT]))
			{
				tdataArray["specialconditionsofcontract"][".import"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_EXPORT]))
			{
				tdataArray["specialconditionsofcontract"][".exportTo"] = true;
			}
			if(XVar.Pack(GlobalVars.pages[Constants.PAGE_PRINT]))
			{
				tdataArray["specialconditionsofcontract"][".printFriendly"] = true;
			}
			tdataArray["specialconditionsofcontract"][".showSimpleSearchOptions"] = true;
			tdataArray["specialconditionsofcontract"][".allowShowHideFields"] = true;
			tdataArray["specialconditionsofcontract"][".allowFieldsReordering"] = true;
			tdataArray["specialconditionsofcontract"][".isUseAjaxSuggest"] = true;


			tdataArray["specialconditionsofcontract"][".ajaxCodeSnippetAdded"] = false;
			tdataArray["specialconditionsofcontract"][".buttonsAdded"] = false;
			tdataArray["specialconditionsofcontract"][".addPageEvents"] = true;
			tdataArray["specialconditionsofcontract"][".isUseTimeForSearch"] = false;
			tdataArray["specialconditionsofcontract"][".badgeColor"] = "4682B4";
			tdataArray["specialconditionsofcontract"][".allSearchFields"] = SettingsMap.GetArray();
			tdataArray["specialconditionsofcontract"][".filterFields"] = SettingsMap.GetArray();
			tdataArray["specialconditionsofcontract"][".requiredSearchFields"] = SettingsMap.GetArray();
			tdataArray["specialconditionsofcontract"][".googleLikeFields"] = SettingsMap.GetArray();
			tdataArray["specialconditionsofcontract"][".googleLikeFields"].Add("Id");
			tdataArray["specialconditionsofcontract"][".googleLikeFields"].Add("PbdId");
			tdataArray["specialconditionsofcontract"][".googleLikeFields"].Add("MilestoneDescription");
			tdataArray["specialconditionsofcontract"][".googleLikeFields"].Add("Deliverable");
			tdataArray["specialconditionsofcontract"][".googleLikeFields"].Add("PaymentPercentage");
			tdataArray["specialconditionsofcontract"][".tableType"] = "list";
			tdataArray["specialconditionsofcontract"][".printerPageOrientation"] = 0;
			tdataArray["specialconditionsofcontract"][".nPrinterPageScale"] = 100;
			tdataArray["specialconditionsofcontract"][".nPrinterSplitRecords"] = 40;
			tdataArray["specialconditionsofcontract"][".geocodingEnabled"] = false;
			tdataArray["specialconditionsofcontract"][".pageSize"] = 20;
			tdataArray["specialconditionsofcontract"][".warnLeavingPages"] = true;
			tstrOrderBy = "";
			tdataArray["specialconditionsofcontract"][".strOrderBy"] = tstrOrderBy;
			tdataArray["specialconditionsofcontract"][".orderindexes"] = SettingsMap.GetArray();
			tdataArray["specialconditionsofcontract"][".sqlHead"] = "SELECT Id,  	PbdId,  	MilestoneDescription,  	Deliverable,  	PaymentPercentage";
			tdataArray["specialconditionsofcontract"][".sqlFrom"] = "FROM dbo.SpecialConditionsOfContract";
			tdataArray["specialconditionsofcontract"][".sqlWhereExpr"] = "";
			tdataArray["specialconditionsofcontract"][".sqlTail"] = "";
			arrRPP = SettingsMap.GetArray();
			arrRPP.Add(10);
			arrRPP.Add(20);
			arrRPP.Add(30);
			arrRPP.Add(50);
			arrRPP.Add(100);
			arrRPP.Add(500);
			arrRPP.Add(-1);
			tdataArray["specialconditionsofcontract"][".arrRecsPerPage"] = arrRPP;
			arrGPP = SettingsMap.GetArray();
			arrGPP.Add(1);
			arrGPP.Add(3);
			arrGPP.Add(5);
			arrGPP.Add(10);
			arrGPP.Add(50);
			arrGPP.Add(100);
			arrGPP.Add(-1);
			tdataArray["specialconditionsofcontract"][".arrGroupsPerPage"] = arrGPP;
			tdataArray["specialconditionsofcontract"][".highlightSearchResults"] = true;
			tableKeysArray["specialconditionsofcontract"] = SettingsMap.GetArray();
			tableKeysArray["specialconditionsofcontract"].Add("Id");
			tdataArray["specialconditionsofcontract"][".Keys"] = tableKeysArray["specialconditionsofcontract"];
			tdataArray["specialconditionsofcontract"][".hideMobileList"] = SettingsMap.GetArray();
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 1;
			fdata["strName"] = "Id";
			fdata["GoodName"] = "Id";
			fdata["ownerTable"] = "dbo.SpecialConditionsOfContract";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SpecialConditionsOfContract","Id");
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
			tdataArray["specialconditionsofcontract"]["Id"] = fdata;
			tdataArray["specialconditionsofcontract"][".searchableFields"].Add("Id");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 2;
			fdata["strName"] = "PbdId";
			fdata["GoodName"] = "PbdId";
			fdata["ownerTable"] = "dbo.SpecialConditionsOfContract";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SpecialConditionsOfContract","PbdId");
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
			tdataArray["specialconditionsofcontract"]["PbdId"] = fdata;
			tdataArray["specialconditionsofcontract"][".searchableFields"].Add("PbdId");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 3;
			fdata["strName"] = "MilestoneDescription";
			fdata["GoodName"] = "MilestoneDescription";
			fdata["ownerTable"] = "dbo.SpecialConditionsOfContract";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SpecialConditionsOfContract","MilestoneDescription");
			fdata["FieldType"] = 200;
			fdata["strField"] = "MilestoneDescription";
			fdata["sourceSingle"] = "MilestoneDescription";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "MilestoneDescription";
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
			tdataArray["specialconditionsofcontract"]["MilestoneDescription"] = fdata;
			tdataArray["specialconditionsofcontract"][".searchableFields"].Add("MilestoneDescription");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 4;
			fdata["strName"] = "Deliverable";
			fdata["GoodName"] = "Deliverable";
			fdata["ownerTable"] = "dbo.SpecialConditionsOfContract";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SpecialConditionsOfContract","Deliverable");
			fdata["FieldType"] = 200;
			fdata["strField"] = "Deliverable";
			fdata["sourceSingle"] = "Deliverable";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "Deliverable";
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
			tdataArray["specialconditionsofcontract"]["Deliverable"] = fdata;
			tdataArray["specialconditionsofcontract"][".searchableFields"].Add("Deliverable");
			fdata = SettingsMap.GetArray();
			fdata["Index"] = 5;
			fdata["strName"] = "PaymentPercentage";
			fdata["GoodName"] = "PaymentPercentage";
			fdata["ownerTable"] = "dbo.SpecialConditionsOfContract";
			fdata["Label"] = CommonFunctions.GetFieldLabel("dbo_SpecialConditionsOfContract","PaymentPercentage");
			fdata["FieldType"] = 14;
			fdata["strField"] = "PaymentPercentage";
			fdata["sourceSingle"] = "PaymentPercentage";
			fdata["isSQLExpression"] = true;
			fdata["FullName"] = "PaymentPercentage";
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
			tdataArray["specialconditionsofcontract"]["PaymentPercentage"] = fdata;
			tdataArray["specialconditionsofcontract"][".searchableFields"].Add("PaymentPercentage");
			GlobalVars.tables_data["dbo.SpecialConditionsOfContract"] = tdataArray["specialconditionsofcontract"];
			GlobalVars.field_labels["dbo_SpecialConditionsOfContract"] = fieldLabelsArray["specialconditionsofcontract"];
			GlobalVars.fieldToolTips["dbo_SpecialConditionsOfContract"] = fieldToolTipsArray["specialconditionsofcontract"];
			GlobalVars.placeHolders["dbo_SpecialConditionsOfContract"] = placeHoldersArray["specialconditionsofcontract"];
			GlobalVars.page_titles["dbo_SpecialConditionsOfContract"] = pageTitlesArray["specialconditionsofcontract"];
			CommonFunctions.changeTextControlsToDate(new XVar("dbo.SpecialConditionsOfContract"));
			GlobalVars.detailsTablesData["dbo.SpecialConditionsOfContract"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.SpecialConditionsOfContract"] = SettingsMap.GetArray();


			strOriginalDetailsTable = "dbo.PhilippineBiddingDocument";
			masterParams = SettingsMap.GetArray();
			masterParams["mDataSourceTable"] = "dbo.PhilippineBiddingDocument";
			masterParams["mOriginalTable"] = strOriginalDetailsTable;
			masterParams["mShortTable"] = "philippinebiddingdocument";
			masterParams["masterKeys"] = SettingsMap.GetArray();
			masterParams["detailKeys"] = SettingsMap.GetArray();
			masterParams["type"] = Constants.PAGE_LIST;
			GlobalVars.masterTablesData["dbo.SpecialConditionsOfContract"][0] = masterParams;
			GlobalVars.masterTablesData["dbo.SpecialConditionsOfContract"][0]["masterKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.SpecialConditionsOfContract"][0]["masterKeys"].Add("Id");
			GlobalVars.masterTablesData["dbo.SpecialConditionsOfContract"][0]["detailKeys"] = SettingsMap.GetArray();
			GlobalVars.masterTablesData["dbo.SpecialConditionsOfContract"][0]["detailKeys"].Add("PbdId");

SQLEntity obj = null;
var protoArray = SettingsMap.GetArray();
protoArray["0"] = SettingsMap.GetArray();
protoArray["0"]["m_strHead"] = "SELECT";
protoArray["0"]["m_strFieldList"] = "Id,  	PbdId,  	MilestoneDescription,  	Deliverable,  	PaymentPercentage";
protoArray["0"]["m_strFrom"] = "FROM dbo.SpecialConditionsOfContract";
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
obj = new SQLField(new XVar("m_strName", "Id", "m_strTable", "dbo.SpecialConditionsOfContract", "m_srcTableName", "dbo.SpecialConditionsOfContract"));

protoArray["6"]["m_sql"] = "Id";
protoArray["6"]["m_srcTableName"] = "dbo.SpecialConditionsOfContract";
protoArray["6"]["m_expr"] = obj;
protoArray["6"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["6"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["8"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "PbdId", "m_strTable", "dbo.SpecialConditionsOfContract", "m_srcTableName", "dbo.SpecialConditionsOfContract"));

protoArray["8"]["m_sql"] = "PbdId";
protoArray["8"]["m_srcTableName"] = "dbo.SpecialConditionsOfContract";
protoArray["8"]["m_expr"] = obj;
protoArray["8"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["8"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["10"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "MilestoneDescription", "m_strTable", "dbo.SpecialConditionsOfContract", "m_srcTableName", "dbo.SpecialConditionsOfContract"));

protoArray["10"]["m_sql"] = "MilestoneDescription";
protoArray["10"]["m_srcTableName"] = "dbo.SpecialConditionsOfContract";
protoArray["10"]["m_expr"] = obj;
protoArray["10"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["10"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["12"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "Deliverable", "m_strTable", "dbo.SpecialConditionsOfContract", "m_srcTableName", "dbo.SpecialConditionsOfContract"));

protoArray["12"]["m_sql"] = "Deliverable";
protoArray["12"]["m_srcTableName"] = "dbo.SpecialConditionsOfContract";
protoArray["12"]["m_expr"] = obj;
protoArray["12"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["12"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["14"] = SettingsMap.GetArray();
obj = new SQLField(new XVar("m_strName", "PaymentPercentage", "m_strTable", "dbo.SpecialConditionsOfContract", "m_srcTableName", "dbo.SpecialConditionsOfContract"));

protoArray["14"]["m_sql"] = "PaymentPercentage";
protoArray["14"]["m_srcTableName"] = "dbo.SpecialConditionsOfContract";
protoArray["14"]["m_expr"] = obj;
protoArray["14"]["m_alias"] = "";
obj = new SQLFieldListItem(protoArray["14"]);

protoArray["0"]["m_fieldlist"].Add(obj);
protoArray["0"]["m_fromlist"] = SettingsMap.GetArray();
protoArray["16"] = SettingsMap.GetArray();
protoArray["16"]["m_link"] = "SQLL_MAIN";
protoArray["17"] = SettingsMap.GetArray();
protoArray["17"]["m_strName"] = "dbo.SpecialConditionsOfContract";
protoArray["17"]["m_srcTableName"] = "dbo.SpecialConditionsOfContract";
protoArray["17"]["m_columns"] = SettingsMap.GetArray();
protoArray["17"]["m_columns"].Add("Id");
protoArray["17"]["m_columns"].Add("PbdId");
protoArray["17"]["m_columns"].Add("MilestoneDescription");
protoArray["17"]["m_columns"].Add("Deliverable");
protoArray["17"]["m_columns"].Add("PaymentPercentage");
obj = new SQLTable(protoArray["17"]);

protoArray["16"]["m_table"] = obj;
protoArray["16"]["m_sql"] = "dbo.SpecialConditionsOfContract";
protoArray["16"]["m_alias"] = "";
protoArray["16"]["m_srcTableName"] = "dbo.SpecialConditionsOfContract";
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
protoArray["0"]["m_srcTableName"] = "dbo.SpecialConditionsOfContract";
obj = new SQLQuery(protoArray["0"]);

queryData_Array["specialconditionsofcontract"] = obj;

				
		
			tdataArray["specialconditionsofcontract"][".sqlquery"] = queryData_Array["specialconditionsofcontract"];
			tdataArray["specialconditionsofcontract"][".hasEvents"] = true;
		}
	}

}
