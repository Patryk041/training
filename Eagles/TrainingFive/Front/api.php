<?php

require_once 'D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Eagles\includePathSetter.php';
	

require_once 'TrainingFive/Database/DbHandle.php';
	
	require_once 'TrainingFive/Database/DbInsert.php';
	
	$dbHandle = new DbHandle();
	
	$result = array();
	
	if (isset($_GET['resType']) && $_GET['resType'] == 'auth')
	{
		$result = $dbHandle->GetData('select * from authors;');
	}
	
	if (isset($_GET['resType']) &&  $_GET['resType'] == 'tests')
	{
		$result = $dbHandle->GetData('select * from testsresultsview;');
	}
	
	
	header('Content-type: application/json');
	
	echo json_encode($result);