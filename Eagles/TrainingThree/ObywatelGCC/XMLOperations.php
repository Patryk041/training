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
		
		public function save($fileName, $domArray, $rootNodeName) //array of InteligentBuildingCommunicationModel
		{
			$rootNode = $this->xmlDoc->createElement($rootNodeName);
			foreach ($domArray as $node)
			{
				$rootNode->appendChild($node);
			}
			$this->xmlDoc->appendChild($rootNode);
			$this->xmlDoc->save($fileName);
		}
		
		public function getEventsDOMArray()
		{
			$rootElement = $this->xmlDoc->documentElement;
			return $rootElement->childNodes;
		}
		
		public function getDOMDocument()
		{
			return $this->xmlDoc;
		}
	}

