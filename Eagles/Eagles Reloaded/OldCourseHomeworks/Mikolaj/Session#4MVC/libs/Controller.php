<?php

abstract class Controller implements IController
{
	function __construct(IModel $model)
	{
		$this->model = $model;
	}
	
}