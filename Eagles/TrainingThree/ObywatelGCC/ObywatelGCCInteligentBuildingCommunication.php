<?php
	require_once '../GhostRider/HomeWork/Interfaces/IInteligentBuildingCommunication.php';
	require_once '../GhostRider/HomeWork/InteligentBuildingCommunicationModel.php';
	
	require_once 'XMLOperations.php';
	require_once 'DOMAndCommunicationModelConverter.php';
	
	class ObywatelGCCInteligentBuildingCommunication implements IInteligentBuildingCommunication
	{
		
		private $xmlFileName = 'data/sample_events.xml'; 
		
		// array of InteligentBuildingCommunicationModel
		public function GetOperations()
		{
			$xml = new XMLOperations();
			$xml->open($this->xmlFileName);
			
			$operationsArray = array();
			$domList = $xml->getEventsDOMArray();
			
			foreach ($domList as $dom)
			{
				$operationsArray[] = DOMAndCommunicationModelConverter::convertToCommunicationModel($dom);				
			}
			return $operationsArray;
		}
	}
	
	//TEST
// 	$a = new ObywatelGCCInteligentBuildingCommunication();
// 	var_dump($a->GetOperations());