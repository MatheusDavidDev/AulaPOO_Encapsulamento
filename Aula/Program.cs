using System;
using Aula.classes;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.Parcelas = 12;

            Console.WriteLine(m.Bandeira);
        }
    }
}
