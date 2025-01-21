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
	public interface IEventProviderCS_specialconditionsofcontract
	{
		//	handlers

		XVar BeforeDelete(dynamic where, dynamic deleted_values, ref dynamic message, dynamic pageObject);




		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_specialconditionsofcontract
	{
		//	handlers



	}

	public class eventclass_specialconditionsofcontract : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_specialconditionsofcontract))]
		public IEventProviderCS_specialconditionsofcontract EventProviderCS;

		//[Import(typeof(IEventProviderVB_specialconditionsofcontract))]
		public IEventProviderVB_specialconditionsofcontract EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_specialconditionsofcontract();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_specialconditionsofcontract");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_specialconditionsofcontract)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_specialconditionsofcontract()
		{
			CreateEvents();

			// fill list of events

			events["BeforeDelete"]=true;




			events["AfterAdd"]=true;


		}


		//	handlers

		
		public XVar BeforeDelete(dynamic where, dynamic deleted_values, ref dynamic message, dynamic pageObject)
		{
			return EventProviderCS.BeforeDelete(where, deleted_values, ref message, pageObject);
		}




		
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.AfterAdd(values, keys, inline, pageObject);
		}





	}
}