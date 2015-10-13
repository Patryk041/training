<?php

	require_once 'handler.php';

	class UserHandler extends Handler
	{
		//UserEntity
		
		/**
		 * (non-PHPdoc)
		 * @see TrainingSix/ChoR/Handler::RunAtomicHandler()
		 * @param $entity UserEntity
		 */
		public function RunAtomicHandler(&$entity) //UserEntity
		{
			echo("\n\n UserHandler: \n");
			var_dump($entity);
			//$entity->Name
			$entity = 6;
			// !!! ! w bazie zapis uzytkownika
			
			$entity->Id = 8888888;
		}
	}
	