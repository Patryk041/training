<?php

class About
{
    public function __construct() {
        echo 'This the home page';
        $this->_other();
    }
    protected function _other()
    {
        echo 'This is the other page';
    }
}