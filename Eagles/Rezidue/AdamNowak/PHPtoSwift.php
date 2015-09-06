<?php
/**
 * Created by PhpStorm.
 * User: adam
 * Date: 9/6/2015
 * Time: 5:24 PM
 */
require_once(__DIR__ . '/CodeConverter.php');

class PHPtoSwift extends CodeConverter
{
    public $swiftCLass;
    public $source;
    public $currentLanguage = 1;
    public $desiredLanguage = 33;
    public $fileContent;
    public $phpKeyWords = array('private', 'public', 'protected', 'abstract');
    //class chunks
    public $prepHead = [];
    public $prepFields = [];
    public $prepMethod = [];

    //class chunks


    function __construct($fileName)
    {
        $this->source = $fileName;
    }

    function openFile()
    {
        $this->fileContent = file($this->source);
    }

    function addImportToContent()
    {
        $importFoundation = 'import Foundation';
        $importUIKit = 'import UIKit';
        array_unshift($this->fileContent, $importFoundation);
        array_unshift($this->fileContent, $importUIKit);
    }

    function endLineDelete()
    {
        $newArray = [];
        $array = $this->fileContent;
        for ($i = 0; $i < count($array); $i++) {
            $new_element = str_replace(';', '', $array[$i]);
            array_push($newArray, $new_element);
        }
        $this->fileContent = $newArray;
    }

    function phpKeyWordsDelete()
    {
        $newArray = [];
        $array = $this->fileContent;
        for ($i = 0; $i < count($array); $i++) {
            $new_element = str_replace($this->phpKeyWords, '', $array[$i]);
            array_push($newArray, $new_element);
        }
        $this->fileContent = $newArray;
    }

    function getClassHead()
    {
        $array = $this->fileContent;
        $fieldsArray = [];
        for ($i = 0; $i < count($array); $i++) {

            if (strstr($array[$i], '{')) {
                break;
            } else {
                array_push($this->prepHead, $array[$i]);
            }

        }
                array_push($this->prepHead,'{');
        return $this->prepHead;
    }

    function getFieldsFromClass()
    {
        $array = $this->fileContent;
        $fieldsArray = [];
        for ($i = 0; $i < count($array); $i++) {
            if (strstr($array[$i], 'function') || strstr($array[$i], 'func')) {
                break;
            } else {
                $new_element = strstr($array[$i], '$');
                array_push($this->prepFields, $new_element);
            }
        }
        return $this->prepFields;
    }

    public function fieldsDeclarationConvert()
    {
        $array = $this->prepFields;
        $this->prepFields = [];
        for ($i = 0; $i < count($array); $i++) {
            $new_element = str_replace('$', 'var ', $array[$i]);
            array_push($this->prepFields, $new_element);
        }
        return $this->prepFields;
    }

    function toFuncParse()
    {
        $newArray = [];
        $array = $this->fileContent;
        for ($i = 0; $i < count($array); $i++) {
            $new_element = str_replace('function', 'func', $array[$i]);
            array_push($newArray, $new_element);
        }
        $this->fileContent = $newArray;
    }

    public function GetResultingClass($source, $currentLanguage, $desiredLanguage)
    {
        return $this->swiftCLass;
    }
}

$swift = new PHPtoSwift('code');
//file:
$swift->openFile();
$swift->addImportToContent();
$swift->endLineDelete();
$swift->phpKeyWordsDelete();
//prepare Fields:
$swift->getFieldsFromClass();
$swift->fieldsDeclarationConvert();
//prepare Head of Class declaration
$swift->getClassHead();

$swift->toFuncParse();

echo 'head of class';
foreach ($swift->prepHead as $lokurwa) {
    echo '<br>' . $lokurwa;
}
echo '<hr>';
//echo fields:
echo 'fields';
foreach ($swift->prepFields as $lokurwa) {
    echo '<br>' . $lokurwa;
}
echo '<hr>';
//echo fields:
echo 'Methods';
foreach ($swift->prepMethod as $lokurwa) {
    echo '<br>' . $lokurwa;
}
echo '<hr>';


echo 'Whole file';
//allfile content:
foreach ($swift->fileContent as $swiftFields) {
    echo '<br>' . $swiftFields;
}
//allfile content: