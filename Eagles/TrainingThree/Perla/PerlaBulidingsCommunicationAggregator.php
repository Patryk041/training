<?php

require_once('BuildingsCommunicationAggregator.php');
require_once('ParseFileContent.php');
require_once('InteligentBuildingCommunication.php');

class PerlaBulidingsCommunicationAggregator extends BuildingsCommunicationAggregator {

    protected $communication;
    protected $model;

    public function __construct() {
        $this->communication = new InteligentBuildingCommunication();
        $this->model = new InteligentBuildingCommunicationModel();
    }

    protected function ChangeIndexNames($tmp) {
        $result = array();


        $result['Street'] = $tmp[0];
        $result['Number'] = $tmp[1];
        $result['Village'] = $tmp[2];
        $result['DeviceType'] = $tmp[3];
        $result['Action'] = $tmp[4];
        $result['Date'] = $tmp[5];
        $result['TimeOfAction'] = $tmp[6];
        $result['EnergyUsage'] = $tmp[7];
        $result['Errors'] = $tmp[8];
        $result['Messages'] = $tmp[9];

        return $result;
    }

    protected function UpdateModelWithArray($namedContent) {

        foreach ($namedContent as $tmp) {
         
            $this->model->HomeAddress[] = array($tmp['Street'], $tmp['Number'], $tmp['Village']);
            $this->model->DeviceName[] = $tmp['DeviceType'];

            $this->model->Operation->OperationType[] = $tmp['Action'];
            $this->model->Operation->OperationHour[] = $tmp['Date'];
            $this->model->Operation->OperationTime[] = $tmp['TimeOfAction'];
            $this->model->Operation->OperatorionEnergyUsage[] = $tmp['EnergyUsage'];
            $this->model->Operation->OperationErrors[] = $tmp['Errors'];
            $this->model->Operation->OperationExtraInfo[] = $tmp['Messages'];
        }
        var_dump($this->model);
    }

    public function UpdateModel(/* IInteligentBuildingCommunication $communication, */$fileName, $separator) {
        $fileHandler = new ParseFileContent();
        $content = $fileHandler->ShapeIntoReadableArray($fileName, $separator);
        $namedContent = array();
        foreach ($content as $tmp) {

            $namedContent[] = $this->ChangeIndexNames($tmp);
        }
        $this->UpdateModelWithArray($namedContent);
    }

    public function AggregateInfo() {
        return $this->communication->GetOperations();
    }

}

$test = new PerlaBulidingsCommunicationAggregator();

$test->UpdateModel('Biestrzynska.34.Dylaki', ';');













