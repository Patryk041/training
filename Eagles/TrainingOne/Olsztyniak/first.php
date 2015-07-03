<?php
function Olsztyniak_reverse($text)
{
	$wynik = '';
	
	for ($i = strlen($text)-1; $i >= $text; $i--)
	{
		$wynik .= $text[$i];
		
	}
	
	return $wynik;
}


function Olsztyniak_strlen ($text)
{
	$wynik = '';
	for ($i = 0; isset($text[$i]); $i++) {
		$wynik++;
	}
	return $wynik;
	
}

function Olsztyniak_substr($text, $count)
{
	$wynik = '';
	for($i = 0; $i < $count; $i++) {
		$wynik .= $text[$i];
	}
	return $wynik;
}

echo Olsztyniak_reverse('natalia');
echo '<br>';
echo Olsztyniak_strlen('natalia');
echo '<br>';
echo Olsztyniak_substr('natalia',4);