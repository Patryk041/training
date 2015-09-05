<?php

interface IphpSwiftConvertGetters
{

    function openFile();

}

interface IphpSwiftConvert
{
    function addImport();
    function endLineCharDelete();
    function convertVariableDeclaration();
    /**
     * var, let, int, double, array, string
     *
     * function convertFunctionsDeclaration();
     * function swiftfunc()->variableType{
     * return variableType
     * }
     */

}