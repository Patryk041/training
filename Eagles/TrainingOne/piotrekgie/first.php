<?php 
    function piotrekgie_substr( $text, $start, $length ) 
	{
	    $result = '';
	    for ( $i = $start; $i <= $start + $length; $i++ )
		{
		    $result .= $text[$i];
		}
		return $result;
	}
	
	echo piotrekgie_substr('piotrekgie', '8', '5');
	
	function piotrekgie_strlen( $text ) 
	{
	    $length = '';
	    for ( $i = 0; isset($text[$i]); $i++ )
		{
		    $length++;
		}
		return $length;
	}
	
	echo piotrekgie_strlen('piotrekgie');