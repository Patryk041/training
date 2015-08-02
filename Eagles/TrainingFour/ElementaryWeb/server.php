<?php

	if (isset($_SERVER['HTTP_X_REQUESTED_WITH']) && $_SERVER['HTTP_X_REQUESTED_WITH'] == 'XMLHttpRequest')
	{
		$tablicaRoutingu = array(
				'registration' => 
					array('controllerObj' => 'RegistrationController', 
							'controllerActions' => 
					array('save' => 'LolSaveRegistration')),
				'gallery' => 
					array('controllerObj'=> 'GalleryController')
);

		echo json_encode($tablicaRoutingu);
		exit;
		//die('tego skryptu nie mozna uruchamiac ajaxem :P');
	}
	
//var_dump($_SERVER);

	echo 'jestem wesoly tomek ';