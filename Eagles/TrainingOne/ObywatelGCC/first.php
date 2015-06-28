<?php
echo "\n\n";
	
	
	function ObywatelGCC_substr($text, $count)
	{
		$wynik = '';
		for($i = 0; $i < $count; $i++)
		{
			$wynik .= $text[$i];
		}
		return $wynik;
	}
	function ObywatelGCC_strlen($text)
	{
		$len = 0;
		for($i = 0; isset($text[$i]); $i++)
		{
			$len++;
		}
		return $len;
	}
	
	
	// substr strlen
	//echo ObywatelGCC_substr("abcd", 2);
	//echo "\n";
	//echo ObywatelGCC_strlen("abcd");