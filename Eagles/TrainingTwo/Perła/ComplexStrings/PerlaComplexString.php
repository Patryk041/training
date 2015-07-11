<?php

require_once('../../GhostRider/Homework/CompexStrings.php');
require_once('StringOperators.php');

class PerlaComplexStrings extends ComplexStrings {

    protected function IsAnagram($subject, $seek) {
        $stringOperators = new PerlaStringOperators;
        if ($stringOperators->AreStringsTheSameLength($subject, $seek)) {
            $subjectSortedArray = $stringOperators->BubbleSort($subject);
            $seekSortedArray = $stringOperators->BubbleSort($seek);
            $subjectLength = $stringOperators->PerlaStrLen($subject);
            for ($i = 0; $i < $subjectLength; $i++) {
                if ($subjectSortedArray[$i] !== $seekSortedArray[$i]) {
                    return FALSE;
                }
            }
            return TRUE;
        }
        return FALSE;
    }

    protected function IsStringInString($subject, $seek) {
        $stringOperators = new PerlaStringOperators;
        $seekLength = $stringOperators->PerlaStrLen($seek);
        if ($stringOperators->IsSubjectGreatherOrEqualToSeek($subject, $seek)) {
            $posibilities = $stringOperators->CharsCombinations($subject, $seekLength);
            foreach ($posibilities as $tmp) {
                if ($tmp == $seek) {
                    return TRUE;
                }
            }
        }
        return FALSE;
    }

    protected function IsStringLettersInString($subject, $seek) {
        $stringOperators = new PerlaStringOperators;
        $seekLength = $stringOperators->PerlaStrLen($seek);
        $subjectArray = $stringOperators->PerlaCharArray($subject);

        for ($i = 0; $i < $seekLength; $i++) {
            $check = $stringOperators->IsLetterInString($subjectArray, $seek[$i]);
            if ($check === FALSE) {
                return FALSE;
            }
            $subjectArray[$check] = '';
        }
        return TRUE;
    }

    function CheckStrings($subject, $seek) {
        $stringOperators = new PerlaStringOperators;
        if ($stringOperators->IsSubjectGreatherOrEqualToSeek($subject, $seek)) {
            $result = array();
            $result[] = $this->IsAnagram($subject, $seek);
            $result[] = $this->IsStringInString($subject, $seek);
            $result[] = $this->IsStringLettersInString($subject, $seek);

            return $result;
        }
    }

}
