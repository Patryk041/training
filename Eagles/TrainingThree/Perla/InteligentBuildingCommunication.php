<?php

require_once 'IInteligentBuildingCommunication.php';
require_once 'InteligentBuildingCommunicationModel.php';

class InteligentBuildingCommunication implements IInteligentBuildingCommunication {

    protected $model;

    public function __construct() {
        $this->model = new InteligentBuildingCommunicationModel();
    }

    public function GetOperations() {
        $result = array();
        for ($i = 0; $i < count($this->model->Operation->OperationType); $i++) {
            $result[] = $this->CreateArray($i);
        }

        return $result;
    }

    protected function CreateArray($i) {
        $result = array();

        $result['HomeAddress'] = $this->model->HomeAddress[$i];
        $result['DeviceName'] = $this->model->DeviceName[$i];

        $result['OperationType'] = $this->model->Operation->OperationType[$i];
        $result['OperationTime'] = $this->model->Operation->OperationTime[$i];
        $result['OperatorionEnergyUsage'] = $this->model->Operation->OperatorionEnergyUsage[$i];
        $result['OperationErrors'] = $this->model->Operation->OperationErrors[$i];
        $result['OperationExtraInfo'] = $this->model->Operation->OperationExtraInfo[$i];

        return $result;
    }

}
