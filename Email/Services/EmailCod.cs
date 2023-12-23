using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email.Services // Namespace Email.Services
{
    public class EmailCod // Classe EmailCod
    {
        public bool EmailSenhaValidos(string email, string senha) // Método que verifica se o email e a senha são válidos
        {
            if (email.Contains("@") && email.Contains(".com") && senha.Length >= 6) // Verifica se o email e a senha são válidos
            {
               return true; // Retorna true se o email e a senha são válidos
            }
            else
            {
                throw new Exception("Email ou senha inválidos"); // Retorna uma exceção se o email e a senha não são válidos
            }
        }
    }
}