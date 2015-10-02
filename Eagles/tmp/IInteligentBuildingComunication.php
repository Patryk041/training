<?php

interface IInteligentBuildingComunication
{
    public function test();
}

class Moja implements  IInteligentBuildingComunication
{
    public function test()
    {}
}

class KolejnyTest
{
    public function method(IInteligentBuildingComunication $r)
    {
        $r->test();
    }
}