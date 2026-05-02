using System;

namespace ClassesObjetos
{
    public class Program
    {
        static void Main()
        {
            BankAccount conta1 = new BankAccount("Daniel Gomes", 1);
            conta1.Depositar(10);
            BankAccount conta2 = new BankAccount("Daniel Santos", 2);
            conta2.Depositar(20);

            Console.WriteLine(conta1.saldo);
            Console.WriteLine(conta2.saldo);

            conta1.Sacar(5);
            Console.WriteLine(conta1.saldo);

            conta2.Transferir(6, conta1);
            Console.WriteLine(conta1.saldo);
            Console.WriteLine(conta2.saldo);
        }
        //Criar um Arquivo apra cada classe; -> MAnter o codigo Organizado 

    }


    //Tests
    class MyClasse
    {
        //Passagem por parametro;
        public void Trocar(ref int x)
        {
            x = 10;
        }

        public void TrocarNumero(Numero num)
        {
            num.n = 10;
        }
    }

    public class Numero
    {
        public int n;
    }
    class MyClasse2
    {
        static void Main()
        {
            MyClasse classe = new MyClasse();
            int t = 2;

            classe.Trocar(ref t); //passando referencia do valor;

            Console.WriteLine(t);
            /////


            Numero num = 2;
            classe.TrocarNumero(num);
            Console.WriteLine(num);
        }
    }

    public class Matematica
    {
        //Parametros de Saida;
        public void Multiplicar(int a, int b, out int c)
        {
            c = a * b;
        }

        //Parametro opcional;
        public double Elevar(double n, double pot = 1)
        {
            return Math.Pow(n, pot);
        }

        void main()
        {
            int c;
            Multiplicar(1, 2, c);
            Console.WriteLine(c);
        }
    }



}