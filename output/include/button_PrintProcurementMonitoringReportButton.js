Runner.buttonEvents["PrintProcurementMonitoringReportButton"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'PrintProcurementMonitoringReportButton';
	
	if ( !pageObj.buttonEventBefore['PrintProcurementMonitoringReportButton'] ) {
		pageObj.buttonEventBefore['PrintProcurementMonitoringReportButton'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;
// Put your code here.
//params["txt"] = "Hello";
//ajax.setMessage("Sending request to server...");
 // Uncomment the following line to prevent execution of "Server" and "Client After" events.
 // return false;
		}
	}
	
	if ( !pageObj.buttonEventAfter['PrintProcurementMonitoringReportButton'] ) {
		pageObj.buttonEventAfter['PrintProcurementMonitoringReportButton'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
// Put your code here.
//var message = result["txt"] + " !!!";
//ajax.setMessage(message);

window.open(result["ReportLink"], '_blank');

		}
	}
	
	$('a[id="PrintProcurementMonitoringReportButton"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "PrintProcurementMonitoringReportButton" + "_" + Runner.genId();
		
		// create object
		var button_PrintProcurementMonitoringReportButton = new Runner.form.Button({
			id: this.id ,
			btnName: "PrintProcurementMonitoringReportButton"
		});
		
		// init
		button_PrintProcurementMonitoringReportButton.init( {args: [ pageObj, proxy, pageid ]} );
	});
};

