<?php

class ReferenceTypes
{
    public $text;
}

class TextOperation
{
    public function Operation(ReferenceTypes &$textContainer)
    {
        $textContainer->text = "Slowo na niedziele";

    }
    public function Operation2(ReferenceTypes $textContainer)
    {
        $textContainer->text = "Operation 2 :)";
    }
}

$t = new ReferenceTypes();
$t->text = 'poczatek';

$op = new TextOperation();
$op->Operation($t);
$op->Operation2($t);
echo $t->text;