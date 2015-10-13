<?php

	abstract class Factory
	{
		protected $Elements = array();
		
		public function GetFactoryItem($itemIdentificator, $params = null)
		{
			if (isset($this->Elements[$itemIdentificator]))
			{
				return new $this->Elements[$itemIdentificator]($params);
			}
			
			throw new Exception('nie znaleziono: ' . $itemIdentificator);
		}
	}