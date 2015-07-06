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
	function IsStringLettersInString($subject, $seek)
	{
		SortTable($subject);
		SortTable($seek);
		
		$len=Dziusio_strlen($seek);
		$len2=Dziusio_strlen($subject);
		$temp=0;
		$j=0;
		$k=0;
		for($i=0;$i<$len;$i++)
		{
			for($j=$k;$j<$len2;$j++)
			{
			
			
			
				if((int)$subject[$j]==(int)$seek[$i])
				{
					
					$temp++;
					$k=$j;
					if($len==$temp)
					{
						return true;
					}
				}
			
			}
		}
		return false;
		
		
	}

	// true: beata ataeb, aateb,
	// false: beata ataeba, aatebb, aaet
	function IsAnagram($subject, $seek)
	{
		SortTable($subject);
		SortTable($seek);
		if ($subject==$seek)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	// return array(true, true, true)
	function CheckStrings($subject, $seek)
	{
		return array(IsStringInString($subject, $seek), IsStringLettersInString($subject, $seek), IsAnagram($subject, $seek));
	}
}