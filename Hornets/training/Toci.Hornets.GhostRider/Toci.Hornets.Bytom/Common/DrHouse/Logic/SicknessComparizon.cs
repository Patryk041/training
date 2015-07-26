using System.Collections.Generic;
using Toci.Hornets.Bytom.Common.DrHouse.Models;

namespace Toci.Hornets.Bytom.Common.DrHouse.Logic
{
	public abstract class SicknessComparizon
	{
		// pacjent wpisuje dane (wiek, płeć) oraz symptomy

		// dane porównujemy z bazą chorób

		// wyświetlamy PossibleConditions (procentowo) lista, ileś pozycji z góry
        public abstract Dictionary<Sickness,int> RecognizePosibleSicknesses(Patient patient);
	}
}
