<?php

require_once '../../GhostRider/HomeWork/BuildingsCommunicationAggregator.php';
require_once "RudiInteligentBuildingCommunication.php";

class RudiBuildingCommunicationAggregator extends BuildingsCommunicationAggregator {
	
	public function AggregateInfo()
	{
		$communication = new RudiInteligentBuildingCommunication();
			
		
		return $communication->GetOperations();
	}
}
