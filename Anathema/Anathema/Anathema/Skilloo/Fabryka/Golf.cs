using System.Drawing;

namespace Anathema.Skilloo.Fabryka
{
    public class Golf:ICar
    {
        public Color color { get; set; }

        public Golf()
        {
            color = Color.Blue;
        }
    }
}