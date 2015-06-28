<?php
    $testStrlenValues = array(
        array('test', 4),
        array('natalia', 7),
        array('bartek', 6),
    );
    
    
    
    $testElemets = array(
        array('dir' => 'Dziara', 'file' => 'function.php', 'strlen' => 'Dziara_strlen', 'substr' => 'Dziara_substr'),
    	array('dir' => 'pwltt' , 'file' => 'function.php', 'strlen' => 'pwltt_strlen', 'substr' => 'pwltt_substr'),
		array('dir' => 'ObywatelGCC', 'file' => 'first.php', 'strlen' => 'ObywatelGCC_strlen', 'substr' => 'ObywatelGCC_substr'),
        array('dir' => 'Vernathic', 'file' => 'TextOperationsVernathic.php', 'strlen' => 'Vernathic_strlen', 'substr' => 'Vernathic_substr'),
            

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
    
    