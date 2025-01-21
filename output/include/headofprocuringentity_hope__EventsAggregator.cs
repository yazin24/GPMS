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
	public interface IEventProviderCS_headofprocuringentity_hope_
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_headofprocuringentity_hope_
	{
		//	handlers



	}

	public class eventclass_headofprocuringentity_hope_ : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_headofprocuringentity_hope_))]
		public IEventProviderCS_headofprocuringentity_hope_ EventProviderCS;

		//[Import(typeof(IEventProviderVB_headofprocuringentity_hope_))]
		public IEventProviderVB_headofprocuringentity_hope_ EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_headofprocuringentity_hope_();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_headofprocuringentity_hope_");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_headofprocuringentity_hope_)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_headofprocuringentity_hope_()
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