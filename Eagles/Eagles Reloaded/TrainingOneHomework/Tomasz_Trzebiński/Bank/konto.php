<?php
require_once 'AccountTester.php';
require_once 'KontoBZWBK.php';

abstract class konto
{

    protected $nrKonta;
    
    protected abstract function zrobPrzelew();
    //funkcja do przedefiniopwania w ka¿dej klasie banku wdg. w³asnego pomys³u
}
$ACDC = new AccountTester();
echo $ACDC->identify("9810309875098f978766768976");


