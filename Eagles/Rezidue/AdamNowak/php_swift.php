<?php

include(__DIR__ . '/IphpSwiftconvert/IphpSwiftconvert.php');

abstract class PHPCode// implements IphpSwiftConvertGetters, IphpSwiftConvert
{
    public $arrayFromFile;
    public $fileName;

    function openFile()
    {
        $this->arrayFromFile = file($this->fileName);
    }

    function endLineCharDelete()
    {
        $newArray = [];
        $array = $this->arrayFromFile;
        $count = count($array);
        $changefrom = array(";\r\n", ";\n", ";\r");
        $changeto = array("\r\n", "\n", "\r");
        for ($i = 0; $i < $count; $i++) {
            $new_element = str_replace($changefrom, $changeto, $array[$i]);
            array_push($newArray, $new_element);
        }
        $this->arrayFromFile = $newArray;
    }

    function convertVariableDeclaration()
    {
        $newArray = [];
        $array = $this->arrayFromFile;
        $count = count($array);
        for ($i = 0; $i < $count; $i++) {
            $changefrom = array("$");
            $changeto = array("var ");
            for ($i = 0; $i < $count; $i++) {
                $new_element = str_replace($changefrom, $changeto, $array[$i]);
                array_push($newArray, $new_element);
            }
        }
        $this->arrayFromFile = $newArray;
    }

    function addImport()
    {
        $fileNewContent = 'import Foundation' . '\n';
        $f = $this->fileName;
        $content = file_get_contents($f);
        file_put_contents($f, $fileNewContent . substr($content, 0));
    }
}

class PreparedCode extends PHPCode
{
    public $PrepCode;

    function __construct($fileName)
    {
        $this->fileName = $fileName;

    }

    public function execute()
    {

        $this->openFile();
        $this->endLineCharDelete();
        $this->convertVariableDeclaration();
    }

}

$instance = new PreparedCode('code');
$instance->execute();

foreach ($instance->arrayFromFile as $lol) {
    echo '<br>' . $lol;
}

