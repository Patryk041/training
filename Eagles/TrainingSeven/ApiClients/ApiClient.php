<?php

	abstract class ApiClient
	{
		const URL_DELIMITER = '/';
		
		/**
		 * Opis 
		 * @var ApiRequestStrategy
		 */
		protected $ApiRequestStrategy;
		
		/**
		 * 
		 * Enter description here ...
		 * @var string
		 */
		protected $ApiUrl;
		
		protected function __construct()
		{
			$this->ApiRequestStrategy = new CurlApiRequestStrategy();
		}
	}