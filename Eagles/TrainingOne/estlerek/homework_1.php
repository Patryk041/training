<?php 
// 	Identyfikacja państwa z którego pochodzi user i jego danych osobowych na podstawie na podstawie numberu ID.

	interface IId { 
		function checkValidation ($number);
	}

	class checkId {		
		function __construct() { 
			$this -> countryList[11] = new Poland; 
			$this -> countryList[14] = new SouthKorea; 
		}
		
		function checkCountry($list) { 
			foreach ($list as $key => $number) {
				$numbers = $number;
				$this -> assignCountry($this -> countryList[strlen($number)], $number);
			}
		}
		
		function assignCountry(IId $country, $number) { 
			$country -> checkValidation($number);
		}

		function checkGender($number) {
			if ($number % 2 == 0) {
				return 'Female';
			} else {
				return 'Male';
			}
		}
		
		function checkBornDate($day, $month, $year) { 
			$data = strtotime($year.'-'.$month.'-'.$day);
			$data = date('d F Y', $data);
			return $data;
		}
	}
	
	class Poland implements IId { 
		function checkValidation($number) { 
			$id_array = str_split($number);
			$control_array = array (1, 3, 7, 9);
			
			$result = 0;
			$j = 0;
			
			for ($i = 0; $i < 10; $i++) { 
				if ($j > 3) { $j = 0; } 
				$result += $id_array[$i] * $control_array[$j];
				$j++;
			}
			
			if ($result % 10 == $id_array[10]) { 
				$valid = 'ID Number is valid'; 
			} else { 
				$valid = 'ID Number is invalid';
			}
			
			$checkId = new checkId();
			$dateOfBirth = $checkId -> checkBornDate(substr($number, 4, 2), substr($number, 2, 2), substr($number, 0, 2));
			$gender = $checkId -> checkGender(substr($number, 7, 1));
			
			echo "$number - Poland - $gender - Born: $dateOfBirth - $valid\n";
		}
	}
	
	class SouthKorea implements IId { 
		function checkValidation($number) { 			
			$checkId = new checkId();
			$dateOfBirth = $checkId -> checkBornDate(substr($number, 4, 2), substr($number, 2, 2), substr($number, 0, 2));
			$gender = $checkId -> checkGender(substr($number, 7, 1));
			
			echo "$number - South Korea - $gender - Born: $dateOfBirth \n";
		}
		
	}
	
	$number_list = array( 
		'09022105957',
		'72053003966',
		'021111-1000000',
		'751204-2000000',
		'84082211499',
		'90121519792',
		'021111-5000000',
		'780223-6000000',
		'73022511295',
		'92060218061',
		'08110305766',
		'970312-7000000',
		'771302-8000000',
		'78082500949',
		'79060616485',
		'03043010469',
		'650711-3000000',
		'990212-4000000',
		'990212-9000000'
	);
	
	$checkId = new checkId();
	$checkId -> checkCountry($number_list);
?>
