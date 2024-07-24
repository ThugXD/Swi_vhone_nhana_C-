using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios3
{
    internal class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int DiasTrabalho { get; set; }
        public double Salario { get; set; }


        public Funcionario(int codigo, string nome, int diasTrabalho, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            DiasTrabalho = diasTrabalho;
            Salario = salario;
        }

        public double SalarioDiario()
        {
            return (Salario / DiasTrabalho);
        }
        public double SalarioMensal()
        {
            return (Salario * 30);
        }

    }
}
