<?php
	class DOMAndCommunicationModelConverter
	{
		public static function convertToCommunicationModel(DOMNode $node)
		{
			$model = new InteligentBuildingCommunicationModel();
			$model->HomeAddress = $node->childNodes[0]->nodeValue;
			$model->DeviceName = $node->childNodes[1]->nodeValue;
			$model->Operation = DOMAndCommunicationModelConverter::operationToCommunicationModel($node->childNodes[2]);
			
			return $model;
		}
		
		public static function convertToDOM(InteligentBuildingCommunicationModel $model)
		{
			return null;
		}
		
		private static function operationToCommunicationModel(DOMNode $operationNode)
		{
			return null;
		}
		
		private static function operationToDOM(Operation $operation)
		{
			return null;
		}
	}