<?php
require_once '../../../TrainingOne/pwltt/test1.php';

class CutOffDate
{
	protected function DajString($string)
	{
		if($string[0] == 0 || $string[0] == 2)
		{
			return $string[1];
		}
		if($string[0] == 3)
		{
			$string[0] = 1;
		}
		
		return $string;
		/*
		switch($string[$i])
		{
			case 0:
				return $string[1];
				break;
				
			case 2: 
				return $string[1];
				break;
				
			case 3:
				$string[0] = 1;
				break;
				
		}
		return string;	*/

	}
	protected function DajRok($string)
	{
		return $Rok = pwltt_substr2($string, 0, 2);
		//switch ()
		
		
	}
	protected function DajMiesiac($string)
	{
		return $Miesiac = pwltt_substr2($string, 3, 5);
	}
	
	protected function DajDzien($string)
	{
		return $Dzien = pwltt_substr2($string, 6, 7);
	}
	public function Data($pesel)
	{
		return array('dzien' => $this -> DajDzien($pesel),
					 'miesiac' => $this -> DajMiesiac($pesel),
					 'rok' => $this -> DajRok($pesel)
					 );
	}
}

    
	$rafal = new CutOffDate();
	$dataa = $rafal -> Data('92122701312');
	var_dump($dataa);
