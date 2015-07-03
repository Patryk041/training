<?php

    function OpenFile($filePath)
    {
        //$zmienna = file_get_contents($filePath);
        
        //echo $zmienna;
    }

    function ReadDirectory($directory)
    {
        $handle = opendir($directory);
        
        while($katalog = readdir($handle))
        {
            //echo $katalog."\n";
            if (is_dir($directory.$katalog) && $katalog != '.' && $katalog != '..'){
                ReadDirectory($directory.$katalog);
            }
            //echo 'RIDER: '.$directory.'/'.$katalog."\n";
            if (is_file($directory.'/'.$katalog))
            {
                OpenFile($directory.'/'.$katalog);
            }
        }
    
    }
    
    ReadDirectory('../');
    //ReadDirectory('../Dziara');
    //var_dump($katalogi);