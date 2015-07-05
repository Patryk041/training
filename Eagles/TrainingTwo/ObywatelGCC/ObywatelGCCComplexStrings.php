<?php
	//require_once '../GhostRider/Homework/CompexStrings.php'; //do w³asnych testów
	
	class ObywatelGCCComplexStrings extends ComplexStrings
	{
		private $seekLength;
		private $subjectLength;

		protected function IsStringInString($subject, $seek)
		{
			$currentSeekIndex = 0;
			
			for($i = 0; $i < $this->subjectLength; $i++)
			{
				if($subject[$i] == $seek[$currentSeekIndex]) { $currentSeekIndex++; }
				else { $currentSeekIndex = 0; }
				
				if($this->seekLength == $currentSeekIndex) { return true; }
			}
			return false;
		}
	
		protected function IsStringLettersInString($subject, $seek)
		{
			if($this->seekLength > $this->subjectLength) return false;
			
			$letterUsesState = array();
			for($i = 0; $i < $this->subjectLength; $i++)
			{
				$letterUses[] = false;
			}
			
			$letterUsesCount = 0;
			for($i = 0; $i < $this->seekLength; $i++)
			{
				$j = 0;
				for(; $j < $this->subjectLength; $j++)
				{
					if($seek[$i] == $subject[$j] && $letterUsesState[$j] == false)
					{
						$letterUsesState[$j] = true;
						$letterUsesCount++;
						break;
					}
				}
				if($j == $this->subjectLength) //nie znaleziono litery w subject
				{
					return false;
				}
			}
			return $letterUsesCount == $this->seekLength;
		}
	
		protected function IsAnagram($subject, $seek)
		{
			if($this->seekLength != $this->subjectLength) return false;
			return $this->IsStringLettersInString($subject, $seek);
		}
	
		public function CheckStrings($subject, $seek)
		{
			$this->seekLength = strlen($seek);
			$this->subjectLength = strlen($subject);
			
			return array($this->IsStringInString($subject, $seek), 
					$this->IsStringLettersInString($subject, $seek), 
					$this->IsAnagram($subject, $seek));
		}
	}
	