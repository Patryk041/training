<?php




class Person_Polish extends Person
{
	
	public function __construct($nationality, $nationalNumber)
	{
		parent::__construct($nationality, $nationalNumber);
		$this->regExPattern = "/^[0-9]{11}+$/";
	}

	function getSex()
	{
		$sex = substr($this->nationalNumber, 9 ,1);

		echo $sex."\n";
		if($sex %2 == 0)
		{
			return  "Female";
		}
		else
		{
			return "Male";
		}
	}



	function validate()
	{
		if (preg_match( $this->regExPattern,$this->nationalNumber))
		{
			$peselTab = str_split($this->nationalNumber);
            $controlSum = 0;
            $helper = 1;

            for( $i = 0; $i<10;$i++)
            {
                $controlSum += $peselTab[$i] * $helper;

                $helper += 2;

                if ($helper == 5 )
                {
                    $helper = 7;
                }

                $helper = $helper % 10;

            }
            $controlSum += (1*$peselTab[10]);

            if($controlSum % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
		}
		else
		{
			return false;
		}
	}

}