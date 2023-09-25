namespace Prova.Classes
{
    internal class Administrativo: Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo(string nome, string cpf, string matricula, DateTime dataNasc, string sexo, 
            double salario, string funcao) : base (nome, cpf, matricula, dataNasc, sexo, salario)
        {
            Funcao = funcao;
        }

        //Esse tipo de funcionário tem no seu salário um acréscimo de
        //R$ 150 de vale transporte e 15% a mais do salário de vale alimentação(sobre o salário sem conta o vale transporte).

    }
}
