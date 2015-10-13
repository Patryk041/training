<?php

require_once('BuildingsCommunicationAggregator.php');
require_once('InteligentBuildingCommunication.php');
require_once('Database.php');

require_once('ParseFileContent.php');


class PerlaBulidingsCommunicationAggregator extends BuildingsCommunicationAggregator {

    public $fileName = 'Biestrzynska.34.Dylaki';
    public $separator = ';';

    public function AggregateInfo() {
        $aggregator = new InteligentBuildingCommunication($this->fileName, $this->separator);
        return $aggregator->GetOperations();
    }

    public function DatabaseInsert() {
        var_dump($this->AggregateInfo());
    }

}
$test = new PerlaBulidingsCommunicationAggregator();
$file = new ParseFileContent;

