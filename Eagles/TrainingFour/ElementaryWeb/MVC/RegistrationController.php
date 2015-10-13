<?php

require_once 'MVC/MvcController.php';

	class RegistrationController extends MvcController
	{
		//routing
		
		//adres url   ->   jaki kontroler ? jaka metoda ? 
		
		public function RenderRegistrationForm(RegistrationModel $model)
		{
			//nazwaUsera
			$view = new RegistrationView();
			
			
			$model->nazwaUsera;
			
			// logika biznesowa
			// bll
			// dal
			
			//mvcmodel
		}
		
		// registration/save
		public function SaveRegistration(RegistrationModel $model)
		{
			///headers
			//markup html
			
			return '<input />';
		}
		///
	}