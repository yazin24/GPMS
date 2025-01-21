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
	[Export(typeof(IEventProviderCS_bidsandawardscommittee_bac_))]
	public class eventclassCS_bidsandawardscommittee_bac_ : IEventProviderCS_bidsandawardscommittee_bac_
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