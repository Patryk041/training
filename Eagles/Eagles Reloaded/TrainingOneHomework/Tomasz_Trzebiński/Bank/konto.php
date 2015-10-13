<?php
require_once 'AccountTester.php';
require_once 'KontoBZWBK.php';

abstract class konto
{

    protected $nrKonta;
    
    protected abstract function zrobPrzelew();
    //funkcja do przedefiniopwania w każdej klasie banku wdg. własnego pomysłu
}


