<?php
class Manager
{
	private $nations = 
	array(
		9  => array('English'),
		11 => array('Polish', 'Finnish'),
	);
	public function checkAll($array)
	{
		foreach($array as $idNumber){
			$this->CheckCurrent($idNumber);
		}
	}

	private function CheckCurrent($idNumber)
	{

		//$idNumber = str_replace(" ",'', $idNumber);
		$idNumber = preg_replace("/\s/", '', $idNumber);

		$matchList = $this->nations[strlen($idNumber)];
		foreach ($matchList as $country) {
			$Person = new $country($idNumber);
			if($Person->CheckMe())
				{
					$Person->PersonInfo();
					break;
				}
		}

	}
}