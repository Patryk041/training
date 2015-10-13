<?php

class Loader {

    public function view($name, $data = false) {

        require_once('Views/' . $name);
        return $data;
    }

    public function library($name) {
        require_once('../libraries/' . $name);
        return new $name;
    }

}
