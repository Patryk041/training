<?php
class MyDate
{
	protected $months = array(
			0,
			1  => 31,
			2  => 28,
			3  => 31,
			4  => 30,
			5  => 31,
			6  => 30,
			7  => 31,
			8  => 31,
			9  => 30,
			10 => 31,
			11 => 30,
			12 => 31
		);

	
	public function check($date = array())
	{
		$index = (intval($date['month']) % 20 <= 12)? intval($date['month']) % 20 : 0;
		//leap year
		if(intval($date['year']) % 4 == 0)    $this->months[2] += 1;
		//ordinary date
		if($this->months[$index]>=$date['day'] && $date['day'] > 0 )
			return true;
		else 
			return false;

	}
}

?>