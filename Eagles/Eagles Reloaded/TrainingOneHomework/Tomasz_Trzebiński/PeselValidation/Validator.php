<?php
require_once 'gruchaxdPeselValidation.php';
require_once 'DateCutter.php';
require_once 'DateChecker.php';

class Validator extends PeselValidation
{

    var $dc;

    var $monthsMap;

    var $dck;

    function __construct ()
    {
        $this->dc = new DateCutter();
        $this->monthsMap = array(
                "1" => "31",
                "2" => "28",
                "3" => "31",
                "4" => "30",
                "5" => "31",
                "6" => "30",
                "7" => "31",
                "8" => "31",
                "9" => "30",
                "10" => "31",
                "11" => "30",
                "12" => "31"
        );
    }

    function DateValidation ($year, $month, $day)
    {
        $this->dck = new DateChecker();
        if ($this->dck->checkYear($year, $this->monthsMap) == true and
                 $this->dck->checkMonth($month) == true and
                 $this->dck->checkDay($day, $this->monthsMap, $this->dc) == true)
            return true;
        else
            return false;
    }

    function CutOffDate ($pesel)
    {
        $this->dc->setDateCode($pesel);
    }

    function CheckSum ($pesel)
    {
        $controlNumber = substr($pesel, 10, 1);
        $pesel10 = substr($pesel, 0, 10);
        
        $total = (string) ($pesel10[0] + $pesel10[1] * 3 + $pesel10[2] * 7 +
                 $pesel10[3] * 9 + $pesel10[4] + $pesel10[5] * 3 + $pesel10[6] *
                 7 + $pesel10[7] * 9 + $pesel10[8] + $pesel10[9] * 3);
        if ((10 - $total[strlen($total) - 1]) == $controlNumber)
            return true;
        else
            return false;
    }

    public function ValidatePesel ($pesel)
    {
        $this->CutOffDate($pesel);
        if ($this->CheckSum($pesel) == true and $this->DateValidation(
                $this->dc->getYear(), $this->dc->getMonth(), $this->dc->getDay()) ==
                 true)
            echo "PESEL POPRAWNY";
        else
            echo "PESEL NIEPOPRAWNY";
    }
}


