<?php

require_once "Library/Databases.php";

define("testowazmienna","fafaf");



define('DATABASE_TYPE',"Databases::MySql");   //mysql /postgre/ mssql /oracle ...
define('DATABASE_HOST',"46.101.236.160");//mysql /postgre/ mssql /oracle ...
define('DATABASE_USER',"ohai");
define('DATABASE_PASSWORD',"aaa111");
define('DATABASE_NAME',"toci");
define('PAGINATION_OPENING_TAG','<table border="5">');
define('PAGINATION_OPENING_TAG','</table>');
define('PAGINATION_PAGE_OPENING_TAG','<tr><td>');
define('PAGINATION_PAGE_CLOSING_TAG','</td></tr>');

//Przekladowy config dla mysql
//$config2=array();
//$config2['databaseType'] = Databases::PostGres;   //mysql /postgre/ mssql /oracle ...
//$config2['databaseHost'] = "46.101.236.160";//mysql /postgre/ mssql /oracle ...
//$config2['databaseUser'] = 'toci';
//$config2['databasePassword'] = 'aaa111';
//$config2['databaseName'] = "toci";