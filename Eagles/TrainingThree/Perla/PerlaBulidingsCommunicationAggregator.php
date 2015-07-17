<?php

require_once('BuildingsCommunicationAggregator.php');
require_once('InteligentBuildingCommunication.php');

class PerlaBulidingsCommunicationAggregator extends BuildingsCommunicationAggregator 
{
    public $fileName = 'Biestrzynska.34.Dylaki';
    public $separator = ';';
    
    public function AggregateInfo()
    {
        $aggregator = new InteligentBuildingCommunication($this->fileName, $this->separator);
        return $aggregator->GetOperations();
    }
}
$test = new PerlaBulidingsCommunicationAggregator();
var_dump($test->AggregateInfo());












