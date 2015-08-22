<?php

	class Singleton
	{
		private static $instance;
		
		private function Singleton()
		{
			
		}
		
		public static function GetInstance()
		{
			if (Singleton::$instance == null)
			{
				Singleton::$instance = new Singleton();
			}
			
			return Singleton::$instance;
		}
	}
	
	$sing = Singleton::GetInstance();