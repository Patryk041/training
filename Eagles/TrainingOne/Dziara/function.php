<?php
	

	function Dziara_strlen($text)
	{
		$count = 0;
		for($i = 0; isset($text[$i]); $i++)
		{
			$count++;
		}
		
		return $count;
	}

	function Dziara_substr($text, $count)
	{
		$new_text = '';
		
		if(Dziara_strlen($text) < $count) 
		{
			return $text;
		}

		for($i = 0; $i < $count; $i++)
		{
			$new_text .= $text[$i];
		}
		
		return $new_text;
	}
	function Dziara_substr2($text, $start, $lenght)
	{
		$new_text = '';
		$index = 0;
		$end = $lenght + $start;
		
		for($i = $start; $i < $end; $i++)	
		{
			$new_text .= $text[$i];	
		}
		
		return $new_text;
	}
	
	
	//echo 'wynik: '.Dziara_substr2('dziarmaga', 0, 5);
	//echo 'wynik: '.Dziara_substr('dziarmaga', 5);
	
	
	
	
	
	
	
	
	
	
	
	