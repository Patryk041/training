<?php
require_once 'ConvertingTools.php';

class JavaConvertingTools extends ConvertingTools
{

    private $JavaRegexTab;

    function __construct ()
    {
        // tablica składni JAVA postaci regexów. Do zrobienia zostało 1000000 ;)
        $this->JavaRegexTab = array(
                "1" => 'System.out.println(":CONVERT");',
                "2" => 'java1',
                "3" => 'java2',
                "4" => 'java3'
        );
    }

    function getJavaRegexTab ()
    {
        return $this->JavaRegexTab;
    }

    function Php2Java ($file, $regex, $i)
    {
        $wyrazenie = (string) $regex;
        $fp = fopen($file, "r+");
        // $plik = 'public class JAVAclass' . "{\n" .
        // 'public static void main(String [args])' . "{\n";
        
        while (! feof($fp))
        {
            $linia = fgets($fp);
            $linia = preg_replace('/\<\?php/', '', $linia);
            if ($this->findX($linia, $wyrazenie))
            { // zmienna zawiera wartość zmiennej pobranej z polecenia (np. z
              // echo "zmienna")
                $zmienna = $this->cutPhp($this->findX($linia, $wyrazenie));
                // dla znalezionego odpowiednika w javie
                // wstawiamy zawrtosc z echo
                $plik .= $this->addJava($zmienna, $this->JavaRegexTab[$i]) . "\n";
            } else
                $plik .= $linia;
        }
        return $plik; // .= "\n}\n}";
    }
}