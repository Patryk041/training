<?php

class test{
	
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
$testVar->showMessage('dupa');
?>