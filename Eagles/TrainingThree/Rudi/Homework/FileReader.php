<?php

class FileReader{

	public $plik;

	function __construct($pathToFile)
	{
		$this->plik=fopen($pathToFile,"r") or die("Nie mozna otworzyc pliku: ".$pathToFile);
	}

	public function nextLine()
	{
		if($this->isNext($this->plik))
		{
			return fgets($this->plik);
		}
	}

	public function isNext()
	{
		return !feof($this->plik);
	}
}

$reader=new FileReader("operacje.txt");

while($reader->isNext())
{
	echo $reader->nextLine();
}


