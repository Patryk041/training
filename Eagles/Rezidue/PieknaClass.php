<?php
	

	class PieknyClass implements IWeAreEvolvingFast
	{
		private $filteringResult;
		
		public function LetsHaveFun($string, $int, $double, array $array)
		{
			if ($int > (int) $double)
			{
				foreach ($array as $key => $value)
				{
					$string .= $value;
					 file_put_contents('C:\self\toci\software\sourcetree\training\Eagles\Rezidue\GhostRider\Piekny_xD_'.$key.'.txt', $array);
				}
			
				return $filteringResult = md5($string);
			}
		}
		
		public function ThereIsEvenMoreFun($chunk, $array)
		{
		  if ($chunk==$array[1] )
		  {
		  	return $chunk[7];
		  }
			
		}
	}

