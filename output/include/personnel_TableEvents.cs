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
	[Export(typeof(IEventProviderCS_personnel))]
	public class eventclassCS_personnel : IEventProviderCS_personnel
	{


		//	handlers

// After record added
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{

// Place event code here.
// Use "Add Action" button to add code snippets.
//pageObject.setMessage("");
//XSession.Session["saved"] = true;

//pageObject.setMessage("Data has been successfully saved!");
return null;

		} // AfterAdd

// Add page: Before process
		public XVar BeforeProcessAdd(dynamic pageObject)
		{


// Place event code here.
// Use "Add Action" button to add code snippets.

//if(XSession.Session["saved"] == true){
//	pageObject.setProxyValue("saved", true);
	//XSession.Session["saved"] = false;
	//pageObject.stopPRG = true;
//}
return null;

		} // BeforeProcessAdd




	}

}