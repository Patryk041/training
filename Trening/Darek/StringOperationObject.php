<?php
abstract class GhostRiderStringOperability
{
	public abstract function StringLenght($string);
	public abstract function SubString($string, $length);
	
	public function CheckImplementation ()
	{
		$table = array (
				array('przykladowo', 11, 4)
		);
		foreach ($table as $item)
		{
			$length =$this->StringLength($item[0]);
			if ($length)
			{
				echo $this->GetNick() . " : positive for length"."\n";
			}
			
			$substr = $this->SubString ($item[0], $item[2]);
			if (strlen ($ubstr) ==$item[2])
			{
				echo $this->GetNick() . " : positive for substr"."\n";
			}
		}
	}
}
class SingleTester
{
	const SEP = '/';
	protected $directory;
	protected $nick;
	protected $className;
	protected $methodName;
	protected $parameters;
	
	public  ($elements)
	{
		$this->directory = $elements [0];
		$this->nick =$elements [1];
		$this->className =$elements [2];
		$this->methodName = $elements [3];
		$this->parameters =$elements [4];
	}
	
	public function RunTest()
	{
		require_once $this->directory. SEP . $this-> nick.$this->className.'.php' ;
		
		$obj = new $this-> nick.$this->className();
		$obj->{$this->methodName}($this->parameters);
		
	}
	
}

class Tester
{
	protected $tab = array (
			array ('Zenek', 'Zenek', 'StringOperability', 'CheckImplementation', null));
	
	function TestAll()
	{
		$object = array();
		foreach ($tab as $element)
		{
			$object[] = new SingleTester();
		}
	}
}