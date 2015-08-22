<?php

	abstract class ChainOfResponsibility
	{
		/**
		@var array of Handler
		 */
		protected $Handlers = array(); // 
		
		public function RunHandlers(ReferenceType $enity) // SO -> L <- ID
		{
			foreach ($this->Handlers as $key => $value)
			{
				$this->Handle($value, $enity);
			}
		}
		
		protected abstract function Handle(Handler $handler, &$generic);
	}