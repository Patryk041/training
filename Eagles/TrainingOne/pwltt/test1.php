<?php
	function pwltt_str($text)
	{
		$count = 0;
		for($i = 0; isset($text[$i]); $i++)
			$count++;
		
		return $count;
	}
	
	function pwltt_substring($text,$count)
	{
	    $wynik = '';
		for( $i = 0; $i <=$count; $i++)
		{
			$wynik .= $text[$i];
		}
		return $wynik;
	}
	
	
	echo pwltt_str('programowanie');
	echo pwltt_substring('programowanie',5);
	
	?>
	
	
	
	
