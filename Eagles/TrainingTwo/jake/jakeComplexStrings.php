<?php
require_once "../GhostRider/Homework/CompexStrings.php";


class jakeComplexStrings extends ComplexStrings {
    protected function IsStringInString($subject, $seek) {

        $arraySubject = str_split($subject);
        $arraySeek = str_split($seek);
        $seekIndex = 0;

        for ($myIndex = 0; $myIndex < strlen($subject); $myIndex++) {
            if ($arraySubject[$myIndex] == $arraySeek[$seekIndex]) {
                $seekIndex++;
            }
            else {
                $seekIndex = 0;
            }

            if ($seekIndex == strlen($seek)) {
                return true;
            }
        }
        return false;

    }

    protected function IsStringLettersInString($subject, $seek)
    {
        $arraySubject = str_split($subject);
        $arraySeek = str_split($seek);

        //chcia³em u¿yæ unset($arraySeek[$myIndex]) ale nie wiem czemu nie dzia³a³o
        //jak da³em ¿eby by³y 0 nie stringowe to te¿ nie dzia³a³o - coœ nie tak by³o z tablic¹
        for ($myIndex = 0; $myIndex < strlen($seek); $myIndex++) {
            for ($myIndex2 = 0; $myIndex2 < strlen($subject); $myIndex2++) {
                if ($arraySubject[$myIndex2] == $arraySeek[$myIndex]) {
                    $arraySeek[$myIndex] = '0';
                    $arraySubject[$myIndex2] = '0';
                }
            }
        }

        for ($myIndex = 0; $myIndex < strlen($seek); $myIndex++) {
            if ($arraySeek[$myIndex] != '0') {
                return false;
            }
        }
        return true;
    }

    protected function IsAnagram($subject, $seek) {
        $subject = strtolower(str_replace(" ","", $subject));
        $seek=strtolower(str_replace(" ","", $seek));

        $arraySubject = str_split($subject);
        $arraySeek = str_split($seek);

        $this -> MySort($arraySeek);
        $this -> MySort($arraySubject);

        for($myIndex = 0; $myIndex < count($arraySubject); $myIndex++) {
            if ($arraySeek[$myIndex] == $arraySubject[$myIndex]){
                continue;
            }
            else {
                return false;
            }
        }

        return true;
    }

    //Korzystam z sortowania bombelkowego
    private function MySort(&$array) {
        do {
            $swapped = false;
            for($i = 0, $c = count($array) - 1; $i < $c; $i++) {
                if($array[$i] > $array[$i + 1]) {
                    list($array[$i + 1], $array[$i]) = array($array[$i], $array[$i + 1]);
                    $swapped = true;
                }
            }
        }
        while($swapped);
    }

    public function CheckStrings($subject, $seek){

//        if ($this->IsStringInString($subject, $seek)){
//            echo "String ok \n";
//        }
//        if ($this->IsStringLettersInString($subject, $seek)) {
//            echo "Letters ok  \n";
//        }
//        if ($this->IsAnagram($subject, $seek)) {
//            echo "Anagram ok   \n";
//        }

        return array(
            $this->IsStringInString($subject,$seek),
            $this->IsStringLettersInString($subject,$seek),
            $this->IsAnagram($subject,$seek),
        );
    }
}
