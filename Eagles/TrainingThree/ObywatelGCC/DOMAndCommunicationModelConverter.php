<?php
	class DOMAndCommunicationModelConverter
	{
		public static function convertModelToCommunicationModel(DOMNode $nodeModel)
		{
			$model = new InteligentBuildingCommunicationModel();
			$model->HomeAddress = $nodeModel->childNodes[0]->nodeValue;
			$model->DeviceName = $nodeModel->childNodes[1]->nodeValue;
			$model->Operation = DOMAndCommunicationModelConverter::convertOperationToCommunicationModel($nodeModel->childNodes[2]);
			
			return $model;
		}
		
		public static function convertModelToDOM(InteligentBuildingCommunicationModel $model, DOMDocument $doc)
		{
			$eventNode = $doc->createElement('Event');
			
			$addressNode = $doc->createElement('HomeAddress', $model->HomeAddress);
			$nameNode = $doc->createElement('DeviceName', $model->DeviceName);
			$operationNode = DOMAndCommunicationModelConverter::convertOperationToDOM($model->Operation, $doc);
			
			$eventNode->appendChild($addressNode);
			$eventNode->appendChild($nameNode);
			$eventNode->appendChild($operationNode);
			
			return $eventNode;
		}
		
		public static function convertOperationToCommunicationModel(DOMNode $operationNode)
		{
			$operation = new Operation();
			$operation->OperationType = $operationNode->childNodes[0]->nodeValue;
			$operation->OperationHour = $operationNode->childNodes[1]->nodeValue;
			$operation->OperationTime = $operationNode->childNodes[2]->nodeValue;
			$operation->OperatorionEnergyUsage = $operationNode->childNodes[3]->nodeValue;
			$operation->OperationErrors = $operationNode->childNodes[4]->nodeValue;
			$operation->OperationExtraInfo = $operationNode->childNodes[5]->nodeValue;
			
			return $operation;
		}
		
		public static function convertOperationToDOM(Operation $operation, DOMDocument $doc)
		{
			$operationNode = $doc->createElement('Operation');
			
			$typeNode = $doc->createElement('OperationType', $operation->OperationType);
			$hourNode = $doc->createElement('OperationHour', $operation->OperationHour);
			$timeNode = $doc->createElement('OperationTime', $operation->OperationTime);
			$energyNode = $doc->createElement('OperatorionEnergyUsage', $operation->OperatorionEnergyUsage);
			$errorNode = $doc->createElement('OperationErrors', $operation->OperationErrors);
			$extraNode = $doc->createElement('OperationExtraInfo', $operation->OperationExtraInfo);
		
			
			$operationNode->appendChild($typeNode);
			$operationNode->appendChild($hourNode);
			$operationNode->appendChild($timeNode);
			$operationNode->appendChild($energyNode);
			$operationNode->appendChild($errorNode);
			$operationNode->appendChild($extraNode);
			
			return $operationNode;
		}
	}