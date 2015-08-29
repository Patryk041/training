<?php
require_once 'classes/Gender.php';
require_once 'classes/Birth.php';

class Main
{
	public function __construct($pesel)
	{
		$gender = new Gender($pesel);
		$gender->printOut();
		$birth = new Birth($pesel);
		$birth->printOut();
	}
}

if(isset($_POST['pesel']))
{
	$pesel = $_POST['pesel'];
	if(!empty($pesel))
	{
		new Main($pesel);
	}
}

?>

<form action="index.php" method="POST">
	<p><label for="pesel">Pesel:</label>
	<input type="text" maxlength="11" name="pesel" autocomplete="off"></p>
	<input type="submit" value="Check Yourself">
</form>