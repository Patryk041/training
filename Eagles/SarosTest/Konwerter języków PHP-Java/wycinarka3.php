<?php

$string = 'echo \'Hello\' World\';';
echo $string."\n";

class test
{
	function znajdz1 ($wyraz){
		$regex = "/echo\(\".*\"\);/";
		$wynik = preg_match($regex, $wyraz, $zmienna);
		return $zmienna[0];   
	}
	function wytnijZmienna ($string)
	{
		$regex = "/\".*\"/";
		$wynik = preg_match($regex, $string, $zmienna);
		return $zmienna[0];
	}
	function changeText ($hello){
		$string = 'public static void main(String[] args) {'."\n";
		$string .= "\t".'System.out.println(\'';
		$string .= $hello;
		$string .= '\');'."\n".'}'."\n";
		return $string;
	}
}

$t1 = new test();
echo $t1->changeText($t1->wytnijZmienna($t1->znajdz1('echo("dupa");')));


