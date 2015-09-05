using Anathema.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Kosski
{
    class CheesFactoryHomework<T> : AbstractFactory<Func<IFigura>> 
    {
        public CheesFactoryHomework()
        {
            for (int y = 1; y < 9 ; y++)
            {
                factoryDictonary.Add("pionekBialy"+y, ()=> new Pionek(2, y, 1));
                factoryDictonary.Add("pionekCzarny"+y, () => new Pionek(7, y, -1));
            }
                factoryDictonary.Add("krolBialy", ()=>  new Pionek(1, 4, 1));
                factoryDictonary.Add("krolCzarny", ()=>  new Pionek(8, 4, -1));
        }


    }


    #region Baza

    public interface IFigura
    {
        Dictionary<int, int> MoveSchema();
    }

    public abstract class Figura
    {
        public int fintPosX { get; set; }
        public int fintPosY { get; set; }
        public int fintPlayerVector { get; set; }
        public Figura(int x, int y, int vector)
        {
            fintPlayerVector = vector;
            fintPosX = x;
            fintPosY = y;
        }
    }

    #endregion

    #region Pionki
    public class Pionek : Figura, IFigura
    {

        public Pionek(int x, int y, int vector) : base(x, y, vector)
        {

        }


        public Dictionary<int, int> MoveSchema()
        {
            Dictionary<int, int> pobjSchema = new Dictionary<int, int> {
                { fintPosX + fintPlayerVector, fintPosY }
            };
            if (fintPosX == 2)
                pobjSchema.Add(fintPosX + fintPlayerVector, fintPosY);

            return pobjSchema;
        }

        public bool changePosition(int x, int y)
        {
            if (MoveSchema().Any(xy => x == xy.Key && y == xy.Value))
            {
                fintPosX = x;
                fintPosY = y;
                return true;
            }
            return false;
        }

    }

    public class Król : Figura, IFigura
    {
        public Król(int x, int y, int vector) : base(x, y, vector)
        {

        }

        public Dictionary<int, int> MoveSchema()
        {
            Dictionary<int, int> pobjSchema = new Dictionary<int, int>();
            for (int x = fintPosX == 1 ? fintPosX : fintPosX - 1; x == fintPosX + 2; x++)
            {
                pobjSchema.Add(x, fintPosY - 1);
                pobjSchema.Add(x, fintPosY);
                pobjSchema.Add(x, fintPosY + 1);
            }
            return pobjSchema;
        }
    } 
    #endregion
}
