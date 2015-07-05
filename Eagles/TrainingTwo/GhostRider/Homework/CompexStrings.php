<?php

    abstract class ComplexStrings
    {
        // true: beata ata, eata, ta
        // false: beata aa, eb
        protected abstract function IsStringInString($subject, $seek);
        
        // true: beata aa, ae, ea, be, eb, ebt
        // false: beata aaa
        protected abstract function IsStringLettersInString($subject, $seek);
        
        // true: beata ataeb, aateb, 
        // false: beata ataeba, aatebb, aaet
        protected abstract function IsAnagram($subject, $seek);
        
        // return array(true, true, true)
        public abstract function CheckStrings($subject, $seek);
    }