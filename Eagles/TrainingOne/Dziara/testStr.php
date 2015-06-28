<?php
	require_once '../GhostRider/ReadDirectoriesFiles.php';
	$testStrlenValues = array(
			array('test', 4),
			array('natalia', 7),
			array('bartek', 6),
	);

	function CreateFunctinoName($directory)
	{
		$tab = array();
		$handle = opendir($directory);
	
		while($katalog = readdir($handle))
		{
			if(is_dir($directory.$katalog) && $katalog != '.' && $katalog != '..' && $katalog != 'GhostRider')
			{
				$tab[] = $katalog.'_strlen';
			}
		}
	
		return $tab;
	}

	//var_dump($fucntnioName);
	
	function DziaraTestStrlen(&$testStrlenValues)
	{
		$fucntnioName = CreateFunctinoName('../');

		foreach ($fucntnioName as $key => $value)
			{
				echo $value. "()\n";
				foreach ($testStrlenValues as $keyTestStrVal)
				{
					
					$result = $value($keyTestStrVal[0]);
					
					if($result == $keyTestStrVal[1])
					{
						echo 'poprawny wynik,  ' . $keyTestStrVal[0] . ' -> ' . $keyTestStrVal[1] . "\n";
					}
					else
					{
						echo 'zly wynik: '. $result .' dla '. $keyTestStrVal[0] .  "\n";
					}
				}
			}
	}	

	

	ReadDirectory('../');

	DziaraTestStrlen(&$testStrlenValues);

