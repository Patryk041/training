<?php

	
	
function maly_substr($text, $count)
           {
                 $wynik = '';
               if($count > strlen($text))
                    {
                     echo 'count poza indexem';		
                    }
	else
            {
	
           for($i=$count; $i < strlen($text);$i++)
                    {
               echo $text[$i];
               
                    }
	 return $wynik;
	}	
           
	}
        maly_substr('Natalia',3);
        
       echo "\n\n";
        
	function maly_strlen($text)
	{
             $count = 0;
             
             while(isset($text[$count]))
             {
                 $count++;
             }
         
             return $count;

	} //isset
	
	
	// substr strlen
	echo maly_strlen('ala');

