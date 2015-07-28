<?php

require_once('loader.php');

abstract class Sys_Controller {

    public function __construct() {
        $this->load = new Loader();
    }

    public $load;

}
