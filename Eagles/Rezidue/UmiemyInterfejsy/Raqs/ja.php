<?php

	require_once '../Interfaces.php';
	
	
	 class Raqs implements IHuman,IDeveloper {
	 	function getName(){
	 		return "Janusz Cebula";
	 	}
	 	function getSex(){
	 		return "Nieznana";
	 	}
	 	
	 	function developSomeCode($codeToCode){
	 		return "Kod Raqsa ".$string;
	 	}
	 }
	 
