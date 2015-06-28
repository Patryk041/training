namespace Toci.Hornets.Bytom.Common.Interfaces
{
	interface IPeselValidator
	{
		bool IsPeselValid(string pesel);		//przy implementacji tej metody powinieneś string pesel rozczłonkować na inty: dzień, miesiąc i rok
												//następnie wywołać metodę ValidateDate (żeby sprawdzić czy data jest poprawna - czyli 30 luty nie wchodzi w grę :))

		//IsPeselValid zwraca true jeśli data jest poprawna, oraz sumy kontrolne i inne pierdoły działają wg algorytmu -> wiki.pl: pesel

		//możesz w swojej klasie dołożyć tyle metod prywatnych ile Ci się podoba :)

		bool ValidateDate(int year, int month, int day);		//logika dla walidacji daty

	}
}
