<?php


class Database {

    protected $connection;

    /**
     * @desc Creates connection to postgres mysql
     * @param data required for new connection
     */
    public function __construct($data) {

        $this->connection = pg_connect($data);
    }

    /**
     * @desc Sends query to database
     * @param string $query which will be send to db
     * @return Postgres result
     */
    public function  query($query)
    {
        return pg_query($this->connection,$query);
    }

    /**
     * @param $array Translates one dimensional array to String
     * Example: arrayToDML(array("ex1","ex2"))=="'ex1', 'ex2'"
     * @return string suited to put in DML query
     */
    private function arrayToDML($array) {
        $query = '';

        foreach ($array as $field) {
            $query .= " '$field', ";
        }

        return rtrim($query, ' ,');
    }

    protected function CreateSetStatement($fields) {
        $query = '';

        $columns = array_keys($fields);
        $cells = array_values($fields);
        for ($i = 0; $i < count($fields); $i++) {
            $query.="$columns[$i]=$cells[$i], ";
        }
        $result = rtrim($query, ', ');
        return $result;
    }

    /**
     * @param $whereArr associativeArray Ex. key='value' etc.
     * @return string
     */
    public function CreateWhereCondition($whereArr) {
        $query = ' WHERE ';

        $keys = array_keys($whereArr);
        $values = array_values($whereArr);

        for ($i = 0; $i < count($whereArr); $i++) {
            $query .= "$keys[$i] = '$values[$i]' AND ";
        }

        return rtrim($query, ' AND ');
    }


    /**
     * @param $table string name of table to select data from
     * @param string/array $columns table names which you want to get
     * @param bool-false/string $where optional WHERE part
     * @return Postgres
     */
    public function PgSelect($table, $columns = '*', $where = false) {

        if (is_array($columns)) {
            $columns = implode(',',$columns);
        }

        $query = "SELECT $columns FROM $table";

        $query=$this->addWhereToQuery($query,$where);

        $query.=';';

        return $this->query($query);

    }


    /**
     * @param $query string normal query string, provided by function in which this method is used
     * @param $where string|assocArray data needed to create WHERE statement
     * @return string
     */
    private function addWhereToQuery($query, $where){

        if (is_array($where)) {
            $query.=self::CreateWhereCondition($where);
        }
        if (is_string($where)) {
            $query.=" WHERE $where ";
        }

        return $query;
    }

    public function PgUpdate($table, $fields, $where = false ) {

        $setStatement = self::arrayToDML($fields);

        $query = "UPDATE $table SET ";

        $keys = array_keys($fields);
        $values = array_values($fields);

        for ($i = 0; $i < count($fields); $i++) {
            $query .= "$keys[$i] = '$values[$i]', ";
        }
        $query=rtrim($query, ', ');


        $query=$this->addWhereToQuery($query,$where);
        $query.=';';

        return $this->query($query);

    }

    /**
     * @param $table string name of table to which data will be commited
     * @param $fields array associative array with data for table
     * INPUT INTO $table($keys) VALUES ($values)
     * @return Postgres result
     */
    public function PgInsert($table, $fields) {

        $keys = implode(",",array_keys($fields));
        $values = $this->arrayToDML(array_values($fields));

        $query = "INSERT INTO $table ($keys) VALUES ($values);";

        return $this->query($query);
    }

    /**
     * @param $table string name of table to which data will be commited
     * @param $where array set of rules to delete statement
     * @return ???? postgres result
     */
    public function PgDelete($table, $where) {

        $query = "DELETE FROM $table ";

        $query=$this->addWhereToQuery($query,$where);

        return $this->query($query);
    }
}

//$db=new Database("host=46.101.236.160 user=toci password=aaa111 dbname=toci");
