using System.Collections.Generic;
using Toci.Hornets.GhostRider.TrainingFour.Generics;

public class RudiGenericList<T> : GhostRiderGenericList<T>
    {

        List<T> list=new List<T>();

        public RudiGenericList()
        {
            list=new List<T>();
        }

        public override bool Add(T item)
        {
            list.Add(item);
            return true;
        }

        public override bool Remove(T item)
        {
            if(list.Contains(item))
            { list.Remove(item);
                return true;
            }
            else {
                return false;}

        }
    }
