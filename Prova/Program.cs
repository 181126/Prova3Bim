using Prova.Classes;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha o tipo de funcionario que deseja cadastrar: \n1-Funcionário Comum\n2-Médico" +
                "\n3-Funcionários do Administrativo\n4-sair");
            int resposta = Convert.ToInt32(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    Console.Write("Digite o nome: ");
                    string nomeFun = Console.ReadLine();
                    Console.Write("Digite o cpf: ");
                    string cpfFun = Console.ReadLine();
                    Console.Write("Digite o número de matrícula: ");
                    string matriculaFun = Console.ReadLine();
                    Console.Write("Digite a data de nascimento: ");
                    DateTime dataNascFun = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Digite o sexo: ");
                    string sexoFun = Convert.ToString(Console.ReadLine());
                    Console.Write("Digite o salário: ");
                    double salarioFun = Convert.ToDouble(Console.ReadLine());

                    Funcionario fun = new Funcionario(nomeFun, cpfFun, matriculaFun, dataNascFun, sexoFun, salarioFun);

                    List<Funcionario> f = new List<Funcionario>();
                    f.Add(fun);
                    foreach (Funcionario funo in f)
                    {
                        Console.WriteLine(funo.ToString());
                    }
                    break;

                case 2:
                    Console.Write("Digite o nome: ");
                    string nomeMed = Console.ReadLine();
                    Console.Write("Digite o cpf: ");
                    string cpfMed = Console.ReadLine();
                    Console.Write("Digite o número de matrícula: ");
                    string matriculaMed = Console.ReadLine();
                    Console.Write("Digite a data de nascimento: ");
                    DateTime dataNascMed = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Digite o sexo: ");
                    string sexoMed = Convert.ToString(Console.ReadLine());
                    Console.Write("Digite o salário: ");
                    double salarioMed = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o número do CRM: ");
                    string crm = Console.ReadLine();
                    Console.Write("Digite o valor de hora extra: ");
                    double valorHoraExtra = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a especialidade: ");
                    string especialidade = Console.ReadLine();

                    Medico med = new Medico(nomeMed, cpfMed, matriculaMed, dataNascMed, sexoMed, salarioMed, crm, valorHoraExtra, especialidade);

                    List<Medico> m = new List<Medico>();
                    m.Add(med);
                    foreach (Medico medico in m)
                    {
                        Console.WriteLine(medico.ToString());
                    }
                    break;

                case 3:
                    Console.Write("Digite o nome: ");
                    string nomeAdm = Console.ReadLine();
                    Console.Write("Digite o cpf: ");
                    string cpfAdm = Console.ReadLine();
                    Console.Write("Digite o número de matrícula: ");
                    string matriculaAdm = Console.ReadLine();
                    Console.Write("Digite a data de nascimento: ");
                    DateTime dataNascAdm = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Digite o sexo: ");
                    string sexoAdm = Convert.ToString(Console.ReadLine());
                    Console.Write("Digite o salário: ");
                    double salarioAdm = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a função: ");
                    string funcao = Console.ReadLine();

                    Administrativo adm = new Administrativo(nomeAdm, cpfAdm, matriculaAdm, dataNascAdm, sexoAdm, salarioAdm, funcao);

                    List<Administrativo> a = new List<Administrativo>();
                    a.Add(adm);
                    foreach (Administrativo admin in a)
                    {
                        Console.WriteLine(admin.ToString());
                    }
                    break;
                    case 4: goto exit;
            }
        }
    exit:;
    }
}
