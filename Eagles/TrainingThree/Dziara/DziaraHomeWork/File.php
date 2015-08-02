<?php
class File
{
    public static function ReadFileTxt($path)
    {
        $content = array();

        $file = fopen($path, 'r');

        while(!feof($file))
        {
            $content[] = fgets($file);
        }

        fclose($file);

        return $content;
    }
}

///$t = new  File();
//var_dump($t->ReadFileTxt('tmp/test.txt'));