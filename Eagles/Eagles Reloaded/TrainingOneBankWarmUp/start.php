<?php

	//skryptowosc
	require_once 'C:\self\toci\software\sourcetree\training\Eagles\Eagles Reloaded\TrainingOneBankWarmUp\Interfaces\IKonto.php';
	require_once 'C:\self\toci\software\sourcetree\training\Eagles\Eagles Reloaded\TrainingOneBankWarmUp\Interfaces\IKlient.php';

	abstract class Konto implements IKonto // public protected private static extends abstract final implements interface 
	{
		//protected $nrKonta;
		public $NazwaBanku;
		
		private function IAmPrivate()
		{
			 
		}
		
		protected function IAmProtected() 
		{
			echo 'IAmProtected frunie';
		}
		
		public static function WytnijIdBanku($nrKonta) // 2 4
		{
			//10102043725923785  -> 1020
			return substr($nrKonta, 2, 4);
			//$this->nrKonta;
			//var_dump($this->nrKonta);
		}
		
		public abstract function ZrobPrzelew(IKlient $klient);
	}
	
	class KontoMBank extends Konto
	{
		public static $Wartosc;
		
		public function Test()
		{
			$this->IAmProtected();
		}
		
		protected function IAmProtected()
		{
			
		}
		
		public function ZrobPrzelew(IKlient $klient)
		{
			
		}
	}
	
	function tesdt()
	{
		$tab = array('sdaf' => 'dsafad');
		
		$tab[] = 'safas';
		$tab[] = $tab;
		
		$tab['wtf'] = new KontoBankMillenium();
		
		var_Dump($tab);
	}
	
	
	class ManagerPrzelewow
	{
		private $MapaBankow;
		/*= array(
			'1020' => 'KontoPkoSa',
			
		);*/

		public function __construct()
		{
			$this->MapaBankow['1020'] = 'KontoIng';
			$this->MapaBankow['1030'] = new KontoIng();
			$this->MapaBankow['1040'] = new KontoBankMillenium();
			$this->MapaBankow['1050'] = new KontoBankGetin();
			
			//new $this->MapaBankow['1020']()->Whatever();
			
		}
		
		public function ZrobWszystkiePrzelewy($tablicaKont)
		{
			foreach ($tablicaKont as $key => $nrKonta)
			{
				//1020
				$nrb = Konto::WytnijIdBanku($nrKonta);
				
				if (isset($this->MapaBankow[$nrb]))
				{
					$this->ZrobJedenPrzelew($this->MapaBankow[$nrb]);
				}
			}
		}
		
		private function ZrobJedenPrzelew(IKonto $kontoBank)
		{
			//Whatever
			$kontoBank->ZrobPrzelew(new Klient());
		} 
	}
	
	class Klient implements IKlient
	{
		
	}
	
	
	//KontoMBank::$Wartosc = 6;
	
	$nr = new KontoMBank();
	
	//$nr->Test();
	
	//Konto::WytnijIdBanku();
	
	//$nr = new Konto();

	//$nr::WytnijIdBanku();
	
	//KIR elixir
	
	class KontoIng implements IKonto
	{
		public function ZrobPrzelew(IKlient $klient)
		{
			echo "przelew z ing \n\n";
		}
		
		public function Whatever()
		{
			
		}
	}
	
	class KontoPkoSa implements IKonto
	{
		public function ZrobPrzelew(IKlient $klient)
		{
			echo "przelew z pko sa \n\n";
			// pko sa
		}
	}
	
	class KontoBankMillenium implements IKonto
	{
		private $tab = array();
		
		public function __construct(){
			$this->tab[] = new KontoBankGetin();
		}
		
		public function ZrobPrzelew(IKlient $klient)
		{
			echo "przelew z millenium \n\n";
			// millenium
		}
	}
	
	class KontoBankGetin implements IKonto
	{
		public function ZrobPrzelew(IKlient $klient)
		{
			echo "przelew z getinu \n\n";
			// millenium
		}
		
		public function AleJaja()
		{
			echo 'Taaaak, to dziala !! :)';
		}
	}
	
	$manager = new ManagerPrzelewow();
	
	
	class niedasie
	{
		
	}
	
	class probouje extends niedasie
	{
		
	}
	
	$janusz = 'stefan';
	$stefan = 'rysiek';
	
	echo $$janusz;
	
	$super = 'KontoBankGetin';
	
	$jeszczelepiej = 'AleJaja';
	
	
	$ob = new $super();
	
	$ob->$jeszczelepiej();
	
	
	tesdt();