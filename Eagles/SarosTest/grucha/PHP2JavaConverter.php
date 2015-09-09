<?php
require_once 'ConvertingTools.php';
require_once 'CodeGenerator.php';
require_once 'JavaConvertingTools.php';

class PHP2JavaConverter extends CodeConverter
{
 /*  DODAĆ TABLICE REPLACEMENTÓW  - > tam gdzię tylko usuwamy elementy składni php (np <?php czy function etc)
  *  -Jak dodać nowe elementy skłądni obcych języków ? dla javy dopisywać typy zmiennych lub typy zwracania funkcji?
  *   try-catch ? kontrola Wyjątków, lambda wyrażenia, przeciążanie metod, wątki,synchronizacja??:D
  *   dodawanie pakietów
  *   
  */
    private $tools;

    private $langTool;

    private $PHPFile;

    private $licznik;

    function __construct ()
    {
        $this->licznik = 1;
        $this->tools = new ConvertingTools();
        $this->regexArray = array(
                "1" => '/echo\s*\".*\"/'
        );
        $this->currentLanguage = "php";
    }

    function setLicznik ($arg)
    {
        $this->licznik = $arg;
    }

    function getLicznik ()
    {
        return $this->licznik;
    }

    function getCurrentLanguage ()
    {
        return $this->currentLanguage;
    }

    function savePHPFile ($fileName)
    {
        $fp = fopen($filename, "r");
        $this->PHPFile = fread($fp, filesize($fileName));
        fclose($fp);
    }

    function GetResultingClass ($source, $currentLanguage, $desiredLanguage)
    {
        if ($this->licznik > count($this->regexArray))
        {
            return;
        }
        if ($this->currentLanguage == "php" && $desiredLanguage == "Java" ||
                 $desiredLanguage == "java")
        {
            $this->langTool = new JavaConvertingTools();
            $this->PHPFile = $source;
            $file = $this->langTool->Php2Java($this->PHPFile, 
                    $this->regexArray[$this->licznik], $this->licznik);
            $licznik ++;
            echo $file;
            file_put_contents("JAVAclass.java", $file);
        }
    }
}

$p1 = new PHP2JavaConverter();
$p1->GetResultingClass('PHPclass.php', $p1->getCurrentLanguage(), 'Java');