//file:///E:/Cursos/Programa%C3%A7%C3%A3o/C%23/01%20-%20Curso%20Softblue%20C%23%20-%20Fundamentos/4%20-%20Classes%20e%20Estruturas/Slides%20-%20Classes%20e%20Estruturas.pdf

namespace MyNamespace
{

    //Classes e objetos
    //• Fields
    //• Métodos
    //• Armazenamento em memória
    //– Stack
    //– Managed heap

    //• Passagem de parâmetros
    //– Por valor
    //– Por referência
    //– Parâmetos de saída
    //– Parâmetros opcionais
    //– O modificador params

    //• Sobrecarga de métodos
    //• Nullable Types
    //• Operador ?? (null-coalescing)
    //• Estruturas
    //– Instanciação
    //– Diferenças entre classes e estruturas


    //• Linguagens de programação mais modernas passaram a adotar a programação orientada a objetos
    //– Ex: C++, Java, C#, Visual Basic .NET
    //– É um paradigma de programação centrado em objetos e na interação entre eles

    //Classes
    //• Desempenham um papel central na orientação a objetos
    //• Definem um modelo para os objetos
    //• Classes são tipos de dados,

    class Caneta //-> criando uma classe
    {

    }

    //Objetos
    //• A partir de uma classe, podemos criar objetos (ou instâncias

    //Criação de Objetos
    //• A criação (instanciação) de um objeto é feita usando o operador new
    Caneta c1 = new Caneta();
    Caneta c2 = new Caneta();

    //Fields
    //• Uma classe pode definir fields
    //• Representam características, informações, atributos objetos de uma classe

    class Caneta
    {
        int cor;
        string marca;
        int anoFabricacao;
        int corTinta;
    } //Fields ou Atributos

    //• Os fields podem ser chamados diretamente em objetos
    //– Dependendo da sua visibilidade

    class Caneta2
    {
        public int cor;
        public string marca;
        public int anoFabricacao;
        public int corTinta;
    } //Visibilidade public

    void tesetAtributos()
    {
        Caneta c = new Caneta2();
        c.cor = 10;
        c.marca = "Bic";
        Console.WriteLine(c.marca);
    }


    //Métodos
    //• Métodos são operações associadas à classe
    //• Estas operações podem ser invocadas por alguém que quer interagir com objetos da classe

    class Caneta
    {
        void Escrever(string texto)
        {
        }
        void Abrir()
        {
        }
    } //Metodos;

    //Declaração de Métodos
    //• Um método tem uma assinatura
    //[modificadores]
    //tipo_retorno Nome([parâmetros]);
    //• Exemplo
    void Escrever(string texto) { }
    //• Método Main()
    static void Main()
    {

    }

    //Retorno em Métodos
    //• Um método não precisa devolver uma informação para quem o chamou
    void EscreverMensagem(string msg)
    {
        Console.WriteLine(msg);
    }

    //• Um método pode devolver alguma informação
    int Somar(int n1, int n2)
    {
        int r = n1 + n2;
        return r;
    }

    //Invocação de Métodos
    //• Métodos podem ser invocados em objetos
    //– Depende da visibilidade

    class Math
    {
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
    void tesetMetodos()
    {
        Math m = new Math();
        int soma = m.Somar(15, 6);
    }

    //Passagem de Parâmetros

    /*
    • Métodos podem receber zero ou mais parâmetros
    • Parâmetros podem ser fornecidos a métodos de duas formas
        – Por valor
    • O valor é copiado para o parâmetro
        – Por referência
    • A referência à área de memória onde o dado está armazenado é fornecida como parâmetro

    • No C#, o padrão é passar os parâmetro por valor

    • Na passagem por referência a área de memória é passada como parâmetro
    • É preciso usar o modificador ref na declaração do método e na chamada

    */


