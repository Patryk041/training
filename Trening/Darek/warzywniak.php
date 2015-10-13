<?php
class jablko
{
	var $kolor;
	var $rozmiar;
	var $awaga;
	
	function jablko($jakikolor, $jakirozmiar, $jakawaga)
	{
		$this->awaga=$jakawaga;
		$this->kolor=$jakikolor;
		$this->rozmiar=$jakirozmiar;
	}
	
}

$ojjablko= new jablko(10, 'czerwone', 'kwadratowe');
echo ($ojjablko->awaga.$ojjablko->kolor.$ojjablko->rozmiar);

$ojjablko= new jablko(10, 'niebieskie', 'kwadratowe');
echo ($ojjablko->awaga.$ojjablko->kolor.$ojjablko->rozmiar);



