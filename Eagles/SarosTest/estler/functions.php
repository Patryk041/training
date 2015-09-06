<?php
	class codeOperator { 
		function splitCode($code) { 
			$input = array(
				';',
				'echo', 
				'else if',
				'elseif',
				'else',
				' if', 
				'{',
				'}',
				'$',
			);
			
			$output = array(
				"; <br />",
				"print",	
				"<br /> elif",
				"<br /> elif",
				"<br /> else",
				'<br /> if', 
				":",
				"",
				"",
			);
			
			for ($i = 0; $i <= count($input)-1; $i++) { 
				$code = str_replace($input[$i], $output[$i], $code); 
			}
			
			echo $code; 
		}
	}