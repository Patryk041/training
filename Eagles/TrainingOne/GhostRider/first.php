<?php
echo "\n\n";
	
	
	function  GhostRider_reverse($text)
	{
		$wynik = '';
		
		for ($i = strlen($text) - 1; $i >= 0; $i--)
		{
			$wynik .= $text[$i];
			//$wynik = $wynik . $text[$i];
		}
		
		return $wynik;
	}
	
	//function nick_substr($text, $count);
	//function nick_strlen($text); //isset
	
	
	// substr strlen
	echo GhostRider_reverse('natalia');
	$testowaZmienna = 'GhostRider_reverse';
	echo $testowaZmienna('bartek');