<?php

require_once 'ISex.php';

abstract  class human implements ISex
{
	protected $dayOfBirth;
	protected $monthOfBirth;
	protected $yearOfBirth;
	
	public function cut($string, $start, $lenght)
	{
		return substr($string, $start, $lenght);
	}
	
	public abstract function sexOfPerson($per, $str);
}

class man extends human
{
	public function sexOfPerson($per, $str)
	{
		$this->dayOfBirth = $this->cut($str, 4, 2);
		$this->monthOfBirth = $this->cut($str, 2, 2);
		$this->yearOfBirth = $this->cut($str, 0, 2);
		$sprMonth = intval($this->monthOfBirth);
		$sprYear = intval($this->yearOfBirth);
		$sprDay = intval($this->dayOfBirth);
		if ($sprMonth < 1 || $sprMonth > 12 || $sprMonth==2 && $sprDay > 29 || $sprDay>31 || $sprDay <1)
		{	//oczywiscie warunek moglby byc dluzszy, ale nie chce mi sie sprawdzac, ktore msc maja ile dni
			echo "=====ZLY PESEL!!=====\n";
		}
		else 
		{
		echo "i am MAN, my date of birth:  ";
		echo $this->dayOfBirth . "." .$this->monthOfBirth . "." . $this->yearOfBirth . "\n";
		}
	}
}


class woman extends human
{
	public function sexOfPerson($per, $str)
	{
		$this->dayOfBirth = $this->cut($str, 4, 2);
		$this->monthOfBirth = $this->cut($str, 2, 2);
		$this->yearOfBirth = $this->cut($str, 0, 2);
		$sprMonth = intval($this->monthOfBirth);
		$sprYear = intval($this->yearOfBirth);
		$sprDay = intval($this->dayOfBirth);
		if ($sprMonth < 1 || $sprMonth > 12 || $sprMonth==2 && $sprDay > 29 || $sprDay>31 || $sprDay <1)
		{	//oczywiscie warunek moglby byc dluzszy, ale nie chce mi sie sprawdzac, ktore msc maja ile dni
			echo "=====ZLY PESEL!!=====\n";
		}
		else 
		{
		echo "i am WOMAN, my date of birth:  ";
		echo $this->dayOfBirth . "." .$this->monthOfBirth . "." . $this->yearOfBirth . "\n";
		
		}	
	}
}

class addPeople
{
	private $sexMap;

	function people($arrayOfPeaple)
	{
			foreach ($arrayOfPeaple as $key => $str)
			{
					$sex = human::cut($str, 9, 1);
	
					if ($sex%2==0)
					{
						 $this->sexMap[$sex] = new woman($str);
					}
					else
					{
						$this->sexMap[$sex] = new man($str);
					}
				
			 if(isset($this->sexMap[$sex]))
                                {
                                        $this->ad1Person($this->sexMap[$sex], $str);
                                }                       
			}
	}
	
	function  ad1Person($per, $str)
	{
		$per->sexOfPerson($per, $str);
	}	
}

$people = new addPeople();
$people->people(array (
		'88000001459',
		'78000201469',
		'90010201419',
		'88010201429',
		'88010201439', /*
		'88010201449',
		'89010201459',
		'85010201469',
		'44010201479',
		'98010201489',
		'78010201499',		*/
		));

		