<?php

    static class IamStatic
    {
        static function Test()
        {
            echo 'dupa   ds ';
            //$this->niestatyczna();
        }
        
        function niestatyczna()
        {
            echo 'niestatyczne';
        }
    }
            //->
    IamStatic::Test();
    
    $test = new IamStatic();
    
    $test::Test();
    
    $test::niestatyczna();
    
    