<?php
	function Dziara_strlen($text)
	{
		$count = 0;
		for($i = 0; isset($text[$i]); $i++)
			$count++;
		
		return $count;
	}

	function Dziara_substr($text, $count)
	{
		$new_text = '';
		
		if(Dziara_strlen($text) < $count) 
			return $new_text;

		for($i = 0; $i < $count; $i++)
		{
			$new_text .= $text[$i];
		}
		
		return $new_text;
	}