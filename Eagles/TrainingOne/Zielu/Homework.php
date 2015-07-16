<?php
	echo "\n \n";
	function Zielu_strlen($text)
	{
		$count = 0;
		for ($i=0; isset($text[$i]); $i++)
		{
			$count ++;
		}
		return $count;
	}
	
	function Zielu_substr($text, $count)
	{
		$result = '';
		for ($i = 0; $i < $count ; $i++)
		{
			$result .= $text[$i];
		}
		return $result;
	}
	echo Zielu_strlen('Natalia');
	echo Zielu_substr('Natalia', 3);
	echo "\n \n";