<?php
	require_once '../GhostRider/ReadDirectoriesFiles.php';
	
	$testStrlenValues = array(
			array('test', 4),
			array('natalia', 7),
			array('bartek', 6),
	);
	
	$testSubStrValues = array(
			array('test', 2, "te"),
			array('natalia', 5, "natal"),
			array('bartek', 3, "bar"),
	);
	
	$functionStrLen = array(
		"Dziara_strlen",
		"Dziusio_substr",
		"jake_substr",
		"ObywatelGCC_strlen",
		"Kollwing_strlen",
		"pwltt_str",
		"Rudi_strlen",
		"Vernathic_strlen",
	);
	$functionSubStr = array(
		"Dziara_substr",
		"Dziusio_strlen",
		"jake_strlen",
		"ObywatelGCC_substr",
		"Kollwing_substr",
		"pwltt_substring",
		"Rudi_substr",
		"Vernathic_substr",
	);

	ReadDirectory('../'); //wywołanie require do wszystkich plików

	
	function ObywatelGCCTestStrLen()
	{
		global $functionStrLen, $testStrlenValues;
		
		foreach ($functionStrLen as $key => $funcName)
		{
			foreach ($testStrlenValues as $strlenKey => $strlenValue)
			{
				$result = $funcName($strlenValue[0]);
				if ($result == $strlenValue[1])
				{
					echo $func . ' zwrocila poprawny wynik, ' . $result . "\n";
				}
				else
				{
					echo $func . ' zwrocila niepoprawny wynik, ' . $result . "\n";
				}
			}
		}
	}
	
	function ObywatelGCCTestSubStr()
	{
		global $functionSubStr, $testSubStrValues;
	
		foreach ($functionSubStr as $key => $funcName)
		{
			foreach ($testSubStrValues as $strlenKey => $subStrValue)
			{
				$result = $funcName($subStrValue[0], $subStrValue[1]);
				if ($result == $subStrValue[2])
				{
					echo $func . ' zwrocila poprawny wynik, ' . $result . "\n";
				}
				else
				{
					echo $func . ' zwrocila niepoprawny wynik, ' . $result . "\n";
				}
			}
		}
	}
	echo "\n\n START OGCC TESTS\n\n";
	ObywatelGCCTestStrLen();
	ObywatelGCCTestSubStr();
	