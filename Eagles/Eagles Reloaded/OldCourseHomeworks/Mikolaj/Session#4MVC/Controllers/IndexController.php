<?php
class IndexController extends Controller
{
public function Hello()
	{
		$this->model->visitor= $_SERVER["REMOTE_ADDR"];
		$this->model->title = 'Welcome';
		$this->render();
	}
	public function render()
	{
		include_once VIEWS.'Header/index.php';
		include_once VIEWS.'Index/index.php';
		include_once VIEWS.'FOOTER/index.php';
	}
}