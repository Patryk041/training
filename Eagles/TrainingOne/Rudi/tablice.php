<?php

echo "tablica wejsciowea: \n";
$input=array("PiErWSzy"=>1,"DrUGI"=>4,"TRZEci"=>3);
print_r($input);


echo "\n\narray_change_key_case():\n";
print_r(array_change_key_case($input,CASE_UPPER));


echo "\n\narray_chunk()\n";
print_r(array_chunk($input,2));


echo "\n\narray_change_key_case():\n";
print_r(array_change_key_case($input));


