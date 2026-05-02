namespace System
{
    class CadastrarUsuario
    {
        public int id;
        public string nome;
        public string email;

        public CadastrarUSuario(int id, string nome, string email)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            ControlarEmail emailService = new ControlarEmail();
            emailService.validEmail(email);
            emailService.sendEmail(email);
        }

        public validarUsuario()
        {

        }

        //Classe de Cadastro de usuario nao deve ter metodo de validar email nem de enviar email;
        //Quem deveria fazer isso é uma classe de email

        // public bool validEmail(string email)
        // {
        //     var address = new System.Net.MailAddress(email);
        //     return address.Address == email;
        // }

        // public void sendEmail(string email, string mensagem)
        // {
        //     Console.Write("Enviando Email");

        // }
    }
}