using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Dynamic;
using System.ComponentModel.Composition;
using runnerDotNet;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Web;
using System.Reflection;

namespace runnerDotNet
{
	public interface IEventProviderCS_philippinebiddingdocument
	{
		//	handlers

		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);







	}

	public interface IEventProviderVB_philippinebiddingdocument
	{
		//	handlers



	}

	public class eventclass_philippinebiddingdocument : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_philippinebiddingdocument))]
		public IEventProviderCS_philippinebiddingdocument EventProviderCS;

		//[Import(typeof(IEventProviderVB_philippinebiddingdocument))]
		public IEventProviderVB_philippinebiddingdocument EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_philippinebiddingdocument();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_philippinebiddingdocument");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_philippinebiddingdocument)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_philippinebiddingdocument()
		{
			CreateEvents();

			// fill list of events

			events["AfterAdd"]=true;




		}


		//	handlers

		
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.AfterAdd(values, keys, inline, pageObject);
		}







	}
}