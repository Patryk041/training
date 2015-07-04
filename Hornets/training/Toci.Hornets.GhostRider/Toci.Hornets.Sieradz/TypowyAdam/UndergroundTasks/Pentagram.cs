namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
 /*Założenia:
  * Wychodzimy z nieoznaczonego wierzchołka z którego wcześniej nie wychodzimy
  * Przechodzimy dwa wierzchołki w linii prostej czyli np 0 - 1 - 3 < trzeci oznaczamy
  * Musimy oznaczyć wszystkie które się da czyli 9 oznaczony i jeden pozostały z którego się wyszło
  * String wynikowy zawiera kolejno oznaczane wierzchołki
  *                 0 
                    ^
                   y88
                  88`88
               9 88' `88 1
   8 d888888888888888888888888888888b 2
      `88.      88'    `88      .88'
        `88.   88'      `88  .88'
          `88.88'        `8888'
        7   >888.       .888<  3
            .88`88.   .88'`88.
           .88'  `88.88'   `88.
          .88'   ,o8'`8o,   `88.
         .88' ,o88" 5   "88, `88.
        .88o88"            "88o88.
        d8"                    "8b
     6                              4       
  
  * 
  * 1 == wierzchołek z którego wychodziliśmy
  * -1 == skasowany wierzchołek
  * 0 == jeszcze niedotykany wierzchołek
  */
    public class Pentagram
    {
        private int[] vertices = new int[10];
        private int currentVertex = 0;
        public string VisitVertices()
        {
            string jumps = null;
            for (int i = 0; i < 9; i++)
            {
                vertices[currentVertex] = 1;
                vertices[(currentVertex - 3) < 0 ? currentVertex - 3 + 10 : currentVertex - 3] = -1;
                jumps += (currentVertex - 3) < 0 ? currentVertex - 3 + 10 : currentVertex - 3;
                currentVertex = (currentVertex + 3) > 9 ? currentVertex + 3 - 10 : currentVertex + 3;
            }
            return jumps;
        }
    }
}