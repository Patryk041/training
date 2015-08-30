<?php
/**
 * Created by PhpStorm.
 * User: tomek
 * Date: 30.08.15
 * Time: 14:59
 */

//use - zamiennik require i include
require_once "polimorfizm.php";

class IDontBelieveIT implements IWeAreEvolvingFast // Dependency Injection
{

    private $filteringResult;

    public function LetsHaveFun($string, $int, $double, $array)
    {
        $chunk = '';

        for($i = $int; $i < strlen($string); $i++)
        {
            $chunk .=$string[$i];

            $result = $this->ThereIsEvenMoreFun($chunk, $array);

            $this->filteringResult = array_combine(array($result), array($result, $result, $result));

        }
    }

    public function ThereIsEvenMoreFun($chunk, $array)
    {

        if (isset($array[$chunk]))
        {
            return $array[$chunk];

        }


        return 'Janueszek';

    }


    public function Serialize()
    {
        //Separation of Concern
        file_put_contents('dafax.txt',$this->filteringResult);
    }
}

$IDontBelieveIt = new IDontBelieveIT();
$IDontBelieveIt->LetsHaveFun("eagles are having fun", 8, 14.0, array(
    'r'=> array('bla'), 're'=>'xD', 'rh'=>'this should not be there'
));