<?php

	require_once 'chor.php';
	require_once 'refType.php';
	require_once 'handler.php';
	require_once 'userhandler.php';
	require_once 'documentshandler.php';
	require_once 'contactshandler.php';
	
	require_once 'Candidate/User.php';
	require_once 'Candidate/Documents.php';
	
	class CandidateChor  extends ChainOfResponsibility
	{
		public function __construct()
		{
			$this->Handlers = array(
				new UserHandler(),
				new DocumentsHandler(),
				new ContactsHandler()
			);
		}
		
		protected function Handle(Handler $handler, &$generic)
		{
			$handler->RunAtomicHandler($generic);
		}
	}
	
	$CandidateChor = new CandidateChor();
	
	$user = new UserEntity();
	
	$user->Name = 'Johnny bravo';
	$user->Documents = new Documents();
	
	$user->Documents->Id = 435;
	echo("\n\n Start: \n");
	$CandidateChor->RunHandlers($user);