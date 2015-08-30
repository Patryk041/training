<?php

	require_once 'C:\self\toci\software\sourcetree\training\Eagles\Rezidue\polimorfizm.php';
	require_once 'C:\self\toci\software\sourcetree\training\Eagles\Rezidue\estler\qwewqe.php'; //set include path
	require_once 'C:\self\toci\software\sourcetree\training\Eagles\Rezidue\GhostRider\xd.php';
	require_once 'C:\self\toci\software\sourcetree\training\Eagles\Rezidue\Raqs\index.php';
	require_once 'C:\self\toci\software\sourcetree\training\Eagles\Rezidue\PieknaClass.php';
	
	class AlsmostChor // Chain of responsibility
	{
		//array
		private $strategies = array(
			//'relse' => new IDontBeliveItByEstler()
		);
		
		public function __construct(){
			$this->strategies[] = new DontBeliveItByEstler();
			$this->strategies[] = new IBeliveICanFly(); // !!! I
			$this->strategies[] = new PieknyClass();
			$this->strategies[] = new GhostRiderDoesNotBelieveIt();
		}
		
		
		public function StrategyFirer(IWeAreEvolvingFast $evolvingFastStrategy, $array)
		{
			return $evolvingFastStrategy->LetsHaveFun('eagles are having hopefully great fun dealing with trainig', 12, 0, $array);
		}
		
		public function LetDoIt()
		{
			$result = array(
				'r' => 'bla', 're' => 'xD', 'rh' => 'this should not be there'
			);
			
			foreach ($this->strategies as $strategy)
			{
				//var_dump($strategy);
				$result[] = $this->StrategyFirer($strategy, $result);
			}
			
			return $result;
		}
	}
	
	$test = new AlsmostChor();
	
	$test->LetDoIt();
	
	