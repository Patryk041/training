<?php

class DateOperators {

//kalendarz gregoriański
    public function IsTheYearLeap($year) {
        if ($year % 4 == 0) {
            if ($year % 100 == 0) {
                if ($year % 400 == 0) {
                    return TRUE;
                } else {
                    return FALSE;
                }
            } else {
                return FALSE;
            }
        } else {
            return FALSE;
        }
    }

    public function CheckYear($year) {
        if ($year > 0 AND $year < 100) {
            return TRUE;
        } else {
            return FALSE;
        }
    }

    public function CheckMonth($month) {
        if ($month > 0 AND $month <= 12) {
            return TRUE;
        } else {
            return FALSE;
        }
    }

    public function CheckDay($year, $month, $day) {
        if ($month == 02) {
            $February = $this->DaysInFebruary($year);
            if ($day == $February) {
                return TRUE;
            } else {
                return FALSE;
            }
        } else {
            $daysInMonth = $this->DaysInMonth($month);
            if ($day <= $daysInMonth) {
                return TRUE;
            } else {
                return FALSE;
            }
        }
    }

    public function DaysInFebruary($year) {
        if ($this->IsTheYearLeap($year)) {
            return 29;
        } else {
            return 28;
        }
    }

    public function DaysInMonth($month) {
        if ($month > 0 AND $month <= 7) {
            if ($month % 2 == 0) {
                return 30;
            } else {
                return 31;
            }
        } else {
            if ($month % 2 == 0) {
                return 31;
            } else {
                return 30;
            }
        }
    }

}
