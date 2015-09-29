<?php

function ValidateMail($mail)
{
	if (preg_match("/^([a-zA-Z0-9])+([a-zA-Z0-9\._-])*@{1}([a-zA-Z0-9_-])+([a-zA-Z0-9\._-]+)+\.+([a-zA-Z0-9])+([a-zA-Z0-9\._-])+$/",$mail, $matches)) 
		return true;
	else return false;
		
}

if (ValidateMail("rkjashfdae3443@sfd.pl"))
	echo "Adres prawidlowy";
else echo "Adres NIEPRAWIDLOWY";