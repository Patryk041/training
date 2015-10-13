<?php

    require 'autoload.php';

/*******************************************************/
/*      Wzorzec projektowy fabryka abstrakcji          */
/*                                                     */
/*******************************************************/

    /* @var FabrykaRegex $fabryka */
    $fabryka = new FabrykaRegex();
    $prostyRegex = $fabryka->pobierzInstancje('prostyRegex');

   echo $prostyRegex->Sprawdz('abc1');
   echo $prostyRegex->Sprawdz('abc');

   $emailRegex = $fabryka->pobierzInstancje('emailRegex');

   echo $emailRegex->Sprawdz('miki0mistrz@gmial.com');

   // result 011




/*******************************************************/
/*     Wzorzec projektowy Chain of Responsibility      */
/*                                                     */
/*******************************************************/

   // 1. Najpierw typ referencyjny, wtedy Chor ma najwiecej sensu jak nad czyms dziala wspolnie
   // nie jest to jednak konieczne, moze byc to tez tablica

   $daneStringa = new DaneStringa("Lorem ipsum dolor sit amet consectetur adipsicing elit");
   $daneStringa->wycinekStart = 6;
   $daneStringa->wycinekLength = 8;

  //2. Mozna ustalic chain o tak;


   // Dzieki ustaleniu kolejnych handlerów mamy kontrole w jakiej
   // kolejnosci instancje beda operowac na danych
   // mozna to zrobic pojedynczo np
   //
   //    $first  = new StrLenClass();
   //    $second = new SubStrClass();
   //    $first->SetNextHandler($second);
   //    $second->setNextHandler(); // third, potem fourth, fifth, sixth itd
   //
   // albo poleciec w petli bardziej automatycznie

   $chor= array(
                new StrLenClass(),
                new SubStrClass(),
            );

   for($i=0; count($chor)-1 > $i; $i++)
   {
       $chor[$i]->SetNextHandler($chor[$i+1]);
   }

   // 3. Uruchamiamy chain przez handle
   $chor[0]->handle($daneStringa);
   // albo jesli tworzylismy chain pojedynczo
   //   $first->handle($daneStringa);

   echo ' Length: '.$daneStringa->length;
   echo " Cutting: ".$daneStringa->wycinek;



/*******************************************************/
/*                  FileSearch example                 */
/*                                                     */
/*******************************************************/
   $fileSearch = new FileSearch();
   $files = $fileSearch->SetType("php")
                       ->SetDirectory(__DIR__)
                       ->Search();
    echo "\n\nZnajezione pliki: \n\n";
    var_dump( $files);