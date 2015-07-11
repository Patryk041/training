<?php

class StringInString extends StringLenght implements IOperation
{
	protected  $size_subject;
	protected  $size_seek;
	
	
	protected function CompareString($subject, $seek)
	{
		for($i = 0; $i < $this->size_subject; $i++)
		{
			if(Dziara_substr2($subject, $i, $this->size_seek) == $seek)
			{
				return true;
			}
		}
		
		return false;
	}
	protected function RunChecking($subject, $seek)
	{
		$this->CalculateLength($subject, $seek);
		
		return $this->CompareString($subject, $seek);
	}
	
	public function StartChecking($subject, $seek)
	{
		return $this->RunChecking($subject, $seek);
	}
}

