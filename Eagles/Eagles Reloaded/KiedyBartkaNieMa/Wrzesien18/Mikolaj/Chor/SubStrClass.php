<?php

// Dzieki mozliwosci Chain of Responsibility ta klasa jest w stanie wykorzystac
// informacje przeslane z poprzedniego handlera, gdyby tak nie nastapilo 
// lancuch nie mialby sensu
//

class SubStrClass extends Handler {
   
    public function handle($daneStringa) {
        
        // daneStringa jest typem referencyjnym wiec puki traktujemy go jako obiekt ktorym jest 
        // nie trzeba zwracac wartosci bo jest ona utrzymywana w kopii referencji
        
        // wytnij zadziala tylko wtedy gdy zostala ustalona dlugosc stringu w porzednim etapie
        // kolejne handlery sa zalerzne od tego co opracowaly poprzednie mozna nawet dodac jakis error handler
        //      if(empty($daneStringa->length)) 
        //      {
        //         /*to w tym przypadku trzeba przerwac bo 
        //          lenght jest wymagane do daleszego dzialania */
        //          return null;
//      //      }
        // albo opracowujemy rozne strategie gdy dane spelniaja jakies kryteria
        // np pominiecie operacji w tym handlerze i przeskok do kolejnego gdyby byl juz ustalony wycinek
        $this->Wytnij($daneStringa);
        
        if(isset($this->handler)){
            return $this->handler->handle($daneStringa);
        }
    }   
    
    protected function Wytnij(DaneStringa $daneStringa) {
        
        // ustalam dane lokalnie by nie zmieniac ich w obiekcie
        
        $ile = !empty($daneStringa->wycinekLength)? $daneStringa->wycinekLength : $daneStringa->length;
        $string = $daneStringa->string;
        $skad = $daneStringa->wycinekStart;
        $length = $daneStringa->length;
        // Przypisuje kolejne znaki do daneStringa->wycinek
        
            for($ile; $length > $skad && $ile > 0 ; $ile--,$skad++) { 
                $daneStringa->wycinek .= $string[$skad];
            }
            
    // zwrot wyniku jest opcjonalny bo i tak dzialamy na typie referencyjnym
        return $daneStringa;
    }
}
