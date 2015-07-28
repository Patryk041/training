<?php

abstract class Sys_Model extends Sys_Controller
{
    public function __construct()
    {
        $this->load->library('darabase');
    }
}

