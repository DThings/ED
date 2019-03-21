using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Emprestimo mds = new Emprestimo();
            Console.WriteLine(mds.DtEmprestimo);
            Console.ReadKey();
        }
    }
}
