<?php
class ComplexStrings
{
	// true: beata ata, eata, ta    wyszukuje znakow seek w subject
	// false: beata aa, eb
 	function IsStringInString($subject, $seek);

	// true: beata aa, ae, ea, be, eb, ebt
	// false: beata aaa
	function IsStringLettersInString($subject, $seek);

	// true: beata ataeb, aateb,
	// false: beata ataeba, aatebb, aaet
	function IsAnagram($subject, $seek);

	// return array(true, true, true)
	function CheckStrings($subject, $seek)
	{
		return array(IsStringInString($subject, $seek), IsStringLettersInString($subject, $seek), IsAnagram($subject, $seek))
	}
}