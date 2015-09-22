<?php


class StrLenClass extends Handler{
    
    
    public function handle($daneStringa) {
        
        // daneStringa jest typem referencyjnym wiec puki traktujemy go jako obiekt ktorym jest 
        // nie trzeba zwracac wartosci bo jest ona utrzymywana w kopii referencji
        
         $this->Sprawdz($daneStringa);
        
        if(isset($this->handler)){
            return $this->handler->handle($daneStringa);
        }
    }
    
    /**
     * @param String $param
     * @return DaneStringa
     */
    protected function Sprawdz($daneStringa) {
        
        for($i = 0; isset($daneStringa->string[$i]); $i++) { }
        // zmiana length jednokrotnie zamiast w petli przy każdym wywołaniu
        $daneStringa->length = $i;
        // gdyby ktos chcial na sile uzyskac wynik to mozna a co :)
        return $daneStringa;
    }
    

}
