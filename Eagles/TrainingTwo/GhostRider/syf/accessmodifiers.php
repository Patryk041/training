<?php
    class Matka 
    {
        public $zmienna = 'TO TO TO';
        protected $innazmienna = 'inne inne inne';
        
        private $niewidoczna = 'niewidoczna';
        
        private function ToSieNieDziedziczyINieOdpali()
        {
            
        }
        
        public function Whatever(Dziecko $obj)
        {
            $this->LogikaRozmyta();
            echo $obj->test();
        }
        
        protected function LogikaRozmyta()
        {
            
        }
    }
    
    class Dziecko extends Matka
    {
        
        public function test()
        {
            echo $this->zmienna;
            echo $this->innazmienna;
            echo $this->niewidoczna;
            
            //$this->ToSieNieDziedziczyINieOdpali();
        }
    }
    
    $matka = new Matka();
    
    $test = new Dziecko();
    
    $matka->Whatever($test);
    
    
    //echo $matka->zmienna;
    //echo $matka->niewidoczna;
    
    
    //$test->test();