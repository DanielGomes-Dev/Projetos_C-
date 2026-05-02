using System.Net.Http;
using System.Runtime.InteropServices;
using System.Data;
using System;
using System.Collections.Generic;


namespace fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento;

            Console.WriteLine("Hello World!");
        }
    }
}


//Encapsulamento; -> Juntar Tudo;

//Abstração -> Esconder Detalhes;

//Herança -> Herdar Metodos propriedades e eventos de outras classes;

//Polimorfismo -> Sobnescrever metodos -> virtual -> override


public class Pagamento
{
    //Variaveis -> Propriedades
    DateTime Vencimento

    //Metodos;
    public virtual Pagar()
    {
    }


    //Eventos;
    //event AoPagar;
}


class PagamentoBoleto : Pagamento
{ //Herança

    public string NumeroBoleto;
    Address BillingAddress;

    public override void Pagar();

}

class PagamentoCartao : Pagamento
{ //Herança

    private void ConsultarSaldoDoCartao()
    {

    }

}


//Modificadores de Acesso;

//private, protected, internal e public;
//private -> acessivel apenas na classe;
//protected -> acessivel para os filhos;
//internal -> acessivel apenas dentro do mesmo namespace;
//public -> visivel como um todo;

//Tipos Complexos;
public class Address
{
    string AddressCode;
}


//Propriedades;
//prop -> e dar tab

class PropsTest
{

    //prop
    public int TestSimples { get; set; };

    //propg
    public int MyProperty { get; private set; }

    //propfull
    private int myVar;
    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }

    public DateTime _test;
    public DateTime Test
    {
        get
        {
            Console.WriteLine("Lendo Valor");
            return _test
        };
        set
        {
            ConstraintCollection.WriteLine("Atribuindo Valor")
            _dataPagamento = value;
        };
    }

}


//Metodos;
//Sobrecarga de metodos; -> metodos com nomes iguais e assinaturas diferentes;
//Sobre Escrita de Metodos; -> reescrever o metodos com virtual e override;
//chamar um metodo do pai com "base.Metodo();"

class TesteMetodos
{
    //Metodo Construtor;
    //ctor

    public TesteMetodos(Parameters)
    {
        //chamado quando instanciamos a classe;
    }


    public void Pagar(string numero) { }

    public void Pagar(string numero, DateTime vencimento, bool pagaVencimento = false) { }

}

//Using e Dispose


//Classes Estaticas;

public static class Settings
{
    //classes estaticas nao podem ser instanciadas;
    //Fica disponivel na memoria da aplicação;
    //classes staticas metodos e propriedades staticas;
    public static string API_URL { get; set; }
}

//Settings.API_URL;

//Classes Selladas; selled;
//classes que nao podem ser herdadas;

//------------------

//Partial Class ->  classes parciais; -> dividir classes em duas ou mais partes;

//Interfaces -> Contrato;

public interface IPayment
{
    int MyProperty { get; set; }
    int MyProperty2 { get; set; }
    void Pagar(double valor);
}

public class Payment : IPayment
{

}

//Classes Abstratas; classes que so servem para ser herdadas; e nao podem ser instanciadas;

public abstract class Pagamento : IPayment
{

}

// upcast e downcast;

// Comparando objetos; Equal

//delegates -> delegar;

//public delegate void Pagar(double);

//Events -> eventos sempre em conjunto com delegates;


public class Room
{
    public int Seats { get; set; }
    public int SeatsInUse { get; set; }
    public Room(int seats)
    {
        Seats = seats;
    }

    public void ReserveSeat()
    {
        SeatsInUse++;
        if (SeatsInUse >= Seats)
        {
            Console.WriteLine("Eventos Cheio");
        }
    }

    public event EventHandler RoomSoldOut;

    protected virtual void OnRoomSoldOutEvent(EventArgs e)
    {
        EventHandler handler = RoomSoldOut;
        handler?.Invoke(this, e);
    }

    room.RoomSoldOut += RoomSoldOutEvent;
}


//Tipos GEnericos no C#;

public class DataContext<T>
{
    public void Save(T entity)
    {

    }
}

public class DataContext2<T>
where T : Person
{

    public void Save(T entity)
    {

    }
}


public class Person { }
public class Payment { }
public class Subscription { }

var person = new Person();
var context = new DataContext<Person>();
context.Save(person);


//Listas;


public class TestList
{
    public void test()
    {
        var payment = new Payment();
        var payments = new List<Payment>();
        IEnumerable<Payment> payments2 = new List<Payment>();
        payments.Add(payment);
        payments.Add(payment);
        payments.Add(payment);
        payments.Add(payment);
        foreach (var p in payments)
        {
            Console.WriteLine(p);
        }

        var pay = payments.Find(x => x.Id == x.Id);
        payments.Remove(payment);
        payments.Clear();

    }
}

