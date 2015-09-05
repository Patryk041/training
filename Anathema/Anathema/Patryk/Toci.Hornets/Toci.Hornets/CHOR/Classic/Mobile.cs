using System;

namespace Toci.Hornets.CHOR.Classic
{
    public class Mobile
    {
        public Type Type { get; set; }
        public double Cost;
        public string GetDescription()
        {
            return "The mobile is of type : " + this.Type;
        }

        public Mobile(Type type, int cost = 0)
        {
            this.Type = type;
            this.Cost = cost;
        }
    }

    public enum Type
    {
        Basic,
        Budget,
        Premium
    }
}