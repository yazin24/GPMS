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
	public interface IEventProviderCS_procurementmonitoring
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_procurementmonitoring
	{
		//	handlers



	}

	public class eventclass_procurementmonitoring : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_procurementmonitoring))]
		public IEventProviderCS_procurementmonitoring EventProviderCS;

		//[Import(typeof(IEventProviderVB_procurementmonitoring))]
		public IEventProviderVB_procurementmonitoring EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_procurementmonitoring();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_procurementmonitoring");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_procurementmonitoring)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_procurementmonitoring()
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