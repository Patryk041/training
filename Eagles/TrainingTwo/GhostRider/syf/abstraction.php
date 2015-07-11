<?php

    abstract class Abstrakcyjna
    {
        protected abstract function TEsting();

        protected abstract function Zabawa();
    }
    
    class Dziedziczaca extends Abstrakcyjna
    {
        public function TEsting()
        {
            echo 'jakies';
        }
        
        public function Zabawa()
        {
            
        }
    }
    
    $test = new Dziedziczaca();
    $test->TEsting();