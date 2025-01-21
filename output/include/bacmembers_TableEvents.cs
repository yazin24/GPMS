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
	[Export(typeof(IEventProviderCS_bacmembers))]
	public class eventclassCS_bacmembers : IEventProviderCS_bacmembers
	{


		//	handlers

// After record added
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{

pageObject.showItem("add_message");

return true;





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

 //dynamic HeadOfProcuringEntityData = XVar.Array();

 values["BacMemberName"] = PersonnelName;

 //DB.Insert("HeadOfProcuringEntity", HeadOfProcuringEntityData);

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

 //dynamic HeadOfProcuringEntityData = XVar.Array();

 values["BacMemberName"] = PersonnelName;

 //DB.Insert("HeadOfProcuringEntity", HeadOfProcuringEntityData);

return true;
return null;

		} // BeforeEdit

// Add page: Before process
		public XVar BeforeProcessAdd(dynamic pageObject)
		{


// Place event code here.
// Use "Add Action" button to add code snippets.


return null;

		} // BeforeProcessAdd




	}

}