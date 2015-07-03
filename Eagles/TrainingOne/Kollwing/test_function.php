<?php
	
	function ReadDirectory($directory)
    {
        $handle = opendir($directory);
        
        while($katalog = readdir($handle))
        {
            
            if (is_dir($directory.$katalog) && $katalog != '.' && $katalog != '..'){
                ReadDirectory($directory.$katalog);
            }
            
            if (is_file($directory.'/'.$katalog))
            {

            	OpenFile($directory.'/'.$katalog);
            }
        }
    
    }
	
	ReadDirectory('../');
	
	
	set_include_path(get_include_path() . PATH_SEPARATOR . '../');
	
	function OpenFile($filePath)
	{
		
		$zmienna = '';		
		for ($i=3;isset($filePath[$i]);$i++)
		{
			
			$zmienna .= $filePath[$i];
		}
		if($zmienna != '/.buildpath' && $zmienna != '/.project' && $zmienna != '.settings/org.eclipse.php.core.prefs' && $zmienna != '.settings/org.eclipse.php.core.prefs' && $zmienna != 'Rudi/.gitignore')
		{
			
			require_once  $zmienna;
		}
	}
	
//Nie wiem dlaczego nie moge dodac sciezki ze zmiennej $zmienna, po wydrukowaniu echo $zmienna, sciezka niby jest prawidlowa 
//jednak require_once nie dziala. 

// Przez to nie moge przetestowac funkcji z pozostalych plikow
    
    

	