<?php

require_once 'Operation.php';

class InteligentBuildingCommunicationModel extends Operation {

    public $HomeAddress ;
    public $DeviceName ;
    public $Operation ;

    public function __construct() {
        $this->Operation = new Operation();
    }

}
