<?php

class wycinarka2
{

    function convertEcho ($string)
    {
        return $this->addJava(
                $this->cutPhp($this->findX($string, "/echo\s*\".*\"/")));
   

    function findX ($wyraz, $regex)
    {
        $wynik = preg_match_all($regex, $wyraz, $zmienna);
        return $zmienna[0];
    }

    function cutPhp ($string)
    {
        $regex = "/\".*\"/";
        $wynik = preg_match($regex, $string[0], $zmienna);
        $wyraz = trim($zmienna[0], "\"");
        return $wyraz;
    }

    function addJava ($string)
    {
        $wynik = 'System.out.println("' . $string . '");';
        return $wynik;
    }
}
