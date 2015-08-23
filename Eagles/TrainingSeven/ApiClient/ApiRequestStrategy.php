<?php


	abstract class ApiRequestStrategy
	{
		public abstract  function ApiRequest($address, $method, $queryString = null, $requestBody = array(), $headers = array());
	}