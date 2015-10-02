<?php

function spacja($liczba)
{
	for ($i=0;$i<strlen($liczba);$i++)
	{
		echo $liczba[$i];
		if (($i+1) % 4 ==0 )
		{
			echo ' ';
		}
	}









function Zamiana ($numerKonta)
	{ 
		$wynik = '';
		for ($i = 0; $i <= strlen($numerKonta); $i+=2)
		{
		$wynik .= $numerKonta[$i + 1] . $numerKonta[$i];
		}
		return $wynik;
	}	


function strzal($numerKonta) 
{
	return	spacja(Zamiana($numerKonta));
}

//echo strzal ('1234454');
