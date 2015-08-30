<?php

	require '..\poliformizm.php';

	class IDontBeliveIt implements IWeAreEnvolvingFast {		
		function LetsHaveFun($string, $int, $double, array $array) { 
			for ($i = $int; $i < $double; $i++) { 
				$array[$i] = $string."$i"; 
			}
			
			$this -> ThereIsEvenMoreFun($double, $array);
		}
			
		function ThereIsEvenMoreFun($chunk, $array) { 
			for ($i = 0; $i < $chunk; $i++) { 
				echo $array[$i]."\n";
			}
		}
	}
	
	$IDontBeliveIt = new IDontBeliveIt();
	
	$IDontBeliveIt -> LetsHaveFun('User', 0, 20, array());
	
	
?>
