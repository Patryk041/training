<?php
/**
* 
*/
class InteligentBuildingConmmunicationModel
{
	
	public $HomeAdress;

	public $DeviceName;
	//operation
	public $Operation;

	public function __construct()
	{
		$this->Operation = new Operation();
		
	}
}