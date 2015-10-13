<?php


class DaneStringa {
    
    public $string;
    public $length;
    public $wycinek = '';
    public $wycinekStart;
    public $wycinekLength = null;
    
    function __construct($string) {
        $this->string = $string;
    }
    
}
