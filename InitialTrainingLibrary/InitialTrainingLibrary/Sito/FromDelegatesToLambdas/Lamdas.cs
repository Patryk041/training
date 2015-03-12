using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Sito.FromDelegatesToLambdas
{
    class Lamdas
    {

        //"tradycyjna" składnia delegatów
        public static void Delegates()
        {
            List<int> list = new List<int>() {20, 1, 4, 6, 9, 44};

            //tworzymy delegat typu Predicate (który może przyjmować pojedynczy typ i zwraca typ bool) i przypisujemy metodę która pasuje do sygnatury
            //dlaczego taki delegat? metoda FindAll właśnie taki wymaga
           Predicate<int> call = new Predicate<int>(IsEvenNumber);
            //wykonujemy na liście zdeklarowany delegat
          
            List<int> evenList = list.FindAll(call);
        }
        //metoda pasująca do sygnatury delegata Predicate
        public static bool IsEvenNumber(int i)
        {
            return (i%2) == 0;
        }

        //to samo tylko że z metodą anonimową
        public static void AnnonymousMethods()
        {
            List<int> list = new List<int>() { 20, 1, 4, 6, 9, 44 };


            //wykonujemy to samo co wyżej dylko za pomocą metody anonimowej która również pasuje do sygnatury wymaganej przez FindAll (przyjmuje jeden parametr i zwraca bool)
            List<int> evenList = list.FindAll(delegate(int i) 
                { return (i % 2) == 0; }
            );
        }
        //jak wyżej za pomocą lambdy
        public static void Lamda()
        {
            List<int> list = new List<int>() { 20, 1, 4, 6, 9, 44 };

            //tak samo dla lambdy (przyjmuje jeden parametr 'i' i zwraca bool
            List<int> evenList = list.FindAll( i => (i % 2) == 0);

            //lambda może zawierać więcej lini kodu oczywiśćie
            List<int> evenList1 = list.FindAll(i =>
            {
                return (i%2) == 0;
            });
        }
    }
}
