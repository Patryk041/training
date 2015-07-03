<?php
echo "\n\n";

	function jake_substr($text, $count)
	{
		$result = '';
		for ($i = $count; $i <= strlen($text); $i++)
		{
			$result.=$text[$i];
		}
		
		return $result;
	}
	
	echo jake_substr("testmoj", 3);
	echo ("\n");
	
	function jake_strlen($text)
	{
		$counter = 0;
		
		while(isset($text[$counter]))
		$counter++;

		return $counter;
	}
	
	echo jake_strlen("Kuba");	
