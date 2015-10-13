<?php

class PerlaStringOperators {

    public function PerlaStrLen($string) {

        $num_of_chars = 0;
        for ($i = 0; isset($string[$i]); $i++) {
            $num_of_chars++;
        }
        return $num_of_chars;
    }

    public function PerlaSubStr($string, $start = 0, $end) {

        $new_string = '';
        $end = $start + $end;
        for ($i = $start; $i < $end; $i++) {
            $new_string .= $string[$i];
        }
        return $new_string;
    }

    public function PerlaCharArray($string) {

        $stringLength = $this->PerlaStrLen($string);
        $result = array();
        for ($i = 0; $i < $stringLength; $i++) {
            $result[] = $this->PerlaSubStr($string, $i, 1);
        }
        return $result;
    }

    public function AreStringsTheSameLength($first, $secound) {
        $firstLength = $this->PerlaStrLen($first);
        $secoundLength = $this->PerlaStrLen($secound);

        if ($firstLength == $secoundLength) {
            return TRUE;
        } else {
            return FALSE;
        }
    }

    public function BubbleSort($string) {
        $stringArray = $this->PerlaCharArray($string);
        $stringArrayLength = $this->PerlaStrLen($string);
        for ($i = 0; $i < $stringArrayLength; $i++) {
            for ($j = 0; $j < $stringArrayLength - 1; $j++) {
                if ($stringArray[$j] > $stringArray[$j + 1]) {
                    $lowerVal = $stringArray[$j + 1];
                    $higherVal = $stringArray[$j];
                    $stringArray[$j] = $lowerVal;
                    $stringArray[$j + 1] = $higherVal;
                }
            }
        }
        return $stringArray;
    }

    public function CharsCombinations($string, $limit) {
        $result = array();
        $stringLength = $this->PerlaStrLen($string);
        for ($i = 0; $i < $stringLength - $limit + 1; $i++) {
            $word = $this->PerlaSubStr($string, $i, $limit);
            $result[] = $word;
        }
        return $result;
    }

    public function IsSubjectGreatherOrEqualToSeek($subject, $seek) {
        $subjectLength = $this->PerlaStrLen($subject);
        $seekLength = $this->PerlaStrLen($seek);
        if ($subjectLength >= $seekLength) {
            return TRUE;
        }
        return FALSE;
    }

    public function IsLetterInString($string, $letter) {
        $stringLength = $this->PerlaStrLen($string);
        for ($i = 0; $i < $stringLength; $i++) {
            if ($string[$i] == $letter) {
                return $i;
            }
        }
        return FALSE;
    }
}
