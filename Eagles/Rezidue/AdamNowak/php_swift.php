<?php

include(__DIR__ . '/IphpSwiftconvert/IphpSwiftconvert.php');

abstract class PHPCode implements IphpSwiftConvertGetters, IphpSwiftConvert
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
        $fileNewContent = 'import Foundation' ;
        $f = $this->fileName;
        $content = file_get_contents($f);
        file_put_contents($f, $fileNewContent . substr($content, 0));
    }

}

class PrepareFields extends PHPCode
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

class PrepareMethods extends PHPCode
{

    public $PrepCode;
    public $keyWordMap = ['public','private','protected '];

    function __construct($fileName)
    {
        $this->fileName = $fileName;

    }

    public function getFileContent(){

        $dane = fread(fopen($this->fileName, "r"), filesize($this->fileName));

        $this->PrepCode = $dane;
    }

    public function variablesInMethods(){

//        $findVarInMethod = strpos(($this->PrepCode),'$');
//        $this->PrepCode = str_replace('$','',$this->PrepCode);
//        $this->PrepCode = str_replace('function','func',$this->PrepCode);
//        if (strstr($this->PrepCode,'return')){
//            $this->PrepCode = str_replace('()','()-> VariableType',$this->PrepCode);
//        }
//        for ($i=0; $i<count($this->keyWordMap);$i++){
//            $this->PrepCode = str_replace($this->keyWordMap[$i],' ',$this->PrepCode);
//        }
        $findDolar = strpos(($this->PrepCode),'$');
        $findEqual = strpos(($this->PrepCode),';');
        $count = $findEqual-$findDolar;
        $var = substr($this->PrepCode,$findDolar,$count);



    }
    public function execute()
    {
        $this->openFile();
        $this->endLineCharDelete();
        $this->getFileContent();
        $this->variablesInMethods();
        foreach ($this->arrayFromFile as $lol) {
            echo '<br>' . $lol;
        }
        echo '<br>'.$this->PrepCode;
    }
}

$instance = new PrepareMethods('methods');
$instance->execute();
echo '<br>'.$instance->getFileContent();




