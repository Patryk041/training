<?php
	echo "\n";
	
	function Vernathic_strlen($string)	// return length of text, use isset($string[$i])
	{
		$length = 0;
		for ($i = 0; isset($string[$i]); $i++) {
			$length++;
		}
		return $length;
	}
	
	function Vernathic_substr($string, $count)
	{
		$substring = '';
		for ($i = 0; $i < $count; $i++) {
			$substring .= $string[$i];
		}
		return $substring;
	}
	
	$text = 'Natalia';
	
	$text1 = Vernathic_strlen($text);
	echo $text1 . "\n";
	
	$text2 = Vernathic_substr($text, 3);
	echo $text2;

	echo "\n";

?>