<?php


$records = array (

	array(
		'id'=>1 ,
		'name'=>'Piotr',
		'surname'=>'Tojak'
	),

	array(
		'id'=>2 ,
		'name'=>'Marek',
		'surname'=>'Kondrat',
	),
	array(
		'id'=>3 ,
		'name'=>'szatan',
		'surname'=>'pospolity',
	),
	array(
		'id'=>666 ,
		'name'=>'bug',
		'surname'=>'niemilowski',
	),
	array(
		'id'=> 88,
		'name'=>'maliusz',
		'surname'=>'marekotskow',
	)
);

$a= array('green','red','yellow');
$b = array('avocado','apple','pear');
echo "array_column():\n";
print_r(array_column($records,'name','id'));

echo "\n\narraycombine():";

print_r(array_combine($a,$b));

