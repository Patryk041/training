<?php

class LettersInString extends StringLenght implements IOperation
{
	private $sorted_seek;
	private $sorted_subject;
	protected  $size_subject;
	protected $size_seek;
	
		
	protected function SortString($subjec, $seek)
	{
		$this->sorted_subject= SortString::Sort($subjec);
		$this->sorted_seek = SortString::Sort($seek);
	}
	protected function CompareElement($seek)
	{
		for ($i = 0; $i < $this->size_subject; $i++)
		{
			if(Dziara_substr2($this->sorted_subject, $i, Dziara_strlen($seek)) == $seek)
			{
				return true;
			}
		}
		return false;
	}
	
	protected function CompareString()
	{
		$tmp_string = '';
		
		for ($i = 0; $i < $this->size_seek; $i++)
		{
			
			$tmp_string .= $this->sorted_seek[$i];
			if($this->sorted_seek[$i] != $this->sorted_seek[$i+1])
			{
				if(!$this->CompareElement($tmp_string))
				{
					return false;
				}
				$tmp_string = '';
			}
		}
		return true;
	}
	
	protected function RunChecking($subject, $seek)
	{
		$this->SortString($subject, $seek);
		$this->CalculateLength($subject, $seek);
		
		return $this->CompareString();
	}
	
	public function StartChecking($subject, $seek)
	{
		return $this->RunChecking($subject, $seek);
	}
	
}