<?php
require '../polimorfizm.php';
	
	class IBeliveICanFly implements IWeAreEvolvingFast{
		private $filteringResult;
		
		public function LetsHaveFun($string, $int, $double, $array){
			$chunk = '';
			for ($i=$int; $i < strlen($string); $i++){
				$chunk .= $string[$i];
				
				$result = $this->ThereIsEvenMoreFun($chunk, $array);
				$this->filteringResult = array_combine(array($result), array($result, $result, $result));
			}
		}
		
		public function ThereIsEvenMoreFun($chunk, $array){
			
			if(isset($array[$chunk])){
				return $array[$chunk];
			}
			return "Gra¿yna";
		}
	}
	