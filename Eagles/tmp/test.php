<?php
class JakasK
{
    public function TT()
    {

    }
}

class Dz extends  JakasK
{
    protected $test;// = new JakasK();

    public function __construct()
    {
        $this->test = new JakasK();
    }
    public function TT()
    {

    }
}