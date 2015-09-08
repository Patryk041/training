<?php
/**
 * Created by PhpStorm.
 * User: adam
 * Date: 9/8/2015
 * Time: 2:34 PM
 */
require_once(__DIR__ . '/CodeConverter.php');

class ConvertCodeTo extends CodeConverter
{

    public $LanguageMap = [1=>'PHP',2=>'PHPToCPP',3=>'PHPToJava',4=>'PHPToSwift'];
    /**
     * @param string $source
     * @param $currentLanguage
     * @param $desiredLanguage
     * @return mixed
     */
    public function GetResultingClass($source, $currentLanguage, $desiredLanguage){

        $convert = $this->LanguageMap[$currentLanguage].' to => '.$this->LanguageMap[$desiredLanguage];
        echo $convert.' || z pliku  = > '.$source;

    }
}


$ob = new ConvertCodeTo();
$ob->GetResultingClass('code',1,4);
