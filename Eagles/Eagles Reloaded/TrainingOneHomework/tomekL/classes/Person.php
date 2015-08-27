<?php

require_once "../interfaces/IPerson.php";

abstract class Person implements IPerson 
{
	function getNationality();
	
	function getSex();

	function getAge();

}


$person = new Person();
