<?php


function Zenek_strlen($text)
{
	$count = 0;
	for ($i=0; isset($text[$i]);$i++)
	{
		$count++;
	}
	
	return $count;
}

function Zenek_substr($text, $count)
{
	$new_text = '';
	
	if (Zenek_strlen($text) < $count)
	{
		return $text;
	}
}