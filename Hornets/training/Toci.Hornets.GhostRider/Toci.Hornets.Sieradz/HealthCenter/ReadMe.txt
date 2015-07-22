#NOT SO UNDERGROUND TASK#
Ogólna idea naszego zadania jest taka:
Tworzymy przychodnie działającą w spójnej architekturze, dzielimy zadania między siebie tak aby się nie nakładały,
 żeby zrealizować całość założeń, więc musimy zgrać swoje działania i co co ma w swoich klasach,
ponieważ oprócz ogólnej architektury jeszcze nie wszystko jest tutaj zrobione i trzeba pouzupełniać pola i metody.
Do zaimplementowania będziemy mieli:
Lekarzy i pacjentów.
Lekarze mają specjalności, mają listę swoich pacjentów, mają też kalendarz, w którym pacjenci wpisują wizyty, lekarz też może 
utworzyć sobie listę pacjentów np na następny tydzień
(czyli pacjent może zająć wolne miejsce w kalendarzu, ale w godzinach pracy pn-pt 08:00-16:00, jedna wizyta = 1h dla uproszczenia)
Pacjenci mają karty choroby zawierające stringi z notatkami z wizyty oraz przebyte zadania. Nowe wpisy do karty choroby może dodać 
lekarz(więc lekarze zmieniają karty choroby pacjentów), 
może zlistować sobie dostępnych lekarzy z danej specjalności oraz zarezerwować sobie wizytę oraz zwrócić listę swoich wizyt. 
Test będzie polegał na wygenerowaniu listy lekarzy i listy pacjentów oraz serii operacji rezerwacji wizyt i rewidowania czy 
ta wizyta w kalendarzu danego lekarza została zarezerowana.
Dzielimy się pracą, nikt nie powiela swojej funkcjonalności i nie robimy 10xPeselValidator. Myślę że mamy tutaj 4 duże rzeczy:
Lekarza
Pacjenta
Kalendarz(funkcjonalności z dodawaniem wizyt i zwracaniem wolnych terminów/zajętych terminów powinien zawierać chyba obiekt 
kalendarza a nie lekarza - do przedyskutowania)
Kartę choroby(tak samo dodawanie nowego wpisu do karty choroby powinna robić sama karta choroby)
i dobrze żeby jedna osoba obrała sobie jeden z tych działów - będzie nas zapewne 4 więc nie ma problemu, dodatkowo będziemy 
musieli postarać się żeby sprzęgnąć te funkcjonalności razem.
Całość będziemy obgadywać o 18:30 i szukać dziury w całym.
Nie robimy frontendu, ale postarajmy się aby zwracane dane były spójne w obrębie aplikacji. 

PS. Folder enums jest może nadmiarowy, ale może być przydatny na jakiś genderbender albo coś.

To Do List:
Pacjent <- DeeJay
Lekarz <- UCTT 
Kalendarz <- Duch Dictionary<DateTime, Patient>
Karta Choroby <-Ja?
Coś mniejszego:
Implementacja PersonalData(dane osobowe, tylko pola, enum z genderbender)
 i ExaminationResults(implementacja Dictionary<testName, testResult> gdzie result to wynik,
 int z minimum i maximum, string z jednostką) <-QuickSilver
 Wczytywanie wyników badań z pliku xml i zwracanie ExaminationResults aby wpisać to w kartę choroby pacjęta.

 Dodatkowo ważnym jest aby wszyscy ze sobą się komunikowali aby wymieniać się informacjami.
 Sieradz rulez.
 end.