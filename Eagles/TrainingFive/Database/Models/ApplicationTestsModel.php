<?php

	class ApplicationTestsModel extends Model
	{
		// zm
		public function __construct()
		{
			$this->tableName = 'applicationtests';
		}
		
		public function SaveApplicationTest($elements)
		{
			// ??map
			return $this->dbHandle->SetData($this->dbInsert->RenderQuery($this->tableName, $elements));
		}
	}
	