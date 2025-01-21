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
	public partial class ConnectionManager_Base : XClass
	{
		protected dynamic cache = XVar.Array();
		protected dynamic _connectionsData;
		protected dynamic _connectionsIdByName = XVar.Array();
		protected dynamic _tablesConnectionIds;
		public ConnectionManager_Base()
		{
			this._setConnectionsData();
			this._setTablesConnectionIds();
		}
		public virtual XVar getTableConnId(dynamic _param_tName)
		{
			#region pass-by-value parameters
			dynamic tName = XVar.Clone(_param_tName);
			#endregion

			return this._tablesConnectionIds[tName];
		}
		public virtual XVar byTable(dynamic _param_tName)
		{
			#region pass-by-value parameters
			dynamic tName = XVar.Clone(_param_tName);
			#endregion

			dynamic connId = null;
			connId = XVar.Clone(this._tablesConnectionIds[tName]);
			if(XVar.Pack(!(XVar)(connId)))
			{
				return this.getDefault();
			}
			return this.byId((XVar)(connId));
		}
		public virtual XVar byName(dynamic _param_connName)
		{
			#region pass-by-value parameters
			dynamic connName = XVar.Clone(_param_connName);
			#endregion

			dynamic connId = null;
			connId = XVar.Clone(this.getIdByName((XVar)(connName)));
			if(XVar.Pack(!(XVar)(connId)))
			{
				return this.getDefault();
			}
			return this.byId((XVar)(connId));
		}
		protected virtual XVar getIdByName(dynamic _param_connName)
		{
			#region pass-by-value parameters
			dynamic connName = XVar.Clone(_param_connName);
			#endregion

			return this._connectionsIdByName[connName];
		}
		public virtual XVar byId(dynamic _param_connId)
		{
			#region pass-by-value parameters
			dynamic connId = XVar.Clone(_param_connId);
			#endregion

			if(XVar.Pack(!(XVar)(this.cache.KeyExists(connId))))
			{
				dynamic conn = null;
				conn = XVar.Clone(this.getConnection((XVar)(connId)));
				if(XVar.Pack(!(XVar)(conn)))
				{
					conn = XVar.Clone(GlobalVars.restApis.getConnection((XVar)(connId)));
				}
				if(XVar.Pack(!(XVar)(conn)))
				{
					conn = XVar.Clone(this.getDefault());
				}
				this.cache.InitAndSetArrayItem(conn, connId);
			}
			return this.cache[connId];
		}
		public virtual XVar getDefault()
		{
			return this.byId(new XVar("GPMS_at_194_233_66_31_1433"));
		}
		public virtual XVar getDefaultConnId()
		{
			return "GPMS_at_194_233_66_31_1433";
		}
		public virtual XVar getForLogin()
		{
			return this.byId((XVar)(this.getLoginConnId()));
		}
		public virtual XVar getLoginConnId()
		{
			dynamic db = XVar.Array();
			db = Security.dbProvider();
			if(XVar.Pack(db))
			{
				return db["table"]["connId"];
			}
			return "";
		}
		public virtual XVar getForAudit()
		{
			return this.getDefault();
			return null;
		}
		public virtual XVar getForLocking()
		{
			return this.getDefault();
			return null;
		}
		public virtual XVar getForUserGroups()
		{
			return this.byId((XVar)(this.getUserGroupsConnId()));
		}
		public virtual XVar getUserGroupsConnId()
		{
			return "GPMS_at_194_233_66_31_1433";
			return null;
		}
		public virtual XVar getForSavedSearches()
		{
			return this.byId((XVar)(this.getSavedSearchesConnId()));
		}
		public virtual XVar getSavedSearchesConnId()
		{
			return "GPMS_at_194_233_66_31_1433";
			return null;
		}
		public virtual XVar getForWebReports()
		{
			return this.byId((XVar)(this.getSavedSearchesConnId()));
		}
		public virtual XVar getWebReportsConnId()
		{
			return "GPMS_at_194_233_66_31_1433";
			return null;
		}
		protected virtual XVar getConnection(dynamic _param_connId)
		{
			#region pass-by-value parameters
			dynamic connId = XVar.Clone(_param_connId);
			#endregion

			return false;
		}
		public virtual XVar getConectionsIds()
		{
			dynamic connectionsIds = XVar.Array();
			connectionsIds = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> data in this._connectionsData.GetEnumerator())
			{
				connectionsIds.InitAndSetArrayItem(data.Key, null);
			}
			return connectionsIds;
		}
		protected virtual XVar _setConnectionsData()
		{
			return null;
		}
		protected virtual XVar _setTablesConnectionIds()
		{
			dynamic connectionsIds = XVar.Array();
			connectionsIds = XVar.Clone(XVar.Array());
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.ProcuringEntity");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.ProcurementUnit");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.BACSecretariat");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.Personnel");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.BACMembers");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.TWG");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.Observer");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.ObserverInterest");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.ObserverReport");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.TWGExpertise");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.PPMP");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.ProcurementMonitoring");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.vw_APP");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.PhilippineBiddingDocument");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.ScheduleOfRequirements");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.TechnicalSpecifications");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.SpecialConditionsOfContract");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.BidsAndAwardsCommittee");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.HeadOfProcuringEntity");
			connectionsIds.InitAndSetArrayItem("GPMS_at_194_233_66_31_1433", "dbo.SystemSelections");
			this._tablesConnectionIds = connectionsIds;
			return null;
		}
		public virtual XVar checkTablesSubqueriesSupport(dynamic _param_dataSourceTName1, dynamic _param_dataSourceTName2)
		{
			#region pass-by-value parameters
			dynamic dataSourceTName1 = XVar.Clone(_param_dataSourceTName1);
			dynamic dataSourceTName2 = XVar.Clone(_param_dataSourceTName2);
			#endregion

			dynamic connId1 = null, connId2 = null;
			connId1 = XVar.Clone(this._tablesConnectionIds[dataSourceTName1]);
			connId2 = XVar.Clone(this._tablesConnectionIds[dataSourceTName2]);
			if(connId1 != connId2)
			{
				return false;
			}
			if((XVar)(this._connectionsData[connId1]["dbType"] == Constants.nDATABASE_Access)  && (XVar)(dataSourceTName1 == dataSourceTName2))
			{
				return false;
			}
			return true;
		}
		public virtual XVar CloseConnections()
		{
			foreach (KeyValuePair<XVar, dynamic> connection in this.cache.GetEnumerator())
			{
				if(XVar.Pack(connection.Value))
				{
					connection.Value.close();
				}
			}
			return null;
		}
	}
}
