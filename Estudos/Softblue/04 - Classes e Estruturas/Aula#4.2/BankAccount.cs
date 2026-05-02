using System;

namespace ClassesObjetos
{

    //Criar um Arquivo apra cada classe; -> Manter o codigo Organizado 
    public class BankAccount
    {
        //Fields / Atributos;
        private string titular;
        private int numAccount;
        private double saldo;

        public BankAccount(string Titular, int NumAccount)
        {
            titular = Titular;
            numAccount = NumAccount;
            saldo = 0;
        }


        public void Sacar(double value)
        {
            if (value > saldo && value <= 0) return;
            saldo -= value;
        }

        public void Depositar(double value)
        {
            if (value <= 0) return;
            saldo += value;
        }

        public void Transferir(double value, BankAccount accountDestiny)
        {
            Sacar(valor);
            accountDestiny.Depositar(valor);
        }
    }

}