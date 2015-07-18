<?php

$array = array(
    1 => 'costam',
    'tablica' => array('jedane', 'dwa'),
    'trzy',
    array(3=>3,
        30=>33,
        'Nowa'=>'Stara;(',
    )
);

//$strin = implode(';', $array);
function wys($array)
{
    foreach($array as $val)
    {
        if(is_array($val))
        {
            wys($val);
        }
        else
        {
           echo $val." ";
        }
    }
}
//echo $strin;

wys($array);