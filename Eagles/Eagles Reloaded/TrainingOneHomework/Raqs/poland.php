<?php
	require 'IPerson.php';
	class personPoland implements Person{
		
		private  $nationalNumber;
		
		function __construct($pesel){
			$this->nationalNumber = $pesel;
		}
		
		function validate(){

			if(strlen($this->nationalNumber) != 11){  //sprawdzenie czy nr ma w ogóle 11 cyfr
				echo "Podany pesel nieprawid³owy!";
				return false;
			}
			else{
				$cyfry = array();
				$suma;
				
				for($i=0; $i<11; $i++){
					$cyfry[$i] = substr($this->nationalNumber, $i, 1);
				}

				$suma = ( 1*$cyfry[0] + 3*$cyfry[1] + 7*$cyfry[2] + 9*$cyfry[3] + 1*$cyfry[4] + 3*$cyfry[5] + 7*$cyfry[6] + 9*$cyfry[7] + 1*$cyfry[8] + 3*$cyfry[9] ); 

				if ( (10 - ($suma%10)) == $cyfry[10] ){
					//echo "PESEL GIT!";
						
					return true;
				}
				else {
					echo "Podany PESEL nieprawid³owy!";
						
					return false;
				}
			}
			
		}
		
				
		function getSex(){
			
			if((substr($this->nationalNumber, 9, 1) % 2) == 0) {
				return "Kobieta";
			}
			else {
				return "Mê¿czyzna";
			}
		}
		function getBirth(){
			echo " ur. ".substr($this->nationalNumber, 4, 2); //dzieñ urodzin
			echo ".".substr($this->nationalNumber, 2, 2); //miesi¹c
			echo ".".substr($this->nationalNumber, 0, 2); //rok
			return;
		}
		
	}
	