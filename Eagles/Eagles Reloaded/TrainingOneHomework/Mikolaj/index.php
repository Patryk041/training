<?php

require_once 'numbers.interface.php';
require_once 'identity.interface.php';


class Manager
{
	private $nations = 
	array(
		9  => array('UK'),
		11 => array('Poland', 'Finland'),
	);
	public function checkAll($array)
	{
		foreach($array as $idNumber){
			$this->CheckCurrent($idNumber);
		}
	}

	function CheckCurrent($idNumber)
	{

		//$idNumber = str_replace(" ",'', $idNumber);
		$idNumber = preg_replace("/\s/", '', $idNumber);

		$matchList = $this->nations[strlen($idNumber)];
		foreach ($matchList as $country) {
			if($country::CheckMe($idNumber))
			{
				$identity = new $country(new Number);
				break;
			}
		}
		
		if(isset($identity)){
			$identity->info($idNumber);
		}else
		echo "undefined";
	}
}


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







class Poland implements Identity
{

	static $regex = '/^(\d{11})+$/';
	private $nationality = "Poland";
	private $number;

	function __construct(Numbers $number)
	{
		$this->number = $number;
	}
	public static function CheckMe($idNumber)
	{
		if(!preg_match(Poland::$regex, $idNumber))
			return false;
		$len = strlen($idNumber)-1; 

		$j=1; $checkSum=0;

		for($i= 0; $i < $len; $i++, $j+=2)
		{
			if($j>9) $j = 1; else if($j==5) $j+=2;

			$checkSum += $idNumber[$i]*$j;

		}
	

		while($checkSum >= 10)
		{
			$checkSum = $checkSum % 10;
		}

		if(($idNumber[$len]) == (10-$checkSum)%10)
			return true;
	}
	public function GetSexValue($idNumber)
	{
		return $idNumber[strlen($idNumber)-2];
	}
	public function PersonSex($idNumber)
	{
		$odd = $this->number->AmIOdd($this->GetSexValue($idNumber));
		if($odd) 
			return "Male";
		else
			return "Female";
		
	}

    public function Info($idNumber)
    {
    	echo "<b>ID</b>: <label style='color:green; font-style:italic;'>{$idNumber} </label>
    	<b>Nationality</b>: <label style='color:green; font-style:italic;'>{$this->nationality} </label>
    	<b>Sex</b>: <label style='color:green; font-style:italic;'>{$this->PersonSex($idNumber)}</label><br>";
    }
}

class UK implements Identity
{
	static $regex = '/^(?!BG|GB|NK|KN|TN|NT|ZZ)[ABCEGHJ-PRSTW-Z][ABCEGHJ-NPRSTW-Z]\d{6}[A-D]$/';
	private $nationality = "United Kingdom";
	private $sex;
	private $number;

	function __construct(Numbers $number)
	{
		$this->number = $number;
	}
	public static function CheckMe($idNumber)
	{
		if(!preg_match(UK::$regex, $idNumber))	
			return false;
		else
			return true;
	}
	public  function GetSexValue($idNumber)
	{

	}
	public function PersonSex($idNumber){

	}

    public function Info($idNumber)
    {
    	echo "<b>ID</b>: <label style='color:orange; font-style:italic;'>{$idNumber} </label>
    	<b>Nationality</b>: <label style='color:orange; font-style:italic;'>{$this->nationality} </label>
    	<b>Sex</b>: <label style='color:orange; font-style:italic;'>{$this->PersonSex($idNumber)}</label><br>";
    }
}


class Finland implements Identity
{
	static  $regex = '/\d{6}[+-A]\d{3}[0123456789ABCDEFHJKLMNPRSTUVWXY]/';

	private $nationality = "Finland";
	private $sex;
	private $number;

	function __construct(Numbers $number)
	{
		$this->number = $number;
	}	
	public static function CheckMe($idNumber)
	{
		if(!preg_match(Finland::$regex, $idNumber))
			return false;

		$control_value = "0123456789ABCDEFHJKLMNPRSTUVWXY";
		$len = strlen($idNumber)-1;
		$val = 0;

		for ($i=0; $i < $len; $i++) { 
			
			$val *= 10;
			if($i == 6) $i++;
			$val += $idNumber[$i];
		}
		$val %= 31;

		if($control_value[$val] == $idNumber[$len])
			return true;
		else 
			return false;
	}
	public  function GetSexValue($idNumber)
	{
		$len = strlen($idNumber)-1;

		return substr($idNumber, 7,3);
	}
	public function PersonSex($idNumber)
	{
		$odd = $this->number->AmIOdd($this->GetSexValue($idNumber));
		if($odd)
			return "Male";
		else
			return "Female";
	}
    public function Info($idNumber)
    {
    	echo "<b>ID</b>: <label style='color:blue; font-style:italic;'>{$idNumber} </label>
    	<b>Nationality</b>: <label style='color:blue; font-style:italic;'>{$this->nationality} </label>
    	<b>Sex</b>: <label style='color:blue; font-style:italic;'>{$this->PersonSex($idNumber)}</label><br>";

    }
}

$todo = new Manager();
$todo->checkAll(array(
					'311280-888Y',
					'311280-8890',
					'14444455564',
					'BC123456C',
					'12345678910'
	)
);




/*Examples
Finland
311280-888Y Female
311280-8890 Male

Poland
12345678910 Male
14444455564 Female

UK
AB 12 34 56 C 
BC123456C
*/