<?php

	class SessionManager
	{
		public static function SessionStart()
		{
			session_start();
		}
		
		public static function SetData($userId, $key, $value)
		{
			//sharding
			// if ?
			//$_SESSION[]
		}
		
		//get
	}