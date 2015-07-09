<?php


require_once "../GhostRider/Homework/CompexStrings.php";
require_once "../../TrainingOne/Rudi/funkcje.php";

class RudiComplexString {

	function IsStringInString($subject, $seek){
		$subjLen=Rudi_strlen($subject);
		$seekLen=Rudi_strlen($seek);

		for($i=0;$i<=($subjLen-$seekLen);$i++)
		{
			$test=$this->CutOffString($subject,$i,$seekLen);
			if($seek==$test)
			{
				return true;
			}
		}

		return false;

	}


	function IsStringLettersInString($subject,$seek){

	for($i=0;$i<Rudi_strlen($seek);$i++)
	{
		for($j=0;$j<Rudi_strlen($subject);$j++)
		{

		if($subject[$j]==$seek[$i]){	
		$subject[$j]=' ';
		$seek[$i]=' ';
		
		}//if
	}
	}

	for($i=0;$i<Rudi_strlen($seek);$i++)
	{
		if($seek[$i]!=' ')
		{
			echo "Nope: ".$seek;
			return false;
		}
	}

	return true;
	}


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

