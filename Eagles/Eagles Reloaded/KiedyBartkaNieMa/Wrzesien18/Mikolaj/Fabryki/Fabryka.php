<?php

abstract class Fabryka{
	/* @var array $mapa */
	protected $mapa;

	/**
	* @param String $nazwaInstancji
	*/
	public function pobierzInstancje($nazwaInstancji)
	{   
		
		// odwołujemy się do tablicy asocjacyjnej ktora zawiera anonimowe funkcje '()' zwracającę instancje
		// zostanie zwrócona instancja obiektu którego nazwa została przesłana w nazwieInstancji

            if(isset($this->mapa[$nazwaInstancji])){

               return $this->mapa[$nazwaInstancji]();
              
            }else{

                return null;
            }
	}
}