using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmacieClase;

class Program
{
    static void Main()
    {
        Clienti clienti1 = new Clienti(1, "Ciornei Alexandra", 20);
        string s1 = clienti1.Info();
        Console.WriteLine(s1);

        var Medicamente1 = new Medicamente(2, "Paracetamol", 20, 5, false);
        string s = Medicamente1.Info();
        Console.WriteLine(s);


        Console.ReadKey();
    }
}