<?php

class Example extends Sys_Controller {

    public function __construct() {
        //$this->load->model('Example.php');
        parent::__construct();
    }

    public function test($argument = 'domyslny',$drugi)
    {
        echo $argument.'<br>';
        echo $drugi;
    }

}

//$test = new Example;
//var_dump($test->index());

