<?php

class EmailRegex implements Regex
{
	public function Sprawdz($wyrazenie)
	{
		return preg_match("/^[a-zA-Z0-9.+-_]*@[a-z]{2,10}.[a-z]{2,4}$/", $wyrazenie);
	}
}