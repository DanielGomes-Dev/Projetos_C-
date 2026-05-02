using System.Collections.Generic;

namespace O
{
    class GeradoraDeArquivos
    {
        public void GerarArquivos(IList<Arquivo> arquivos)
        {
            foreach (var arquivos in arquivos)
            {
                arquivos.Gerar();
            }
        }
    }
}