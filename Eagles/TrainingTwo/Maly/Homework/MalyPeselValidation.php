<?php
require_once '../../GhostRider/Homework/PeselValidation.php';

class MalyPeselValidation extends  PeselValidation {

    protected  $year=null ;
    protected  $month=null;
    protected  $day=null ;


    protected function DateValidation($year, $month, $day)
    {
        $NOD =array(31,28,31,30,31,30,31,31,30,31,30,31);
        if($this->IsLeapYear()) $NOD[1]=29;

        if($NOD[(int)$this->month]-1 < $day) return false;
             echo "----------------";
              echo  var_dump($this->month) ."<br>";
              echo   var_dump($this->day) ."<br>";
                echo "----------------";
         return true;
    }

    protected function CutOffDate($pesel)
    {
        for($i=0;$i<11;$i++)
        {
            if($i<2)         $this->year= $this->year .$pesel[$i];
            if($i>1 && $i<4) $this->month = $this->month .$pesel[$i];
            if($i>3 && $i<6) $this->day =$this->day .$pesel[$i];
        }

        $this->year = $this->DateToInt($this->year);
        $this->month = $this->DateToInt($this->month);

        if($this->month > 19)
        {
            $this->month = $this->month - 20;
            $this->year=2000+$this->year;
        }
        else $this->year =1900+$year;

        $this->day = $this->DateToInt($this->day);
    }

    protected function CheckSum($pesel)
    {
        $sum=0;
        $j=0;
        $validate = array(1,3,7,9);

        for($i=0;$i<strlen($pesel);$i++)
        {
            $sum+= $pesel[$i] * $validate[$j];
            echo $sum ."<br>";
            $j++;
            if($j == 4) $j=0;

        }

        echo "Sumka:" .$sum % 10 ."<br>";
        return $sum % 10  == $pesel[10] ? true : false;

    }

    public function ValidatePesel($pesel)
    {
        $this->CutOffDate($pesel);
        $this->DateValidation($this->year,$this->month,$this->day);
        $this->CheckSum($pesel);
        if($this->CutOffDate($pesel) && $this->CheckSum($pesel)&&  $this->DateValidation($this->year,$this->month,$this->day)) return true;
        return false;
    }

    protected function DateToInt($tekst)
    {
             return 10 * (int) $tekst[0] + (int) $tekst[1];
    }
    public function IsLeapYear()
    {
        if(($this->year % 4 == 0) && ($this->year% 100 >0 ))  return true;
        return false;
    }

}

