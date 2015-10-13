<?php

	abstract class CodeConverter
	{
	    protected $regexArray; //tablica asocjacyjna składni języka Z którego zmieniamy  : "1" => "regex", itd
	    protected $currentLanguage;
	    protected $desiredLanguage;
		/**
		 * 
		 * Enter description here ...
		 * @param $source string class definition
		 * @param $language int programing lang
		 */
									/*
									 * class JavaIsColl  , 1 - php, 2 -> c#, java, c++
									 * {
									 * }
									 */
		public abstract function GetResultingClass($source, $currentLanguage, $desiredLanguage);
	}