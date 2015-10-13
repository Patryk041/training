<?php
/**
 * Created by PhpStorm.
 * User: tomek
 * Date: 30.08.15
 * Time: 14:52
 */

require_once '../polimorfizm.php';
	
	class Polimorfizm implements IWeAreEvolvingFast{
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
			return "TomekL";
		}
	}
	
	$IBeliveICanFly = new IBeliveICanFly();
	$IBeliveICanFly->LetsHaveFun("ale kosmos", 8, 14, array( 'r' => array('bla')))
