using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Legnica.Adrianowsky94.PeselValidatorHW;
using Toci.Hornets.Legnica.Amman.StringManipulator;

namespace Toci.Hornets.UnitTests.Kalisz.Amman
{
    [TestClass]
    public class AmmanUnitTester
    {
        [TestMethod]
        public void StringceptionTest()
        {
            string[][] words =
            {
                new[] {"Amman", "mm"}, 
                new[]{"Amman", "Amm"}, 
                new[]{"Amman", "amm"}, 
                new[]{"Amman", "man"}, 
                new[]{"Amman", "nam"},
                new[]{"Amman", "b"}, 
                new[]{"Amman", "dsa"}, 
                new[]{"fsdsfad", "fdsfds"}, 
                new[]{"Amman", "nammA"}, 
                new[]{"Amman", "Aammn"}, 
                new[]{"Amman", "aAnmn"}, 
                new[]{"fdsff", "njvkdsb"},
                new[]{"quid est veritas", "vir est quiadest"}, 
                new[]{"salvador dali", "avida dollars"}, 
                new[]{"julian tuwim", "lutni ujawmi"} 

            };
            var stringceptions = new List<string[]>();
            var stringElements = new List<string[]>();
            var anagrams = new List<string[]>();

            foreach (var pair in words)
            {
                var unit = new AmmanStringCheck().RunStringOperations(pair[0], pair[1]);
                if (unit.IsAnagram) anagrams.Add(pair);
                if (unit.IsStringElementsInString) stringElements.Add(pair);
                if (unit.IsStringInString) stringceptions.Add(pair);
            }
            Assert.AreEqual(stringceptions.Count,3);
            Assert.AreEqual(stringElements.Count,12);
            Assert.AreEqual(anagrams.Count,6);
        }
        [TestMethod]
        public void PeselValidationTest()
        {
            var validPesels = new List<string>
            {
                "95121715083",
                "57031312507",
                "41030516093",
                "66042212311",
                "81061912033",
                "64101306575",
                "29071211739",
                "38012100481",
                "61111009591",
                "71022507224",
                "42511506495",
                "33483008225",
                "28491619596",
                "58912209819",
                "44682908368",
                "56680804126",
                "95121715083"
            };

            var invalidPesels = new List<string> //just random numbers, let's hope it's not actual PESEL
            {
                "2",
                "123489611468",
                "1f6ds1f64f4",
                "123132456",
                "6786d78s9",
                "8908908989",
                "0000000000",
                "dsadwdwff11",
                "bfyhjbfhyjdf",
                "25616148013",
                "44885566331",
                "1",
                "71022507223"
            };
            var validator = new A94PeselValidator();
            foreach (var psl in validPesels)
            {
                Assert.IsTrue(validator.IsPeselValid(psl));
            }
            foreach (var psl in invalidPesels)
            {
                Assert.IsFalse(validator.IsPeselValid(psl));
            }

        }
        [TestMethod]
        public void BatchAnagramTest()
        {
            var tekst =
                "mam pewność że tak będzie boa) będzie opowiadał o Biblii)będzie długic)będzie rozważaniem sensu w okrucieństwienawet jeśli ambicja każe ci to czytać bo sprowokowałem ją tytułem to sobie daruj, " +
                "zwykle czytasz krótkie informacje a ta będzie długa, nudna i wymagająca myślenia, myślenie zaś boli wiec może porzuć dumę i sie nie przemęczaj nie dodam w tym tekscie żadnego kolorowego obrazka po to by zwrócił uwagę kogokolwiek, nie będzie krótkim fotoblogowym wpisem co to się rzuca w oczy i można zaraz o nim zapomniec a główka jak była pusta tak jest " +
                "dziś znalazłem demota z wypowiedzia Lema, coś w stylu że dopóki nie zaczał siedziec w sieci to nie przypuszczał ilu idiotów jest na świecie, świeta prawda jesli się patrzy lub czytac cos z tekstów nowoczesnej młodzieży, w tym środowisku króluje bezmyślnośc, tępota umysłowa, powtarzanie bezrefleksyjne i frazes, w dodatku nikt nawet nie postara się wpisać czegokolwiek w wikipedie by sprawdzić czy to na pewno racja zresztą sam niestety pod wpływem sieci łapie sie na tym że powtarzam głupoty, ostatnio chyba na temat autorstwa pewnego wiersza Miłosza co niekonicznie było prawdą, z kim poprzestajesz takim się stajesz niestety" +
                "jełsi wiec mimowszystko to czytasz i uznałeś/łaś że cię obrażam posądząjąc o głupote to tak naprawdę gówno mnie to obchodzi, nie mam teraz ochoty na okres miłości dla zwierząr, postanowiłem napisac coś dłuższego a nie podlizać się komukolwiek i wogóle nie mam zamiaru poprawiać mojej karygodnej internetowej ortografii, robię błędy bo widze klawiaturę a nie to co piszę, owszem gdzybym wrócił i to czytał to i może bym poprawił ale szczerze mówiąc wisi mi to, jestem wzrokowcem a klawiatura nie pozwala mi na poprawianie, strata czasu kiedyś nie brakowało mi cierpliwości by się na pewnym forum zabawiać w pokazywanie głupoty panom racjonalistom, niesamowita byla ich niewiedza i niechęc do czytania czegoś poza swoimi tekstami, w końcu mnie zablokowali bo psułem im dobre o sobie mniemanie, a dzis na fali tego sentymentu napisze parę słów o Biblii " +
                "ilekroć dyskutuje z kimkolwiek o niej trafia mnie z nerwów bo słysze bzdury, przeinaczenia, interpretacje dowolne, koszmar,zreszta mam za swoje, dopiero od roku na poważniej się w jej tekst wczytuje i przecież sam bym kiedyś to powtarzał czym raczą mnie moi rozmówcy, te wszystkie frazesy, bzdury, przeinaczenia itp ale o czym to ja chciałem? no oczywiście wypłoszyć róznego rodzaju osoby w stylu - mam swoje zdanie i kazdy ma prawo myśłec co mu sie podoba - panów Nergali róznej maści, agnostyków pseudofilozoficznych itp, nie żebym się uważał za mądrego czlowieka, gdzieby tam, ale jak to mówił sokrates ja przynajmniej wiem że jestem głupi a oni sobie z tego nie zdają sprawy " +
                "historie ktora chce przedstawić i nad którąc chciałbym się zastanowić poznałem przypadkiem, czytaliście Hamleta? (czyta to ktoś?) Hamlet w pewnym momencie mówi do Ojca ofelii o córce Jeftego, ze słów Hamleta wynika że coś dzieje się z córką Jeftego niedobrego a te słowa  należy odnieść własnie do Ofelii i jej ojca, Ofelia jak wiecie ma potem w dramacie zfiksowac i się utopić sprawdziłem wiec kim jest ów Jefte i co za historia jest z jej córką historie Jeftego i jego córki znajdziecie w Ks Sędziów 11 i 12 rozdział, Jefte jest synem niewolnicy, którego jego bracia z prawego łożą wygnali i pozbawili spadku, w tym czasie plemie Izraela było przesladowane przez Ammonitów, prześladowane to pewnie mało powiedziane, jest to efekt gniewu Bożego, Izrraelici odwrócili się od Boga i łamiąc pierwsze przykazanie oddawali cześc drewnianym posągom, " +
                "Bóg wiec zesłał na nich karę czyli zbrałto co im dał, ziemie  i powodzenie, nastały czasy przesladowania wiec Izraelici zwrócili się do Boga prosząc o przebaczenie, On odpowiada że ma już dośc ich nieprawości i nie wybaczy im tego, jednak Izraelici wyrzucają stele i aszery obcych bóstw i się poprawiaja wiec Bóg im przebacza, dalej pojawia sie Jefte którego starszyzna poprosiła o powrót do domu i objecie przywódzctwa, Biblia nie opisuje jego czynów ale musiał byc naprawde sławnym wodzem skoro po niego posłali na wygnanie i skoro zapomnieli czyim jest synem, Jefte się zgadza, wraca do domu i wysyła list do króla Amonitów w którym tłumaczy dlaczego nie powinien atakować Izraelitów, tamten nie uznaje słuszności tych spraw, ale list pokazuje że Jefte nie jest monoteistą uznaje Jahwe za największego boga ale nie jedynego, Jefte zbiera armie " +
                "i pokonuje Amonitów ale składa przysiegę, w podziece za zwyciestwo jesli Bóg na nie pozwoli złoży w ofierze pierwsza osobe ktora wyjdzie go powirać, zwyciestwo jak juz pisalem było wiec Jefte wraca do domu, i na powitanie pierwsza wybiega mu córka, jedyne ukochane dziecko, Jefte mówi jej o przysiedze a ona prosi tylko o dwa miesiace zwłoki bowiem chche oplakac swoje dziewictwo, potem wraca zgor i zostaje zlozona w ofierze czy ta historia nie jest okrutna, czy po poznaniu jej nie potakiwalibyście głową i zgadzali sie z Nergalem ze Bibliia jest chora a Bóg jest okrutny?" +
                " no to posłuchajcie o ile doczytaliście, bo łatwo jest być bezmyślnym a trudno myśleć Izraelici zostali ukarani odebraniem ziemi które Bóg im dał za posłuszeństwo, kiedy go zabrakło, kiedy czcili Baala Bóg się od nich po prostu odwrócił i zabrał to co im dał, zło jakie na nich spadło było efektem ich działań - to sprawiedliwe kiedy prosili Boga o przebaczenie ten powiedział że im nie wybaczy ale gdy poprawili swoje czyny On im wybaczył - bo jest miłosierny przede wszytkim i nawet gdy ktoś nie zasłuży na przebaczenie a prosi i się porawia Bóg przebacza" +
                "jednak znowu zgrzeszyli bo zamiast znowu Boga prosić o pomoc wezwali sobie Jeftego na wodza, człowieka który nie znał dobrze prawa Mojrzeszowego w ktorym wyraznie zakazano składania ludzi w ofierze, Bóg wybrałby im dobrego wodza, lepszego o wiele niż Jefte, przykładem takich władców są do pewnego momentu Dawid i Salomon - Bóg zna serca ludzki i wie czego naprawde potrzebują o Izraelici nie zaufali Bogu wiec skonczylo sie pogańskim ślubem wiec to zabójstwo sobie też mogą przypisać Jefte poprzez wiare w inne bóstwa z drewna sklada slubowanie ktore jest nieludzkie, chce poswiecic kogos ze swojej sluzby, tymczasem Bóg wysyła jego córkę- Dlaczego?" +
                "co wiecej ona umrze bezpotomnie co jest dla niej strasznym wstydem bo izraelitka umierajac bezpotomnie naraza sie na hanbe, stad te dwa miesiace placzu nad swoim dziwictwem ale Bóg to wlasnie ja wysyla na stos poniewaz jejh postepowanie jest jak najbardziej szlachetne, skladając siebie w ofierze wypelnia slubowanie ojca, przypuszczam ze ona tez nie zna prawa mojrzeszowego co jakos ja tlumaczy ale wue jak inni poganie a wlasciwie polpoganie ze slubowanie zlozone Bogu sprowadzilo by na jej ojca straszliwa kare gdyby go nie dotrzymal, corka Jeftego wiec w swoim mniemaniu " +
                "poswieca sie i swoje zycie dla dobra ojca, n ie wie że Bóg jasno zakazał ofiar z ludzi ani że nawet od takiej przysiego mozna sie bylo łatwo wykupić tak jak kazał Bóg i wystarczyło by 30syklów srebra na ofiare swiatyni a gdyby nie bylo jej rodziny stac na taka ofiare kapłan mojego Pana obnizył by oplate stosownie do mozliwosci biedaka- Kapł rozdział 27 - bóg jest dobry i nie żada za grzechy zbyt wielkiej ofiary" +
                "jej ofiara wiec jest czysta choc i podszyta niewiedzą, nie wie że Bóg nie chce takiego poświecenia, Bóg jest miłosierny i żąda poświeceń znacznie mniejszych niż człowiek jest w stanie spełnić ale córka Jeftego wypełnia swoją powinność posłuszeństwa ojcu który chce od niej daru życia, i zarazem oddala od niego widmo złosci Boga, bo uważa Jahwe za Boga okrutnego co nie jest prawdą Jefte znów grzeszy bo sklada ja w ofierze zamiast udac sie po radę do swiatyni, kaplania pewnie by mu wytłumaczyli ze zle robił i jeszcze gorzej chce zrobić  " +
                "ale Bóg przyjmuje ofiarę z miłości dziecka, dlaczego? Bo córka Jefte sama o tym nie wiedząc naśladuje Chrystusa On umarł by odkupić nasze grzechy, ona by odkupić grzechy ojca i oddalić od niego grzech krzywoprzysiestwa Bogu On oddał życie i ona On umarł w wielkiej hańbie bo ukrzyżowanie było najgorszą upokarzającą karą, ona bo umarła bezdzietnie co było hańbą dla izraelitki więc Bóg pozwala jej się poświęcić, całym swoim życiem by nie zrobiła czegoś tak zasługującego na chwałę jak w tej śmierci" +
                "regułą w Starym Testamencie jest że grzech sprowadza na człowieka karę, zwykle coś co nie zostaje zesłane przez Boga ale jest konsekwencją złych czynów ludzi, natomiast wielokrotny grzech Jeftego nie sprawadza na niego kary, pewnie nawet nie wiedział żę jego córka odkupiła jego grzechy i że może z jej ofiary korzystać, oczywiście nie bez końca ale Jefte już nie grzeszył zbytnio bo wojna domowa jaką prowadził była okrutna i głupia ale to nic w porównaniu ze swoim pogańskim ślubem i pychą która nie pozwoliła mu prosić o pomoc " +
                "podobnie jest z Chrystusem, jego cierpienie sprowadza na nas łaskę Boga, który jak wierze nie jeden raz odwraca od nas zło, będące efektem naszych czynów przypomnijcie sobie jeszcze raz jak wygląda gniew Boga na izraelitów, powiedział że im nie wybaczy bo nie zasłużyli, ale kiedy oni zmienili swoje postępowanie wybacza :) złamał swoje słowo bo ważniejsze dla niego było miłosierdzie grzehc";
            var result = BatchAnagram.Go(tekst);


        }

        [TestMethod]
        public void ContainsTest()
        {
            var a1 = "0123456789";
            var a2 = "675834625784";
            var result = a2.Contains(a1);
        }

    }
}