<?php

	$string = 'echo \'Hello\' World\';';

    function changeText ($string) // w naszym przypadku string bêdzie : echo
                                  // 'Hello\' World';
    {
        $string = 'public static void main(String[] args) {';
        $string .= System . out . println("");
        $string .= 'tu nasz znaleziony hello wordl :) - teraz kwestia jego znalezienia';
        $string .= '\");}';
        $string .= '}';
        return $string;

        function znajdzSystem_out_println ($wyraz)) {
            $wyraz = $wyraz;
            $regex = "/echo\s*\".*\"/";
            $wynik = preg_match_all($regex, $wyraz, $zmienna);
            $tablica = $zmienna[0];
            return $tablica;
        }
    }
    changeText($string);

    ?>
    <?php
 /*
     *  PHP na Java
     *  class HelloWorld {
    		echo 'Hello World';
    	}
    	
    	na 
    	
    	
        public class HelloWorld {

    		public static void main(String[] args) {
       			System.out.println("Hello, World");
    		}
    	}
                    
    	// Dla ka¿dej czêœci sk³adni javy trzeba stworzyæ funkcjê w php, która wyszuka dany element sk³adni za pomoc¹ wyra¿eñ regularnych
    	// np dla System.out.println("coœ tam"); bêdzie funkcja która znajdzie go. Druga funckja wytnie napis "coœ tam" z jego œrodka .
/*
http://stackoverflow.com/questions/11482418/how-to-convert-javascript-variable-value-into-php-variable



 */


class test
{

    function znajdz1 ($wyraz)
    {
        $wyraz = $wyraz;
        $regex = "/echo\s*/";
        $wynik = preg_match_all($regex, $wyraz, $zmienna);
        $tablica = $zmienna[0];
        return $tablica;
    }

    function wytnijZmienna ($string)
    {
        $tabX = $this->znajdz1($string);
        $newString = $tabX[0];
        $zmienna = $this->znajdz1($newString);  
        echo $zmienna[0];
    }
}

$t1 = new test();
$tabX = $t1->znajdz1('System.out.println("dupa");');

?>


<script>
function jstophp(){


var javavar=document.getElementById("Helo World").value;  

document.getElementById("Helo World").innerHTML="<?php 
$phpvar='"+javavar+"'; 
echo $phpvar;?>";
}

function phptojs(){

var javavar2 = "<?php 

$phpvar2="Hello World";
echo $phpvar2;

?>";
alert(javavar2);
}

</script> 
<body>
<div id="rslt">
</div>


<input type="text" id="Helo World" />
<button onClick="jstophp()" >Convert js to php</button>
<button onClick="phptojs()">Convert php to js</button>

PHP variable will appear here:
<div id="Helo World">
</div>

</body>
