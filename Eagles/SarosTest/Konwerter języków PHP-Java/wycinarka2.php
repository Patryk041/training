<?php

class test
{

    function znajdz1 ($wyraz, $regex)
    {
        $wynik = preg_match($regex, $wyraz, $zmienna);
        return $zmienna[0];
    }

    function wytnijZmienna ($string)
    {
        $regex = "/\".*\"/";
        $wynik = preg_match($regex, $string, $zmienna);
        $wyraz = trim($zmienna[0], "\"");
        return $wyraz;
    }
}

$t1 = new test();
echo $t1->wytnijZmienna($t1->znajdz1('echo"zupa";', "/echo\s*\".*\"/"));


//wytnijZmienna($t1->znajdz1('System.out.println("dupa");',"/System\.out\.println\(\".*\"\);/")); 

