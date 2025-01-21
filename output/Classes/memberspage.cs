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
	public partial class MembersPage : ListPage_Simple
	{
		public dynamic groups = XVar.Array();
		public dynamic groupFullChecked = XVar.Array();
		public dynamic members = XVar.Array();
		public dynamic users = XVar.Array();
		public dynamic fields = XVar.Array();
		protected dynamic noRecordsFound = XVar.Pack(false);
		protected dynamic sources = XVar.Array();
		protected dynamic providerLabels = XVar.Array();
		protected static bool skipMembersPageCtor = false;
		public MembersPage(dynamic var_params)
			:base((XVar)var_params)
		{
			if(skipMembersPageCtor)
			{
				skipMembersPageCtor = false;
				return;
			}
			this.listAjax = new XVar(false);
			this.pageSize = XVar.Clone(-1);
		}
		public override XVar commonAssign()
		{
			base.commonAssign();
			if(XVar.Pack(!(XVar)(this.noRecordsFound)))
			{
				this.xt.assign(new XVar("savebuttons_block"), new XVar(true));
				this.xt.assign(new XVar("savebutton_attrs"), new XVar("id=\"saveBtn\""));
				this.xt.assign(new XVar("resetbutton_attrs"), new XVar("id=\"resetBtn\""));
			}
			this.xt.assign(new XVar("search_records_block"), new XVar(true));
			this.initLogin();
			this.hideElement(new XVar("message"));
			this.xt.assign(new XVar("menu_block"), new XVar(true));
			this.xt.assign(new XVar("grid_block"), new XVar(true));
			if(XVar.Pack(this.showDisplayField()))
			{
				this.xt.assign(new XVar("displayname_column"), new XVar(true));
			}
			if(XVar.Pack(this.showEmailField()))
			{
				this.xt.assign(new XVar("email_column"), new XVar(true));
			}
			return null;
		}
		public override XVar fillGridData()
		{
			dynamic data = XVar.Array(), dbProvider = null, formattedUsername = null, groups_sate = XVar.Array(), provider = XVar.Array(), row = XVar.Array(), rowInfo = XVar.Array(), rowgroups = XVar.Array(), securityId = null, securityIdField = null, smartyGroups = XVar.Array(), userGroups = XVar.Array(), userid = null, username = null;
			rowInfo = XVar.Clone(XVar.Array());
			data = XVar.Clone(this.beforeProccessRow());
			securityIdField = XVar.Clone(Security.extIdField());
			dbProvider = XVar.Clone(Security.dbProvider());
			while(XVar.Pack(data))
			{
				userid = XVar.Clone(this.recNo);
				row = XVar.Clone(XVar.Array());
				row.InitAndSetArrayItem(XVar.Array(), "grid_record");
				row.InitAndSetArrayItem(XVar.Array(), "grid_record", "data");
				username = XVar.Clone(data[Security.usernameField()]);
				securityId = new XVar("");
				provider = XVar.Clone(dbProvider);
				if(XVar.Pack(securityIdField))
				{
					securityId = XVar.Clone(data[securityIdField]);
					if(XVar.Pack(securityId))
					{
						provider = XVar.Clone(Security.findProvider((XVar)(MVCFunctions.substr((XVar)(securityId), new XVar(0), new XVar(2)))));
					}
				}
				if((XVar)(provider)  && (XVar)(XVar.Equals(XVar.Pack(MVCFunctions.array_search((XVar)(provider["code"]), (XVar)(this.sources))), XVar.Pack(false))))
				{
					this.sources.InitAndSetArrayItem(provider["code"], null);
				}
				if(XVar.Pack(!(XVar)(provider)))
				{
					provider = XVar.Clone(dbProvider);
					securityId = new XVar("");
				}
				groups_sate = XVar.Clone(XVar.Array());
				rowgroups = XVar.Clone(XVar.Array());
				userGroups = XVar.Clone(XVar.Array());
				foreach (KeyValuePair<XVar, dynamic> m in this.members.GetEnumerator())
				{
					if((XVar)((XVar)((XVar)(provider["type"] == Constants.stDB)  && (XVar)(!(XVar)(m.Value["provider"])))  && (XVar)(m.Value["userId"] == username))  || (XVar)((XVar)((XVar)(provider["type"] != Constants.stDB)  && (XVar)(m.Value["provider"] == provider["code"]))  && (XVar)(m.Value["userId"] == securityId)))
					{
						userGroups.InitAndSetArrayItem(m.Value["groupId"], null);
					}
				}
				foreach (KeyValuePair<XVar, dynamic> g in this.groups.GetEnumerator())
				{
					dynamic groupId = null, smarty_group = XVar.Array(), var_checked = null;
					groupId = XVar.Clone(g.Value[0]);
					var_checked = new XVar(0);
					foreach (KeyValuePair<XVar, dynamic> userGroup in userGroups.GetEnumerator())
					{
						if(userGroup.Value == groupId)
						{
							var_checked = new XVar(1);
							break;
						}
					}
					if((XVar)(groupId == -1)  && (XVar)((XVar)(Security.getUserName() == username)  || (XVar)((XVar)(securityId)  && (XVar)(securityId == Security.getUserName()))))
					{
						var_checked = new XVar(3);
					}
					groups_sate.InitAndSetArrayItem(var_checked, groupId);
					smarty_group = XVar.Clone(XVar.Array());
					smarty_group.InitAndSetArrayItem(groupId, "group");
					smarty_group.InitAndSetArrayItem(MVCFunctions.Concat("data-checked=\"", var_checked, "\" id=\"box", groupId, userid, "\" data-userid=\"", userid, "\" data-group=\"", groupId, "\""), "groupbox_attrs");
					rowgroups.InitAndSetArrayItem(new XVar("usergroup_box", new XVar("data", new XVar(0, smarty_group)), "groupcellbox_attrs", MVCFunctions.Concat("id=\"cell", groupId, userid, "\" data-col=\"", groupId, "\"")), null);
				}
				rowgroups.InitAndSetArrayItem("rnr-edge", MVCFunctions.count(rowgroups) - 1, "rnredgeclass");
				row.InitAndSetArrayItem(new XVar("data", rowgroups), "usergroup_boxes");
				row.InitAndSetArrayItem(MVCFunctions.Concat("data-userid=\"userid\" id=\"cellusername", MVCFunctions.runner_htmlspecialchars((XVar)(userid)), "\""), "usernamecell_attrs");
				row.InitAndSetArrayItem(MVCFunctions.Concat("id=\"usernamerow", MVCFunctions.runner_htmlspecialchars((XVar)(userid)), "\""), "usernamerow_attrs");
				row.InitAndSetArrayItem(MVCFunctions.Concat("data-userid=\"", MVCFunctions.runner_htmlspecialchars((XVar)(userid)), "\" data-checked=\"0\" id=\"rowbox", MVCFunctions.runner_htmlspecialchars((XVar)(userid)), "\""), "usernamebox_attrs");
				formattedUsername = XVar.Clone(username);
				if((XVar)(provider)  && (XVar)(provider["type"] != Constants.stDB))
				{
					formattedUsername = XVar.Clone(MVCFunctions.substr((XVar)(securityId), new XVar(2)));
				}
				row.InitAndSetArrayItem(MVCFunctions.runner_htmlspecialchars((XVar)(formattedUsername)), "username");
				this.users.InitAndSetArrayItem(XVar.Array(), userid);
				this.users.InitAndSetArrayItem(provider["code"], userid, "provider");
				if(XVar.Pack(this.showDisplayField()))
				{
					row.InitAndSetArrayItem(MVCFunctions.runner_htmlspecialchars((XVar)(data[""])), "displayusername");
					row.InitAndSetArrayItem(MVCFunctions.Concat("id=\"cellDisplayName", MVCFunctions.runner_htmlspecialchars((XVar)(userid)), "\""), "displayusername_attrs");
					this.users.InitAndSetArrayItem(data[""], userid, "displayUserName");
				}
				if(XVar.Pack(this.showEmailField()))
				{
					row.InitAndSetArrayItem(MVCFunctions.runner_htmlspecialchars((XVar)(data[Security.emailField()])), "emailuser");
					row.InitAndSetArrayItem(MVCFunctions.Concat("id=\"cellEmail", MVCFunctions.runner_htmlspecialchars((XVar)(userid)), "\""), "emailuser_attrs");
					this.users.InitAndSetArrayItem(data[Security.emailField()], userid, "emailUser");
				}
				row.InitAndSetArrayItem(CommonFunctions.GetMLString((XVar)(provider["label"])), "source");
				if(XVar.Pack(securityId))
				{
					this.users.InitAndSetArrayItem(securityId, userid, "userName");
				}
				else
				{
					this.users.InitAndSetArrayItem(username, userid, "userName");
				}
				this.users.InitAndSetArrayItem(groups_sate, userid, "groups");
				this.users.InitAndSetArrayItem(true, userid, "visible");
				row.InitAndSetArrayItem(this.recNo, "recNo");
				this.recNo++;
				if(XVar.Pack(this.eventExists(new XVar("BeforeMoveNextList"))))
				{
					dynamic record = XVar.Array();
					this.eventsObject.BeforeMoveNextList((XVar)(data), (XVar)(row), (XVar)(record), (XVar)(record["recId"]), this);
				}
				rowInfo.InitAndSetArrayItem(row, null);
				data = XVar.Clone(this.beforeProccessRow());
			}
			smartyGroups = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> g in this.groups.GetEnumerator())
			{
				smartyGroups.InitAndSetArrayItem(new XVar("groupname", MVCFunctions.runner_htmlspecialchars((XVar)(g.Value[1])), "groupheadersort_attrs", MVCFunctions.Concat("data-group=\"", g.Value[0], "\" id=\"colsort", g.Value[0], "\" href=\"#\""), "groupheadertdsort_attrs", MVCFunctions.Concat("id=\"tdsort", g.Value[0], "\""), "groupheaderbox_attrs", MVCFunctions.Concat("data-group=\"", g.Value[0], "\" data-checked=\"0\" id=\"colbox", g.Value[0], "\""), "groupheadertdbox_attrs", MVCFunctions.Concat("id=\"tdbox", g.Value[0], "\"")), null);
			}
			this.xt.assign(new XVar("displayuserheadersort_attrs"), new XVar("id=\"displayNameSort\" href=\"#\""));
			this.xt.assign(new XVar("emailuserheadersort_attrs"), new XVar("id=\"EmailSort\" href=\"#\""));
			this.xt.assign(new XVar("usernameheadersort_attrs"), new XVar("id=\"userNameSort\" href=\"#\""));
			this.xt.assign(new XVar("choosecolumnsbutton_attrs"), new XVar("id=\"chooseColumnsButton\" href=\"#\""));
			this.xt.assign(new XVar("sourceuserheadersort_attrs"), new XVar("id=\"SourceSort\" href=\"#\""));
			this.xt.assign(new XVar("displayuserheadertdbox_attrs"), new XVar("id=\"tdboxDisplayName\""));
			this.xt.assign(new XVar("displayuserheadertdsort_attrs"), new XVar("id=\"tdsortDisplayName\""));
			this.xt.assign(new XVar("emailuserheadertdsort_attrs"), new XVar("id=\"tdsortEmail\""));
			this.xt.assign(new XVar("emailuserheadertdbox_attrs"), new XVar("id=\"tdboxEmail\""));
			this.xt.assign_loopsection(new XVar("grid_row"), (XVar)(rowInfo));
			smartyGroups.InitAndSetArrayItem("rnr-edge", MVCFunctions.count(smartyGroups) - 1, "rnredgeclass");
			this.xt.assign_loopsection(new XVar("usergroup_header"), (XVar)(smartyGroups));
			if(XVar.Pack(!(XVar)(rowInfo)))
			{
				this.noRecordsFound = new XVar(true);
			}
			return null;
		}
		public virtual XVar fillMembers()
		{
			dynamic dataSource = null, dc = null, provider = null, qResult = null, tdata = XVar.Array();
			dataSource = XVar.Clone(Security.getUgMembersDatasource());
			dc = XVar.Clone(new DsCommand());
			dc.order = XVar.Clone(XVar.Array());
			dc.order.InitAndSetArrayItem(new XVar("column", ""), null);
			dc.order.InitAndSetArrayItem(new XVar("column", ""), null);
			qResult = XVar.Clone(dataSource.getList((XVar)(dc)));
			while(XVar.Pack(tdata = XVar.Clone(qResult.fetchAssoc())))
			{
				provider = XVar.Clone(tdata[""]);
				this.members.InitAndSetArrayItem(new XVar("userId", tdata[""], "groupId", tdata[""], "provider", provider), null);
			}
			return null;
		}
		public virtual XVar fillGroups()
		{
			dynamic data = XVar.Array(), dataSource = null, dc = null, groupIdField = null, groupLabelField = null, groupProviderField = null, qResult = null;
			this.groups.InitAndSetArrayItem(new XVar(0, -1, 1, MVCFunctions.Concat("<", "Admin", ">")), null);
			this.groupFullChecked.InitAndSetArrayItem(true, null);
			groupIdField = new XVar("");
			groupLabelField = new XVar("");
			groupProviderField = new XVar("");
			dataSource = XVar.Clone(Security.getUgGroupsDatasource());
			dc = XVar.Clone(new DsCommand());
			if(XVar.Pack(CommonFunctions.storageGet(new XVar("groups_provider_field"))))
			{
				dc.order.InitAndSetArrayItem(new XVar("column", groupProviderField, "dir", "ASC"), null);
			}
			dc.order.InitAndSetArrayItem(new XVar("column", groupLabelField, "dir", "ASC"), null);
			qResult = XVar.Clone(dataSource.getList((XVar)(dc)));
			CommonFunctions.storageSet(new XVar("groups_provider_field"), (XVar)(qResult.fieldExists((XVar)(groupProviderField))));
			while(XVar.Pack(data = XVar.Clone(qResult.fetchAssoc())))
			{
				if(XVar.Pack(!(XVar)(!(XVar)(data[groupProviderField]))))
				{
					continue;
				}
				this.groups.InitAndSetArrayItem(new XVar(0, data[groupIdField], 1, data[groupLabelField], 2, data[groupProviderField]), null);
				this.groupFullChecked.InitAndSetArrayItem(true, null);
			}
			return null;
		}
		public override XVar prepareForResizeColumns()
		{
			return null;
		}
		public override XVar rulePRG()
		{
			if((XVar)(MVCFunctions.no_output_done())  && (XVar)(MVCFunctions.postvalue(new XVar("a")) == "save"))
			{
				MVCFunctions.HeaderRedirect((XVar)(this.shortTableName), (XVar)(this.getPageType()), new XVar("a=return"));
				MVCFunctions.ob_flush();
				HttpContext.Current.Response.End();
				throw new RunnerInlineOutputException();
			}
			return null;
		}
		public override XVar prepareForBuildPage()
		{
			this.rulePRG();
			this.fillMembers();
			this.fillGroups();
			this.calculateRecordCount();
			this.buildPagination();
			this.recSet = XVar.Clone(this.dataSource.getList((XVar)(this.queryCommand)));
			if(XVar.Pack(!(XVar)(this.recSet)))
			{
				MVCFunctions.showError((XVar)(this.dataSource.lastError()));
			}
			this.fillGridData();
			this.fillSources();
			this.buildSearchPanel();
			this.fillFields();
			this.addCommonJs();
			this.addCommonHtml();
			this.commonAssign();
			return null;
		}
		public override XVar showPage()
		{
			this.display((XVar)(this.templatefile));
			return null;
		}
		public override XVar addCommonJs()
		{
			RunnerPage.addCommonJs(this);
			this.addJsGroupsAndRights();
			return null;
		}
		public virtual XVar addJsGroupsAndRights()
		{
			this.jsSettings.InitAndSetArrayItem(true, "tableSettings", this.tName, "warnOnLeaving");
			this.jsSettings.InitAndSetArrayItem(this.users, "tableSettings", this.tName, "usersList");
			this.jsSettings.InitAndSetArrayItem(this.fields, "tableSettings", this.tName, "fieldsList");
			this.jsSettings.InitAndSetArrayItem(XVar.Array(), "tableSettings", this.tName, "groupsList");
			foreach (KeyValuePair<XVar, dynamic> grArr in this.groups.GetEnumerator())
			{
				this.jsSettings.InitAndSetArrayItem(grArr.Value[1], "tableSettings", this.tName, "groupsList", grArr.Value[0]);
			}
			this.jsSettings.InitAndSetArrayItem(this.providerLabels, "tableSettings", this.tName, "providerLabels");
			return null;
		}
		public virtual XVar saveMembers(dynamic modifiedMembers)
		{
			foreach (KeyValuePair<XVar, dynamic> userData in modifiedMembers.GetEnumerator())
			{
				this.updateUserGroups((XVar)(userData.Value["provider"]), (XVar)(userData.Value["username"]), (XVar)(userData.Value["groups"]));
			}
			MVCFunctions.Echo(MVCFunctions.my_json_encode((XVar)(new XVar("success", true))));
			return null;
		}
		public virtual XVar updateUserGroups(dynamic _param_provider, dynamic _param_user, dynamic _param_groups)
		{
			#region pass-by-value parameters
			dynamic provider = XVar.Clone(_param_provider);
			dynamic user = XVar.Clone(_param_user);
			dynamic groups = XVar.Clone(_param_groups);
			#endregion

			dynamic dataSource = null, dbProvider = XVar.Array();
			dataSource = XVar.Clone(Security.getUgMembersDatasource());
			dbProvider = XVar.Clone(Security.dbProvider());
			foreach (KeyValuePair<XVar, dynamic> state in groups.GetEnumerator())
			{
				if(state.Value == 1)
				{
					dynamic dcInsert = null;
					dcInsert = XVar.Clone(new DsCommand());
					dcInsert.values = XVar.Clone(new XVar("", user, "", state.Key));
					if(provider != dbProvider["code"])
					{
						dcInsert.values.InitAndSetArrayItem(provider, "");
					}
					dataSource.insertSingle((XVar)(dcInsert));
				}
				else
				{
					dynamic conditions = XVar.Array(), dcDelete = null;
					dcDelete = XVar.Clone(new DsCommand());
					conditions = XVar.Clone(new XVar(0, DataCondition.FieldEquals(new XVar(""), (XVar)(state.Key)), 1, DataCondition.FieldEquals(new XVar(""), (XVar)(user), new XVar(0), (XVar)((XVar.Pack(Security.caseInsensitiveUsername()) ? XVar.Pack(Constants.dsCASE_INSENSITIVE) : XVar.Pack(Constants.dsCASE_STRICT))))));
					if(provider != dbProvider["code"])
					{
						conditions.InitAndSetArrayItem(DataCondition.FieldEquals(new XVar(""), (XVar)(provider)), null);
					}
					else
					{
						if(XVar.Pack(CommonFunctions.storageGet(new XVar("groups_provider_field"))))
						{
							conditions.InitAndSetArrayItem(DataCondition.FieldIs(new XVar(""), new XVar(Constants.dsopEMPTY), new XVar("")), null);
						}
					}
					dcDelete.filter = XVar.Clone(DataCondition._And((XVar)(conditions)));
					dataSource.deleteSingle((XVar)(dcDelete), new XVar(false));
				}
			}
			return null;
		}
		public virtual XVar fillFields()
		{
			if(XVar.Pack(this.showDisplayField()))
			{
				this.fields.InitAndSetArrayItem(new XVar("name", "DisplayName", "visible", 1, "caption", "Display name"), null);
			}
			if(XVar.Pack(this.showEmailField()))
			{
				this.fields.InitAndSetArrayItem(new XVar("name", "Email", "visible", 1, "caption", "E-mail"), null);
			}
			foreach (KeyValuePair<XVar, dynamic> g in this.groups.GetEnumerator())
			{
				this.fields.InitAndSetArrayItem(new XVar("name", g.Value[0], "visible", 1, "caption", g.Value[1]), null);
			}
			return null;
		}
		public override XVar eventExists(dynamic _param_name)
		{
			#region pass-by-value parameters
			dynamic name = XVar.Clone(_param_name);
			#endregion

			return false;
		}
		public override XVar buildSearchPanel()
		{
			return null;
		}
		public override XVar assignSimpleSearch()
		{
			return null;
		}
		protected override XVar setDataSource()
		{
			this.dataSource = XVar.Clone(CommonFunctions.getLoginDataSource());
			return null;
		}
		public virtual XVar sourceSort(dynamic _param_a, dynamic _param_b)
		{
			#region pass-by-value parameters
			dynamic a = XVar.Clone(_param_a);
			dynamic b = XVar.Clone(_param_b);
			#endregion

			if(a["label"] == b["label"])
			{
				return 0;
			}
			return (XVar.Pack(b["label"] < a["label"]) ? XVar.Pack(1) : XVar.Pack(-1));
		}
		protected virtual XVar fillSources()
		{
			dynamic userSources = XVar.Array();
			if(MVCFunctions.count(this.sources) < 2)
			{
				return null;
			}
			this.xt.assign(new XVar("source_column"), new XVar(true));
			userSources = XVar.Clone(XVar.Array());
			foreach (KeyValuePair<XVar, dynamic> code in this.sources.GetEnumerator())
			{
				dynamic provider = XVar.Array(), source = XVar.Array();
				provider = XVar.Clone(Security.findProvider((XVar)(code.Value)));
				source = XVar.Clone(new XVar("code", code.Value, "label", CommonFunctions.GetMLString((XVar)(provider["label"]))));
				userSources.InitAndSetArrayItem(source, null);
				this.providerLabels.InitAndSetArrayItem(source["label"], code.Value);
			}
			MVCFunctions.usort((XVar)(userSources), (XVar)(new XVar(0, this, 1, "sourceSort")));
			this.xt.assign(new XVar("user_sources"), (XVar)(new XVar("data", userSources)));
			return null;
		}
		protected virtual XVar showDisplayField()
		{
			dynamic displayNameField = null, usernameField = null;
			displayNameField = XVar.Clone(Security.fullnameField());
			usernameField = XVar.Clone(Security.usernameField());
			return (XVar)(displayNameField)  && (XVar)(displayNameField != usernameField);
		}
		protected virtual XVar showEmailField()
		{
			dynamic displayNameField = null, emailField = null, usernameField = null;
			displayNameField = XVar.Clone(Security.fullnameField());
			usernameField = XVar.Clone(Security.usernameField());
			emailField = XVar.Clone(Security.emailField());
			return (XVar)((XVar)(emailField)  && (XVar)(emailField != usernameField))  && (XVar)(emailField != displayNameField);
		}
	}
}
