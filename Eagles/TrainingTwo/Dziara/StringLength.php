<?php
abstract class StringLenght
{
	protected function CalculateLength($subjec, $seek)
	{
		$this->size_subject = Dziara_strlen($subjec);
		$this->size_seek = Dziara_strlen($seek);
	}
}