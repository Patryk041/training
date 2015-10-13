<?php

	require_once 'C:\self\toci\software\sourcetree\training\Eagles\TrainingSeven\ApiClient\CurlApiRequestStrategy.php';
	require_once 'C:\self\toci\software\sourcetree\training\Eagles\TrainingSeven\ApiClients\ApiClient.php';

	class GaduGaduApiClient extends ApiClient
	{
		public function __construct()
		{
			parent::__construct();
			$this->ApiUrl = 'api.gadu-gadu.pl';
		}
		
		public function SearchUsers($name)
		{
			$resource = 'users.json';
			
			$queryString = '?name=' . $name;
			
			$result = $this->ApiRequestStrategy->ApiRequest($this->ApiUrl, 'get', self::URL_DELIMITER.$resource.$queryString);

			$users = json_decode($result, true);
			//die('dump: '.var_dump($users));
			
			
			
			return $users;
		}
	}
	
	$new = new GaduGaduApiClient();
	
	var_dump($new->SearchUsers($argv[1]));
	echo 'xD';