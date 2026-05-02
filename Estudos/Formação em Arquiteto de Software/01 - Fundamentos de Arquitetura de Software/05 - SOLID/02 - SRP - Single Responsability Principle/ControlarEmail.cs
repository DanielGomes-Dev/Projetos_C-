namespace System
{
    class ControlarEmail
    {
        public bool validEmail(string email)
        {
            var address = new System.Net.MailAddress(email);
            return address.Address == email;
        }
        public void sendEmail(string email, string mensagem)
        {
            Console.Write("Enviando Email");
        }
    }
}