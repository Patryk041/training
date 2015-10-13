<?php

interface ICountry
	{
		public function retCountry();
		
		public function retSex();
		
		//public function retBirthYear();
		
		//public function retBirthMonth();
		
		//public function retBirthDay();

	} 

abstract class Country implements ICountry 
	{

	public $CountryCode;
	
	public $NatIDNumber;
	
	public abstract function retCountry();
		
	public abstract function retSex();
		
	//public abstract function retBirthYear();
		
	//public abstract function retBirthMonth();
		
	//public abstract function retBirthDay();
	
	}
	
class ID_POL extends Country
	{
		
		public function retCountry()
		{
			return $this->CountryCode;
		}
		
		public function retSex()
		{
			if((substr($this->NatIDNumber, -2, 1) % 2) == 0) 
			{
				return "female";
			} else {
				return "male";
			}
		}
		
		public function __construct($PersonID)
		{
			$this->NatIDNumber = $PersonID;
			$this->CountryCode = "POL";
		}
		
	}
	
	class ID_ITA extends Country
	{
		
		public function retCountry()
		{
			return $this->CountryCode;
		}
		
		public function retSex()
		{
			if((substr($this->NatIDNumber, 9, 2)) >= 40) 
			{
				return "female";
			} else {
				return "male";
			}
		}
		
		public function __construct($PersonID)
		{
			$this->NatIDNumber = $PersonID;
			$this->CountryCode = "ITA";
		}
		
	}
	
	$IDs = array(
		"90022815265",
		"MRTMTT25D09F205Z",
		"LolDupa"
	);
	
	$IDgroup = array();
	
	class CountryManager {
		 
		static function checkCountry($NatIDNumber){
			if (strlen($NatIDNumber)==11)
			{
				return new ID_POL($NatIDNumber);
			} 
			elseif (strlen($NatIDNumber)==16)
			{
				return new ID_ITA($NatIDNumber);
			}
			
			return null;
		}
	}
	
	foreach ($IDs as $ID){
		array_push($IDgroup, CountryManager::checkCountry($ID));
	}
	
	foreach ($IDgroup as $ID){
		if ($ID!=null)
			echo $ID->retCountry()."\n";
	}
	
	//echo "\nJeszcze dziala!";

?>