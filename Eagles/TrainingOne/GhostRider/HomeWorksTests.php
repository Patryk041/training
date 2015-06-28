<?php
    $testStrlenValues = array(
        array('test', 4),
        array('natalia', 7),
        array('bartek', 6),
    );
 		   
    
    
    $testElements = array(
        array('dir' => 'Dziara', 'file' => 'function.php', 'strlen' => 'Dziara_strlen', 'substr' => 'Dziara_substr'),
    	array('dir' => 'pwltt' , 'file' => 'test1.php', 'strlen' => 'pwltt_str', 'substr' => 'pwltt_substr'),
		array('dir' => 'ObywatelGCC', 'file' => 'first.php', 'strlen' => 'ObywatelGCC_strlen', 'substr' => 'ObywatelGCC_substr'),
        array('dir' => 'Vernathic', 'file' => 'TextOperationsVernathic.php', 'strlen' => 'Vernathic_strlen', 'substr' => 'Vernathic_substr'),
        array('dir' => 'jake', 'file' => 'first.php', 'strlen' => 'jake_strlen', 'substr' => 'jake_substr'),
    	array('dir' => 'Kollwing', 'file' => 'functions.php', 'strlen' => 'Kollwing_strlen', 'substr' => 'Kollwing_substr'),
  	 	array('dir' => 'Rudi', 'file' => 'funkcje.php', 'strlen' => 'Rudi_strlen', 'substr' => 'Rudi_substr'),
    	array('dir' => 'Dziusio', 'file' => 'test.php', 'strlen' => 'Dziusio_strlen', 'substr' => 'Dziusio_substr'),
    	array('dir' => 'Olsztyniak', 'file' => 'first.php', 'strlen' => 'Olsztyniak_strlen', 'substr' => 'Olsztyniak_substr'),
    );
    
    set_include_path(get_include_path() . PATH_SEPARATOR . '../');
    
    foreach ($testElemets as $key => $value)
    {
        require_once $value['dir']. '/'. $value['file'];
        echo $value['dir']. '/'. $value['file']."\n";
        
        foreach ($testStrlenValues as $strlenKey => $strlenValue)
        {
        
            $result = $value['strlen']($strlenValue[0]);
            
            if ($result == $strlenValue[1])
            {
                echo $value['strlen'] . ' zwrocila poprawny wynik, ' . $result . "\n";
            }
            else
            {
                echo $value['strlen'] . ' zwrocila niepoprawny wynik, ' . $result . "\n";
            }
        }
    }
    
    
