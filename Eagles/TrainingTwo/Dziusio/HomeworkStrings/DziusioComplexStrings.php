<?php
class DziusioComplexStrings extends ComplexStrings
{
	// true: beata ata, eata, ta    wyszukuje znakow seek w subject
	// false: beata aa, eb
	
 	function IsStringInString($subject, $seek)
 	{
 		$temp=0;
 		$legthStringFirst=StringLength($subject);
 		$legthStringSecond=StringLength($seek);

 		for($i=0;$i<=$legthStringFirst-$legthStringSecond;$i++)
 		{
 			if ($subject[$i]==$seek[$temp])
 			{
 				$new = Dziusio_substr_rev($subject, ($legthStringFirst-1)-$i);
 				$new1= Dziusio_substr($new,$legthStringSecond);
 				if($new1==$seek)
 				{
 					return true;
 				}
 			}
 			
 			
 		}
 		return false;
 		//
 	}
 		
 		
 		
 				
 	

	// true: beata aa, ae, ea, be, eb, ebt
	// false: beata aaa
	function IsStringLettersInString($subject, $seek);

	// true: beata ataeb, aateb,
	// false: beata ataeba, aatebb, aaet
	function IsAnagram($subject, $seek);

	// return array(true, true, true)
	function CheckStrings($subject, $seek)
	{
		return array(IsStringInString($subject, $seek), IsStringLettersInString($subject, $seek), IsAnagram($subject, $seek));
	}
}