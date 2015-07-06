<?php
class DziusioPeselValidation extends PeselValidation
{
	protected function CutOffDate($pesel)
	{
		
		$data = Dziusio_substr($pesel, 6);
		$year = Dziusio_substr($pesel, 2);
		$temp = Dziusio_substr($data, 4);
		$month = Dziusio_substr_rev($temp, 2);
		$day = Dziusio_substr_rev($Data, 2);
		return array{$year, $month, $day};
	
	}

	function ReturnDay($pesel)
	{
		$data = Dziusio_substr($pesel, 6);
		$day = Dziusio_substr_rev($Data, 2);
		return $day;
		
	}
	function ReturnMonth($pesel)
	{
		$data = Dziusio_substr($pesel, 6);
		$temp = Dziusio_substr($data, 4);
		$month = Dziusio_substr_rev($temp, 2);
		return $month;
	}
	function ReturnYear($pesel)
	{
		$year = Dziusio_substr($pesel, 2);
		return $year;
	}
	function ReturnDate($pesel)
	{
		$data = Dziusio_substr($pesel, 6);
		return $data;
	}
	
	
	
	
	protected function DateValidation($year, $month, $day)
	{	if(Day($year, $month, $day) == true && Month($year, $month, $day) == true && (Year($year, $month, $day)>=1800 && Year($year, $month, $day) <=2299 ) )
		{		
			return true;
		}
		
		else
		{
			return false;
		}
	}
	protected function CheckSum($pesel)
	{	$tab=array{1,3,7,9}
		$temp=0;
		$wynik=0;
		
		$lengthPesel=Dziusio_strlen($pesel); //isset
		Something=1;
		for($i = 0; $i < $lengthPesel-1; i++)
		{
			if ($i % 4 ==0)
			{
				temp=0;
			}
			
			$wynik+=$tab[temp]*$pesel[$i];
			
		}
		$temp=$wynik % 10;
		return $temp;

		
	
	}
	protected function ValidateCheckSum($pesel)
	{
		
		$temp=CheckSum($pesel);
		$lengthPesel=Dziusio_strlen($pesel);
		if ($temp==0 && $pesel[$lengthPesel-1]==0)
		{
			return true;
		}
		if ($temp>=1 && $temp<=9 && $pesel[$lengthPesel-1]==$temp)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	
	public function ValidatePesel($pesel)
	{
		
		if(DateValidation(ReturnYear($pesel), ReturnMonth($pesel), ReturnDay($pesel) == true && ValidateCheckSum($pesel)==true)
		return true;		
	}
	
	
	
}




