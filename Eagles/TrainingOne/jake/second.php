<?php
    set_include_path(get_include_path() . PATH_SEPARATOR . '../');
    require_once 'GhostRider/ReadDirectoriesFiles.php';

$czymTestujemy = array(
		array('cojest', 6),
		array('natalia', 7),
		array('Jake',4)
		);

$testujemy = Array(
		'Dziusio_strlen',
		'pwltt_str',
		'Kollwing_strlen'
		'Vernathic_strlen',
		'jake_strlen',
		'Rudi_strlen'
		);

		for($n=0;isset($testujemy);$i++)
		{
			for($j=0;$j<7;$j++)
			{
				echo $testujemy[i]($czymTestujemy[0]);
			}
		}

ReadDirectorys('../');
