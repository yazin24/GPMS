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
	public interface IEventProviderCS_ppmp
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_ppmp
	{
		//	handlers



	}

	public class eventclass_ppmp : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_ppmp))]
		public IEventProviderCS_ppmp EventProviderCS;

		//[Import(typeof(IEventProviderVB_ppmp))]
		public IEventProviderVB_ppmp EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_ppmp();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_ppmp");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_ppmp)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_ppmp()
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