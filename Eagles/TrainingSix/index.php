<?php

//SETC
	
	session_start();
	
	if ($_GET['id'] == 8)
	{
		$_SESSION['beatka'] = array('dsaf' => 'dsafdas', 'dsafasd' => array(3,54,6,3,2,24), array(432,43));
	}
	else 
	{
		$_SESSION['beatka'] = '';
	}
	
	?>
	
	<form action="other.php">
	<input type="submit" />
</form>
	