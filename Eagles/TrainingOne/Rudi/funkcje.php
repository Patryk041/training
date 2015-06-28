<?php

function Rudi_strlen($text)
{
	$counter=0;
	while(isset($text[$counter]))
		$counter++;

	return $counter;
}

function Rudi_substr($text,$start)
{
	$wynik='';

	for($i=$start;$i<Rudi_strlen($text);$i++)
	{
		$wynik .=$text[$i];
	}
	return $wynik;
}

	echo Rudi_strlen("hahah");
	echo "\n";
	echo Rudi_substr("12345678",4);
