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
        long pret;

        public Automobile()
        {
            marca = string.Empty;
            culoare = string.Empty;
            pret = 0;
        }
        public Automobile(string _marca, string _culoare, long _pret)
        {
            marca = _marca;
            culoare = _culoare;
            pret = _pret;
        }

        public string afisare()
        {
            return string.Format(" {0}, de culoare {1}, la pretul de {2} euro \n", marca, culoare, pret);
        }

        public string getmarca()
        {
            return marca;
        }

        public string getculoare()
        {
            return culoare;
        }

        public long getpret()
        {
            return pret;
        }

        public string verifica (long _buget)
        {
            if (_buget >= pret)
                return string.Format("Isi permite masina");
            else
                return string.Format("Nu isi permite masina");
        }

        
    }
}