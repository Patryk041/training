<?php

class Pesel {
	private $nrPesel = null;
	private $nrPeselDigit = array();
	private $tabTemp = array(190,190,200,200,210,210,220,220,180,180);
	private $tabCorrect = array(1,3,7,9,1,3,7,9,1,3);
	private $tabDay = array(31,28,31,30,31,30,31,31,30,31,30,31);
	private $tabMonath = array("styczen", "luty", "marzec", "kwiecien", "maj", "czerwiec", "lipiec", "sierpien", "wrzesien", "pazdziernik", "listopad", "grudzie�");
	public $leapYear = null;
	public $year = null;
	public $monath = null;
	public $day = null;
	public $sex = null;
	
	public function  __construct($pesel) {
		$this->nrPesel = $pesel;
	} 
	
	private function isLong () {
		if (strlen($this->nrPesel)== 11) {
			return true;
		}
		echo "Nieprawidlowa dlugosc numeru pesel .\n";
		return false;
	}
	
	private function isDigit (){		
		if ($this->isLong()) {
			for ($i=0 ;$i< strlen($this->nrPesel); $i++ ) {
				if (is_numeric($this->nrPesel[$i])){
					$this->nrPeselDigit[$i]=$this->nrPesel[$i];
					}
				else {
					echo "Wprowadzony numer pesel zawiera niedozwolone znaki: ".$this->nrPesel[$i]."\n";
					return false;
				}
			}
			return true;
		}
		return false;
	}
	
	private function setData (){
		if ($this->isCorrect() & $this->checkMonath() & $this->checkDay()){
			$this->year = $this->setYear();
			$this->monath = $this->setMonath();
			$this->day = $this->setDay();
			$this->sex = $this->setSex();
			return true;
		}else return false; 
			
	}

	private function setYear(){
		return (($this->tabTemp[$this->nrPeselDigit[2]]+$this->nrPeselDigit[0])*10)+$this->nrPeselDigit[1]; 
	}
	
	private function leapYear(){
		if ( ( ($this->year % 4 == 0) and ($this->year % 100 <> 0) ) or ($this->year % 400 == 0) ){
			$this->leapYear = 1;
			return true;
		}
		$this->leapYear = 0;
		return false;
	}
	
	private function setMonath(){
		return ((($this->nrPeselDigit[2]*10)+ $this->nrPeselDigit[3])-($this->nrPeselDigit[2]*10));
	}
	
	private function setDay(){
		return ($this->nrPeselDigit[4]*10) + $this->nrPeselDigit[5];
	}
	
	private function setSex(){
			if ($this->nrPeselDigit[9]%2 == 0) 
				return "kobieta";
			else return "mezczyzna";
	}
	
	private function checkMonath(){
		if ($this->setMonath() >0 & $this->setMonath()<=12)
			return true;
		else {
			echo "Blad na pozycji miesiaca.\n";
			return false;			
		}

	}
	
	private function checkDay (){
		if ($this->setDay() < $this->tabDay[$this->setMonath()] & $this->setDay() > 0)
			return true;
		else{ 
			if ($this->leapYear() & ($this->setMonat() == 2) & ($this->setDay() == 29))
				return true;
		}
		return false;
	}
	
	private function isCorrect (){
		if ($this->isDigit()) {
			$sum =0;
			for ($i=0;$i<10;$i++)
			 	$sum = $sum + ($this->nrPeselDigit[$i]*$this->tabCorrect[$i]);
			if (!$sum%10)
				$sum = 0;
				else
					$sum = 10-$sum%10;
			if ($sum == $this->nrPeselDigit[10])
				return true;
			else {
				echo "Nieprawidlowy numer pesel.\n\n";
				return false;
			} 				 						
		}
	}
	
	public function show() {
		if ($this->setData())
			return "Plec: ".$this->sex."\n"."Data urodzenia: ".$this->year." ".$this->tabMonath[$this->monath-1]." ".$this->day;
		else echo "Bledne dane.\n";
	}
}

$pesel = new Pesel("74062109896");
echo $pesel->show();

?>