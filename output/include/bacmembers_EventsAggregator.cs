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
	public interface IEventProviderCS_bacmembers
	{
		//	handlers



		XVar AfterAdd(dynamic values, dynamic keys, dynamic inline, dynamic pageObject);


		XVar BeforeAdd(dynamic values, dynamic sqlValues, ref dynamic message, dynamic inline, dynamic pageObject);


		XVar BeforeEdit(dynamic values, dynamic sqlValues, dynamic where, dynamic oldvalues, dynamic keys, ref dynamic message, dynamic inline, dynamic pageObject);


		XVar BeforeProcessAdd(dynamic pageObject);





	}

	public interface IEventProviderVB_bacmembers
	{
		//	handlers



	}

	public class eventclass_bacmembers : EventsAggregatorBase
	{
		//[Import(typeof(IEventProviderCS_bacmembers))]
		public IEventProviderCS_bacmembers EventProviderCS;

		//[Import(typeof(IEventProviderVB_bacmembers))]
		public IEventProviderVB_bacmembers EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new eventclassCS_bacmembers();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.eventclassVB_bacmembers");
				if(eType != null)
				{
					EventProviderVB = (IEventProviderVB_bacmembers)Activator.CreateInstance(eType);
				}
			}
        }

		public eventclass_bacmembers()
		{
			CreateEvents();

			// fill list of events



			events["AfterAdd"]=true;


			events["BeforeAdd"]=true;


			events["BeforeEdit"]=true;


			events["BeforeProcessAdd"]=true;


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


		
		public XVar BeforeProcessAdd(dynamic pageObject)
		{
			return EventProviderCS.BeforeProcessAdd(pageObject);
		}





	}
}