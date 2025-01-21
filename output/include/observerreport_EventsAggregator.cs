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
	public interface IEventProviderCS_observerreport
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_observerreport
	{
		//	handlers



	}

	public class eventclass_observerreport : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_observerreport))]
		public IEventProviderCS_observerreport EventProviderCS;

		//[Import(typeof(IEventProviderVB_observerreport))]
		public IEventProviderVB_observerreport EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_observerreport();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_observerreport");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_observerreport)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_observerreport()
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