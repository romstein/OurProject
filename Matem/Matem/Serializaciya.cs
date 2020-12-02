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
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Nazvanie_Theme naz = (Nazvanie_Theme)obj;
            return (this.Name == naz.Name);
        }
    }
}
