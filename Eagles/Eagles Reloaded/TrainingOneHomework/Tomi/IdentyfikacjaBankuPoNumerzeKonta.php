<?php
interface IAccount {
    function identify($idAccounts);
}
class Account implements IAccount{
    static $banks = array();
    public function __construct(){
        $this::$banks = array(
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
            "1540" => "BO?",
            "1580" => "Mercedes-Benz Bank Polska",
            "1600" => "BNP Paribas Fortis",
            "1610" => "SGB Bank",
            "1670" => "RBS Bank Polska",
            "1680" => "Plus Bank",
            "1750" => "Raiffeisen Bank",
            "1840" => "Societe Generale",
            "1870" => "FM Bank PBP",
            "1910" => "Deutsche Bank Polska",
            "1930" => "Bank Polskiej Spó?dzielczo?ci",
            "1940" => "Credit Agricole Bank Polska",
            "1950" => "Idea Bank",
            "2000" => "Rabobank Polska",
            "2030" => "BG?",
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
    public function identify($idAccounts){
        return Account::$banks[substr($idAccounts, 2, 4)];
    }
}
class Client extends Account {
    static $clients = array();
    public function __construct(){
        parent::__construct();
        $this::$clients = array(
            "10102060000786786720" => "Andrzej Kowalski",   //PKO
            "10105040000367586543" => "Karol Nieb³ocki",    //ING
            "10128060000347526750" => "Stefan Nowak",       //HSBC
            "10158060000353555786" => "Mateusz Szperkowski" //Mercedes Benz
        );
    }
    function checkHim($idAccounts){
        foreach($idAccounts as $key) {
            echo isset(Client::$clients[$key]) ? Client::$clients[$key]." - ".Account::identify($key)."\n" : "Blad: Brak klienta w bazie\n";
        }
    }
}

$ids = array(
    '10128060000347526750', //HSBC
    '10102060000786786720', //PKO
    '10105040000367586543', //ING
    '10158060656335435786', //brak
    '10158060000353555786', //Mercedes
    '10105040000367586543', //ING
    '10158060000353555786'  //Mercedes
);
echo "\n";
$checkClient = new Client();
$checkClient->checkHim($ids);
