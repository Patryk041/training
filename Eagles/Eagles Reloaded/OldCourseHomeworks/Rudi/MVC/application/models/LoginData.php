<?php


class LoginData
{
    private $login;
    private $pass;

    public function __construct($login, $pass){
        $this->login=$login;
        $this->pass=md5($pass);
    }

    public function checkPassword($givenLogin, $givenPassword){

        $correctLogin=$givenLogin==$this->login;
        $correctPass=md5($givenPassword)==$this->pass;

        return  $correctLogin && $correctPass ? true:false;
    }

}