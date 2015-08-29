<?php

class personFrance implements Person{
 
	private $nr;
 	function __construct($id){
 		$this->nr = $id;
 	}
 	
 	
	 function getSex(){
	 	if(substr($this->nr, 0, 1) == 1){
	 		return "Mê¿czyzna";
	 	}
	 	else {
	 		return "Kobieta";
	 	}
	 }
	 
	 function getBirth(){
	 	
	 	echo " ur. ".substr($this->nr, 3, 2); //dzieñ urodzin
	 	echo ".".substr($this->nr, 2, 2); //rok
	 	return;
	 	
	 }
	 
	 function validate(){

	 	if(strlen($this->nr) == 13 || strlen($this->nr) == 15){
	 		return true;
	 	}
	 	else {
	 		echo "Numer INSEE nieprawid³owy!";
	 		return false;
	 	}
	 }
 
}