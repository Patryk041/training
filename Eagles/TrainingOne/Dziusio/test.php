<?php

echo "hello world";

function Dziusio_substr($text, $count)
	{
	$wynik='';
	for($i=0;$i<$count;$i++)
		{
			$wynik .= $text[$i];
		}
	return $wynik;
	}

function Dziusio_strlen($text) //isset
	{
		$wynik=0;
		for($i=0;isset($text);i++)
		{
			$wynik+=1;
		}
		return $wynik;
	}