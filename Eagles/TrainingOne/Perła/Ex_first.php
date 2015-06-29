<?php

function Perla_reverse($text) {
    $wynik = '';
    $i = length($text) - 1;
    while ($i >= 0) {
        $wynik .= $text[$i];
        $i--;
    }
    return $wynik;
}

function Perla_substr($text, $count) {
    return substr($text, $count);
}

function Perla_strlen($text) {
    if (isset($text)) {
        return length($text);
    }
    else
    {
        return 'Podaj ciąg mający więcej niż 0 znaków!';
    }
}
