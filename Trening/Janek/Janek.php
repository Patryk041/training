<?php
/*function kwiatek($liczba)
{
	for ($i=0;$i<strlen($liczba);$i+=2)
	{
		echo $liczba[$i];
	}
}
function auto($liczba)
{
	for ($i=0;$i<strlen($liczba);$i+=4)
	{
		echo $liczba[$i];
	}
}
function dom ($liczba)
{
	for ($i=0;$i<strlen($liczba);$i+=5)
	{
		echo $liczba[$i];
	}
}

//kwiatek('213213123')."\n";
//auto ('1231334324234')."\n";
*/
//chcemy aby z fsdafsd454354 wyciagnelo tylko liczby


$text='412214';

//$liczba [1=>'jeden', 2=>'dwa',3=>'trzy',4=>'cztery', 5=>'piec'];
for($i=0;$i <=strlen($text);$i++)
{
	ZamienLiczbeNaTekst($text[$i]);
	/*if ($text [$i]==1)
	{
		echo 'jeden'."\n";
	}
	if ($text [$i]==2)
	{
		echo 'dwa'."\n";
	}

	if ($text [$i]==3)
	{
		echo 'trzy'."\n";
	}
	if ($text [$i]==4)
	{
		echo 'cztery'."\n";
	}*/
	
}

function ZamienLiczbeNaTekst($liczba)
{
	$var= array (1=>'jeden',2=>'dwa',4=>'cztery');
	{
	echo $var [$liczba]. "\n";
	}
}