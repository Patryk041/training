<?php
interface Identity 
{

	function __construct(Numbers $number);
	function GetSexValue($idNumber);
	function PersonSex($idNumber);

	static function CheckMe($idNumber);

	

}