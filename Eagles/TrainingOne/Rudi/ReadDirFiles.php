<?php

require_once 'funkcje.php';


function OpenFile($plik)
{
	if(Rudi_getend($plik,4)==".php")
	 require_once "$plik";
}


function ReadDirectory($directory)
{	
	$handle = opendir($directory);
	
	while($katalog = readdir($handle))
	{
		if($katalog!="." && $katalog!="..")
	//	echo $katalog."\n";
		if(is_dir($directory.$katalog) && $katalog!='.' && $katalog!='..')
		{
			ReadDirectory($directory.$katalog);
		}
		
		if(is_file($directory."/".$katalog))
		{
			OpenFile($directory."/".$katalog);
		}
	}
}



ReadDirectory('../');