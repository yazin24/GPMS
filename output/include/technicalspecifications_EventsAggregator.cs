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
	public interface IEventProviderCS_technicalspecifications
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_technicalspecifications
	{
		//	handlers



	}

	public class eventclass_technicalspecifications : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_technicalspecifications))]
		public IEventProviderCS_technicalspecifications EventProviderCS;

		//[Import(typeof(IEventProviderVB_technicalspecifications))]
		public IEventProviderVB_technicalspecifications EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_technicalspecifications();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_technicalspecifications");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_technicalspecifications)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_technicalspecifications()
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