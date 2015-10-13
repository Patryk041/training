<?php

	abstract class MvcModel
	{
		public $ErrorsList = array(); // 'nazwaelementuform' => 'kom'
		
		public $Nazwa;
		
		public function __construct(){
			if ($_SERVER['REQUEST_METHOD'] == 'POST') // GET POST PUT DELETE ?
			{
				//$_POST['nazwaUsera']
				foreach ($_POST as $key => $value)
				{
					$this->$key = $value; //__set __get
				}
				
			}
		}
	}