<?php
	require_once '../GhostRider/HomeWork/BuildingsCommunicationAggregator.php';
	
	class ObywatelGCCBuildingsCommunicationAggregator extends BuildingsCommunicationAggregator
	{
		// kilka array of InteligentBuildingCommunicationModel
		public abstract function AggregateInfo();
	}