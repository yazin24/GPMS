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
	[Export(typeof(IEventProviderCS_observerinterest))]
	public class eventclassCS_observerinterest : IEventProviderCS_observerinterest
	{


		//	handlers

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