    /*
    Parâmetros de Saída
    • São parâmetros cujos valores são definidos pelo método chamado
        – Quem chama o método não precisa inicializar a variável
    • Os parâmetros de saída são designados através do modificador out
        – O C# passa parâmetros de saída como referência de forma automática

    */

    void Somar(int x, int y, out int r)
    {
        r = x + y;
    }

    void testParamSaida()
    {
        int x;
        Somar(5, 10, out x); //Usado para retornar varios valores;
    }

    /*
    Parâmetros Opcionais
    • São parâmetros que podem ou não ser passados
        – Se não forem passados, assumem um valor padrão

    Parâmetros opcionais 
    devem ser declarados 
    por último

    */

    int Calcular(int x, int y, char op = '+')
    {
        if (op == '+')
        {
            return x + y;
        }
        else if (op == '-')
        {
            return x - y;
        }
        return 0;
    }

    /*
    O modificador param
    */
    //Este tipo de parâmetro deve ser declarado por último
    int Somar(params int[] valores)
    {
        int soma = 0;
        foreach (int v in valores)
        {
            soma += v;
        }
        return soma;
    }

    int r = Somar(1, 3, 7, 2);


    /*
    Sobrecarga de Métodos
    • Sobrecarregar um método significa criar outros métodos com o mesmo nome, mas com assinatura diferente


    */

    int Somar(int a, int b) { }
    int Somar(int a, int b, int c) { }
    double Somar(double a, double b) { }
    long Somar(long a, long b, long c) { }
    void Somar(int a, int b, out int c) { }

    //Mudar só o tipo do retorno gera erro de compilação
    //A mudança pode ser feita nos parâmetros (tipo e/ou quantidade) e no tipo de retorno

    /*
    Nullable Types
    • Permite que value types possam receber null
        – Não pode ser usado por reference types
    */

    //Não compila, pois null só pode ser usado com reference types
    bool b = null;
    int i = null;

    //O uso do ? como sufixo do valuetype permite a atribuição do null
    bool? b = null;
    int? i = null;

    //Permite testar se o valor da variável é null

    void testNull()
    {
        if (b != null) { }
        if (b.HasValue) { }

    }

    /*
    
    Operador ??
    • Null-coalescing operator
    • Permite atribuir um valor padrão a uma variável se o valor dela for null
    
    */

    void testCoalescing()
    {
        //b2 recebe o valor de b1.Se b1 for null, b2 recebe false
        bool? b1 = null;
        bool b2 = b1 ?? false;
    }

    /*
    Estruturas
    • Também chamadas de strutctures ou structs
    • São estruturas de dados usadas para agrupar dados
    • A declaração é bastante similar às classes
        – Estruturas também podem conter fields e/ou métodos

    */
    struct Fracao
    {
        public double numerador;
        public double denominador;
        public double Dividir()
        {
            return numerador / denominador;
        }
    }

    /*
    Instanciação de Estruturas
    • A instanciação é similar a encontrada em classes

    */

    Fracao f = new Fracao();

    /* Ou
    Fracao f;
    f.numerador = 5;
    f.denominador = 10;

    */


    //Classe vs Struct;
    // Class -> ReferenceTypes / Struct -> ValueTypes;
    //Class -> Contrutor com/sem params / Struc -> Sempre sem param;

    /*
    • Estruturas devem ser usadas para tipos de dados simples
        – O fato de estruturas serem value types impacta na passagem de parâmetros
        – Por outro lado, são rapidamente removidas da memória, pois são criadas na stack
    */

    /*
    • Um nested type (ou inner type) é um tipo definido dentro de uma classe ou estrutura

    */

    class Outer
    {
        class Inner
        {
        }
    }


    /*
    A Notação UML
        • Unified Modeling Language
        • Utilizada para documentar sistemas orientados a objetos
        • Composta por diversos diagramas
            – Um deles é o Diagrama de Classes, que mostra as classes do sistema, juntamente com seus respectivos métodos e fields

    Diagrama de Classes -> Pesquisar;

    */
}
