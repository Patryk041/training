<?php
//DziaraPeselValidation
    abstract class PeselValidation
    {
        //84080818074
        //11241411113
        //nie korzystamy z systemowego date itd itd
        protected abstract function DateValidation($year, $month, $day);
        // 1984 02 29
        // 1986 02 29 ? 
        // 2011 13 01 ?
        // 2011 11 31 ?
        // 2011 03 31 ? 
        // 2011 04 31 ? 
        
        protected abstract function CutOffDate($pesel);
        
        protected abstract function CheckSum($pesel);
        
        public abstract function ValidatePesel($pesel);
    }