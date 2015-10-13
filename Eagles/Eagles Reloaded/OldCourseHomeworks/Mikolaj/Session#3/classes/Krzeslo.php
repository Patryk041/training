<?php 



class Krzeslo implements IInteligentBuildingCommunication
{

	//return array of IInteligentBuildingCommunicationModel
	public function GetOperations(InteligentBuildingConmmunicationModel $Device, $message)
	{
		//set information from $message 
			$Device->HomeAdress = '';
			$Device->DeviceName = '';
			$Device->Operation->OperationType   = '';
			$Device->Operation->OperationTime   = '';
			$Device->Operation->OperationStatus = '';

			return array($Device);
	}
}