<?php

require_once "../GhostRider/Homework/StringOperationsObj.php";
require_once "../../TrainingOne/Rudi/funkcje.php";

class RudiStringOperability extends GhostRiderStringOperability
{
	public function StringLength($string){
		return Rudi_strlen($string);
	}

	public function SubString($string, $length){
		return Rudi_substr($string, $length);
		}

	public function GetNick()
	{
	return "Rudi";
	}
	
}
