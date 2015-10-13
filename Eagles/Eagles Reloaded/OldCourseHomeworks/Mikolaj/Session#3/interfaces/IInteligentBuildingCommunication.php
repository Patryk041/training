<?php


interface IInteligentBuildingCommunication
{	//return array of IInteligentBuildingCommunicationModel
	public function GetOperations(InteligentBuildingConmmunicationModel $Device, $message);
}