<?php
require_once '../Dziara/ss.php';
require_once '../Perla/ss.php';

class CollectionInteligentBuildingCommunication
{
    private $collectionObejcts = array(
        array('Dziara' => 'DziaraBuildingsCommunicationAggregator'),
        array('Perla' => 'PerlaBuildingsCommunicationAggregator'),
    );

    public function GetCollectionObjects()
    {
        return $this->collectionObejcts;
    }
}