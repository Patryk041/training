<?php
class Jaszczurka
{
	private $imie =' ';
	private $pamiec = array();
	
	
	function __construct($x)
	{
		$this->imie=$x;
	}
	
	function getImie()
	{
		return $this->imie;
	}
	function __toString()
	{
		return $this->imie;
	}
	
	function __set($co,$wartosc)
	{
		$this->pamiec[$co]=$wartosc;
		echo 'Nauczylem sie co to jest'. $co;
	}
	function __get($co)
	{
		return $this->pamiec[$co];
	}
}

$tmp= new Jaszczurka('Marian'."\n");
$nowe=new Mysza(Zenek);
echo  $tmp;
//$nowe->ziejeOgniem();

$tmp->burak='Warzywo';
echo $tmp->burak;
//$nowe->Gowno='smierdzi';



class Mysza extends Jaszczurka
{
	/*private $skleroza= array();
	function ziejeOgniem()
	{
		echo 'Roar!';
	}
	var $imie;
	
	function Mysza($jakieimie)
	{
		$this->imie=$jakieimie;
	}
	function __set($jak,$noi)
	{
		$this->skleroza[$jak]=$noi;
		echo' Wiem co to '.$jak;
	}*/
}



//echo 'Jego imie to'. ($nowe->imie);