namespace Prova.Classes
{
    internal class Medico : Funcionario
    {
        public string Crm { get; set; }
        public double ValorHoraExtra { get; set; }
        public string especialidade { get; set; }

        public Medico(string nome, string cpf, string matricula, DateTime dataNasc, string sexo, double salario,
            string crm, double valorHoraExtra, string especialidade) : base (nome, cpf, matricula, dataNasc, sexo, salario)
        {
            Crm = crm;
            ValorHoraExtra = valorHoraExtra;
            this.especialidade = especialidade;
        }
    }
}
