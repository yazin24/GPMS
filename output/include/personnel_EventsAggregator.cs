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
	public interface IEventProviderCS_personnel
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);


		XVar BeforeProcessAdd(dynamic pageObject);





	}

	public interface IEventProviderVB_personnel
	{
		//	handlers



	}

	public class eventclass_personnel : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_personnel))]
		public IEventProviderCS_personnel EventProviderCS;

		//[Import(typeof(IEventProviderVB_personnel))]
		public IEventProviderVB_personnel EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_personnel();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_personnel");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_personnel)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_personnel()
		{
			CreateEvents();

			// fill list of events



			events["AfterAdd"]=true;


			events["BeforeProcessAdd"]=true;


		}


		//	handlers



		
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.AfterAdd(values, keys, inline, pageObject);
		}


		
		public XVar BeforeProcessAdd(dynamic pageObject)
		{
			return EventProviderCS.BeforeProcessAdd(pageObject);
		}





	}
}