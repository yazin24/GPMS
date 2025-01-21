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
	public interface IEventProviderCS_twgexpertise
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);


		XVar BeforeAdd(dynamic values, dynamic sqlValues, ref dynamic message, dynamic inline, dynamic pageObject);


		XVar BeforeEdit(dynamic values, dynamic sqlValues, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject);





	}

	public interface IEventProviderVB_twgexpertise
	{
		//	handlers



	}

	public class eventclass_twgexpertise : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_twgexpertise))]
		public IEventProviderCS_twgexpertise EventProviderCS;

		//[Import(typeof(IEventProviderVB_twgexpertise))]
		public IEventProviderVB_twgexpertise EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_twgexpertise();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_twgexpertise");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_twgexpertise)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_twgexpertise()
		{
			CreateEvents();

			// fill list of events



			events["AfterAdd"]=true;


			events["BeforeAdd"]=true;


			events["BeforeEdit"]=true;


		}


		//	handlers



		
		public XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.AfterAdd(values, keys, inline, pageObject);
		}


		
		public XVar BeforeAdd(dynamic values, dynamic sqlValues, ref dynamic message, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.BeforeAdd(values, sqlValues, ref message, inline, pageObject);
		}


		
		public XVar BeforeEdit(dynamic values, dynamic sqlValues, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject)
		{
			return EventProviderCS.BeforeEdit(values, sqlValues, where, oldvalues, keys, ref message, inline, pageObject);
		}





	}
}