<?php

/**
*  Przykład wzorca projektowego Fabryka abstrakcji
*/
class FabrykaRegex extends Fabryka
{
	
	public function __construct()
	{
		$this->mapa = array(
				'prostyRegex' => function(){ return new ProstyRegex();  },
				'emailRegex'  => function(){ return new EmailRegex();   },
			);
	}
	
}