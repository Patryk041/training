<?php

class database extends Loader
{
    public function __construct()
    {
        $this->connection = Connection($databaseLanguage); // pg_connect    
    }
    
    public $connection;
    
    public function Connection($databaseLanguage) {
        //return new connection();
    }

}
