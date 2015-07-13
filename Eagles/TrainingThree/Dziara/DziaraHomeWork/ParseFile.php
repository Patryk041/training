<?php
require_once 'File.php';

 class ParseFile
 {
     private $separator = ' ';
     private $indexOfArray = array(
         'DeviceName',
         'HomeAddress',
         'OperationType',
         'OperationHour',
         'OperationTime',
         'OperatorionEnergyUsage',
         'OperationErrors',
         'OperationExtraInfo',
        );

     private function ParseString($string)
     {
         $result = array();
         $tmpArray = explode($this->separator, $string);

         for($i = 0; isset($this->indexOfArray[$i]); $i++)
         {
             $result[ $this->indexOfArray[$i] ] = $tmpArray[$i];
         }

         return $result;
     }

     private function ParseArray($arrayContent)
     {
         $content = array(

         );

         foreach ($arrayContent as $value)
         {
             $content[] = $this->ParseString($value);
         }

         return $content;
     }

     private function Parse($path, $separator)
     {
         $this->separator = $separator;

         return $this->ParseArray( File::ReadFileTxt($path));
     }

     public function RunParse($path, $separator)
     {
         return $this->Parse($path, $separator);
     }
 }

//$test = new ParseFile();
//var_dump($test->RunParse('dane.txt', ' '));