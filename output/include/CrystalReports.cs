using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using runnerDotNet;
using CrystalDecisions.Shared;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace runnerDotNet
{
    public class CrystalReports
    {
		//private static HttpResponse response;
		public static string connString = System.Configuration.ConfigurationManager.ConnectionStrings["GPMS_at_194_233_66_31_1433"].ConnectionString;


		public static string PrintConsolidatedProcurementMonitoringReport(string id)
		{
			CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

			string fileName = @"..\CrystalReport\ConsolidatedProcurementMonitoringReport.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";

			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);

				//CrystalDecisions.Shared.ParameterDiscreteValue paramValue2 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				//paramValue2.Value = id;
				//crReportDocument.SetParameterValue("@ParamName", paramValue2);

			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}

			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);

			crReportDocument.Dispose();
			crReportDocument.Close();
		}


		public static string PrintAPPReport(string id)
		{
			CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

			string fileName = @"..\CrystalReport\APP.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";

			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);

				//CrystalDecisions.Shared.ParameterDiscreteValue paramValue2 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				//paramValue2.Value = id;
				//crReportDocument.SetParameterValue("@ParamName", paramValue2);

			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}

			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);

			crReportDocument.Dispose();
			crReportDocument.Close();
		}

		public static string PrintProcurementMonitoringReport(string id)
		{
			CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

			string fileName = @"..\CrystalReport\ProcurementMonitoringReport.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";

			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);

				//CrystalDecisions.Shared.ParameterDiscreteValue paramValue2 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				//paramValue2.Value = id;
				//crReportDocument.SetParameterValue("@ParamName", paramValue2);

			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}

			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);

			crReportDocument.Dispose();
			crReportDocument.Close();
		}


		public static string PrintPPMP(string id)
		{
			CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

			string fileName = @"..\CrystalReport\ProjectProcurementManagementPlan.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";

			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);

				//CrystalDecisions.Shared.ParameterDiscreteValue paramValue2 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				//paramValue2.Value = id;
				//crReportDocument.SetParameterValue("@ParamName", paramValue2);

			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}

			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);

			crReportDocument.Dispose();
			crReportDocument.Close();
		}


		public static string PrintPdf(string id, string report)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\"+report;
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string PrintPds(string id, string report)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\"+report;
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			/*if(report == "Pds.rpt"){
				fileName = @"..\CrystalReport\Pds.rpt";
			}else if(report == "PdsTransmittal.rpt"){
				fileName = @"..\CrystalReport\PdsTransmittal.rpt";
			}*/
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
	


		public static string PrintStaffingPlan(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\RecruitmentStaffingPlan.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
	
		
		
		public static string PrintRecruitmentPlan(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\RecruitmentPlan.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string PrintPersonnelRquisition(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\RecruitmentPersonnelRequisition.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string PrintTurnaroundTime(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\RecruitmentTurnaroundTime.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string PrintComparativeAssessment(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\RecruitmentComparativeAssessment.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string PrintBackgroundInvestigation(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\BackgroundInvestigation.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string RecruitmentAppointment(string id, string report)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\"+report;
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string PrintLeave(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\Leave.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		public static string PrintSaln(string id, string report)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\"+report;
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string PrintPayroll(string id, string report)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\"+report;
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string PrintPayrollRemittanceOfficialReceipt(string id, string incded)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\PayrollRemittanceOfficialReceipt.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue2 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue2.Value = incded;
				crReportDocument.SetParameterValue("@IncomeDeduction", paramValue2);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}

	
		
		public static string PrintServiceRecord(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\ServiceRecord.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		public static string PrintEmploymentCertificate(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\EmploymentCertificate.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		public static string PrintEmployeeTimeRecord(string id, string mm, string yy)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\EmployeeTimeRecord.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue2 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue2.Value = mm;
				crReportDocument.SetParameterValue("@Month", paramValue2);
				
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue3 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue3.Value = yy;
				crReportDocument.SetParameterValue("@Year", paramValue3);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		public static string PrintLeaveCredits(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\EmployeeLeaveSheet.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@Id", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		
		
		
		public static string PrintSpmsPerformanceRating(string id)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
			
			string fileName = @"..\CrystalReport\SpmsPerformanceRating.rpt";
			string reportType = "pdf";
			string reportFormat = ".pdf";
			
			try
			{
				if (fileName.Substring(1).StartsWith(@":\"))
					crReportDocument.Load(fileName);
				else
					crReportDocument.Load(System.Web.HttpContext.Current.Server.MapPath(fileName));
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " Please make sure the dlls for Crystal Report are compatible with the Crystal Report file.";
			}

			try
			{
				//Set report parameter
				CrystalDecisions.Shared.ParameterDiscreteValue paramValue1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
				paramValue1.Value = id;
				crReportDocument.SetParameterValue("@PeriodFrom", paramValue1);
				
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			return ExportReport(crReportDocument, Path.GetFileName(fileName), reportType, reportFormat);
			
			crReportDocument.Dispose();
			crReportDocument.Close();
		}
		
		

		//Call to export report
		public static string ExportReport(CrystalDecisions.CrystalReports.Engine.ReportDocument crReportDocument, string reportFile, string reportType, string reportFormat)
        {
			string report = "";
			
			try
			{
				//define and locate required objects for db login
				CrystalDecisions.CrystalReports.Engine.Database db = crReportDocument.Database;
				CrystalDecisions.CrystalReports.Engine.Tables tables = db.Tables;
				CrystalDecisions.Shared.TableLogOnInfo tableLoginInfo = new CrystalDecisions.Shared.TableLogOnInfo();

				//define connection information
				System.Data.SqlClient.SqlConnectionStringBuilder connStringBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder(connString);
				CrystalDecisions.Shared.ConnectionInfo dbConnInfo = new CrystalDecisions.Shared.ConnectionInfo();
				dbConnInfo.UserID = connStringBuilder.UserID;
				dbConnInfo.Password = connStringBuilder.Password;
				dbConnInfo.ServerName = connStringBuilder.DataSource;
				

				//apply connection information to each table
				foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
				{
					tableLoginInfo = table.LogOnInfo;
					tableLoginInfo.ConnectionInfo = dbConnInfo;
					table.ApplyLogOnInfo(tableLoginInfo);
				}
			}
			catch (Exception ex)
			{
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				errMsg += " If this is a deployment machine, make sure network service has permissions to read and write to the windows\\temp folder.";
			}
			
			try{
				ExportOptions exOpt = default(ExportOptions);
				DiskFileDestinationOptions dfdOpt = new DiskFileDestinationOptions();
				
				string filepath = "/PrintedReport/"+reportFile+"-"+DateTime.Now.ToString("MMddyy-hmmss")+reportFormat;
				dfdOpt.DiskFileName = HttpContext.Current.Server.MapPath("~"+filepath);
				
				exOpt = crReportDocument.ExportOptions;
				exOpt.ExportDestinationType = ExportDestinationType.DiskFile;
				
				if(reportType == "pdf"){
					exOpt.ExportFormatType = ExportFormatType.PortableDocFormat;
				}else if(reportType == "excel"){
					exOpt.ExportFormatType = ExportFormatType.Excel;
				}else if(reportType == "record"){
					exOpt.ExportFormatType = ExportFormatType.ExcelRecord;
				}else if(reportType == "word"){
					exOpt.ExportFormatType = ExportFormatType.WordForWindows;
				}
				
				exOpt.DestinationOptions = dfdOpt;
				
				//finally export your report document    
				crReportDocument.Export();
				crReportDocument.Dispose();
				crReportDocument.Close();
				
				//return string to asprunner
				string newpath = HttpContext.Current.Request.Url.Scheme + "://" +  HttpContext.Current.Request.Url.Host + ":" +  HttpContext.Current.Request.Url.Port + HttpContext.Current.Request.ApplicationPath + filepath;
				//string newpath = HttpContext.Current.Request.Url.Scheme + "://" +  HttpContext.Current.Request.Url.Host + ":" +  HttpContext.Current.Request.Url.Port + filepath;
				report = newpath;
			}catch (Exception ex){
				string errMsg = ex.Message.Replace("\n", "").Replace("\r", "");
				report = errMsg;
			}
			
			crReportDocument.Dispose();
			crReportDocument.Close();
			return report;
			
			//email report
			//Email(HttpContext.Current.Server.MapPath(report));
		}
		
		
		
		public static string PrintExcelNoticeOfVacancy(string id)
		{
			string report = "";// Set the license context in your application startup or configuration
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory+"/CrystalReport/CS Form No. 9 Request for Publication.xlsm");
			
			// Create Excel package
			using (var package = new ExcelPackage(new FileInfo(filePath)))
			{
				// Get the first worksheet
				var worksheet = package.Workbook.Worksheets[0];

				// Execute stored procedure to get data
				DataTable dataTable = new DataTable();
				using (SqlConnection connection = new SqlConnection(connString))
				{
					using (SqlCommand command = new SqlCommand("sp_PrintRecruitmentNoticeOfVacancy", connection))
					{
						command.CommandType = CommandType.StoredProcedure;

						// Add the parameter
						command.Parameters.AddWithValue("@Id", id);

						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							dataTable.Load(reader);
						}
					}
				}


				// Replace {HRMONAME} with the data from the first row of the "HrOfficer" column
				string hrOfficerName = Convert.ToString(dataTable.Rows[0]["HrOfficer"]);
				foreach (var cell in worksheet.Cells)
				{
					if (cell.Text.Contains("{HRMONAME}"))
					{
						cell.Value = cell.Text.Replace("{HRMONAME}", hrOfficerName);
					}
				}

				// Insert DatePublished in row 14, column JK
				//worksheet.Cells[14, 11].Value = dataTable.Rows[0]["DatePublished"].ToString();

				// Replace {DATEPUBLISHED} with the data from the first row of the "DatePublished" column
				string datePublsihed = Convert.ToString(dataTable.Rows[0]["DatePublished"]);
				foreach (var cell in worksheet.Cells)
				{
					if (cell.Text.Contains("{DATEPUBLISHED}"))
					{
						cell.Value = cell.Text.Replace("{DATEPUBLISHED}", datePublsihed);
					}
				}

				// Insert Deadline in row 29
				//worksheet.Cells[29, 2].Value = "Interested and qualified applicants should signify their interest in writing. Attach the following documents to the application letter and send to the address below not later than " + dataTable.Rows[0]["Deadline"].ToString();
				string deadline = Convert.ToString(dataTable.Rows[0]["Deadline"]);
				foreach (var cell in worksheet.Cells)
				{
					if (cell.Text.Contains("Interested and qualified applicants should signify their interest in writing. Attach the following documents to the application letter and send to the address below not later than December 29, 2023."))
					{
						cell.Value = cell.Text.Replace("Interested and qualified applicants should signify their interest in writing. Attach the following documents to the application letter and send to the address below not later than December 29, 2023.", "Interested and qualified applicants should signify their interest in writing. Attach the following documents to the application letter and send to the address below not later than "+ deadline+".");
					}
				}

				// Populate the data from the DataTable
				int startRow = 17;
				if (dataTable.Rows.Count <= 10)
				{
					// If 10 or fewer rows, insert data into rows 18 to 27
					foreach (DataRow row in dataTable.Rows)
					{
						startRow++;

						// Add row number in column A starting from 1
						worksheet.Cells[startRow, 1].Value = startRow - 17;

						worksheet.Cells[startRow, 2].Value = row["PositionTitle"];
						worksheet.Cells[startRow, 3].Value = row["ItemNo"];
						worksheet.Cells[startRow, 4].Value = row["SalaryGrade"];
						worksheet.Cells[startRow, 5].Value = row["MonthlySalary"];
						worksheet.Cells[startRow, 6].Value = row["Education"];
						worksheet.Cells[startRow, 7].Value = row["Training"];
						worksheet.Cells[startRow, 8].Value = row["Experience"];
						worksheet.Cells[startRow, 9].Value = row["Eligibility"];
						worksheet.Cells[startRow, 10].Value = row["Competency"];
						worksheet.Cells[startRow, 11].Value = row["PlaceOfAssignment"];
					}
				}
				else
				{
					int rowCount = dataTable.Rows.Count;

					// Row number where you want to insert blank rows
					int startRowNumber = 27;

					// Number of blank rows to insert
					int numberOfBlankRows = rowCount - 10;

					// Insert blank rows
					worksheet.InsertRow(startRowNumber + 1, numberOfBlankRows);

					// Row number to start in column A
					int startRowNumberInColumnA = 11;

					// Add row numbers to column A
					for (int i = 0; i < numberOfBlankRows; i++)
					{
						worksheet.Cells[startRowNumber + i + 1, 1].Value = startRowNumberInColumnA + i;

						// Add borders to the inserted row (columns A to K)
						using (var range = worksheet.Cells[startRowNumber + i + 1, 1, startRowNumber + i + 1, 11])
						{
							range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
							range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
							range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
							range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
						}
					}

					// If 10 or fewer rows, insert data into rows 18 to 27
					foreach (DataRow row in dataTable.Rows)
					{
						startRow++;

						// Add row number in column A starting from 1
						worksheet.Cells[startRow, 1].Value = startRow - 17;

						worksheet.Cells[startRow, 2].Value = row["PositionTitle"];
						worksheet.Cells[startRow, 3].Value = row["ItemNo"];
						worksheet.Cells[startRow, 4].Value = row["SalaryGrade"];
						worksheet.Cells[startRow, 5].Value = row["MonthlySalary"];
						worksheet.Cells[startRow, 6].Value = row["Education"];
						worksheet.Cells[startRow, 7].Value = row["Training"];
						worksheet.Cells[startRow, 8].Value = row["Experience"];
						worksheet.Cells[startRow, 9].Value = row["Eligibility"];
						worksheet.Cells[startRow, 10].Value = row["Competency"];
						worksheet.Cells[startRow, 11].Value = row["PlaceOfAssignment"];
					}

					

				}

				// Save the changes
				string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
				string newFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory+"/PrintedReport", Path.GetFileNameWithoutExtension(filePath) + "_" + timestamp + Path.GetExtension(filePath));
				package.SaveAs(new FileInfo(newFilePath));
				return report = HttpContext.Current.Request.Url.Scheme + "://" +  HttpContext.Current.Request.Url.Host + ":" +  HttpContext.Current.Request.Url.Port + HttpContext.Current.Request.ApplicationPath + "/PrintedReport/"+Path.GetFileName(newFilePath);
				// Return the new file path
				//return newFilePath;
			}
		}
		
		
		
	}
}