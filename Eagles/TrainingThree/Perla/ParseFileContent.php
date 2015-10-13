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
        $content = array_chunk($fullData, $numberOfElementsInRecord);
        $result = array();

        foreach ($content as $row) {
            $result[] = $this->CreateIndexNames($row);
        }
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

    protected function CreateIndexNames($cell) {

        $result = array();

        $result['Street'] = $cell[0];
        $result['Number'] = $cell[1];
        $result['Place'] = $cell[2];
        $result['Device'] = $cell[3];
        $result['Action'] = $cell[4];
        $result['Date'] = $cell[5];
        $result['Time'] = $cell[6];
        $result['EnergyUsage'] = $cell[7];
        $result['Errors'] = $cell[8];
        $result['Messages'] = $cell[9];

        return $result;
    }



}

//$test = new ParseFileContent();
//var_dump($test->ShapeIntoReadableArray('Biestrzynska.34.Dylaki', ';'));
