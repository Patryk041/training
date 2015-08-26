<?php
class Number implements Numbers
{
	
	public function AmIOdd($number)
	{
		if(($number % 2) == 0)
			return false;
		else
			return true;
	}
}
