<?php

class ParseFileContent {

    public function GetFileContent($fileName) {
        $path = 'InteligentHomeInfoText/' . $fileName;
        $file = fopen($path, 'r');
        $result = fread($file, filesize($path));
        fclose($file);

        return $result;
    }

    public function ShapeIntoReadableArray($fileName, $separator) {
        $fullData = $this->ParseFileContentToArray($fileName, $separator);
        $numberOfElementsInRecord = $this->CountElementsInRecord($fileName, $separator) - 1;
        $result = array_chunk($fullData, $numberOfElementsInRecord);

        return $result;
    }

    public function ParseFileContentToArray($fileName, $separator) {
        $content = $this->GetFileContent($fileName);
        $result = array_map('trim', explode($separator, $content));

        return $result;
    }

    public function CountElementsInRecord($fileName, $separator) {
        $file = file('InteligentHomeInfoText/' . $fileName);
        $elements = explode($separator, $file[0]);
        return count($elements);
    }

}
