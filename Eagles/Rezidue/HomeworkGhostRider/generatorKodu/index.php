<?php 
$plik = file_get_contents("HelloWorld.php");

$generator = new CodeGenerator();
$generator->GenerateCode("PHP","Java",$plik);

class CodeGenerator{
	
	public function GenerateCode($current, $desired, $kod)
	{
		$kod = preg_replace("/\n|\s|\s+/", '', $kod);
		$generator = new PhpToJava($kod);
		$generator->Generate($kod);
	    $generator->ShowCode();
	}
}
class PhpToJava{
		protected $slownik;
		protected $translated;

	function __construct($kod)
	{
		$this->translated = new JavaCode();
		$this->slownik= array(
		"<?php" 		 => array("wpisz" => "", 				"stop" => ""),  //stop "" means to stop doing nested Generate method and come back to parent Generate method
		"{"     		 => array("wpisz" => "{",				"stop" => ""),  // test
		"}" 			 => array("wpisz" => "}",				"stop" => ""),  // test
		";"				 => array("wpisz" => ";",				"stop" => ""),  // test
		"class" 		 => array("wpisz" => "\npublic class ", "stop" => "{"),
		"publicfunction" => array("wpisz" => "\n\tpublic void ", "stop" => "{"),  //needs add ExternalTranslateMethod
		"__construct()"  => array("wpisz" => " static  void main(String[] args)","stop" => "{"),  //needs add ExternalTranslateMethod
		"+"				 => array("wpisz" => "+",				"stop" => ""),
		"-"				 => array("wpisz" => "-",				"stop" => ""),
		"*"				 => array("wpisz" => "*",				"stop" => ""),
		"/"				 => array("wpisz" => "/",				"stop" => ""),
		"="				 => array("wpisz" => "=",				"stop" => ""),
		"\""			 => array("wpisz" => "\"",				"stop" => ""),
		1				 => array("wpisz" => "1",				"stop" => ""),
		"echo" 			 => array("ExternalTranslateMethod" => "EchoMethod"),
		"$"				 => array("wpisz" => "",				"stop" => ""),  //needs add externalTranslateMethod
		"cuztojest"		 => array("wpisz" => "cuztojest",		"stop" => ""),


		);

	}
	public function ShowCode()
	{
		echo $this->translated->code;
	}
	protected function Translate($arrayKey, $kod, $child = false)
	{
		if(isset($this->slownik[$arrayKey]["ExternalTranslateMethod"])){


			require_once 'libs/'.$this->slownik[$arrayKey]["ExternalTranslateMethod"].".php";
			$ExternalTranslateMethod = new $this->slownik[$arrayKey]["ExternalTranslateMethod"]($this->translated);
			$ExternalTranslateMethod->AddBuffor();
			$result = $ExternalTranslateMethod->Translate($arrayKey, $kod, true);


		}else{

			$result =   $this->InternalTranslateMethod($this->slownik[$arrayKey]["wpisz"],$this->slownik[$arrayKey]["stop"], $kod, $child);
		}

		return $result;
	}
	protected function InternalTranslateMethod($dopis, $stop, $kod, $child=false)
	{
		$this->translated->code .=$dopis; 
			

		 //echo "Dopisuje <span style='color: blue; font-weight:bold; font-style:italic;'>".htmlspecialchars($dopis)."</span><br>";

		$result = $this->Generate($kod, '', $stop);

		if(strlen($stop)>0 ){
			$result["zlepek"]   .= $this->GetBuffor().$stop;
			$result["kod"] = substr($result["kod"], 1);
		}

			// echo "Buffor equals to: ".$this->GetBuffor()."<br>";
			$this->translated->code .= $result["zlepek"];
		

		 // echo " <span style='color: blue; font-weight:bold; font-style:italic;'>Zlepiam".htmlspecialchars($result["zlepek"])."</span><br>";

		return $result["kod"];
	}
	// null is different from "" and so stop is preset with null value so that  generate method might be called for the first time
	// after first call stop has a value  related to arrayKey found in slownik
	public function Generate($kod, $zlepek='', $stop=null) 
	{
		while(strlen($kod) > 0 && $kod[0] !== $stop && $stop !== '')
		{	
			// echo "Kod to: ".htmlspecialchars($kod[0])." Stop to: ".htmlspecialchars($stop)."<br>";
			

			// by creating $zlepek we want to define if its value exists in slownik as a key value
			
			if(array_key_exists($zlepek, $this->slownik)){
				  // echo "Istnieje zlepek: <span style='color: green; font-weight:bold; font-style:italic;'>".htmlspecialchars($zlepek)."</span><br>";
				$kod = $this->Translate($zlepek, $kod);


				$zlepek = '';
			}else{
				$zlepek .= $kod[0];
				 // echo "Tworze zlepek: <span style='color: orange; font-weight:bold; font-style:italic;'>".htmlspecialchars($zlepek)."</span><br>";
				$kod = substr($kod, 1);
			}


		}

		return array("kod" => $kod, "zlepek" => $zlepek);

	}
	protected function AddBuffor(){
		array_unshift($this->translated->buffor, $this->buffor);

	}
	protected function GetBuffor(){
		$buffor =  array_shift($this->translated->buffor);
		return $buffor;
	}
}

class JavaCode
{
	public $code = '';
	public $buffor = array();
	public $comments = array();

}