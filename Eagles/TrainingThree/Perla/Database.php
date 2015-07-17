<?php

require_once('ParseFileContent.php');

class Database {

    private $connection;
    private $tableName;

    public function __construct($tableName, $user = 'root', $pass = '', $server = '127.0.0.1') {
        $this->connection = new mysqli($server, $user, $pass);
        $this->tableName = $tableName;
    }

    protected function CheckConnection() {
        if ($this->connection->connect_error) {
            return FALSE;
        }
        return TRUE;
    }

    public function ParseArrayToDatabase($content) {
        if ($this->CheckConnection()) {
            $columns = array_keys($content);
            $this->CreateTable($this->tableName, $columns);
        }
        return 'Uwierzytelnianie do systemu bazy danych nie powiodło się.';
    }

    public function CreateTable($name, $columns) {
        $query = " CREATE TABLE IF NOT EXIST $name ( "
                . $this->SplitHeaders($columns)
                . " )ENGINE = InnoDB DEFAULT CHARACTER SET = utf8 ; ";
        echo $query;
    }

    public function SplitHeaders($columns) {
        $query = '';
        foreach ($columns as $column) {
            $query = $query." '$column'" . ' VARCHAR (128) ,';
        }
    
        $result = substr($query, 0, -1);
        return $result;
    }

}

//CREATE TABLE `test`.`test` (
//  `raz` VARCHAR(128) NOT NULL,
//  `dwa` VARCHAR(45) NULL,
//  PRIMARY KEY (`raz`))
//ENGINE = InnoDB
//DEFAULT CHARACTER SET = utf8;
$test = new Database('test');
$test->ParseArrayToDatabase(array('raz' => 1, 'dwa' => 2));
