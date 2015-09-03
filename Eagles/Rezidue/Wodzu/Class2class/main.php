<?php

$input_test = '
class testClazz{
	
	var $valueConstructor;
	
	function __construct($valueConstructor) {
       $this->valueConstructor = $valueConstructor;
   }
	
	function showMessage ($wyraz){
        echo $wyraz;
    }
	
}

$testVar = new test(8);
$testVar->showMessage($testVar->valueConstructor);
$testVar->showMessage("dupa");
';

interface translate {
	
	function parseClass($classText);
	
	function parseFunction();
	
	function parseVariable();
	
	function parseComment();
	
	function finishBuild();
	
}

abstract class translator {
	
	var $variables = array();
	
	var $functions = array();
	
	var $className;
	
}

class phpToJavaScript extends translator implements translate{
	
	function parseClass($classText){
		
		$this->className = trim(substr(
								trim($classText),
		 						6,
		  						(strpos($classText,"{")-8)
		  						));
		  						
		while (true){
			
			
			
			
			
			
			
			break;
		}
		
	}
	
	function parseFunction(){
		
	}
	
	function parseVariable(){
		
	}
	
	function parseComment(){
		
	}
	
	function finishBuild(){
		
	}
	
	function getStringBetween($str, $from, $to)
	{
		//$toPos = strpos($sub,$to);
		$fromPosEnd = strpos($str,$from)+strlen($from);
    	$sub = substr($str, $fromPosEnd, strlen($str)-$fromPosEnd);
    	return substr($sub,0,strpos($sub,$to));
	}
	
}

$test = new phpToJavaScript();

//$input2 = "    duap a da fad ft  fd f  f dsffd     dfs d";

//echo $dupa->getStringBetween($input2, "fd", "s d");

echo $test->parseClass($input_test);

echo $test->className;

//echo $input_test;

//$input = "    duap a da fad ft  fd f  f dsffd     dfs d";
//$output = preg_replace('!\s+!', ' ', $input);

//echo $input."\n";
//echo $output;