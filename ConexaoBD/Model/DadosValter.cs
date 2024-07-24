using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD.Model
{
    class DadosValter
    {
        //Id INT IDENTITY(1,1),
	    //Nome NVARCHAR,
        //Idade INT,
	    //BI INT UNIQUE,
	    //Bairro NVARCHAR
        public string Nome { get; set;}
        public int Idade { get; set; }
        public int Bi { get; set; }
        public string Bairro { get; set; }

        public DadosValter(string nome, int idade, int bi, string bairro)
        {
            Nome = nome;
            Idade = idade;
            Bi = bi;
            Bairro = bairro;
        }
    }
}
