<?php
require_once 'first.php';
    echo "\n\n".GhostRider_reverse('tdsghdg')."\n\n";

    $tablica[0] = '5';
    
    $tablica[1] = 6;
    
    $tablica['cokolwiek'] = array(1, 2, 'jazda' => array(4,5,9));
    
    //$table = array();
    
    $szanujacasie = array(23, 'index1' => 'wpis', 'index2' => 234, 'index1' => 'rider');
    
    $szanujacasie['cyrk'] = $szanujacasie;
    
    $szanujacasie['test'] = 88;
    
    function naszarekurencja($szanujacasie)
    {
        foreach ($szanujacasie as $key => $value)
        {
            echo $key . ' => ' . $value . "\n";
            if (is_array($value))
            {
                naszarekurencja($value);
            }
        }
    }
    naszarekurencja($szanujacasie);
    
    
    //$szanujacasie[7] = 786;
    //$szanujacasie[4] = 4325432;
    //$szanujacasie[2] = 4325432;
    //$szanujacasie[] = 888;
    
    var_dump($szanujacasie);