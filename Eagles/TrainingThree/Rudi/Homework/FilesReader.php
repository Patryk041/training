<?php

require_once "FileReader.php";

class FilesReader{

	public $pliki=array();
	public $currentFile=0;
	public 
	function __construct($pathsArray)
	{
		$i=0;
		//konstruktor odrazu laduje wszystkie pliki gotowe do odczytu
		foreach ($pathsArray as $path)
		{
			if(is_readable($path)){
			
				$this->pliki[$i++]=new FileReader($path);
			}
		}

		var_dump($this->pliki);

	}

	public function getNextLine()
	{
		echo "plik:".$this->currentFile.": ";
		if($this->getCurrFile()->isNext())
		{
			return $this->getCurrFile()->getNextLine();
		} else {
			echo "\nfiles: koniec pliku\n";

		}
	}

	public function isNext()
	{
		echo "sprawdzam: ".$this->currentFile."  ";
		if($this->getCurrFile()->isNext())
		{
			return true;
		}else{
			echo "kolejny plik";
			if(count($this->pliki)>$this->currentFile)
			{	
				echo "wczytuje plik";
				$this->currentFile++;
				echo "\nco jest\n";
				$this->getNextLine();
			}
		}
	}

	public function getCurrFile()
	{
		echo "pobnrano plik: ".$this->currentFile."  ";
		return $this->pliki[$this->currentFile];
	}

}

$fr= new FilesReader(array("operacje.txt","operacje2.txt"));

while($fr->isNext())
	echo $fr->getNextLine();

