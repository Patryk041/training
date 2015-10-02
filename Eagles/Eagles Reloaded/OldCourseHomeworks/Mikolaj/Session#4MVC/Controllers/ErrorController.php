<?php
class ErrorController extends Controller
{
public function UserMessage()
	{
		$this->model->title ='Error #404';
		$this->render();
	}
	public function render()
	{
		include_once VIEWS.'Header/index.php';
		include_once VIEWS.'Error/index.php';
		include_once VIEWS.'FOOTER/index.php';
	}
}