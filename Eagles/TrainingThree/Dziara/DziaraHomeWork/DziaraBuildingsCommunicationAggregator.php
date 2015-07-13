<?php
require_once 'DziaraInteligentBuildingCommunication.php';
require_once '../../GhostRider/HomeWork/BuildingsCommunicationAggregator.php';

class DziaraBuildingsCommunicationAggregator extends  BuildingsCommunicationAggregator
{
    public function AggregateInfo()
    {
        $object = new DziaraInteligentBuildingCommunication();

        return $object->GetOperations();
    }
}

//$te = new DziaraBuildingsCommunicationAggregator();
//var_dump($te->AggregateInfo());