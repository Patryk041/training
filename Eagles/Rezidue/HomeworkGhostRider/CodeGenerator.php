<?php

	abstract class CodeConverter
	{
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