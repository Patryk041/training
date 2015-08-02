<?php


require_once "../GhostRider/Homework/CompexStrings.php";
require_once "../../TrainingOne/Rudi/funkcje.php";

class RudiComplexString {

	function IsStringInString($subject, $seek){

		//obliczamy dlugosc podanych argumentow
		$subjLen=Rudi_strlen($subject);
		$seekLen=Rudi_strlen($seek);

		
		for($i=0;$i<=($subjLen-$seekLen);$i++)
		{
			// CutOffString wycina kawalek tekstu z $subject
			// o dlugosci $seek i porownuje go z nim  
			$test=$this->CutOffString($subject,$i,$seekLen);
			
			//jesli wyciety kawalek zgadza sie z $seek = return true
			if($seek==$test)
			{
				return true;
			}
		}

		//jesli nie znalazl zgodnosci = return false
		return false;

	}


	function IsStringLettersInString($subject,$seek){

	//dla kazdej litery z $seek sprawdza czy istnieje taka w $subject 
	for($i=0;$i<Rudi_strlen($seek);$i++)
	{
		for($j=0;$j<Rudi_strlen($subject);$j++)
		{
		//jesli litery sie zgadzaja, zamienia je na spacje, z jakiegos powodu null nie zdawal testu 
			if($subject[$j]==$seek[$i]){	// abcca aabbc
				$subject[$j]=' ';
				$seek[$i]=' ';
			}
		}
	}

	//sprawdz czy nie ma jkais pozostalych literek w $seek
	//nie sprowadzalem stringa to arraya charow aby nie zuywac funkcji systemowej
	for($i=0;$i<Rudi_strlen($seek);$i++)
	{
		if($seek[$i]!=' ')
		{
			return false;
		}
	}

	return true;
	}

	//poprzednia funkcja spelnia wymogi, musimy tylko zalozyc ze strinki maja taka sama dlugosc
	function IsAnagram($subject, $seek)
	{
		if(Rudi_strlen($subject)==Rudi_strlen($seek)){
		return $this->IsStringLettersInString($subject, $seek);
		}
		return false;
	}
	
	function CheckStrings($subject, $seek)
	{
		return array(
		$this->IsStringInString($subject,$seek),
		$this->IsStringLettersInString($subject,$seek),
		$this->IsAnagram($subject,$seek),
		);

	}


	private function CutOffString($string, $start, $count)
	{
		$result='';
		for($i=0;$i<$count;$i++)
		{
			$result.=$string[$i+$start];
		}
	
		return $result;

	}

}

