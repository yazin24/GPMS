Runner.buttonEvents["Print_PPMP_Button"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'Print_PPMP_Button';
	
	if ( !pageObj.buttonEventBefore['Print_PPMP_Button'] ) {
		pageObj.buttonEventBefore['Print_PPMP_Button'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;
// Put your code here.
//params["txt"] = "Hello";
//ajax.setMessage("Sending request to server...");
 // Uncomment the following line to prevent execution of "Server" and "Client After" events.
 // return false;
		}
	}
	
	if ( !pageObj.buttonEventAfter['Print_PPMP_Button'] ) {
		pageObj.buttonEventAfter['Print_PPMP_Button'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
// Put your code here.
//var message = result["txt"] + " !!!";
//ajax.setMessage(message);

window.open(result["ReportLink"], '_blank');
		}
	}
	
	$('a[id="Print_PPMP_Button"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "Print_PPMP_Button" + "_" + Runner.genId();
		
		// create object
		var button_Print_PPMP_Button = new Runner.form.Button({
			id: this.id ,
			btnName: "Print_PPMP_Button"
		});
		
		// init
		button_Print_PPMP_Button.init( {args: [ pageObj, proxy, pageid ]} );
	});
};

