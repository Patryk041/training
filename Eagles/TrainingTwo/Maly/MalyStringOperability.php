<?php

 //require_once 'TrainingTwo/GhostRider/Homework/StringOperationsObj.php';

class MalyStringOperability extends GhostRiderStringOperability
{
	public  function StringLength($string)
	{
		$count = 0;
		for($i = 0; isset($string[$i]); $i++)
		{
			$count++;
		}
		
		return $count;
	}
	
	public  function SubString($string, $length)
	{
		$new_text = '';
		
		
		
		for($i = 0; $i < $length; $i++)
		{
			$new_text .= $string[$i];
		}
		
		return $new_text;
	}
	
	public  function GetNick()
	{
		return "Maly";
	}
	
}