<?php
	echo "\n\n";
	
	function ObywatelGCC_strlen($text)
	{
		$len = 0;
		for($i = 0; isset($text[$i]); $i++)
		{
			$len++;
		}
		return $len;
	}
	
	function ObywatelGCC_substr($text, $count)
	{
		$wynik = '';
		for($i = 0; $i < $count; $i++)
		{
			$wynik .= $text[$i];
		}
		return $wynik;
	}
