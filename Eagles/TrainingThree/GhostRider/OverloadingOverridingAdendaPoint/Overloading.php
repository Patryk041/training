<?php

	class Overloading // przeciazenie
	{
		private $mapa = array(
			0 => 'NazwaMetody',
			1 => 'InnaNazwaMetody'
		);
		
		public function Operacja($cokolwiek = null, $nastepne = null)
		{
			
			echo 'operacja w Overloading';
			
			/*$args = func_get_args();
			
			var_dump($args);
			
			$nazwaM = $this->mapa[sizeof($args)];
			//echo $nazwaM;
//			$this->$nazwaM();

			call_user_method($this->mapa[sizeof($args)], $this);*/
		}
		
		private function NazwaMetody()
		{
			echo 'akuku';
		}
		
		protected function InnaNazwaMetody()
		{
			echo 'inaczej';
		}
	}
	
	
	
	class Overriding extends Overloading
	{
		public function Operacja()
		{
			echo 'operacja w Overriding';
		}
	}
	
	class Test
	{
		public function  __construct()
		{
			
		}
		
		public function TestCokolwiek(Overloading $obj)
		{
			$this->__construct();
			$obj->Operacja();
		}
	}
	
	$overl = new Overloading();
	
	$overr = new Overriding();
	
	$test = new Test();
	
	$test->TestCokolwiek($overl);
	
	//$overl->Operacja();
	
	//settype($overr, Overloading);
	
	//$overr = (array)$overr;
	
	//$overr->Operacja();
	
	//$overl->Operacja();
	
	//$overl->Operacja("o powuiedzmy zmienie");
	
	//$overl->Operacja("dsaffdas", "fdsas");