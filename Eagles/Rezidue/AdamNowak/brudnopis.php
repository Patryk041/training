<?php




























public function execute()
{
    $this->openFile();
    $this->endLineCharDelete();
    $this->getFileContent();
    $this->variablesInMethods();
//        foreach ($this->arrayFromFile as $lol) {
//            echo '<br>' . $lol;
//        }
    echo '<br>'.$this->PrepMethodSceleton;
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
class PrepareMethods extends PHPCode
{

    public $PrepMethodSceleton;
    public $keyWordMap = ['public', 'private', 'protected '];

    function __construct($fileName)
    {
        $this->fileName = $fileName;

    }

    public function getFileContent()
    {

        $dane = fread(fopen($this->fileName, "r"), filesize($this->fileName));

        $this->PrepMethodSceleton = $dane;
    }

    public function variablesInMethods()
    {

        $prep = str_replace(';', '', $this->PrepMethodSceleton);
        $this->PrepCode = $prep;
        if (strstr($this->PrepMethodSceleton, 'return')) {
            $this->PrepCode = str_replace('()', '()-> VariableType', $this->PrepMethodSceleton);
        }
        for ($i = 0; $i < count($this->keyWordMap); $i++) {
            $this->PrepCode = str_replace($this->keyWordMap[$i], ' ', $this->PrepMethodSceleton);
        }

        $findVarInMethod = strpos(($this->PrepMethodSceleton), '$');
        $this->PrepCode = str_replace('$', '', $this->PrepMethodSceleton);
        $this->PrepCode = str_replace('function', 'func', $this->PrepMethodSceleton);


    }

}
//////////////
<?php

require_once(__DIR__ . '/IphpSwiftconvert/IphpSwiftconvert.php');

abstract class PHPCode implements IphpSwiftConvertGetters, IphpSwiftConvert
{
    public $fileName;
    public $arrayFromFile;
    public $endLinePHP = array(";\r\n", ";\n", ";\r");
    public $endLineSwift = array("\r\n", "\n", "\r");



    function openFile()
    {
        $this->arrayFromFile = file($this->fileName);
    }

    function addImport()
    {
        $importFoundation = 'import Foundation';
        $importUIKit = 'import UIKit';
        array_unshift($this->arrayFromFile, $importFoundation);
        array_unshift($this->arrayFromFile, $importUIKit);
    }

}

class PrepareFields extends PHPCode
{
    public $prepFields;

    function __construct($fileName)
    {
        $this->fileName = $fileName;
    }

    function setprepFields()
    {
        $this->prepFields = $this->arrayFromFile;
    }

    function endLineCharDelete()
    {
        $newArray = [];
        $array = $this->arrayFromFile;
        for ($i = 0; $i < count($array); $i++) {
            $new_element = str_replace($this->endLinePHP, $this->endLineSwift, $array[$i]);
            array_push($newArray, $new_element);
        }
        $this->prepFields = $newArray;
    }

    function varDeclarationConvert()
    {
        $newArray = [];
        $array = $this->prepFields;
        for ($i = 0; $i < count($array); $i++) {
            $new_element = str_replace('$', 'var ', $array[$i]);
            array_push($newArray, $new_element);
        }
        $this->prepFields = $newArray;
    }

}

class PrepareMethodsSceleton extends PHPCode
{


    public $prepMethods;

    function __construct($fileName)
    {
        $this->fileName = $fileName;
    }

    function setprepMethods()
    {
        $this->prepMethods = $this->arrayFromFile;
    }

    function endLineCharDelete()
    {
        // TODO: Implement endLineCharDelete() method. (except for loop)
        $newArray = [];
        $array = $this->prepMethods;
        for ($i = 0; $i < count($array); $i++) {
            $new_element = str_replace($this->endLinePHP, $this->endLineSwift, $array[$i]);
            array_push($newArray, $new_element);
        }
        $this->prepMethods = $newArray;
    }

    function varDeclarationConvert()
    {
        // TODO: Implement varDeclarationConvert() method.
        // $strposdolar = strpos();
    }

}


$fields = new PrepareFields('code');
$fields->openFile();
$fields->addImport();
$fields->endLineCharDelete();
$fields->varDeclarationConvert();

foreach ($fields->prepFields as $val) {
    echo '<br>' . $val;
}
echo '<hr>';
$methods = new PrepareMethodsSceleton('methods');
$methods->openFile();
$methods->setprepMethods();
$methods->endLineCharDelete();
foreach ($methods->prepMethods as $val) {
    echo '<br>' . $val;
}
