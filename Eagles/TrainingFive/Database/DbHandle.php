<?php

	class DbHandle 
	{
		protected $connectionString = 'host=127.0.0.1 user=postgres dbname=filadelfia password=beatka';
		public $connectionHandle;
		
		public function Connect()
		{
			$this->connectionHandle = pg_connect($this->connectionString);
		}	
		
		public function GetData($selectQuery) // select * from
		{
			$this->Connect();
			
			$result = pg_query($this->connectionHandle, $selectQuery);
			
			return pg_fetch_all($result);
		}
		
		public function SetData($setQuery) // del up ins
		{
			$this->Connect();
			
			//var_dump('????', $setQuery, "???");
			
			$result = pg_query($this->connectionHandle, $setQuery);
			
			return pg_affected_rows($result);
		}
	}