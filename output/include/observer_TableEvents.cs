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
	[Export(typeof(IEventProviderCS_observer))]
	public class eventclassCS_observer : IEventProviderCS_observer
	{


		//	handlers

// After record added
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{


// Place event code here.
// Use "Add Action" button to add code snippets.
//pageObject.setMessage("");
//XSession.Session["saved"] = true;

pageObject.setMessage("Data has been successfully saved!");
return null;

		} // AfterAdd

// Before record added
		public XVar BeforeAdd(dynamic values, dynamic sqlValues, ref dynamic message, dynamic inline, dynamic pageObject)
		{


// Place event code here.
// Use "Add Action" button to add code snippets.

 int ID = values["PersonnelId"];


 string sqlQuery = "SELECT Name FROM dbo.Personnel WHERE Id=" + ID;
 dynamic result = DB.Query(sqlQuery);
 string PersonnelName = result.fetchAssoc()["Name"];

 values["ObserverName"] = PersonnelName;

 return true;

return null;

		} // BeforeAdd

// Before record updated
		public XVar BeforeEdit(dynamic values, dynamic sqlValues, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject)
		{


// Place event code here.
// Use "Add Action" button to add code snippets.

 int ID = values["PersonnelId"];


 string sqlQuery = "SELECT Name FROM dbo.Personnel WHERE Id=" + ID;
 dynamic result = DB.Query(sqlQuery);
 string PersonnelName = result.fetchAssoc()["Name"];

 values["ObserverName"] = PersonnelName;

 return true;

return null;

		} // BeforeEdit

// Add page: Before process
		public XVar BeforeProcessAdd(dynamic pageObject)
		{


// Place event code here.
// Use "Add Action" button to add code snippets.

//if(XSession.Session["saved"] == true){
	//pageObject.setProxyValue("saved", true);
//XSession.Session["saved"] = false;
	//pageObject.stopPRG = true;
//}
return null;

		} // BeforeProcessAdd




	}

}