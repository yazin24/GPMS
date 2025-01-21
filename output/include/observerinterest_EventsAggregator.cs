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
	public interface IEventProviderCS_observerinterest
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_observerinterest
	{
		//	handlers



	}

	public class eventclass_observerinterest : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_observerinterest))]
		public IEventProviderCS_observerinterest EventProviderCS;

		//[Import(typeof(IEventProviderVB_observerinterest))]
		public IEventProviderVB_observerinterest EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_observerinterest();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_observerinterest");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_observerinterest)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_observerinterest()
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