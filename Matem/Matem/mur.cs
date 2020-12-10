using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matem
{
    public class Pair<T, K>
    {
        public T First { get; set; }
        public K Second { get; set; }


    }
    [Serializable]
    public class Mission
    {
        public string question { get; set; }
        public string Theme { get; set; }
        public List<Pair<string, bool>> answers = new List<Pair<string, bool>>();
        public bool Status = false;
        public Mission() { }
        public Mission(string Q, string TH, List<Pair<string, bool>> a)
        {
            question = Q;
            Theme = TH;
            answers = a;
        }
       

    }
    
}
