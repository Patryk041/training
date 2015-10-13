<?php

class Index {

    public function __construct() {
        $this->_url = trim($_SERVER['PATH_INFO'], '/');
        $this->_uri = $this->CreateUriArray();
        $this->call();
    }

    protected $_url;
    public $_uri;

    private function CreateUriArray() {
        $url = explode('/', $this->_url);
        $result['controller'] = $url[0];
        if (count($url) > 1) {
            $result['method'] = $url[1];
            $result['arguments'] = $this->GetArguments($url);
        }

        return $result;
    }

    private function GetArguments($url) {
        $result = array();
        for ($i = 2; $i < count($url); $i++) {
            $result[] = $url[$i];
        }
        return $result;
    }

    private function call() {
        $route = $this->_uri;
        if (isset($route['method'])) {
            $method = $route['method'];
        }
        if (isset($route['arguments'])) {
            $arguments = $route['arguments'];
        }

        include('System/Sys_Controller.php');

        include('Controllers/' . $route['controller'] . '.php');

        $controller = new $route['controller'];

        call_user_func_array(array($controller, $method), $arguments);
    }

}

$index = new Index();
