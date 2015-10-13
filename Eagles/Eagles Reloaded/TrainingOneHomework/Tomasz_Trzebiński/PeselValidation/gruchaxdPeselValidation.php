<?php

abstract class PeselValidation
{

    protected abstract function DateValidation ($year, $month, $day);

    protected abstract function CutOffDate ($pesel);

    protected abstract function CheckSum ($pesel);
    
    public abstract function ValidatePesel($pesel);
}