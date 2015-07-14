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
                array('niech bedzie', 12, 6), 
            );
            
            foreach ($table as $item)
            {
                $length = $this->StringLength($item[0]);
                if ($length == $item[1])
                {
                    echo $this->GetNick() . " : positive for length operation\n";
                }
                
                $substr = $this->SubString($item[0], $item[2]);
                if (strlen($substr) == $item[2])
                {
                    echo $this->GetNick() . " : positive for substr operation\n";
                }
                else {
                    echo $this->GetNick() . " : negative for substr operation\n";
                }
            }
        }
    }
    
    class SingleTester
    {
        const SEP = '/';
        protected $directory;
        protected $nick;
        protected $className;
        protected $methodName;
        protected $parameters;
        
        //public __construct($dir, $nick, $class, $method, $params)
        public function __construct($elements)
        {
            $this->directory = $elements[0];
            $this->nick = $elements[1];
            $this->className = $elements[2];
            $this->methodName = $elements[3];
            $this->parameters = $elements[4];
        }
        
        public function RunTest()
        {
            if (is_file($this->directory. self::SEP . $this->nick.$this->className.'.php'))
            {
                require_once $this->directory. self::SEP . $this->nick.$this->className.'.php';
                $name = $this->nick.$this->className;
                
                $obj = new $name();
                
                $obj->{$this->methodName}($this->parameters);
            }
        }
    }
    
    class Tester
    {
        protected $tab = array(
        	array('../../Dziara', 'Dziara', 'StringOperability', 'CheckImplementation', null),
        	array('../../Dziusio', 'Dziusio', 'StringOperability', 'CheckImplementation', null),
        	array('../../jake', 'jake', 'StringOperability', 'CheckImplementation', null),
        	array('../../Maly', 'Maly', 'StringOperability', 'CheckImplementation', null),
        	array('../../ObywatelGCC', 'ObywatelGCC', 'StringOperability', 'CheckImplementation', null),
        	array('../../Olsztyniak', 'Olsztyniak', 'StringOperability', 'CheckImplementation', null),
        	array('../../Per³a', 'Perla', 'StringOperability', 'CheckImplementation', null),
        	array('../../Rudi', 'Rudi', 'StringOperability', 'CheckImplementation', null),
        	);
        
        public function TestAll()
        {
            $objects = array();
            foreach ($this->tab as $element)
            {
                $objects[] = new SingleTester($element);
            }
            
            foreach ($objects as $item)
            {
                $item->RunTest();
            }
        }
    }
    
    