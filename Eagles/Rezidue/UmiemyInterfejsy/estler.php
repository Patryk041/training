<?php 
 	require 'Interfaces.php';
	
	class showAll implements IDeveloper { 
		function printData() { 
			$datas = new getData(); 
			return "Developer name is: ".$datas -> getName()." and his sex is: ".$datas -> getSex()."\nHis main sense is ".$datas -> getSenseName()." and it sounds ".$datas->useSense()."\n"; 
		}
		
		function developSomeCode($someLove) { 
			for ($i = 0; $i <= $someLove; $i++) { 
				echo "Everybody need some love \n";
			}
		}
	}
	
	class getData implements IHuman, ISenses { 
		function getName() { 
			$given_name = 'Piotr'; 
			$family_name = 'Kowalski'; 
			
			return $given_name.' '.$family_name;
		}

		function getSex() {
			$checkSex = $this -> getName(); 
			$pices = explode(' ', $checkSex);
			$sex = substr($pices[0], 1); 
			
			if ($sex == 'a' ) {
				$sex = 'Female';
			} else { 
				$sex = 'Male'; 
			}
			
			return $sex; 
		}

		function getSenseName() {
			return 'Smell'; 
		}

		function useSense() {
			if ($this-> getSenseName() == 'Smell') { 
				return 'Sniff Sniff';
			}
		}
	}
	
	$user = new showAll();
	echo $user -> printData(); 
	echo $user -> developSomeCode(20); 
?>
