<?php
    set_include_path(get_include_path() . PATH_SEPARATOR . '../');
    require_once 'GhostRider/ReadDirectoriesFiles.php';
$testElemetss = Array('Dziarastrlen',
		'Dziusio_strlen',
		'pwltt_str',
		'Vernathic_strlen',
		'jake_strlen',
		'Kollwing_strlen',
		'Rudi_strlen'
		);
$testStrlenValuess = array(
		array('test', 4),
		array('natalia', 7),
		array('andrzej', 7),
		array('zbychu', 6),
		array('ja', 6),
		array('trampek', 6),
		array('elf', 6),
		);



	
	
		for($i=0;isset($testElemetss);$i++)
		{
			for($j=0;$j<7;$j++)
			{
				echo $testElemetss[i]($testStrlenValuess[0]);
			}
		
			
			
		}
		


	
	ReadDirectorys('../');
