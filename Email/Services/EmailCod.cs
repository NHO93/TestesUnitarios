using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email.Services
{
    public class EmailCod
    {
        public void EmailSenhaValidos(string email, string senha)
        {
            if (email.Contains("@") && email.Contains(".com") && senha.Length >= 6)
            {
                Console.WriteLine("Email e senha válidos");
            }
            else
            {
                Console.WriteLine("Email e senha inválidos");
            }
        }

        public void EmailSenhaInvalidos() => EmailSenhaValidos("anajoaquinaemail.com", "123456");

        public void EmailSenhaInvalidos2() => EmailSenhaValidos("anajoaquina@email.com", "12356");

        public void EmailSenhaInvalidos3() => EmailSenhaValidos("anajoaqu ina@email.com", "12 356");

        public void EmailSenhaInvalidos4() => EmailSenhaValidos("", "");
    }
}