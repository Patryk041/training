<?php
// require_once('../GhostRider/Homework/PeselValidation.php');

class OlsztyniakPeselValidation extends PeselValidation {
	

private function GetDay($pesel) {
	$pesel = substr($pesel, 4, 2);
	return $pesel;
}

private function GetMonth($pesel) {
	$pesel = substr($pesel, 2, 2);
	return $pesel;
}

private function GetCutYear($pesel) {
	$pesel = substr($pesel, 0, 2);
	return $pesel;
}
	
	
// czy rok 19xx czy 20xx? zwraca gotowy rok
private function GetYear($cutyear, $month) {

if ( $month >= 1 && $month <= 12 ) {
	$year = '19'.$cutyear;
}

elseif ($month >= 21 && $month <= 32) {
	$year = '20'.$cutyear;
}

else {
	$year = NULL;
}

return $year;
}


// czy rok jest przestepny?
private function IsLeapYear($year) {

// jezeli rok niepodzielny przez 100 ale podzielny przez 4 lub podzielny przez 100 i 400 to jest przestepny
	if ( ( $year % 100 != 0 && $year % 4 == 0 )  OR ( $year % 100 == 0 && $year % 400 == 0 ) ) {
		return TRUE;
	}
	
	else {
		return FALSE;
	}

}


// czy dzien jest prawidlowy
private function IsGoodDay($day,$month,$year) {
	
$days_vs_months = array (
array('month' => 01, 'days' => 31),
array('month' => 02, 'days' => 28),
array('month' => 03, 'days' => 31),
array('month' => 04, 'days' => 30),
array('month' => 05, 'days' => 31),
array('month' => 06, 'days' => 30),
array('month' => 07, 'days' => 31),
array('month' => 08, 'days' => 31),
array('month' => 09, 'days' => 30),
array('month' => 10, 'days' => 31),
array('month' => 11, 'days' => 30),
array('month' => 12, 'days' => 31),
array('month' => 21, 'days' => 31),
array('month' => 22, 'days' => 28),
array('month' => 23, 'days' => 31),
array('month' => 24, 'days' => 30),
array('month' => 25, 'days' => 31),
array('month' => 26, 'days' => 30),
array('month' => 27, 'days' => 31),
array('month' => 28, 'days' => 31),
array('month' => 29, 'days' => 30),
array('month' => 30, 'days' => 31),
array('month' => 31, 'days' => 30),
array('month' => 32, 'days' => 31)
);

if ( $this->IsLeapYear($year) ) {
	$days_vs_months[02] = array('month' => 02, 'days' => 29);
	$days_vs_months[13] = array('month' => 22, 'days' => 29);
}


$result = 0;
foreach ($days_vs_months as $key=>$val) {
	
if($val['month'] == $month){
$result = $val['days'];
}

}

if ( $result != 0 && $day <= $result) {
	return TRUE;
}

else {
	return FALSE;
}

	
}

// czy miesiac jest prawidlowy
private function IsGoodMonth($month) {
	if ( ($month >= 01 && $month <= 12) OR ( $month >=21 && $month <= 32 ) ) {
		return TRUE;
	}
	
	else {
		return FALSE;
	}
}

// czy rok jest prawidlowy
private function IsGoodYear($year) {
	if ( $year >= 1900 && $year <= 2099 ) {
		return TRUE;
	}
	
	else {
		return FALSE;
	}
}



// validacja daty
protected function DateValidation ($year, $month, $day) {
	
$year = $this->GetYear($year, $month);
$year = $this->IsGoodYear($year);
$month = $this->IsGoodMonth($month);
$day = $this->IsGoodDay($day,$month,$year);

if ($year && $month && $day === TRUE) {
	return TRUE;
}

else {
	return FALSE;
}



}

// wycinanie daty z peselu
protected function CutOffDate($pesel) {
	$pesel = substr($pesel, 0, 6);
	return $pesel;
}

// sprawdzanie sumy kontrolnej




public function CheckSum($pesel) {
	
// jak pesel nie ma 11 znaków to nie mamy o czym gadać :)
if ( strlen($pesel) != 11 ) {
	return FALSE;
	exit;
}
	
$wagi = array(1,3,7,9,1,3,7,9,1,3);
$pesel = ''.$pesel.''; //aby traktowal pesel jako string i dzialal array na nim
		
$policz = 0;
		
for ( $i = 0; $i < 10; $i++) {
	$policz += $pesel[$i] * $wagi[$i];
}
		
//sprawdzenie z suma kontrolna
if($policz %10 == (10 - $pesel[10]))	{
	return TRUE;
}
		
else {
	return FALSE;
}

}



// ostatecznie - sprawdzanie poprawności numeru PESEL
public function ValidatePesel($pesel) {

$day = $this->GetDay($pesel);
$month = $this->GetMonth($pesel);
$year = $this->GetCutYear($pesel);

$data = $this->DateValidation ($year, $month, $day);
$checksum = $this->CheckSum($pesel);

if ($data == TRUE && $checksum == TRUE) {
	return TRUE;
}

else {
	return FALSE;
}
	
}

}



/* testy

$pesel = new OlsztyniakPeselValidation;

if ( $pesel->CheckSum(84121200978) == TRUE ) {
	echo 'TRUE';
}

else {
	echo 'FALSE';
}

*/