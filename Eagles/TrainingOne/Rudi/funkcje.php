<?php
function Rudi_strlen($text) {
	$counter = 0;
	while ( isset ( $text [$counter] ) )
		$counter ++;
	
	return $counter;
}

function Rudi_substr($text, $start) {
	$wynik = '';
	
	for($i = 0; $i < $start; $i ++) {
		$wynik .= $text [$i];
	}
	return $wynik;
}

function Rudi_getend($text, $count)
{
	$wynik = '';
	$lenght=Rudi_strlen($text);
	for($i = $lenght-$count; $i < $lenght; $i ++) {
		$wynik .= $text[$i];
	}
	return $wynik;
}
 /*
echo Rudi_strlen ( "hahah" );
echo "\n";
echo Rudi_substr ( "12345678", 4 );
echo "\n";
echo Rudi_getend ("1234567",4);

testy, aby nie zakłucały requirow
*/