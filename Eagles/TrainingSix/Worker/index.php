<?php

	$zm = $_GET['id'];
	
	var_dump(shell_exec(' C:\\xampp\\php\\php.exe C:\\self\\toci\\software\\sourcetree\\training\\Eagles\\TrainingSix\\Worker\\worker.php '.$zm));
	
	//var_dump(exec('C:\\Windows\\System32\\psexec.exe -d C:\\xampp\\php\\php.exe C:\\self\\toci\\software\\sourcetree\\training\\Eagles\\TrainingSix\\Worker\\worker.php'));
	
	echo 'fds';