<?php
	require_once '../GhostRider/Homework/PeselValidation.php';
	
	class OGCCDate
	{
		public $year;
		public $month;
		public $day;
		
		private $daysCount = array(1 => 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31);
		
		function __construct($year, $month, $day) 
		{
			$this->year = $year;
			$this->month = $month;
			$this->day = $day;
		}
		
		public function IsLeapYear()
		{
			if(($this->year % 4 == 0 && $this->year % 100 != 0) || $this->year % 400 == 0)
				return true;
			return false;
		}
		
		public function IsValidYear()
		{
			return $this->year > 0;
		}
		
		public function IsValidMonth()
		{
			return $this->month >= 1 && $this->month <= 12;
		}
		
		public function IsValidDay()
		{
			if(!$this->IsValidMonth()) return false;
			if($this->day < 1) return false;
			
			if($this->IsLeapYear() && $this->month == 2)
				return $this->day <= $this->daysCount[$this->month] + 1;
			else
				return $this->day <= $this->daysCount[$this->month];
		}
	}
	
	
	class ObywatelGCCPeselValidation extends PeselValidation
	{	
		protected function DateValidation($year, $month, $day)
		{
			$date = new ObywatelGCCDate($year, $month, $day);
			$result = false;
			$result = $result | !$date->IsValidYear();
			$result = $result | !$date->IsValidMonth();
			$result = $result | !$date->IsValidDay();
			return !$result;
		}
		
		protected function CutOffDate($pesel)
		{
			$year;
			$month;
			$day;
			
			if($pesel[2] == 8 || $pesel[2] == 9) { $year = 1800; }
			else if($pesel[2] == 0 || $pesel[2] == 1) { $year = 1900; }
			else if($pesel[2] == 2 || $pesel[2] == 3) { $year = 2000; }
			else if($pesel[2] == 4 || $pesel[2] == 5) { $year = 2100; }
			else if($pesel[2] == 6 || $pesel[2] == 7) { $year = 2200; }
			$year += 10 * $pesel[0] + $pesel[1];
			
			if($pesel[2] % 2 == 1) $month = 10;
			$month += $pesel[3];
			
			$day = 10 * $pesel[4] + $pesel[5];
			
			$date = new OGCCDate($year, $month, $day);
			return $date;
		}
		
		protected function CheckSum($pesel)
		{
			/*1*a + 3*b + 7*c + 9*d + 1*e + 3*f + 7*g + 9*h + 1*i + 3*j
Nast�pnie nale�y odj�� ostatni� cyfr� otrzymanego wyniku od 10. Je�li otrzymany wynik nie jest r�wny cyfrze kontrolnej, to znaczy, �e numer zawiera b��d[22].*/
			$tempValue = 1 * $pesel[0] + $pesel[1] $pesel[2] + $pesel[3] + $pesel[4] + $pesel[5] + $pesel[6] + $pesel[7] + $pesel[8] + $pesel[9] + $pesel[10]
		}
		
		public function ValidatePesel($pesel)
		{
			if(strlen($pesel) != 11) return false;
			$result = false;
			
			$date = $this->CutOffDate($pesel);
			var_dump($date);
			$result = $result | !$this->DateValidationFromOCCDate($date);
			//$result = $result | !$this->DateValidation($date->year, $date->month, $date->day)
			//$result = $result | !$this->CheckSum($pesel);
			return !$result;
		}
		
		protected function DateValidationFromOCCDate(OGCCDate $date)
		{
			$result = false;
			$result = $result | !$date->IsValidYear();
			$result = $result | !$date->IsValidMonth();
			$result = $result | !$date->IsValidDay();
			return !$result;
		}
	}
	
	$validator = new ObywatelGCCPeselValidation();
	if($validator->ValidatePesel('12345678901') == true)
		echo "Valid";
	else
		echo "Invalid";