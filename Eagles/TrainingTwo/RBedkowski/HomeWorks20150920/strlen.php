<?php
$tekst1 = "12412424";
$tekst2 = "hjgyjjgfhgjgd34";
$tekst3 ="";


function StringLenght ($tekst) 
{	
	$i =0;
	while (isset($tekst[$i])){
		$i=$i+1;
	}
	return $i;
}


echo "Dlugosc ciagu wynosi : ".StringLenght($tekst2);