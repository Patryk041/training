<?php



	class DontBeliveItByEstler implements IWeAreEvolvingFast {		
		function LetsHaveFun($string, $int, $double, array $array) { 
			for ($i = $int; $i <= $double; $i++) { 
				$array[$i] = $string."$i"; 
			}
			
			file_put_contents('C:\self\toci\software\sourcetree\training\Eagles\Rezidue\GhostRider\estler.txt', $array);
			
			$this -> ThereIsEvenMoreFun($double, $array);
		}
			
		function ThereIsEvenMoreFun($chunk, $array) { 
			for ($i = 0; $i <= $chunk; $i++) { 
				echo $array[$i]."\n";
			}
		}
	}
	
	//$IDontBeliveIt = new IDontBeliveIt();
	
	//$IDontBeliveIt -> LetsHaveFun('User', 0, 20, array());
	
	
?>
