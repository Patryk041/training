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
                'System.out.println(":CONVERT");'
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

    function echo2Java ($file, $regex, $i)
    {
        $wyrazenie = (string) $regex;
        
        $fp = fopen($file, "r+");
        $plik = '';
        while (! feof($fp))
        {
            $linia = fgets($fp);
            if ($this->t1->findX($linia, $wyrazenie))
            {//zmienna daje zawartosc dla regexu np z echo 
                $zmienna = $this->t1->cutPhp(
                        $this->t1->findX($linia, $wyrazenie));
                // dla znalezionego odpowiednika w javie 
                // wstawiamy zawrtosc z echo
                $plik .= $this->t1->addJava(
                                    $zmienna,
                                    $this->tablicaPhp[$i+1]
                                    ) . "\n";
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
file_put_contents("javaCode.java", file_get_contents("Siema.php"));
// echo $P2J->echo2Java("Siema.php", $P2J->getTablicaPhp()[0]);
for ($i = 0; $i < count($P2J->getTablicaPhp()); $i +=2)
{
    $plik = $P2J->echo2Java("javaCode.java", $P2J->getTablicaPhp()[$i], $i);
    file_put_contents("javaCode.java", $plik);
}