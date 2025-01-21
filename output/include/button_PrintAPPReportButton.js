Runner.buttonEvents["PrintAPPReportButton"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'PrintAPPReportButton';
	
	if ( !pageObj.buttonEventBefore['PrintAPPReportButton'] ) {
		pageObj.buttonEventBefore['PrintAPPReportButton'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;
// Put your code here.
//params["txt"] = "Hello";
//ajax.setMessage("Sending request to server...");
 // Uncomment the following line to prevent execution of "Server" and "Client After" events.
 // return false;
		}
	}
	
	if ( !pageObj.buttonEventAfter['PrintAPPReportButton'] ) {
		pageObj.buttonEventAfter['PrintAPPReportButton'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
// Put your code here.
//var message = result["txt"] + " !!!";
//ajax.setMessage(message);

//window.open(result["ReportLink"], '_blank');
		}
	}
	
	$('a[id="PrintAPPReportButton"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "PrintAPPReportButton" + "_" + Runner.genId();
		
		// create object
		var button_PrintAPPReportButton = new Runner.form.Button({
			id: this.id ,
			btnName: "PrintAPPReportButton"
		});
		
		// init
		button_PrintAPPReportButton.init( {args: [ pageObj, proxy, pageid ]} );
	});
};

