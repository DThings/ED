using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public Emprestimo()
        {
            this.dtEmprestimo = DateTime.Today;
        }
        public DateTime DtEmprestimo
        {
            get { return this.dtEmprestimo; }
            set { this.dtEmprestimo = value; }
        }
        public DateTime DtDevolucao
        {
            get { return this.dtDevolucao; }
            set { this.dtDevolucao = value; }
        }
    }
}
