using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmacieClase
{
    public class Medicamente
    {
        int numar;
        string nume = string.Empty;
        int pret = 0;
        int stoc;
        bool reteta = false;

        public Medicamente(int _numar, string _nume, int _pret, int _stoc, bool _reteta)
        {
            numar = _numar;
            nume = _nume;
            pret = _pret;
            stoc = _stoc;
            reteta = _reteta;
        }
        public string Info()
        {
            return $"Numarul de ordine: {numar}, Numele medicamentului: {nume}, Pretul medicamentului: {pret}, Cantitate in stoc: {stoc}, Necesar reteta: {reteta}";
        }
    }
}
