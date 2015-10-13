<?php

require_once '../Interfaces.php';

class Starycjusz implements IDeveloper,ISenses, IHuman
{
    public function developSomeCode($codeToCode)
    {
        $codeToCode += 'czy aby na pewno?';
        
        for ($i = 0; $i < 3; $i++)
        {
            $codeToCode += rand(0, 10);
        }
        
        return $codeToCode;
    }
    
    public function getSenseName()
    {
        $characters = 'abcdefghijklmnopqrstuvwxyz';
        $charactersLength = strlen($characters);
        $randomString = '';
        
        for ($i = 0; $i < 15; $i++) 
        {
            $randomString .= $characters[rand(0, $charactersLength - 1)];
        }
        
        return $randomString;
    }
    
    public function useSense()
    {
        return true;
    }
    
    public function getName()
    {
        return 'jam jest Starycjusz, władca galaktyki';
    }
    
    public function getSex()
    {
        $sex = rand(1, 2);
        
        if ($sex == 1)
        {
            return 'mele';
        }
        else
        {
            return 'female';
        }
    }
}

