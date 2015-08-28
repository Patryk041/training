<?php
require_once "./interfaces/IPerson.php";
require_once "./classes/Person.php";



require_once "./classes/Person_English.php";
require_once "./classes/Person_Polish.php";


$Polish = new Person_Polish("Polish", '81092210492');
$English = new Person_English("English", "AA111111AA" );

$tab = array($Polish, $English);


foreach($tab as $values)
{
    echo $values->getSex()."\n";

    echo $values->validate()."\n";

    echo $values->getNationality()."\n";

    echo $values->getNationalNumber()."\n";

}

