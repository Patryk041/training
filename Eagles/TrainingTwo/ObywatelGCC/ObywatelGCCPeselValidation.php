<?php
	class ObywatelGCCDate
	{
		private $year;
		private $month;
		private $day;
		
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
		
		protected function DateValidation(ObywatelGCCDate $date)
		{
			$result = false;
			$result = $result | !$date->IsValidYear();
			$result = $result | !$date->IsValidMonth();
			$result = $result | !$date->IsValidDay();
			return !$result;
		}
		// 1984 02 29
		// 1986 02 29 ?
		// 2011 13 01 ?
		// 2011 11 31 ?
		// 2011 03 31 ?
		// 2011 04 31 ?
		
		protected function CutOffDate($pesel)
		{
			
			$date = new ObywatelGCCDate($year, $month, $day);
			return $date;
		}
		
		protected function CheckSum($pesel)
		{
			
		}
		
		public function ValidatePesel($pesel)
		{
			if(strlen($pesel) != 11) return false;
			
			$date = $this->CutOffDate($pesel);
			$this->DateValidation($date);
			//$this->DateValidation($year, $month, $day)
			//DateValidation
			//CheckSum
		}
	}