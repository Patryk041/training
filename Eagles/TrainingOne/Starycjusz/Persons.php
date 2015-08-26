<?php

require_once('IPerson.php');

class Person
{    
    private $CountryMap;
    
    public function __construct()
    {
        $this->CountryMap['PL'] = new PLPerson();
        $this->CountryMap['FR'] = new FRPerson();
        $this->CountryMap['SL'] = new SLPerson();
    }

    static function getCountry($number) //ewentualny algorytm rozpoznawania kraju po numerze 
    {
        return 'Country';
    }

    public function ShowData($number, $country) 
    {
        if (isset($this->CountryMap[$country]))
        {
            $citizen = $this->CountryMap[$country];
            
            $citizen->setNumber($number);
            
            echo 'DD: ' . $citizen->getDay() . '</br>' .
                 'MM: ' . $citizen->getMonth() . '</br>' .
                 'YY: ' . $citizen->getYear() . '</br>' .
                 'Sex: ' . $citizen->getSex();
        }
    }
}

class PLPerson implements IPerson
{
    public $number;

    public function setNumber($number) 
    {
        $this->number = $number;
    }

    public function getDay() 
    {
        return substr($this->number, 4, 2);
    }

    public function getMonth()
    {
        return substr($this->number, 2, 2);
    }
    
    public function getYear() 
    {
        return substr($this->number, 0, 2);
    }
    
    public function getSex() 
    {
        $check = substr($this->number, 9, 1);
        
        if ($check % 2 == 0)
        {
            return 'Female';
        }
        else
        {
            return 'Male';
        }
    }
}

class FRPerson implements IPerson
{
    public $number;

    public function setNumber($number) 
    {
        $this->number = $number;
    }
    
    public function getDay() 
    {
        return 'unknown';
    }

    public function getMonth()
    {
        return substr($this->number, 3, 2);
    }
    
    public function getYear() 
    {
        return substr($this->number, 1, 2);
    }
    
    public function getSex() 
    {
        $check = substr($this->number, 0, 1);
        if ($check == 1)
        {
            return 'Male';
        }
        else 
        {
            return 'Female';
        }
    }
}

class SLPerson implements IPerson
{
    public $number;

    public function setNumber($number) 
    {
        $this->number = $number;
    }
    
    public function getDay() 
    {
        return substr($this->number, 0, 2);
    }

    public function getMonth()
    {
        return substr($this->number, 2, 2);
    }
    
    public function getYear() 
    {
        return substr($this->number, 4, 3);
    }
    
    public function getSex() 
    {
        $check = substr($this->number, 9, 3);
        if ($check < 500)
        {
            return 'Male';
        }
        else 
        {
            return 'Female';
        }
    }
}

//...