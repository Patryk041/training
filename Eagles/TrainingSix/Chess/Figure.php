<?php


	abstract class Figure implements IFIgure
	{
		protected $shape;
		
		protected function __construct($shape)
		{
			$this->shape = $shape;
		}
		
		abstract function Move($coordinates);
		
		abstract function GetColour();
		
		function GetShape()
		{
			return $this->shape;
		}
	}