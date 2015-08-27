<?php

require_once 'interfaces/Operation.php';
require_once 'InteligentBuildingConmmunicationModel.php';

require_once 'interfaces/IInteligentBuildingCommunication.php';

require_once 'classes/Krzeslo.php';

class BuildingCommunicationAgregator
{	
//drivars map
	private $drivers = array("Krzeslo Corp" => "Krzeslo");

	public function AgregateInfo($message)
	{
		if(array_key_exists($message["Corp"], $this->drivers)){
			$driver = new $this->drivers[$message["Corp"]]();
			echo $this->drivers[$message["Corp"]];
			$info = $driver->GetOperations(New InteligentBuildingConmmunicationModel(), $message["info"]);
			var_dump($info);
		}else{
			echo "Error";
		}
	}
}

$homework = new BuildingCommunicationAgregator();
$message = array("Corp" => "Krzeslo Corp", "info" =>"String");
$homework->AgregateInfo($message);