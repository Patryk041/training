<?php

require_once 'TrainingFive/Database/DbQuery.php';

class DbUpdate extends DbQuery {

    protected $format = 'UPDATE %s SET %s  ;'; // klucz = 'wartosc' WHERE

    public function RenderQuery($table, $elements) {
// TODO tabela
		$items = array();
		foreach ($elements as $key => $value)
		{
			$items[] = $key . ' = ' . '\''.$value.'\'';
		}
		
        $query = sprintf($this->format, $table, implode(', ', $items)); //, implode('\', \'', array_values($elements)));
        return $query;
    }

}
