using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБА20._2
{
    class Файл
    {
        public string Name { get; set; }

        public int Size { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public override string ToString()
        {
            return Name + Size + Date + Time;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Файл objAsФайл = obj as Файл;
            if (objAsФайл == null) return false;
            else return Equals(objAsФайл);
        }
        public override int GetHashCode()
        {
            return Size;
        }

        public bool Equals(Файл other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
    }
}
