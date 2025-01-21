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
	public interface IEventProviderCS_procurementunit
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_procurementunit
	{
		//	handlers



	}

	public class eventclass_procurementunit : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_procurementunit))]
		public IEventProviderCS_procurementunit EventProviderCS;

		//[Import(typeof(IEventProviderVB_procurementunit))]
		public IEventProviderVB_procurementunit EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_procurementunit();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_procurementunit");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_procurementunit)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_procurementunit()
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