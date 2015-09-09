<?php

class ConvertingTools
{

    function findX ($wyraz, $regex)
    {
        $wynik = preg_match_all($regex, $wyraz, $zmienna);
        return $zmienna[0];
    }

    function cutPhp ($string) // funkcję tę można zmodyfikowac ustawiając
                              // dodatkowy argument zmieniający cudzysłowy na np
                              // nawiasy itd.
    {
        $regex = "/\".*\"/";
        $wynik = preg_match($regex, $string[0], $zmienna);
        $wyraz = trim($zmienna[0], "\"");
        return $wyraz;
    }

    function addJava ($string, $kod)
    {
        // $wynik = 'System.out.println("' . $string . '");';
        $wynik = str_replace(":CONVERT", $string, $kod);
        return $wynik;
    }
}
