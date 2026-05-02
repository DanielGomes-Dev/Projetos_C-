using System;

namespace OPP
{
    //Definin��o de Classe
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public int Valor { get; set; }
        public int NumeroVagas { get; set; }

    }

    public class Objeto
    {
        public Objeto()
        {
            //Defini��o de Objeto
            Casa casa = new Casa
            {
                TamanhoM2 = 90,
                Andares = 2,
                Valor = 210000,
                NumeroVagas = 2,
            };
        }
    }

    //Estado e Comportamento:
    public class Pessoa
    {
        //Estado (Propriedades/Atributos)
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        //Comportamento (Metodos)
        public int CalcularIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - DataNascimento.Year;
            if (dataAtual < DataNascimento.AddYears(idade)) idade--;
            return idade;
        }
    }

    //Herança
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            Funcionario funcionario = new Funcionario
            {
                Nome = "Daniel Gomes",
                DataAdmissao = DateTime.Now,
                DataDataNascimento = Convert.ToDateTime("1990/01/01"),
                Registro = "012123"
            };
        }

    }

    //Abstração;

    public abstract class Eletrodomestico //Abstract -> Deve ser obrgatoriamente herdada
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        //Classes que vão instanciar devem implementar;
        public abstract void Ligar();
        public virtual void Desligar();
        public void Testar()
        {
            Console.WriteLine("Testando o Equipamento");
        }


    }

    //Polimorfismo
    public class Cafeteira : Eletrodomestico
    {
        //public CafeteiraEspressa(string nome, int voltagem) : base(nome, voltagem) { }
        public CafeteiraEspressa() : base("Ultra Max Pro", 220) { }
        private static void AquecerAgua()
        {
            Console.WriteLine("Aquecendo Agua");
        }
        private static void MoerGraos()
        {
            Console.WriteLine("Moendo Caf�");
        }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            Console.WriteLine("Preparando Caf�");

            //ETC...
        }

        public override void Ligar() //override(polimorfismo) -> sobrescrevendo o comportamento de uma classe bases
        {
            Console.WriteLine("Ligando a Cafeteira");
        }
        public override void Desligar()
        {
            Console.WriteLine("Desligando a Cafeteira");
        }
    }

    //Encapsulamento -> Aula 06 -> reassistir
    public class AutomacaoCafe
    {
        public void ServiceCafe()
        {
            Cafeteira espresso = new Cafeteira()
            {

            };
            espresso.Ligar();
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
    //Classes -> Selead, internal, abstract, public, private
    // Metodos -> private, public, protected
    //[assembly]: InternalsVisibleTo(namespace)

    //Interface(Melhor) Vs Implementa��o
    public interface IRepository
    {
        void Adicionar();
    }
    public class Repository : IRepository
    {
        public void Adicionar()
        {
            //Adicionar
        }
    }

    //Herança VS Composição; -> Voltar Depois;


    //Herança
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    //Composição -> Estudar Mais Sobre Composição; -> Baixo acoplamento e alta coesao;
    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class TestesHerancaCompiscao
    {
        public TestesHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "Daniel",
                DataNascimento = DateTime.Now,
                Cpf = "12345678910"
            };

            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Daniel",
                    DataNascimento = DateTime.Now,
                },
                Cpf = "12345678910"
            };

            var NomeHerance = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }



}



