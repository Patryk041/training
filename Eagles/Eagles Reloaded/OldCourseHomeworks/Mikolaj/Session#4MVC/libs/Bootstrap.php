<?php

class Bootstrap
{
	function __construct()
	{	


		$url = explode("/",@$_GET["url"]);
		//load model 
		$model = $this->GetModel($url[0]);
		//load controller and pass to it model
		$this->LoadController($model, $url);
	}
	protected function GetModel($modelName)
	{
		$modelName .="Model";
		$modelPath = MODELS.$modelName.".php";
		if(file_exists($modelPath)){
			require $modelPath;
			$model = new $modelName();
			
			return $model;
		}else
			$this->ErrorHandler("Żądana strona nie istnieje", $modelPath);
	}
	protected function LoadController(IModel $model, array $url)
	{
		$controllerName = @$url[0]."Controller";
		$controllerPath = CONTROLLERS.$controllerName.".php";

		if(file_exists($controllerPath)){

			require $controllerPath;
			$controller = new $controllerName($model);

			$this->LoadMethod($controller, $url);
		}else
			$this->ErrorHandler( "Żądana strona nie istnieje", $controllerPath);
			

	}
	protected function LoadMethod(IController $controller, array $url)
	{

		if(isset($url[1]) && method_exists($controller, $url[1])){
			$controller->$url[1]();
		}else
			$this->ErrorHandler( "Żądana metoda nie istnieje");
	}
	protected function ErrorHandler( $info, $path=null)
	{
		$model = $this->GetModel("Error");
		$model->Errors->loadError = $path;
		$model->Errors->userInfo  = $info;

		$this->LoadController($model, array("Error", "UserMessage"));
	}
}