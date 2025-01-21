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
	public interface IEventProviderCS_scheduleofrequirements
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_scheduleofrequirements
	{
		//	handlers



	}

	public class eventclass_scheduleofrequirements : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_scheduleofrequirements))]
		public IEventProviderCS_scheduleofrequirements EventProviderCS;

		//[Import(typeof(IEventProviderVB_scheduleofrequirements))]
		public IEventProviderVB_scheduleofrequirements EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_scheduleofrequirements();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_scheduleofrequirements");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_scheduleofrequirements)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_scheduleofrequirements()
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