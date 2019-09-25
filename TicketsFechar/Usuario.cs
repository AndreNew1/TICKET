namespace TicketsFechar
{
    public class Usuario : Base
    {
        public string Nome { get; set; }  // fluent validation (maior que 3 caracteres) , not null 
        public string Email { get; set; } // fluent validation (EmailAddress) not null.
        public string Senha { get; set; } // criptrografar e descriptografar. not null.
        public string Tipo { get; set; } //cliente ou atendente. not null.

    }
}