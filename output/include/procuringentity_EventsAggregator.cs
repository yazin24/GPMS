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
	public interface IEventProviderCS_procuringentity
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_procuringentity
	{
		//	handlers



	}

	public class eventclass_procuringentity : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_procuringentity))]
		public IEventProviderCS_procuringentity EventProviderCS;

		//[Import(typeof(IEventProviderVB_procuringentity))]
		public IEventProviderVB_procuringentity EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_procuringentity();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_procuringentity");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_procuringentity)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_procuringentity()
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