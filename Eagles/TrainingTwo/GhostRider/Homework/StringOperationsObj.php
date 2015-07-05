<?php
// Nick StringOperability.php
// Nick StringOperability extends GhostRiderStringOperability

    abstract class GhostRiderStringOperability
    {
        public abstract function StringLength($string);
        
        public abstract function SubString($string, $length);
        
        public abstract function GetNick();
        
        public function CheckImplementation()
        {
            $table = array(
                array('przykladowo', 11, 4), 
                array('przykladowo', 11, 4), 
                array('przykladowo', 11, 4), 
                array('przykladowo', 11, 4), 
                array('przykladowo', 11, 4), 
                array('przykladowo', 11, 4), 
                array('przykladowo', 11, 4), 
                array('przykladowo', 11, 4), 
                array('przykladowo', 11, 4), 
                array('przykladowo', 11, 4), 
            );
            
            foreach ($table as $item)
            {
                $length = $this->StringLength($item[0]);
                if ($length == $item[1])
                {
                    echo $this->GetNick() . " : positive for length operation\n";
                }
                
                
            }
        }
    }