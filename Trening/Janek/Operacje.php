<?php
/*
$path= dirname(__FILE__);

$katalogi = readdir($path);

var_dump($katalogi);
*/

class tescik
{

	function petla ($cos)
	{
	for ($i=0;$i<strlen($cos);$i++)
		{
			echo $cos[$i]."\n";
		}

	}

}
