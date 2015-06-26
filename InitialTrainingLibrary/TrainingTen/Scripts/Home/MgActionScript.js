
var dotychczasowy = document.title;

var nowyTytul = 'mryganie';

var interval;

function ZapalMryganie() {
    console.log('zapalone');

    interval = setInterval(function () {
        PodmienTytul();
    }, 1000);
}

function ZatrymajMryganie()
{
    clearInterval(interval);
}

function PodmienTytul() {
    var test = nowyTytul;
    nowyTytul = dotychczasowy;
    dotychczasowy = test;

    document.title = nowyTytul;
    console.log('test PodmienTytul');
}