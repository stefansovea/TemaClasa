using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaLab2
{
    class Automobile
    {
        string marca;
        string culoare;
        int pret;

        public Automobile()
        {
            marca = string.Empty;
            culoare = string.Empty;
            pret = 0;
        }
        public Automobile(string _marca, string _culoare, int _pret)
        {
            marca = _marca;
            culoare = _culoare;
            pret = _pret;
        }

        public string afisare()
        {
            return string.Format("Se alege un automobil marca {0}, de culoare {1}, la pretul de {2} lei", marca, culoare, pret);
        }
    }
}