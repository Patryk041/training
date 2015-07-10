<?php
    class Balagan 
    {
         public $ilosc;
         public $jakosc; 

         public function Logika()
         {
             return "wynik";
         }
    }
    
    class GorszyBalagan
    {        
        public function test()
        {
            $zmienna = 'class Costam {
            public function ToDopieroCyrk()
            {
            	return \'wcale nie fdhsauksg\';
        }
        }
        $jazda = new Costam();';
            
            $zmiennadobazy = base64_encode($zmienna);
            
            echo "\n\n\n" . $zmiennadobazy . "\n\n\n";

            $nowejaja = base64_decode($zmiennadobazy);
            
            eval($nowejaja);
            
            echo $jazda->ToDopieroCyrk();
            
            $cyrk = 'Balagan';
            $jajca = 'Logika';
            $balagan = new $cyrk();
            
            return $balagan->$jajca();
        }
    }
    
    $gorszyBalagan = new GorszyBalagan();
    echo $gorszyBalagan->test();
    
    