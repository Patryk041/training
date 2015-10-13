<?php
class DateChecker{
    
    function checkYear ($year, $map)
    {
        if (strlen($year) == 4) {
            if ((($year % 4 == 0) and ($year % 100 != 0)) or ($year % 400 == 0)) {
                $map[2] = "29";
            } else {
                $map[2] = "28";
            }
            return true;
        } else
            return false;
        // true = rok przestêpny
    }
    
    function checkMonth ($month)
    {
        if ($month >= 0 and $month <= 12)
            return true;
        else
            return false;
    }
    
    function checkDay ($day, $map, $dc)
    {
        if ($day[0] == "0")
            $day2 = substr($day, 1, 1);
        else
            $day2 = $day;
        $month = $dc->getMonth();
        if ($day2 >= 1 and $day2 <=$map[$month]) {
            return true;
        }
    
        else {
            return false;
        }
    }
}