<?php
	require 'poland.php';
	require 'france.php';
		
		$polak1 = new personPoland("70030857974");
		$polak1->validate();
		echo $polak1->getSex();
		$polak1->getBirth();
		echo "\n";
		
		$polak2 = new personPoland("37042721585");
		$polak2->validate();
		echo $polak2->getSex()."\n";
		
		$polak3 = new personPoland("12345678901");
		$polak3->validate();
		echo "\n\n\n";
		
		
		$francuz1 = new personFrance("2870372001126");
		$francuz1->validate();
		echo $francuz1->getSex();
		$francuz1->getBirth();
		echo "\n";
		
		$francuz2 = new personFrance(1234567890);
		$francuz2->validate();
		
		
		
		
		