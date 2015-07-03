<?php
    set_include_path(get_include_path() . PATH_SEPARATOR . '../');
    //require_once 'GhostRider/ReadDirectoriesFiles.php';
    
    
    $functionNames = array(
            array('strlen' => 'Dziara_strlen', 'substr' => 'Dziara_substr'),
            array('strlen' => 'pwltt_strlen', 'substr' => 'pwltt_substr'),
            array('strlen' => 'ObywatelGCC_strlen', 'substr' => 'ObywatelGCC_substr'),
            array('strlen' => 'Vernathic_strlen', 'substr' => 'Vernathic_substr'),
            array('strlen' => 'jake_strlen', 'substr' => 'jake_substr'),
            array('strlen' => 'Kollwing_strlen', 'substr' => 'Kollwing_substr'),
    );
    
    
    $functionParameters = array(
            'stringParam' => array('Natalia', 'Kazik', 'Owieczki hasają po łące.'),
            'substrCount' => array(3, 4, 12)
    ); 
    
    
    function OpenFile($filePath)
    {
        require_once $filePath;
    }
    
    
    function ReadDirectory($directory)
    {
        $handle = opendir($directory);
    
        while($katalog = readdir($handle))
        {
            echo $katalog."\n";
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
    
    
    function TestStrlen($functionName, $functionParameter)
    {
        //here test $functionName with given $functionParameters
        
        $functionResult =  $functionName($functionParameter);
        
        if($functionResult == strlen($functionParameter))
        {
            echo "Function ". $functionName . " works fine.";
        }
        else
        {
            echo "Dear programmer, your function called ". $functionName . " doesn't work very well.";
        }
    }
    
    
    function RunTests_strlen()
    {
        //here run TestStrlen for each strlen function in $functionNames array
        
        foreach ($functionNames as $key => $value)
        {
            $fnName = $value['strlen'];
            foreach ($functionParameters['stringParam'] as $k => $v)
            {
                TestStrlen($fnName, $v);
            }
        }
    }
    
    RunTests_strlen();