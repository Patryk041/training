<?php

	function Kollwing_strlen($text)
	{
		$wynik = 0;
		for ($i=0;isset($text[$i]);$i++)
		{
			$wynik++;
		}
		
		return $wynik;
	}


	$test1 = Kollwing_strlen('jakistekst');

	echo $test1;
	
	function Kollwing_substr($text,$count)
	{	
		$text_count;
		
		for($i = 0; $i < $count; $i++)
		{
			$text_count .=$text[$i];
			
			return $text_count;
		}

		
		return $text_count;
	}

