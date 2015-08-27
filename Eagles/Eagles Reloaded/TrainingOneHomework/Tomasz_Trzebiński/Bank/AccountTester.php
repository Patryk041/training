<?php

interface IBankIdentification
{

    function identify ($nrkonta);
}

class AccountTester implements IBankIdentification
{

    var $tablica;

    function __construct ()
    {
        $this->tablica = array(
                "1010" => "Narodowy Bank Polski",
                "1020" => "PKO BP",
                "1030" => "Citybank handlowy",
                "1050" => "ING",
                "1060" => "BPH",
                "1090" => "BZ WBK",
                "1130" => "BGK",
                "1140" => "mBank",
                "1160" => "Bank Millenium",
                "1240" => "Pekao",
                "1280" => "HSBC",
                "1300" => "Meritum Bank",
                "1320" => "Bank Pocztowy",
                "1440" => "Nordea Bank",
                "1470" => "Euro Bank",
                "1540" => "BOŒ",
                "1580" => "Mercedes-Benz Bank Polska",
                "1600" => "BNP Paribas Fortis",
                "1610" => "SGB Bank",
                "1670" => "RBS Bank Polska",
                "1680" => "Plus Bank",
                "1750" => "Raiffeisen Bank",
                "1840" => "Societe Generale",
                "1870" => "FM Bank PBP",
                "1910" => "Deutsche Bank Polska",
                "1930" => "Bank Polskiej Spó³dzielczoœci",
                "1940" => "Credit Agricole Bank Polska",
                "1950" => "Idea Bank",
                "2000" => "Rabobank Polska",
                "2030" => "BG¯",
                "2070" => "FCE Bank Polska",
                "2120" => "Santander Consumer Bank",
                "2130" => "Volkswagen Bank",
                "2140" => "Fiat Bank Polska",
                "2160" => "Toyta Bank",
                "2190" => "DnB Nord",
                "2480" => "Getin Noble Bank",
                "2490" => "Alior Bank"
        );
    }

    function identify ($nrkonta)
    {
        if (strlen($nrkonta) == 26) {
            $nrb = substr($nrkonta, 2, 4);
            if ($this->tablica[$nrb] == null)
                echo $this->tablica[$nrb];
            
            else
                echo $this->tablica[$nrb] . "\n";
        } else
            echo "Numer konta musi sk³adaæ sie z 26 cyfr!";
    }
}