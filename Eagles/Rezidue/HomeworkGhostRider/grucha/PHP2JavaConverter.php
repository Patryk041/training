<?php
require_once 'ConvertingTools.php';
require_once 'CodeGenerator.php';
require_once 'JavaConvertingTools.php';

class PHP2JavaConverter extends CodeConverter
{

    /*
     * DODAĆ TABLICE REPLACEMENTÓW - > tam gdzię tylko usuwamy elementy składni
     * php (np <?php czy function etc)
     * -dodać nowe elementy skłądni obcych języków ? dla javy dopisywać typy
     * zmiennych lub typy zwracania funkcji
     * try-catch ? kontrola Wyjątków, lambda wyrażenia, przeciążanie metod,
     * wątki,synchronizacja??:D
     * dodawanie pakietów
     *
     */
    private $tools;

    private $langTool;

    private $PHPFile;

    function __construct ()
    {
        $this->licznik = 1;
        $this->tools = new ConvertingTools();
        // tablica składni PHP w postaci regexów. Do zrobienia zostało 1000000
        // ;)
        $this->regexArray = array(
                "1" => '/echo\s*\".*\"/',
                "2" => '/php1/',
                "3" => '/php2/',
                "4" => '/php3/'
        );
        $this->currentLanguage = "php";
    }

    function getCurrentLanguage ()
    {
        return $this->currentLanguage;
    }

    function GetResultingClass ($source, $currentLanguage, $desiredLanguage)
    {
        $this->PHPFile = $source;
        if ($this->licznik > count($this->regexArray))
        {
            return;
        }
        if ($this->currentLanguage == "php" && $desiredLanguage == "Java" ||
                 $desiredLanguage == "java")
        {
            $this->langTool = new JavaConvertingTools();
            for ($i = 1; $i <= count($this->regexArray); $i ++)
            {
                $fileTest = file_get_contents("tempPHP.php");
                if (strlen($fileTest) > 0)
                    $this->PHPFile = "tempPHP.php";
                
                $file = $this->langTool->Php2Java($this->PHPFile, 
                        $this->regexArray[$i], $i);
                
                file_put_contents("tempPHP.php", $file);
            }
            file_put_contents("JAVAclass.java", $file);
            $emptyFile = '';
            file_put_contents("tempPHP.php", $emptyFile);
        }
    }
}

$p1 = new PHP2JavaConverter();
$p1->GetResultingClass('PHPclass.php', $p1->getCurrentLanguage(), 'Java');