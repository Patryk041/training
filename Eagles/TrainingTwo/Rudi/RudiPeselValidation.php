<?php

require_once "../GhostRider/Homework/PeselValidation.php";

class RudiPeselValidation  extends PeselValidation
{
	function DateValidation($year, $month, $day)
	{
	//zakladamy ze rok jest z zakresu ktory obejmuje pesel 1800-2300
		if($year<2300 && $year>1800)
		{
		
			if($month>0&& $month<13)
			{
					
			switch($month)
			{
			case 1:
			case 3:
			case 5:
			case 7:
			case 8:
			case 10:
			case 12: return $day<=31?true:false; break;


			case 4:
			case 6:
			case 9:
			case 11: return $day<=30?true:false; break;

			case 2:
			// sprawdzenie dla roku przestepnego
			if(($year%4==0)&&($year%100!=0)||$year % 400==0)
			{
				return $day<=29?true:false;
			} else
				return $day<=28?true:false;

			}
			}
	}}
	


	function CutOffDate($pesel)
	{
		$peselArray=$this->intToArray($pesel);

		//obliczamy rok
		$year=intval($pesel/1000000000);
		switch($peselArray[2])
		{
		case 0: 
		case 1: $year+=1900; break;
		case 2: 
		case 3: $year+=2000; break;
		case 4: 
		case 5: $year+=2100; break;
		case 6: 
		case 7: $year+=2200; break;
		case 8: 
		case 9: $year+=1800; break;
		}

		//obliczamy miesiac
		$month=($peselArray[2]%2)*10+$peselArray[3];
		$day=($peselArray[4]*10)+$peselArray[5];
		
		return array($year,$month,$day);
	}
	

	function CheckSum($pesel)
	{	
		$wagi=array(1,3,7,9,1,3,7,9,1,3);
		$peselArray=$this->intToArray($pesel);

		$suma=0;
		for($i=0;$i<10;$i++)
		{
		$suma+=$wagi[$i]*$peselArray[$i];	

		}

		//sprawdzenie z cyfra kontrolna
		if($suma %10 == (10 - $peselArray[10]))
		{	
			return true;
		}
		return false;
	}

	public function ValidatePesel($pesel)
	{
		//jesli data i suma kontrolna sa poprawne = return true
		$date = $this->CutOffDate($pesel);
		if($this->CheckSum($pesel)&& $this->DateValidation($date[0],$date[1],$date[2]))
		{
			return true;
		}
		return false;
	}


	private	function intToArray($number)
	{
		//mozna uzyc str_split zamiast tego kodu
		//dodatkowo zakladamy ze pesel jest intem a nie stringiem
		

		$peselArray=array();
		do{
		array_push($peselArray,$number%10);
		$number =intval($number/10);
		}while($number!=0);

		return array_reverse($peselArray);
	}
}
