<?php

	require_once 'TrainingFive/Database/DbQuery.php';

	class DbInsert extends DbQuery
	{
		protected $format = 'insert into %s (%s) values (\'%s\');';
		
		public function RenderQuery($table, $elements)
		{
			// TODO tabela
			$query = sprintf($this->format, $table, implode(', ', array_keys($elements)), implode('\', \'', array_values($elements)));
			return $query;
		}
	}