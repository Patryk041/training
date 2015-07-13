<?php
require_once '../../GhostRider/HomeWork/Interfaces/IInteligentBuildingCommunication.php';
require_once '../../GhostRider/HomeWork/InteligentBuildingCommunicationModel.php';
require_once '../../GhostRider/HomeWork/Operation.php';
require_once 'ParseFile.php';

    class DziaraInteligentBuildingCommunication implements IInteligentBuildingCommunication
    {
        private $data = array();

        private function LoadData()
        {
            $parser = new ParseFile();

            $this->data = $parser->RunParse('dane.txt', ' ');
        }

        private function CreateObjectOperation($row)
        {
            $operation = new Operation();

            $operation->OperationErrors = $this->data[$row]['OperationErrors'];
            $operation->OperationExtraInfo = $this->data[$row]['OperationExtraInfo'];
            $operation->OperationHour = $this->data[$row]['OperationHour'];
            $operation->OperationTime = $this->data[$row]['OperationTime'];
            $operation->OperationType = $this->data[$row]['OperationType'];
            $operation->OperatorionEnergyUsage = $this->data[$row]['OperatorionEnergyUsage'];

            return $operation;
        }

        private function PrepareObjectModel($row)
        {
            $modelArray = array();
            $model = new InteligentBuildingCommunicationModel();

            for($row = 0; isset($this->data[$row]); $row++)
            {
                $model->DeviceName = $this->data[$row]['DeviceName'];
                $model->HomeAddress = $this->data[$row]['HomeAddress'];
                $model->Operation = $this->CreateObjectOperation($row);

                $modelArray[] = $model;
            }

            return $modelArray;
        }

        private function Preapare()
        {
            $this->LoadData();

            return $this->PrepareObjectModel();
        }

        public function GetOperations()
        {
            return $this->Preapare();
        }

        //??????????
        public function SendNotification($notification)
        {
            // TODO: Implement SendNotification() method.
        }
    }

//$te = new DziaraInteligentBuildingCommunication();
//var_dump($te->GetOperations());

//var_dump($te->data);