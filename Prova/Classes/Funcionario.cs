using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Prova.Classes
{
    internal class Funcionario
    {
        public string Nome { get; set; }    
        public string Cpf { get; set; }
        public string Matricula { get; set; }   
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set;}
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, string matricula, DateTime dataNasc, string sexo, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            DataNasc = dataNasc;
            Sexo = sexo;
            Salario = salario;
        }
    }
}
