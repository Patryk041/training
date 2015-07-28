<?php

require_once "Database/Databases.php";

$config = array();


$config['databaseType'] = Databases::MySql;   //mysql /postgre/ mssql /oracle ...
$config['databaseHost'] = "46.101.236.160";//mysql /postgre/ mssql /oracle ...
$config['databaseUser'] = 'ohai';
$config['databasePassword'] = 'aaa111';
$config['databaseName'] = "toci";
$config['pagination_opening_tag'] = '<div>';
$config['pagination_closing_tag'] = '<div>';
$config['pagination_page_opening_tag'] = '<tr>';
$config['pagination_page_closing_tag'] = '</tr>';


$config2=array();
$config2['databaseType'] = Databases::PostGres;   //mysql /postgre/ mssql /oracle ...
$config2['databaseHost'] = "46.101.236.160";//mysql /postgre/ mssql /oracle ...
$config2['databaseUser'] = 'toci';
$config2['databasePassword'] = 'aaa111';
$config2['databaseName'] = "toci";