<?php

class ProstyRegex implements Regex
{
	public function Sprawdz($wyrazenie)
	{
		return preg_match('/^abc+$/', $wyrazenie);
	}
}