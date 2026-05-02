using System.Collections.Generic;
using System;

namespace O
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Arquivo> arquivos = new List<Arquivos>();
            ArquivoWord x = new ArquivoWord();
            ArquivoPDF y = new ArquivoPDF();
            ArquivoTXT z = new ArquivoTXT();
            arquivos.Add(x);
            arquivos.Add(y);
            arquivos.Add(z);

            GeradoraDeArquivos g = new GeradoraDeArquivos();
            g.GerarArquivos(arquivos);
            Console.Read();
        }
    }
}