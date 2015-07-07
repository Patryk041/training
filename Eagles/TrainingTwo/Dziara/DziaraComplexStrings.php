<?php
require_once '../GhostRider/Homework/CompexStrings.php';
require_once '../../TrainingOne/Dziara/function.php';
require_once 'StringLength.php';
require_once 'IOperation.php';
require_once 'SortString.php';
require_once 'LettersInString.php';
require_once 'StringInString.php';
require_once 'IsAnagram.php';


class DziaraComplexStrings extends ComplexStrings
{
	private $objects = array();
	
	public function __construct()
	{
		$this->objects[0] = new StringInString();
		$this->objects[1] = new LettersInString();
		$this->objects[2] = new IsAnagram();
	}
	
	protected function IsStringInString($subject, $seek)
	{
		return $this->objects[0]->StartChecking($subject, $seek);
	}
	
	protected function IsStringLettersInString($subject, $seek)
	{
		return $this->objects[1]->StartChecking($subject, $seek);
	}
	
	protected function IsAnagram($subject, $seek)
	{
		return $this->objects[2]->StartChecking($subject, $seek);
	}
	
	public function CheckStrings($subject, $seek)
	{
		return array(
				$this->IsStringInString($subject, $seek),
				$this->IsStringLettersInString($subject, $seek),
				$this->IsAnagram($subject, $seek),
			);
	}

}




//$test = new DziaraComplexStrings();
//$arraa = $test->CheckStrings('rafal', 'lafar');
//var_dump($arraa);
















