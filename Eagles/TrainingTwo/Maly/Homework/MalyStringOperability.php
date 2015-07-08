<?php

require_once '..\..\GhostRider\Homework\CompexStrings.php';


class MalyStringOperability extends  ComplexStrings{

    protected function IsStringInString($subject, $seek)
    {

        $j=0;


        for($i=0;$i<strlen($subject);$i++)
        {

            if($subject[$i]==$seek[$j])
            {
                 $j++;
            }
            else
            {
                $j=0;
            }
            if($j==strlen($seek))
            {
                return true;
            }
            if($i==strlen($subject)-1)
            {
                return false;
            }
        }
    }

    protected function IsStringLettersInString($subject, $seek)
    {

       for($i=0;$i<strlen($seek);$i++)
        {
             if($this->CountLetter( $subject,$seek[$i]) < $this->CountLetter( $seek,$seek[$i])) return false;
        }
        return true;
    }

    // true: beata ataeb, aateb,
    // false: beata ataeba, aatebb, aaet
    protected function IsAnagram($subject, $seek)
    {

       if(($this->IsStringLettersInString($subject, $seek)) && (strlen($subject) == strlen($seek))) return true;
        else return false;
    }

// return array(true, true, true)
    public function CheckStrings($subject, $seek)
    {
        return array($this->IsAnagram($subject,$seek),$this->IsStringLettersInString($subject,$seek), $this->IsAnagram($subject, $seek));
    }

    protected function SortString($subject)
    {
        for($i =0; $i<strlen($subject);$i++)
        {
            for($j =0; $j<strlen($subject);$j++)
            {
                $t=null;
                $t2=null;
                if($subject[$i]<$subject[$j])
                {
                    $t=$subject[$i];
                    $subject[$i]=$subject[$j];
                    $subject[$j]=$t;
                }
            }
        }
        return $subject;
    }
    protected function CountLetter ($subject,$leter)
    {
        $count=0;
        for($i=0;$i<strlen($subject);$i++)
        {
            if($leter==$subject[$i]) $count++;
        }

        return $count;
    }
}

/*$m = new MalyStringOperability;
var_dump($m->CheckStrings("BEATA","BEATA"));
*/