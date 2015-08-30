<?php
require '../polimorfizm.php';
	
	class IBeliveICanFly implements IWeAreEvolvingFast{
		public function LetsHaveFun($string, $int, $double, $array){
			$chunk = '';
			for ($i=$int; $i < strlen($string); $i++){
				$chunk .= $string[$i];
				
				$this->ThereIsEvenMoreFun($chunk, $array);
			}
		}
		
		public function ThereIsEvenMoreFun($chunk, $array){
			
			if(isset($array[$chunk])){
				
			}
			
		}
	}
	