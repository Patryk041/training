<?php

set_include_path('D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Eagles\TrainingThree\GhostRider\InterfaceAgendaPoint');

require_once 'IInteligentBuildingCommunication.php';
require_once 'IInteligentBuildingDevice.php';
require_once 'IInteligentBuildingManagement.php';

	class PrzykladWieleInterfejsow implements IInteligentBuildingCommunication, IInteligentBuildingManagement, IInteligentBuildingDevice
	{
		
	}
	
	class PrzykladDziedziczenia extends PrzykladWieleInterfejsow
	{
		public function Whatever()
		{
			
		}
	}