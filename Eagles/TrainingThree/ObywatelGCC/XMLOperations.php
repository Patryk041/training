<?php
	class XMLOperations
	{
		private $xmlDoc = null;
		
		public function __construct()
		{
			$this->xmlDoc = new DOMDocument();
			$this->xmlDoc->preserveWhiteSpace = false; // important to avoid #text node
		}
		
		public function open($fileName)
		{
			return $this->xmlDoc->load($fileName); //true if open
		}
		
		public function save($fileName, $communicationModelArray) //array of InteligentBuildingCommunicationModel
		{
			
		}
		
		public function getEventsDOMArray()
		{
			$rootElement = $this->xmlDoc->documentElement;
			return $rootElement->childNodes;
		}
	}
	
// 	$a = new XMLOperations();
// 	$a->open("data/sample_events.xml");
// 	var_dump($a->getEventsDOMArray()[0]->childNodes[2]->childNodes[1]);
