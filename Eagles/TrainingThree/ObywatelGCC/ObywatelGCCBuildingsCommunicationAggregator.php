<?php

	require_once '../GhostRider/HomeWork/Interfaces/IInteligentBuildingCommunication.php';
	require_once '../GhostRider/HomeWork/InteligentBuildingCommunicationModel.php';
	require_once '../GhostRider/HomeWork/BuildingsCommunicationAggregator.php';
	
	class ObywatelGCCBuildingsCommunicationAggregator extends BuildingsCommunicationAggregator
	{
		private $buildingCommunicationList = array(
// 				array('producentName' => 'Dziara', 'dir' => 'DziaraHomeWork/', 'communicationFunction' => 'DziaraInteligentBuildingCommunication'), 
				array('producentName' => 'ObywatelGCC', 'dir' => '', 'communicationFunction' => 'ObywatelGCCInteligentBuildingCommunication'),
// 				array('producentName' => 'Perla', 'dir' => '', 'communicationFunction' => 'InteligentBuildingCommunication'),
				array('producentName' => 'Rudi', 'dir' => 'Homework/', 'communicationFunction' => 'RudiInteligentBuildingCommunication'),
		);
		
		public function AggregateInfo()
		{
			$this->getRequireCommunicationFunctions();
			$operationsArray = $this->getAllOperations();
			$this->saveAggregateOperations($operationsArray);
		}
		
		private function getRequireCommunicationFunctions()
		{
			foreach ($this->buildingCommunicationList as $value) 
			{
				require_once '../' . $value['producentName'] . '/' . $value['dir'] . $value['communicationFunction'] . '.php';
			}
		}
		
		private function getAllOperations()
		{
			$operations = array();
			foreach ($this->buildingCommunicationList as $value)
			{
				$buildingCommunication = new $value['communicationFunction']();
				$operations = array_merge($operations, $buildingCommunication->GetOperations());
			}
			return $operations;
		}
		
		private function saveAggregateOperations($operationsArray)
		{
			$xml = new XMLOperations();
				
			$domArray = array();
			
			foreach ($operationsArray as $operation)
			{
				$domArray[] = DOMAndCommunicationModelConverter::convertModelToDOM($operation, $xml->getDOMDocument());
			}
			$xml->save('data/all_events.xml', $domArray, 'DevicesEvents');
		}
	}
	
	//Aggregation Test
	$a = new ObywatelGCCBuildingsCommunicationAggregator();
	$a->AggregateInfo();
	
	