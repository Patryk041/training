<?php

require_once 'GhostRider/Homework/StringOperationsObj.php';

class PerlaStringOperability extends GhostRiderStringOperability {

    public function StringLength($string) {
        $num_of_chars = 0;
        for ($i = 0; isset($string[$i]); $i++) {
            $num_of_chars = $num_of_chars + 1;
        }
        return $num_of_chars;
    }

    public function SubString($string, $length) {
        $output_string = '';

        if($length < isset($string)) {
            	for($i = 0; $i < $length; $i++)
		{
			$output_string .= $string[$i];
		}
        }
        else
        {
            return FALSE;
        }
    }

}
