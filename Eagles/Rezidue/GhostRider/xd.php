<?php
	//use
	require_once 'C:\self\toci\software\sourcetree\training\Eagles\Rezidue\polimorfizm.php'; //set_include_path

	class GhostRiderDoesNotBelieveIt implements IWeAreEvolvingFast //DI
	{
		private $filteringResult; //array
		
		public function LetsHaveFun($string, $int, $double, array $array)
		{
			$chunk = '';
			for ($i = $int; $i < strlen($string); $i++)
			{
				$chunk .= $string[$i];
				//
				$result = $this->ThereIsEvenMoreFun($chunk, $array);

				//$this->filteringResult[$chunk] = 'Toc# kung fu panda strike' . $result;//array_combine(array($result), array($result));
			}
			
			$this->Serialize();
			
			return $this->filteringResult;
		}
		
		public function ThereIsEvenMoreFun($chunk, $array)
		{
			//foreach($array as $chunkCandidate => $element)
			//{
				
			//}
			
			$this->filteringResult['xD' . rand(2, 8)] = 'dafaq' . rand(12, 31);
			
			
			if (isset($array[$chunk]))
			{
				return $array[$chunk]; // Array
			}
			
			return 'Janueszek';
		}
		
		public function Serialize()
		{
			//SOC 2 !!!
			return file_put_contents('C:\self\toci\software\sourcetree\training\Eagles\Rezidue\GhostRider\dafax8.txt', $this->filteringResult);
		}
	}
	
	//$IDontBelieveIT = new IDontBelieveIT();
	//r
	/*$IDontBelieveIT->LetsHaveFun('eagles are having hopefully great fun dealing with trainig', 8, 14, array(
		'r' => 'bla', 're' => 'xD', 'rh' => 'this should not be there'
	));
	
	var_dump($IDontBelieveIT->Serialize());*/