<?php

require_once 'Pesel.php';
require_once 'interfaces/Person.php';

class Birth extends Pesel implements Person
{	

	private $day;
	private $month;
	private $year;

	/**
	 * cutting pesel, day,month,year
	 */
	public function __construct($pesel)
	{
		parent::__construct($pesel);

		$this->year = $this->cutPesel(0,2);
		$this->month = $this->cutPesel(2,2);
		$this->day = $this->cutPesel(4,2);

	}
	/**
	 * Checking if the day of specific month is correct
	 */
	public function validateDay()
	{
		$maxDayOfMonth = [
		'01'	=>	'31',
		'02'	=>	'29',
		'03'	=>	'31',
		'04'	=>	'30',
		'05'	=>	'31',
		'06'	=>	'30',
		'07'	=>	'31',
		'08'	=>	'30',
		'09'	=>	'31',
		'10'	=>	'30',
		'11'	=>	'31',
		'12'	=>	'30',
		];

		if($this->day < '00' || $this->day>$maxDayOfMonth[$this->month])
			return false;
		return true;
	}
	
	/**
	 * checking if the given number of month is correct
	 */
	public function validateMonth()
	{
		if($this->month<0 || $this->month>12)
			return false;
		return true;
	}

	/**
	 * from interface, printing out message f.e day:20 month: january year: 91
	 */
	public function printOut()
	{
		
		if(self::validateMonth() &&	self::validateDay())
		{
			$monthNumber = [
			'01' => 'January',
			'02' => 'February',
			'03' => 'March',
			'04' => 'April',
			'05' => 'May',
			'06' => 'June',
			'07' => 'July',
			'08' => 'August',
			'09' => 'September',
			'10' => 'October',
			'11' => 'November',
			'12' => 'December',
			];
			echo 'day: '.$this->day.' month: '.$monthNumber[$this->month].' year: '.$this->year.'<hr />';
		}
		else
		{
			echo 'wrong pesel';
		}
	}
}