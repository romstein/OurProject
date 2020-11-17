using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Matem
{
    [Serializable]
    public class Nazvanie_Theme
    {
        public string Name { get; set; }
        public Nazvanie_Theme() { }
        public Nazvanie_Theme(string name)
        {
            Name = name;
        }
    }
}
