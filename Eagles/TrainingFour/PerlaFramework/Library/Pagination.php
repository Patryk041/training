<?php

require_once '../config.php';

class Pagination
{
    public $totalPages;
    public $pages;

    public function __construct($data,$resultsPerPage){

        $this->totalPages=ceil(count($data)/$resultsPerPage);
        $j=0;
        while(count($data)>0)
        {
            if(isset($this->pages[$j][$resultsPerPage-1]))
            {
                $j++;
            }
            //echo "$data=".$data;
            $this->pages[$j][]=array_shift($data);
        }

    }

    public function getPage($strona)
    {
        $html=PAGINATION_OPENING_TAG;

        foreach($this->pages[$strona] as $page)
        {
            $html.=PAGINATION_PAGE_OPENING_TAG.$page.PAGINATION_PAGE_CLOSING_TAG;
        }
        $html.=PAGINATION_PAGE_CLOSING_TAG;
        return $html;
    }

}

$dane=array();
for($i=0;$i<10;$i++)
{
    $dane[]=$i;
}

$pagi=new Pagination($dane,5);
//var_dump($pagi->pages);
echo $pagi->getPage(1);