<?php

require_once('StringOperators.php');
require_once('DateOperators.php');
require_once'../GhostRider/Homework/PeselValidation.php';

class PerlaPeselValidation extends PeselValidation {

    public function CutOffDate($pesel) {

        $stringsHandler = new PerlaStringOperators;

        $year = $stringsHandler->PerlaSubStr($pesel, 0, 2);
        $month = $stringsHandler->PerlaSubStr($pesel, 2, 2);
        $day = $stringsHandler->PerlaSubStr($pesel, 4, 2);

        return $result = array('year' => $year, 'month' => $month, 'day' => $day);
    }

    public function DateValidation($year, $month, $day) {
        $dateHandler = new DateOperators;

        $isYearCorrect = $dateHandler->CheckYear($year);
        $isMonthCorrect = $dateHandler->CheckMonth($month);
        $isDayCorrect = $dateHandler->CheckDay($year, $month, $day);
        $result = array($isYearCorrect, $isMonthCorrect, $isDayCorrect);

        return $result;
    }

    public function CheckSum($pesel) {
        $stringsHandler = new PerlaStringOperators;

        $lastNumber = $stringsHandler->PerlaSubStr($pesel, 10, 1);
        $peselChars = $stringsHandler->PerlaCharArray($pesel);

        $peselCharsSum = $peselChars[0] + 3 * $peselChars[1] + 7 * $peselChars[2] + 9 * $peselChars[3] + $peselChars[4] +
                3 * $peselChars[5] + 7 * $peselChars[6] + 9 * $peselChars [7] + $peselChars[8] + 3 * $peselChars[9];

        $peselCharsSumLength = $stringsHandler->PerlaStrLen($peselCharsSum);
        $peselCharsSumLastCharacter = $stringsHandler->PerlaSubStr($peselCharsSum, $peselCharsSumLength - 1, 1);
        $checkSum = $peselCharsSumLastCharacter % 10;

        if ($checkSum == $lastNumber AND $checkSum == 0) {
            return TRUE;
        } else if (10 - $checkSum == $lastNumber) {
            return TRUE;
        } else {
            return FALSE;
        }
    }

    public function ValidatePesel($pesel) {
        if ($this->CheckSum($pesel)) {
            $date = $this->CutOffDate($pesel);
            $checkSumConfirmation = TRUE;
        }
        if ($checkSumConfirmation) {
            $dateValidation = $this->DateValidation($date['year'], $date['month'], $date['day']);
            var_dump($dateValidation);
        }
        if ($dateValidation[2] == FALSE AND $dateValidation[1] AND $dateValidation[0]) {
            $this->DecreaseDayByTwenty($date['year'], $date['month'], $date['day']);
        }
        if ($dateValidation[2] AND $dateValidation[1] AND $dateValidation[0]) {
            return TRUE;
        }
    }

    public function DecreaseDayByTwenty($year, $month, $day) {

        for ($i = $day; $i > 0; $i = $i - 20) {
            if ($this->DayValidation($year, $month, $day)[2] == TRUE) {
                return TRUE;
            } else {
                return FALSE;
            }
        }
    }

}

$test = new PerlaPeselValidation;
var_dump($test->ValidatePesel(96102508250));
