<?php

header('x-moj-fajny-naglowek: ale jaja');

echo $_SERVER['REQUEST_URI'];

$url = 'registration/save';

$controller = 'registration';
$action = 'save';

$tablicaRoutingu = array(
	'registration' => array('controllerObj' => 'RegistrationController', 'controllerActions' => array('save' => 'SaveRegistration'))
);

require_once 'MVC/'.$tablicaRoutingu[$controller]['controllerObj'].'.php';

$controler = new $tablicaRoutingu[$controller]['controllerObj']();
$methodName = $tablicaRoutingu[$controller]['controllerActions'][$action];

$markup = $controler->$methodName();

echo $markup;

session_start();

ob_start();

echo "<br /> SERVER: <br />";
	
	var_dump($_SERVER);

echo "<br /> COOKIES: <br />";
	
	var_dump($_COOKIE);
	
	$_SESSION['cokolwiek'] = 'jakas';
	
	echo "<br /> SESSION: <br />";
	
	var_dump($_SESSION);

	echo '!!!';
	
	//$_REQUEST = array();
	
	echo "GET ! : <br />";
	
	//var_dump($_GET);
	
	echo "<br /> POST: <br />";
	
	var_dump($_POST);
	if (!isset($_POST['OnaPojawiSieWIndexieAsocjacyjnymTablicyPost']))
	{
		$_POST['OnaPojawiSieWIndexieAsocjacyjnymTablicyPost'] = 1;
	}

	$validatedOna = htmlentities($_GET['OnaPojawiSieWIndexieAsocjacyjnymTablicyPost']);
	echo $validatedOna;
	//var_dump($validatedOna);
	
	echo '<form action="index.php?OnaPojawiSieWIndexieAsocjacyjnymTablicyPost=234" method="post">';
	
	
		echo '<input type="text" name="OnaPojawiSieWIndexieAsocjacyjnymTablicyPost" value="'.$validatedOna.'" />';

		
	echo '<input type="submit" name="ToTezPojawiSieWTablicyPost" value="Kliknij!" />
	</form>';
	
	$output = ob_get_clean();
	
	//echo $output;
	$test = 5;
	header('Location: session.php?out='.$test);
	
	//echo $output;