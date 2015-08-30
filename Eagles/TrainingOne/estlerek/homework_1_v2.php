<?php 
	$host = 'localhost';
	$user = 'root';
	$pass = '';
	$db = 'id_numbers';
	
	$mysqli = new mysqli($host, $user, $pass, $db);
	
	interface IPerson { 
		public function checkData($number); 
		public function checkSex($number);
		public function checkBirthDate($day, $month, $year); 
	}
	
	class Records {
		function __construct() { 
			$this -> countryName['Poland'] = new Poland;
			$this -> countryName['Hungary'] = new Hungary;
		}
		
		function checkCountry($data) { 
			while ($selected_row = mysqli_fetch_assoc($data)) { 
				$country = $this -> countryName[$selected_row['country']];
				$country -> checkData($selected_row['id_number']);
			}
		}
	}
	
	class Poland implements IPerson { 
		function checkData($number) {
			$sex = $this -> checkSex(substr($number, 9, 1));
			$date_of_birth = $this -> checkBirthDate(substr($number, 4, 2),substr($number, 2, 2),substr($number, 0, 2));
			
			$text = "Person is: $sex, born $date_of_birth in Poland \n";
			echo $text;
		}
		
		function checkSex($number) { 
			if ($number % 2) { 
				return 'Male';
			} else { 
				return 'Female';
			}
		}
		
		function checkBirthDate($day, $month, $year) { 
			return "$day-$month-$year";
		}
	}
	
	class Hungary implements IPerson { 		
		function checkData($number) {
			$sex = $this -> checkSex(substr($number, 0, 1));
			$date_of_birth = $this -> checkBirthDate(substr($number, 5, 2),substr($number, 3, 2),substr($number, 1, 2));
			
			$text = "Person is: $sex in $date_of_birth \n";
			echo $text;
		}
		
		function checkSex($number) { 
			if ($number < 5) { 
				if ($number % 2) { 
					return 'Male born in Hungary';
				} else { 
					return 'Female born in Hungary';
				}
			} else { 
				if ($number % 2) { 
					return 'Male born outside of Hungary';
				} else { 
					return 'Female born outside of Hungary';
				}				
			}
		}
	
		function checkBirthDate($day, $month, $year) { 
			return "$day-$month-$year";
		}
	}
	
	$query = "SELECT * FROM `numbers`";
	$all_data = $mysqli-> query($query); 
	
	$record = new Records();
	$record -> checkCountry($all_data);
?>
