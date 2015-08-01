<?php


function tomekL_reverse($text)
{

	$output = "";

	for($i=(strlen($text)-1); $i >= 0; $i--)
	{
		$output .= $text[$i];
	}

	return $output."\n";
}


echo tomekL_reverse("natalia");


function tomekL_substring($text, $miejsce, $dlugosc)
{

}