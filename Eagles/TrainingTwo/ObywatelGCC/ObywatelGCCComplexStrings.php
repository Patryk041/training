<?php
	require_once '../GhostRider/Homework/ComplexStrings.php'; //do w³asnych testów
	
	class ObywatelGCCComplexStrings
	{
		private $seekLength;
		private $subjectLength;
		// true: beata ata, eata, ta
		// false: beata aa, eb
		protected function IsStringInString($subject, $seek)
		{
			$currentSeekIndex = 0;
			
			for($i = 0; $i < $subjectLength; $i++)
			{
				if($subject[$i] == $seek[$currentSeekIndex]) { $currentSeekIndex++; }
				else { $currentSeekIndex = 0; }
				
				if($seekLength == $currentSeekIndex) { return true; }
			}
			return false;
		}
	
		// true: beata aa, ae, ea, be, eb, ebt
		// false: beata aaa
		protected function IsStringLettersInString($subject, $seek)
		{
			if($seekLength > $subjectLength) return false;
			
			$letterUsesState = array();
			for($i = 0; $i < $subjectLength; $i++)
			{
				$letterUses[] = false;
			}
			
			$letterUsesCount = 0;
			for($i = 0; $i < $seekLength; $i++)
			{
				$j = 0;
				for(; $j < $subjectLength; $j++)
				{
					if($seek[$i] == $subject[$j] && $letterUsesState[$j] == false)
					{
						$letterUsesState[$j] = true;
						$letterUsesCount++;
						break;
					}
				}
				if($j == $subjectLength) //nie znaleziono litery w subject
				{
					return false;
				}
			}
			return $letterUsesCount == $seekLength;
		}
	
		// true: beata ataeb, aateb,
		// false: beata ataeba, aatebb, aaet
		protected function IsAnagram($subject, $seek)
		{
			if($seekLength != $subjectLength) return false;
			return IsStringLettersInString($subject, $seek);
		}
	
		// return array(true, true, true)
		public function CheckStrings($subject, $seek)
		{
			$seekLength = strlen($seek);
			$subjectLength = strlen($subject);
			
			return array($this->IsStringInString($subject, $seek), 
					$this->IsStringLettersInString($subject, $seek), 
					$this->IsAnagram($subject, $seek));
		}
	}