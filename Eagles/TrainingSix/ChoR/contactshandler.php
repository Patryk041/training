<?php

	class ContactsHandler extends Handler
	{
		//UserEntity
		
	/**
		 * (non-PHPdoc)
		 * @see TrainingSix/ChoR/Handler::RunAtomicHandler()
		 * @param $entity UserEntity
		 */
		public function RunAtomicHandler(&$entity)
		{
			echo("\n\n ContactsHandler: \n");
			var_dump($entity);
			
			//$entity->Documents->Id = 12345;
			//$entity->Id
			
			//$entity->Documents->Id
			
			// dokumnety do bazy
		}
	}
	