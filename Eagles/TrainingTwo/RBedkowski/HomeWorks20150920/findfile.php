<?php



function FindFileWithExtension($extension)
{
foreach (glob("*.".$extension) as $filename) 
	echo $filename . "\n";
}

FindFileWithExtension("php");