<?php
require_once '../../GhostRider/HomeWork/Interfaces/IInteligentBuildingCommunication.php';
require_once '../../GhostRider/HomeWork/InteligentBuildingCommunicationModel.php';
require_once '../../GhostRider/HomeWork/Operation.php';
require_once 'FileReader.php';

class RudiInteligentBuildingCommunicationModel implements IInteligentBuildingCommunication
{
	
	public $date=array();
	public $operacje=array();
	
	public function __construct()
	{
		//wczytanie danych z pliku textowego
		$fr=new FileReader("operacje.txt");
		
		//odczytanie wszystkich linii z pliku
		$this->date=$fr->getAll();
		

		//utworzenie z danych obiektów Operacja 
		foreach($this->date as $data)
		{
			$model=new ru
			$operacja=$this->getOperacja($data);
			
			
			
		}
		
		
	}

	private function getOperacja($data)
	{
		$operacaj=new Operation();
		$operacaj->OperationType=$data[0];
		$operacaj->OperationHour=$data[1];
		$operacaj->OperationTime=$data[2];
		$operacaj->OperatorionEnergyUsage=$data[3];
		$operacaj->OperationErrors=$data[4];
		$operacaj->OperationExtraInfo=$data[5];
	}
	
}