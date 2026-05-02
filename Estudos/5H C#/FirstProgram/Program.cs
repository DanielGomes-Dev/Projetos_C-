using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{

    class Program
    {
        enum Cor { Azul = 1, Verde, Amarelo, Vermelho }
        enum Cor2 { Azul = 33, Verde, Amarelo, Vermelho }
        enum Cor3 { Azul = 33, Verde = 50, Amarelo, Vermelho }

        static void first_func(int preco, string nome, int idade = 0, bool test = true)
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Preço: " + preco);

        }
        static void Main(string[] args)
        {

            //Primeiro Programa

            Console.Write("Hello World\n");

            Console.Write("Meu Nome é Daniel\n");

            Console.WriteLine("Hello World");

            Console.WriteLine("Meu Nome é Daniel");


            //Variaveis
            //Int 12
            //Float 12.5
            //Doble 12.88888888
            //Decimal
            //Bool - true ou false
            //String - "Daniel Gomes"
            //Char - 'A'
            var myName = "Daniel Gomes";

            string corFavorita = "Preto";
            int my_age = 22;
            int n11 = 1, n22 = 2, n33;
            float height = 1.81f; // colocar f para dizer q e float
            bool working = true;

            Console.WriteLine(myName);
            Console.WriteLine(my_age);
            Console.WriteLine(corFavorita);
            Console.WriteLine(height);
            Console.WriteLine(working);
            working = false;
            Console.WriteLine(working);

            //Variaveis dinamicas podem ser seus tipos alterados -> não usar muito;
            dynamic variavelDinamica = "Texto";
            Console.WriteLine(variavelDinamica);
            variavelDinamica = 12345;
            Console.WriteLine(variavelDinamica);

            //constantes

            const int numberConstante = 12;
            Console.WriteLine(numberConstante);

            //entrada de usuario;
            Console.WriteLine("Escreva seu nome: ");
            //string name = Console.ReadLine();
            // Console.WriteLine(name);

            //Operadores Aritmeticos;
            int n1 = 20 + 20;
            int n2 = 20 - 20;
            int n3 = 20 * 20;
            int n4 = 20 / 20; //Cuidado com o resultado;
            float n5 = 5f / 2f; //Cuidado com o resultado;
            int n6 = 4 + 20 * 20;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);


            //Estruturas Condicionais
            //retorna true or false
            //Condicoes ->>>  > < >= <= == != 
            //if else

            if (10 > 2)
            {
                Console.WriteLine("entrou no if");
            }

            if (10 < 2)
            {
                Console.WriteLine("entrou no if");
            }
            else
            {
                Console.WriteLine("Entrou no else");
            }

            if (10 < 2)
            {
                Console.WriteLine("entrou no if");
            }
            else if (10 > 3)
            {
                Console.WriteLine("Entrou no else if");
            }
            else
            {
                Console.WriteLine("Entrou no else");
            }


            //Operadores Logicos;
            /// && ||
            /// 
            int idade = int.Parse("123"); //converte strings para numeros

            //Funções C#
            first_func(10, "Camisa");
            Console.WriteLine(Math.Abs(-100));


            //Retorno de funções;
            //void


            //Array ou Vetor
            //Lista de valores;  

            //Não é possivel mudar o tamanho do array;
            string[] productArray = new string[4] { "Daniel", "Gomes", "dos", "Santos" };

            productArray[2] = "Gomes2";

            Console.WriteLine(productArray[0]);
            Console.WriteLine(productArray[1]);
            Console.WriteLine(productArray[2]);
            Console.WriteLine(productArray[3]);

            int[] valores = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(valores[2]);

            //Switch

            string cor = "azul";

            switch (cor)
            {
                case "vermelho":
                    Console.WriteLine("Sua Cor Favorita é Vermelho");
                    break;
                case "rosa":
                    Console.WriteLine("Sua Cor Favorita é Rosa");
                    break;
                case "azul":
                    Console.WriteLine("Sua Cor Favorita é Azul");
                    break;

                default:
                    Console.WriteLine("Você Não tem uma cor favorita");
                    break;

            }

            //Enum -> criar um novo tipo de dados;
            //Outras formas -> classes e struct;

            Cor corFavoritaEnum = Cor.Azul;

            Console.WriteLine(corFavoritaEnum);
            Console.WriteLine((int)corFavoritaEnum); //cast converte para um numero
            Console.WriteLine((Cor)1); //cast converte para uma Cor


            //Enum com switch
            Console.WriteLine("Selecione sua cor favorita");
            Console.WriteLine("1-Azul 2-Verde 3-Amarelo 4-Vermelho");
            int index = int.Parse(Console.ReadLine());

            Cor colorFavorite = (Cor)index;

            switch (colorFavorite)
            {
                case Cor.Azul:
                    Console.WriteLine("Sua Cor Favorita é Azul");
                    break;

                case Cor.Amarelo:
                    Console.WriteLine("Sua Cor Favorita é Amarelo");
                    break;

                case Cor.Vermelho:
                    Console.WriteLine("Sua Cor Favorita é Vermelho");
                    break;

                case Cor.Verde:
                    Console.WriteLine("Sua Cor Favorita é Verde");
                    break;

                default:
                    Console.WriteLine("Valor invalido");
                    break;


            }

            //Estruturas de Repetição, While, For, ForEach, Do While;
            //While
            int countWhile = 0;
            while (countWhile < 10)
            {
                Console.WriteLine(countWhile);
                ++countWhile;
            }
            //Do While;
            do
            {
                Console.WriteLine("log do");
            }
            while (false);

            //foreach -> percorrer arrays

            string[] palavras = { "palavra01", "palavra02", "palavra03", "palavra04" };

            foreach (string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }

            //For

            for (int contador = 0; contador < palavras.Length; ++contador)
            {
                Console.WriteLine(palavras[contador]);
            }

            for (int contador = palavras.Length - 1; contador >= 0; --contador)
            {
                Console.WriteLine(palavras[contador]);
            }



            Console.ReadLine();
        }
    }
}
