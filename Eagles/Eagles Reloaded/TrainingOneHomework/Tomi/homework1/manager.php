<?php
require_once ('IFindCitizen.php');
include_once ('poland.php');
include_once ('england.php');

//funkcja która sprawdza wprowadzony nr id i wybiera poprawny kraj pochodzenia numeru
class Citizen implements IFindCitizen {
    function checkNumber($number){
        if(strlen("$number") == 11) {
            $poland = new PolishCitizens();
            $poland->findCitizen($number);
        }
        if(strlen("$number") == 9){
            $england = new EnglishCitizens();
            $england->test($number);
        }
    }
}
