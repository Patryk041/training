<?php

include_once __DIR__.'/../models/LoginData.php';

class Login
{
    public function __construct(){

        //przykładowe dane, normalnie sprawdzili byśmy to w bazie danych
        $correctData=new LoginData('janek', 'muzykant');

        //dla wygody ten sam kontroler od razu zajmuje się sprawdzaniem loginu jak i ładowaniem odpowiednich widoków

        if(isset($_POST['login']) && isset($_POST['pass'])){
            $inputLogin=$_POST['login'];
            $inputPass=$_POST['pass'];

            if($correctData->checkPassword($inputLogin,$inputPass)){
                echo file_get_contents(__DIR__.'/../views/logged.php');
            }else{
                //tutaj powinien być jakiś widok załadowany zamiast stringa
                echo "Złe dane";
            }
        }else{
            echo file_get_contents(__DIR__.'/../views/login.php');
        }

    }
}