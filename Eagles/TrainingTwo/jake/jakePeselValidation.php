<?php

require_once "../GhostRider/Homework/PeselValidation.php";
class jakePeselValidation extends PeselValidation
{
    public function ValidatePesel($pesel)
    {
        //Sprawdzanie jakiego typu jest pesel - czy int czy string

        if(gettype($pesel) == 'integer')
        {
            $pesel = (string)$pesel;
        }

        if(strlen($pesel) != 11)
        {
            return false;
        }

        $date = $this -> CutOffDate($pesel);

        $validateThisDate = $this ->DateValidation($date[2], $date[1], $date[0]);

        $checkSum = $this -> CheckSum($pesel);


        if ($validateThisDate && $checkSum) {
            return true;
        }

       else{
            return false;
        }
    }


    protected function CutOffDate($pesel)
    {
        $arrayPesel = str_split($pesel);

        $day = 0;
        $month = 0;
        $year = 0;
       //Zaczynamy od roku i jednoczesnie miesiaca


        if($arrayPesel[2] == 0 || $arrayPesel[2] == 1) {
            $year = 1900 + 10*$arrayPesel[0] + $arrayPesel[1];
            $month = 10 * $arrayPesel[2] + $arrayPesel[3];
        }

        if($arrayPesel[2] == 2 || $arrayPesel[2] == 3) {
            $year = 2000 + 10 * $arrayPesel[0] + $arrayPesel[1];
            $month = 10 * ($arrayPesel[2] - 2) + $arrayPesel[3];
        }

        if($arrayPesel[2] == 4 || $arrayPesel[2] == 5) {
            $year = 2100 + 10 * $arrayPesel[0] + $arrayPesel[1];
            $month = 10 * ($arrayPesel[2] - 4) + $arrayPesel[3];
        }

        if($arrayPesel[2] == 6 || $arrayPesel[2] == 7) {
            $year = 2200 + 10 * $arrayPesel[0] + $arrayPesel[1];
            $month = 10 * ($arrayPesel[2] - 6) + $arrayPesel[3];
        }

        $day = 10* $arrayPesel[4] + $arrayPesel[5];

        return array($day, $month, $year);
    }

    public function DateValidation($year, $month, $day) {

        $daysOfMonth = array(0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31);

        if ($month > 12) {
            return false;
        }

        if ($this -> isLeapYear($year)) {
            if ($month == 2)
            {
                if ($day <=29){
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                if ($day <=  $daysOfMonth[$month]) {
                    return true;
                } else {
                    return false;
                }
            }
        }
        else {
            if ($day <= $daysOfMonth[$month]) {
                return true;
            } else {
                return false;
            }
        }
    }

    function isLeapYear($year) {
        if ($year % 4 == 0 && $year % 100 != 0 || $year % 400 == 0) {
            return true;
        }
        else {
            return false;
        }
    }

    protected function CheckSum ($arrayPesel) {
        $peselTemp = ($arrayPesel[0] * 1 + $arrayPesel[1] * 3 + $arrayPesel[2] * 7 + $arrayPesel[3] * 9 + $arrayPesel[4] * 1 +
                    $arrayPesel[5] * 3 + $arrayPesel[6] * 7 + $arrayPesel[7] * 9 + $arrayPesel[8] * 1 + $arrayPesel[9] * 3)%10;

        if ($peselTemp == 0 && $arrayPesel[10] == 0){
            return true;
        }

        if ((10 - $peselTemp) == $arrayPesel[10]){
            return true;
        }
        else{
            return false;
        }
    }
}
