<?php

class ParseFileContent {

    protected function GetFileContent($fileName) {
        $path = '../IntelligentHomeInfoText/' . $fileName;
        $file = fopen($path, 'r');
        $result = fread($file, filesize($path));
        fclose($file);
        
        return $result;
    }

    protected function ParseFileContentToArray($fileName, $separator) {
        $content = $this->GetFileContent($fileName);
        $result = array_map('trim', explode($separator, $content));

        return $result;
    }

    public function ShapeIntoReadableArray($fileName, $separator, $numberOfElementsInRecord) {
        $fullData = $this->ParseFileContentToArray($fileName, $separator);
        $result = array_chunk($fullData, $numberOfElementsInRecord);
        
        return $result;
    }

}

//$test = new ParseFileContent();
//var_dump($test->ShapeIntoReadableArray('Biestrzynska.34.Dylaki', ';', 8));

