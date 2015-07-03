namespace DemoApplication.Demo.WordExample
{
    public class GenerateDocument
    {
        void ShowEnvironment()
        {
            
        }

        bool SaveContent(SaveFile fileSave)
        {
            StaticExample.testowawartosc = 5;


            FirstClass first = new FirstClass();
            FirstClass dsaFirstClass = new FirstClass();
            FirstClass fdsghdsf = new FirstClass();

           first.Przykladdzialania();

            first.ilosc = 8;

            dsaFirstClass.Przykladdzialania();

            dsaFirstClass.ilosc = 9;

            first.Przykladdzialania();

            // informacja pobrana z contenera do tworzenia ogromnej ilosci textu
            //fileSave.Save("test", "c:/tdsayfuad.docx");


            //StaticExample example = new StaticExample();



            return true;
        }
    }
}