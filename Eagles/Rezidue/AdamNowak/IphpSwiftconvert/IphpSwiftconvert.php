<?php

interface IphpSwiftConvertGetters
{

    function openFile();
    function addImport();
}

interface IphpSwiftConvert
{

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