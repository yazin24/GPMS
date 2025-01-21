using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Data.Common;
using runnerDotNet;

namespace runnerDotNet
{
	public class ConnectionManager : ConnectionManager_Base
	{
		protected override XVar getConnection(dynamic connId)
		{
			if(connId == "")
				return getDefault();

			XVar data = _connectionsData[connId];

			switch(data["connStringType"].ToString())
			{
				case "mssql":
						return new MSSQLConnection(data);
				case "msaccess":
				case "odbc":
				case "odbcdsn":
				case "custom":
				case "file":
				case "db2":
				{
					string firstClause = GlobalVars.ConnectionStrings[connId].ToString().Substring(0, 9).ToUpper();
					if(  firstClause == "PROVIDER=" )
						return new OLEDBConnection(data);
					else
						return new ODBCConnection(data);
				}
				default:
					return null;
			}
		}

		/**
		 * Set the data representing the project's
		 * db connection properties
		 */
		protected override XVar _setConnectionsData()
		{
			// content of this function can be modified on demo account
			// variable names data and connectionsData are important

			var connectionsData = XVar.Array();
			XVar data;
			data = XVar.Array();
			data["dbType"] = "2";
			data["connStringType"] = "mssql";
			data["connId"] = "GPMS_at_194_233_66_31_1433";
			data["connName"] = "GPMS at 194.233.66.31,1433";
			data["leftWrap"] = "[";
			data["rightWrap"] = "]";

			_connectionsIdByName["GPMS at 194.233.66.31,1433"] = "GPMS_at_194_233_66_31_1433";

			data["EncryptInfo"] = XVar.Array();
				data["EncryptInfo"]["mode"] = 0;
			data["EncryptInfo"]["alg"]  = 256;
			data["EncryptInfo"]["key"]  = "";
					data["EncryptInfo"]["slqserverkey"] = "";
			data["EncryptInfo"]["slqservercert"] = "";

			connectionsData["GPMS_at_194_233_66_31_1433"] = data;
			_connectionsData = connectionsData;
			return null;
		}
	}
}