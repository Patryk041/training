<?php
// Annotation helps but code looks shitty after all
class FileSearch {
  
   protected $type;
   protected $dir;
   protected $files = [];
   /**
    * @param String $type
    * @return \FileSearch
    */
   public function SetType($type) {
       $this->type = $type;
       return $this;
   }
   /**
    * @param String $dir
    * @return \FileSearch
    */
   public function SetDirectory($dir) {
       //craete absolute path
       
       $dir = realpath($dir);
       
       if(file_exists($dir))
        {
            $this->dir = $dir;
            return $this;
            
        }else{
            throw new Exception ("Directory doesn't exit");
        }
   }
   /**
    * @return Array
    */
   public function Search(){
       $handle = opendir($this->dir);
       
       while($file = readdir($handle)){

            $this->Add($file);
       }
       
       return $this->files;
   }
   /**
    * @param String $file
    * @return boolean
    */
   protected function IsType($file) {
       $exploded = explode(".", $file);
       
       if(end($exploded) == $this->type){ return true; }else{ return false; }
   }
   /**
    * @param String $file
    */
   protected function Add($file){
       
        if($this->IsType($file))
            {
                 $this->files[] = $file;
            }
   }
}


