<?php

require_once 'IInteligentBuildingCommunication.php';
require_once 'InteligentBuildingCommunicationModel.php';
require_once 'Operation.php';
require_once 'ParseFileContent.php';

class InteligentBuildingCommunication implements IInteligentBuildingCommunication {

    protected $model;
    protected $operation;
    private $fileName;
    private $separator;
    private $fileOperator;

    public function __construct($fileName, $separator) {
        $this->model = new InteligentBuildingCommunicationModel();
        $this->operation = new Operation();

        $this->fileName = $fileName;
        $this->separator = $separator;
        $this->fileOperator = new ParseFileContent();
    }

    public function GetOperations() {

        return $this->GenerateInfoArray();
    }

    public function UpdateModel() {
        $content = $this->fileOperator->ShapeIntoReadableArray($this->fileName, $this->separator);
        foreach ($content as $row) {
            $this->model->HomeAddress[] = array(
                'Street' => $row['Street'],
                'Number' => $row['Number'],
                'Place' => $row['Place']);
            $this->model->DeviceName[] = $row['Device'];
            $this->operation->OperationType[] = $row['Action'];
            $this->operation->OperationHour[] = $row['Date'];
            $this->operation->OperationTime[] = $row['Time'];
            $this->operation->OperatorionEnergyUsage[] = $row['EnergyUsage'];
            $this->operation->OperationErrors[] = $row['Errors'];
            $this->operation->OperationExtraInfo[] = $row['Messages'];
        }
    }

    protected function GenerateInfoArray() {

        $this->UpdateModel();

        $result = array();

        $result['HomeAddress'] = $this->model->HomeAddress;
        $result['DeviceName'] = $this->model->DeviceName;
        $result['OperationType'] = $this->operation->OperationType;
        $result['OperationHour'] = $this->operation->OperationHour;
        $result['OperationTime'] = $this->operation->OperationTime;
        $result['OperatorionEnergyUsage'] = $this->operation->OperatorionEnergyUsage;
        $result['OperationErrors'] = $this->operation->OperationErrors;
        $result['OperationExtraInfo'] = $this->operation->OperationExtraInfo;

        return $result;
    }

}
