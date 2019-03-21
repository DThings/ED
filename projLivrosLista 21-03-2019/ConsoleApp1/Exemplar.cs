using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public Exemplar()
        {
            this.tombo = 0;
            this.emprestimos = new List<Emprestimo>();
        }
        public Exemplar(int tombo, List<Emprestimo> emprestimos){
            this.tombo = tombo;
            this.emprestimos = emprestimos;
        }
        public bool emprestar()
        {
            emprestimos.Add(new Emprestimo());
            return true;
        }
        public bool devolver()
        {
            emprestimos.Last().DtDevolucao = DateTime.Today;
            return true;
        }
    }
}
