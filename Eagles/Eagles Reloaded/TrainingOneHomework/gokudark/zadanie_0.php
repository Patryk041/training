<?php

abstract class ID_info{
	public abstract function checkSex($pesel);
	public abstract function checkDateOfBirth($pesel);
}


class ID_validation {
	var $pesel;
	var $lable ="Unknown";

	function __construct($pesel) {
		$this->pesel = $pesel;
		$this->checkCountry($this->pesel);
	}

	public function checkCountry($pesel){

		$last_numb = substr($pesel, -1);
		$arr1 = str_split($pesel);
		$arr_len = count($arr1)-1;

		$arr2 = array(1, 3, 7, 9, 1, 3, 7, 9, 1, 3);

		$q = 0;

		for($numb=0;$numb<$arr_len;$numb++){
			$q += $arr1[$numb]*$arr2[$numb];
		}
			
		$q = $q%10;

		if($q!=0)$q= 10-$q;

		var_dump($q);

		if ($last_numb!=$q) {
			$this->lable ="Unknown";
		}else $this->lable ="POL";

	}

	function show_info(){

		if($this->lable=="POL"){
			$pol = new ID_POL();
			echo "\n";
			echo "SEX : ";
			echo "\n";
			echo $pol->checkSex($this->pesel);
			echo "\n";
			echo "day\month\year";
			echo "\n";
			echo $pol->checkDateOfBirth($this->pesel);
			echo "\n";
		}
		if($this->lable=="CZE"){

		}
		if($this->lable=="VIE"){

		}

	}
}

class ID_POL extends ID_info{

	public  function checkSex($pesel){
		$sex_numb = substr($pesel, -2,1);
		if($sex_numb%2==0){
			return "female";
		}else return "male";
	}
	
	public  function checkDateOfBirth($pesel){

		$date = substr($pesel,0,6);
		$year = substr($date,0, 2);
		$month = substr($date, 2, 2);
		$day = substr($date, 4, 2);

		if($month>12)  $month = $month - 20;

		$date_full = $day . ":" . $month . ":" . $day;

		return $date_full;
	}

}



class ID_Vietnam extends ID_info{

	public  function checkSex($pesel){
	
	}
	
	public  function checkDateOfBirth($pesel){
	
	}

}

/*

class ID_Czech extends ID_info{

}
*/


//28022415826 git gut (Poprawny polski pessel)
//44051401358 nie git gut (Nie poprawny polski pessel)
$zal = new ID_validation("94062501610");

echo $zal->lable;
$zal->show_info();

?>