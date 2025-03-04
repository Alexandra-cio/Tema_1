using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmacieClase
{
    public class Clienti
    {
        int id;
        string nume = string.Empty;
        int varsta = 0;

        public Clienti(int _id, string _nume, int _varsta)
        {
            id = _id;
            nume = _nume;
            varsta = _varsta;
        }
        public string Info()
        {
            return $"Id client: {id}, Nume client : {nume} , varsta client : {varsta}";
        }
    }
}
