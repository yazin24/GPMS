Runner.buttonEvents["ViewDetailsButton"] = function( pageObj, proxy, pageid ) {
	//register a new button
	pageObj.buttonNames[ pageObj.buttonNames.length ] = 'ViewDetailsButton';
	
	if ( !pageObj.buttonEventBefore['ViewDetailsButton'] ) {
		pageObj.buttonEventBefore['ViewDetailsButton'] = function( params, ctrl, pageObj, proxy, pageid, rowData, row, submit ) {		
			var ajax = ctrl;
// Client Before


var viewUrl = "procurementmonitoring/view?editid1=<%Id%>";


Runner.displayPopup({
    url: viewUrl,
    width: 700, 
    height: 700, 
    modal: true, 
    closeBtn: true 
});


return false;
		}
	}
	
	if ( !pageObj.buttonEventAfter['ViewDetailsButton'] ) {
		pageObj.buttonEventAfter['ViewDetailsButton'] = function( result, ctrl, pageObj, proxy, pageid, rowData, row, params ) {
			var ajax = ctrl;
// Put your code here.
var message = result["txt"] + " !!!";
ajax.setMessage(message);

		}
	}
	
	$('a[id="ViewDetailsButton"]').each( function() {
		if ( $(this).closest('.gridRowAdd').length ) {
			return;
		}
		
		this.id = "ViewDetailsButton" + "_" + Runner.genId();
		
		// create object
		var button_ViewDetailsButton = new Runner.form.Button({
			id: this.id ,
			btnName: "ViewDetailsButton"
		});
		
		// init
		button_ViewDetailsButton.init( {args: [ pageObj, proxy, pageid ]} );
	});
};

