<?php

class test
{

    function znajdz1 ($wyraz)
    {
        $wyraz = $wyraz;
        $regex = "/System\.out\.println\(\".*\"\);/";
        $wynik = preg_match($regex, $wyraz, $zmienna);
        return $zmienna[0];
    }
    
    function wytnijZmienna ($string)
    {
        $regex = "/\".*\"/";
        $wynik = preg_match($regex, $string, $zmienna);
        return $zmienna[0];
    }
}

$t1 = new test();
echo $t1->wytnijZmienna($t1->znajdz1('System.out.println("z upa");'));

