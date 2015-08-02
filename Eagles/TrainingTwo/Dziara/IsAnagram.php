<?php

class IsAnagram implements IOperation
{
	protected function CompareString($subject, $seek)
	{
		return SortString::Sort($subject) == SortString::Sort($seek);		
	}
	
	public function StartChecking($subject, $seek)
	{
		return $this->CompareString($subject, $seek);
	}
}
