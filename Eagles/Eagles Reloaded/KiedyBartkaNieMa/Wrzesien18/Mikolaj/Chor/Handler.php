<?php


abstract class Handler {
    /* @var Handler $handler */
    protected $handler;
    // metoda do wywolywanie operacji w danych ogniwie lancucha
    // moze automatycznie wywolac nastepny handler
    abstract function handle($data);

    public function SetNextHandler(Handler $handler) {
        $this->handler = $handler;
    }
}
