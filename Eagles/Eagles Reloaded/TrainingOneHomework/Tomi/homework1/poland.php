<?php

class PolishCitizens extends Person {
    static $peopleInDataBase = array(
        "31077654720" => "Adam Nowak",
        "20128717231" => "Stefan Kowalski",
    );
    function findCitizen($number){
        foreach(PolishCitizens::$peopleInDataBase as $key => $value){
            if($key == $number)
                echo $key." - ".$value." - Polish\n";
        }
    }
}