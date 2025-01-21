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
	public interface IGlobalEventProviderCS
	{

		// handlers

		XVar ModifyMenu(dynamic menu);


		// onscreen events

		// table maps, buttons
		XVar event_ViewDetailsButton(dynamic context);
		XVar event_Print_PPMP_Button(dynamic context);
		XVar event_PrintProcurementMonitoringReportButton(dynamic context);
		XVar event_PrintAPPReportButton(dynamic context);
		XVar event_New_Button(dynamic context);



		// common events
		XVar AfterTableInit(dynamic context);
		XVar GetTablePermissions(dynamic permissions, dynamic table = null);
		XVar IsRecordEditable(dynamic values, dynamic isEditable, dynamic table = null);
	}

	public interface IGlobalEventProviderVB
	{

		// handlers

		// onscreen events

		// table maps, buttons



		// common events
		XVar AfterTableInit(dynamic context);
		XVar GetTablePermissions(dynamic permissions, dynamic table = null);
		XVar IsRecordEditable(dynamic values, dynamic isEditable, dynamic table = null);
	}

	public class EventsAggregatorBase : XClass
	{
		public enum EventLanguage
		{
			CS = 0,
			VB = 1
		};

		public XVar events;
		public XVar captchas;
		public XVar maps;

		public EventsAggregatorBase()
		{
			events = XVar.Array();
			captchas = XVar.Array();
			maps = XVar.Array();
		}

		public XVar exists(dynamic curEvent, dynamic table = null)
		{
			if(table == null || table == "")
				return events.KeyExists(curEvent);
			else
				return events.KeyExists(curEvent) && events[curEvent].KeyExists(table);
		}

		public XVar existsMap(dynamic page)
		{
			return maps.KeyExists(page);
		}

		public XVar existsCAPTCHA(dynamic page)
		{
			return captchas.KeyExists(page);
		}
	}

	public class class_GlobalEvents : EventsAggregatorBase
	{
		//[Import(typeof(IGlobalEventProviderCS))]
		public IGlobalEventProviderCS EventProviderCS;

		//[Import(typeof(IGlobalEventProviderVB))]
		public IGlobalEventProviderVB EventProviderVB;

		public void CreateEvents()
        {
			EventProviderCS = new CommonEventsCS();
			if(appsettings.vbEvents != null)
			{
				Type eType = appsettings.vbEvents.GetType("runnerDotNet.runnerDotNet.CommonEventsVB");
				if(eType != null)
				{
					EventProviderVB = (IGlobalEventProviderVB)Activator.CreateInstance(eType);
				}
			}
        }

		public class_GlobalEvents()
		{
			CreateEvents();

			// fill list of events

			events["ModifyMenu"]=true;




			// onscreen events

		}

		//	handlers

		
		public XVar ModifyMenu(dynamic menu)
		{
			return EventProviderCS.ModifyMenu(menu);
		}


		//	onscreen events


		// local maps, buttons
		public XVar event_ViewDetailsButton(dynamic context)
		{
			EventProviderCS.event_ViewDetailsButton(context);
			return MVCFunctions.GetBuferContentAndClearBufer();
		}
		public XVar event_Print_PPMP_Button(dynamic context)
		{
			EventProviderCS.event_Print_PPMP_Button(context);
			return MVCFunctions.GetBuferContentAndClearBufer();
		}
		public XVar event_PrintProcurementMonitoringReportButton(dynamic context)
		{
			EventProviderCS.event_PrintProcurementMonitoringReportButton(context);
			return MVCFunctions.GetBuferContentAndClearBufer();
		}
		public XVar event_PrintAPPReportButton(dynamic context)
		{
			EventProviderCS.event_PrintAPPReportButton(context);
			return MVCFunctions.GetBuferContentAndClearBufer();
		}
		public XVar event_New_Button(dynamic context)
		{
			EventProviderCS.event_New_Button(context);
			return MVCFunctions.GetBuferContentAndClearBufer();
		}

		// AJAX handlers



		public XVar AfterTableInit(dynamic context)
		{
			if (EventProviderCS != null)
	        {
	            EventProviderCS.AfterTableInit(context);
	        }
	        if (EventProviderVB != null)
	        {
	            EventProviderVB.AfterTableInit(context);
	        }
			return null;
		}

		public XVar GetTablePermissions(dynamic permissions, dynamic table = null)
		{
			if (EventProviderCS != null)
	        {
	            permissions = EventProviderCS.GetTablePermissions(permissions, table);
	        }
	        if (EventProviderVB != null)
	        {
	            permissions = EventProviderVB.GetTablePermissions(permissions, table);
	        }
			return permissions;
		}

		public XVar IsRecordEditable(dynamic values, dynamic isEditable, dynamic table = null)
		{
			if (EventProviderCS != null)
        	{
	            isEditable = EventProviderCS.IsRecordEditable(values, isEditable, table);
	        }
	        if (EventProviderVB != null)
	        {
	            isEditable = EventProviderVB.IsRecordEditable(values, isEditable, table);
	        }
			return isEditable;
		}
	}
}