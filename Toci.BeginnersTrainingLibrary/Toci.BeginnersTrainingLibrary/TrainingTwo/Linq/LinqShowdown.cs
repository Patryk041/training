using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Linq
{
    public class LinqShowdown
    {
        Dictionary<string, string> hashMap = new Dictionary<string, string>()
        {
            {"dsafads", "dsafdasgsdf"},
            {"fdgjis", "dsafdasgsdf"},
            {"gjuier", "dsafdasgsdf"},
            {"fhdgsf", "dsafdasgsdf"},
            {"fjdsghfds", "dsafdasgsdf"},
            {"fjuewgndhksf", "dsafdasgsdf"},
            {"fjduwigdsf", "dsafdasgsdf"},
            {"fhuigewgnj", "dsafdasgsdf"},
            {"egyqwifbadsih", "dsafdasgsdf"},
            {"fhdsuf", "dsafdasgsdf"}
        };

        List<string> list = new List<string>()
        {
            "dsafdafds",
            "dsafdafds",
            "fjuewgndhksf",
            "dsafdafds",
            "egyqwifbadsih",
            "fjduwigdsf",
            "dsafdafds",
            "dsafdafds",
        };

        public List<string> Get(string filter)
        {
            int[] dsa = new[] {2, 4, 5, 6, 7};

            var wynik = dsa.Where(item => item == 2); //.Where(item => item==3); //.Select()

            dsa[2] = 2;

            var niekumacie = wynik.ToList();

            return list.Where(item => item == filter).ToList();
        }
    }
}
