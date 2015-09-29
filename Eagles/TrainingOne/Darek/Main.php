<?php
	
//require_once 'DateOfBirth.php';
//require_once 'Sex.php';

//wpisujemy pesel gdy chcemy znalezc osobe i info o niej
$pesel='89021106559';
$costam = new Person();
$costam->Osoba ($pesel);
$costam->DateOfBirth($pesel);
$costam->sex($pesel);

class Person  
{
	function Osoba ($pesel)
	{
		$person = array 
		(		'89021106559'=>'Jan Kowalski',
				'91021106559'=>'Krzysztof Brzêczyszykiewicz',
				'66110105323'=>'Jerzy Jaworowicz',
				'91021106569'=>'Mysza Myszata'
				
		);
		if(array_key_exists($pesel, $person))
		{
			echo $person[$pesel]."\n";
		}
		
	}
	
	
	function DateOfBirth($pesel)//Jak dodasz ecoh dateofbirth i w nawiasach pesel to wywali
	{
		$year = '19'.substr($pesel, 0,2); // rok urodzenia
		$month = substr($pesel, 2, 2);
		$day = substr($pesel, 4, 2);
	
		$data = strtotime($year.'-'.$month.'-'.$day);
	
		$data = date('d F Y', $data);
	
		echo 'Data urodzenia: '.$data."\n";
	
	}
	
	function sex ($pesel)
	{
		$plec = array ('0','2','4','6','8');
		if (array_key_exists($pesel[10], $plec))
		{
			echo 'Plec-Kobieta'."\n";
		}
		else
		{
			echo 'Plec-Mezczyzna'."\n";
		}
	}
	
	//Osoba ('89021106559'); //wyciaga to jana kowalskiego z funckji dziala nie usuwaæ
	
}

	