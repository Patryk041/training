using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.Bytom.Common.DrHouse.Types;

namespace Toci.Hornets.Bytom.Common.DrHouse.Logic
{
	public abstract class IllnessComparizon
	{
		// pacjent wpisuje dane (wiek, płeć) oraz symptomy

		// dane porównujemy z bazą chorób

		// wyświetlamy PossibleConditions (procentowo) lista, ileś pozycji z góry
        public abstract List<Illness> RecognizePosibleDiseases(Patient obj);


	}
}
