<?php

class FileReader{

	public $plik;

	function __construct($pathToFile)
	{
		if(is_readable($pathToFile))
			$this->plik=fopen($pathToFile,"r");
		else
			echo "Nie mozna otworzyc pliku: ".$pathToFile;
	}

	public function getAll()
	{
		$tablicaLinii=array();
		
		while($this->isNext())
		{
			$tablicaLinii[]=$this->getNextLine();
		}
		
		return $tablicaLinii;
		
	}
	
	public function getNextLine()
	{
		if($this->isNext($this->plik))
		{
			return fgets($this->plik);
		}
	}

	public function isNext()
	{
		//dodanie zamkniecia klpiku
		if(!feof($this->plik))
		{
			return true;
		} else{
			fclose($this->plik);
			return false;
		}
	}
}



