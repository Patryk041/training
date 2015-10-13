<?php

class KontoBZWBK extends konto
{

    function __construct ($numerKonta)
    {
        $this->nrKonta = $numerKonta;
    }

    function getAccountNr ()
    {
        return $this->nrKonta;
    }
    
    function zrobPrzelew(){
        //Definicja przelewu wdg BZWBK...
    }
    
}