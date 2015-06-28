<?php

	function Kollwing_strlen($text)
	{
		$wynik = 0;
		for ($i=0;isset($text);$i++)
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
		
		for ($i=0;$count;i++)
		{
			$text_cunt .= $text[$i];
		}
		
		return $text_count;
	}

	$test2 = Kollwing_substr('jakistekst2', 3);

	echo '\n\n';
	echo &test2;