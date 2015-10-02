<?php



function SubString($tekst, $start=0, $lenght=1)
{
	$i =0;
	$indeksStart = 0;
	$indeksEnd = 0;
	$result="";
	while (isset($tekst[$i])){
		$i=$i+1;
	}
	
	if ($start >= 0 & $start< $i)
		$indeksStart += $start -1;
	else $indeksStart = $i + $start;
	
	if ($lenght >= 0 & $lenght< $i)
		$indeksEnd = $indeksStart + $lenght;
	else $indeksEnd = $i + $lenght;
	
	for ($t=$indeksStart;$t<$indeksEnd;$t++)
	return $result.$tekst[$t];
	
}

echo "Wynik funkcji : ".SubString("abcdef",-3,1);

