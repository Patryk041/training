<?php
require_once 'CodeGenerator.php';
require_once 'wycinarka2.php';

class Php2Java extends CodeConverter
{

    private $fileToConvert;

    private $t1;

    private $tablicaPhp;

    function __construct ($fileName)
    {
        // Tablica ze wszystkimi elementami skĹ‚adni w postaci regexĂłw
        // poĹ‚Ä…czona z ich zamiennikamiz
        $this->tablicaPhp = array(
                '/echo\s*\".*\"/',
                'System.out.println("' . $zmienna . '")'
        );
        $this->t1 = new wycinarka2();
        $fp = fopen($fileName, "r+");
        $this->fileToConvert = fread($fp, filesize($fileName));
        fclose($fp);
    }

    function getFileToConvert ()
    {
        return $this->fileToConvert;
    }

    function getTablicaPhp ()
    {
        return $this->tablicaPhp;
    }

    function saveFile ($string)
    {}

    function echo2Java ($file, $regex)
    {
        $wyrazenie = (string) $regex;
        
        $fp = fopen($file, "r+");
        while (! feof($fp))
        {
            $linia = fgets($fp);
            if ($this->t1->findX($linia, $wyrazenie))
            {
                $zmienna = $this->t1->cutPhp(
                        $this->t1->findX($linia, $wyrazenie));
                
                $plik .= $this->t1->convertEcho($linia) . "\n";
            } else
                $plik .= $linia;
        }
        return $plik;
    }

    function GetResultingClass ($source, $currentLanguage, $desiredLanguage)
    {}
}
$P2J = new Php2Java("Siema.php");
$t1 = new wycinarka2();

echo $P2J->echo2Java("Siema.php", $P2J->getTablicaPhp()[0]);
for ($i = 0; $i <= count($P2J->getTablicaPhp()); $i ++)
{
    $P2J->echo2Java("Siema.php", $P2J->getTablicaPhp()[0]);
}