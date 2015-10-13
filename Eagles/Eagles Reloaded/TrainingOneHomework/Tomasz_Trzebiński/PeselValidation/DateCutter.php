<?php

class DateCutter
{

    var $dateCode;

    function setDateCode ($pesel)
    {
        $this->dateCode = substr($pesel, 0, 6);
    }

    function getYear ()
    {
        $yearIndex = substr($this->dateCode, 0, 2);
        $tmp = substr($this->dateCode, 2, 2);
        if ($tmp > 0 && $tmp < 13)
            $yearIndex += 1900;
        else 
            if ($tmp > 20 && $tmp < 33)
                $yearIndex += 2000;
            else 
                if ($tmp > 40 && $tmp < 53)
                    $yearIndex == 2100;
                else 
                    if ($tmp > 60 && $tmp < 63)
                        $yearIndex += 2200;
                    else 
                        if ($tmp > 80 && $tmp < 93)
                            $yearIndex += 1800;
        return $yearIndex;
    }

    function getDateCode ()
    {
        return $dateCode;
    }

    function getMonth ()
    {
        $tmp = substr($this->dateCode, 2, 2);
        if ($tmp > 80 && $tmp < 93) {
            $tmp -= 80;
        } else 
            if ($tmp > 60 && $tmp < 73) {
                $tmp -= 60;
            } else 
                if ($tmp > 40 && $tmp < 53) {
                    $tmp -= 40;
                } else 
                    if ($tmp > 20 && $tmp < 33) {
                        $tmp -= 20;
                    }
        if ($tmp[0] == "0")
            $tmp2 = substr($tmp, 1, 1);
        else
            $tmp2 = $tmp;
        
        return $tmp2;
    }

    function getDay ()
    {
        $day = substr(($this->dateCode), 4, 2);
        if ($day[0] == "0")
            $day2 = substr($day, 1, 1);
        else
            $day2 = $day;
        return $day2;
    }
}


