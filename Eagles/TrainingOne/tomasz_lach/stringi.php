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


function tomekL_substring($text, $count)
{
	$output = "";

	for($i = 0; $i < $count; $i++)
	{
		$output .= $text[$i];
	}
	return $output."\n";
}

echo tomekL_substring("Edward", 4);

function tomekL_strlen($text)//isset
{
	$output = 0;
	for($i=0; isset($text[$i]); $i++)
	{
		$output = $i+1;//bo elementy w tablicy indeksowane są od zera
	}

	return $output."\n";

}

echo tomekL_strlen("abcdefghij");
echo tomekL_strlen("");