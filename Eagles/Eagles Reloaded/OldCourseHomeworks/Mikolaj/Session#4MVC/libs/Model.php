<?php
abstract class Model implements IModel
{
	public $Errors;

	public function __construct()
	{
		require_once ROOT."libs/ErrorList.php";
		$this->Errors = new ErrorList();
	}
}