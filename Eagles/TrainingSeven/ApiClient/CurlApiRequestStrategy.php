<?php
	//use 'ApiRequestStrategy.php';
	require_once 'ApiRequestStrategy.php';
	
	//incl
	
	//build
	
	// nagios regresja integracja jednostkowe
	
	// php parsuje skrypt op code
	
	// www lighttpd apache x-cache
	
	class CurlApiRequestStrategy extends ApiRequestStrategy
	{
		// caly plik do jednego
		
		private $ch; //curl handle
		
		/**
		 * (non-PHPdoc)
		 * @see TrainingSeven/ApiClient/ApiRequestStrategy::ApiRequest()
		 * 
		 * @param $address string 
		 * 
		 */
		public function ApiRequest($address, $method, $queryString = null, $requestBody = array(), $headers = array())
		{
			$this->ch = curl_init($address.$queryString);
			
			curl_setopt($this->ch, CURLOPT_HTTPHEADER, $headers);
			
			curl_setopt($this->ch, CURLOPT_PROXY, '127.0.0.1:8888');
			
			curl_setopt($this->ch, CURLOPT_RETURNTRANSFER, true);
			curl_setopt($this->ch, CURLOPT_FOLLOWLOCATION, true);
			curl_setopt($this->ch, CURLOPT_MAXREDIRS, 1);
			
			//ob_start();
			$result = curl_exec($this->ch);
			//$r = ob_end_clean();
			return $result;
			
			//$soap = new SoapClient("https://webapi.allegro.pl/uploader.php?wsdl");
			//$soap->
			
			//$this->
		}
		
		private function AddHeaders($headers)
		{
			if (sizeof($headers))
			{
				foreach ($headers as $key => $value)
				{
					curl_setopt($this->ch, CURLOPT_HTTPHEADER, $this->parseHeader($key, $value));
				}
			}
		}
		
		private function parseHeader($headerName, $headerValue)
		{
			return $headerName.': '.$headerValue;
		}
	}
	
	//$req = new CurlApiRequestStrategy();
	
	//echo $req->ApiRequest('api.gadu-gadu.pl/users.json?name=bartek', 'get', null, null, array('cookie: nazwa=ghruwfgsdhghsbis', 'glupota: fsafadfgsd'));