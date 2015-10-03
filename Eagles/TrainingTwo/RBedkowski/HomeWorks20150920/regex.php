<?php
$tekst1 ="ggjkjkljhhkabc1w3e";
$tekst2 = "hgsjehdcfhjabciuoyiw4";

$reg1 = '*.abc[^1]*';

function regex ($reg , $tekst)
{	
	if (preg_match($reg, $tekst, $matches)) 
		return true;
	else return false;
		
}

if (regex($reg1, $tekst2))
	echo "Ciag znaleziony";
else 
	echo "Ciag nie odnaleziony";