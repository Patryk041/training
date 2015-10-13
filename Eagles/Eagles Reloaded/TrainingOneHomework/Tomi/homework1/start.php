<?php
include_once 'manager.php';

$citizen = new Citizen();
$citizen->checkNumber(31077654720); // metoda w manager.php
$citizen->checkNumber(786234987);