<?php

    function OpenFile($filePath)
    {
        set_include_path(get_include_path() . PATH_SEPARATOR . '../');
        //$zmienna = file_get_contents($filePath);
        require_once $filePath;
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