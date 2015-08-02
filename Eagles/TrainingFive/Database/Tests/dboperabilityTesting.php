<?php

	require_once 'D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Eagles\includePathSetter.php';
	
	

	require_once 'TrainingFive/Database/DbHandle.php';
	
	require_once 'TrainingFive/Database/DbInsert.php';
	
	$dbHandle = new DbHandle();
	
	/*$updateResult = $dbHandle->SetData('update applicationtests set rightanswers = \'ale heca\'; -- where id > 4;');
	
	var_dump($updateResult);
	
	$result = $dbHandle->GetData('select * from applicationtests;');
	
	var_dump($result);*/
	
	$dbInsert = new DbInsert();
	
	$inseert = $dbInsert->RenderQuery('applicationtests', array('codesnipet' => 'robimy inserty z php a', 'rightanswers' => 'to jest fantastyczna odpowiedz'));
	
	//var_dump('etylieta: '.$inseert);
	
	$dbHandle->SetData($inseert);
	