<?php
require_once '../../GhostRider/HomeWork/Interfaces/IInteligentBuildingCommunication.php';
require_once '../../GhostRider/HomeWork/InteligentBuildingCommunicationModel.php';
require_once '../../GhostRider/HomeWork/Operation.php';
require_once 'FileReader.php';

class RudiInteligentBuildingCommunication implements IInteligentBuildingCommunication
{
	
	public $daneZPliku=array();
	public $modele=array();
	
	public function __construct()
	{
		//wczytanie danych z pliku textowego
		$fr=new FileReader("operacje.txt");
		
		//odczytanie wszystkich linii z pliku
		$this->daneZPliku=$fr->getAll();
		

		//utworzenie z danych obiektów Operacja 
		foreach($this->daneZPliku as $linia)
		{
			$model=new InteligentBuildingCommunicationModel();
			$dane = explode(';', $linia);
			
			$model->Operation = $this->getOperacja($dane);
			$model->HomeAddress=$dane[0];
			$model->DeviceName=$dane[1];
			$this->modele[]=$model;
		}
			
	}

	private function getOperacja($dane)
	{
		$operacja=new Operation();
		$operacja->OperationType=$dane[2];
		$operacja->OperationHour=$dane[3];
		$operacja->OperationTime=$dane[4];
		$operacja->OperatorionEnergyUsage=$dane[5];
		$operacja->OperationErrors=$dane[6];
		$operacja->OperationExtraInfo=$dane[7];
		
		return $operacja;
	}

	public function GetOperations(){
		return $this->modele;
	}
	
}