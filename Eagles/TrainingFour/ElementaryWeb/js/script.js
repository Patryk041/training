

$(document).ready(function() {

	//console.log('test');
	RegisterAllButtonsAjax();
});

function RegisterAllButtonsAjax()
{
	
	RegisterButtonClickCallback('przycisk', PrzyciskClick);
	
}

function PrzyciskClick(ev) {

	$.ajax(
		{
			url: 'server.php',
			success: PRzyciskAjaxCallback
		}
	);
}

function PRzyciskAjaxCallback(data)
{
	// my spodziewamy sie html !
	
	var json = JSON.parse(data);
	
	console.log('edt', json);
	
	//json.registration.controllerActions.save
	//markup
	$('#container').html(json.registration.controllerActions.save);
}

//----------------------

function RegisterButtonClickCallback(buttonId, callback)
{
	$('#' + buttonId).click(function(ev) 
	{
		callback(ev);
	});
}