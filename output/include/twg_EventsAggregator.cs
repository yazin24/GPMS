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
	public interface IEventProviderCS_twg
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_twg
	{
		//	handlers



	}

	public class eventclass_twg : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_twg))]
		public IEventProviderCS_twg EventProviderCS;

		//[Import(typeof(IEventProviderVB_twg))]
		public IEventProviderVB_twg EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_twg();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_twg");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_twg)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_twg()
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