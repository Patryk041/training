<?php

	class Chess
	{
		protected $figures = array();
		
		public function __construct()
		{
			$factory = new ChessFactory();
			
			$this->figures[] = $factory->GetFactoryItem('rook');
		}
		
		protected function MoveFigure(IFIgure $figure) // SO L ID DI dependency injection
		{
			$figure->Move(array(4,5));
		}
	}