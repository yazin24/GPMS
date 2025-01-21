using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using System.Web;
using runnerDotNet;


namespace runnerDotNet
{
	[Export(typeof(IEventProviderCS_specialconditionsofcontract))]
	public class eventclassCS_specialconditionsofcontract : IEventProviderCS_specialconditionsofcontract
	{


		//	handlers
// Before record deleted
		public XVar BeforeDelete(dynamic where, dynamic deleted_values, ref dynamic message, dynamic pageObject)
		{

//**********  Send email with old data record  ************
string email = "test@test.com";
string from = "admin@test.com";
StringBuilder msg = new StringBuilder("");
string subject = "Sample subject";

// modify the following SQL query to select fields you like to send
XVar rs = CommonFunctions.db_query("select * from " + GlobalVars.strTableName.ToString() + " where " + where.ToString(), null);

XVar data = CommonFunctions.db_fetch_array(rs);
if(data)
{
	foreach(var field in data.GetEnumerator())
	{
		msg.Append(field.Key.ToString() + " : " + field.Value.ToString() + "\r\n");
	}
	XVar ret = MVCFunctions.runner_mail(new XVar("to", email, "subject", subject, "body", msg.ToString(), "from", from));
	if(!ret["mailed"])
	{
		MVCFunctions.EchoToOutput(ret["message"]);
	}
}



return null;

		} // BeforeDelete


// After record added
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{


// Place event code here.
// Use "Add Action" button to add code snippets.
pageObject.setMessage("");
XSession.Session["saved"] = true;
return null;

		} // AfterAdd




	}

}