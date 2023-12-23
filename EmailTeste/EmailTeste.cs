using Email.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

public class EmailTeste
{
  private EmailCod emailCod; // Instancia da classe EmailCod
    public EmailTeste() // Construtor
    {
        emailCod = new EmailCod(); // Instancia da classe EmailCod
    }
    
    [Fact]
    public void EmailSenhaValidos() // Teste passa pois o email é válido
    {
        // Arrange
        var email = "anajoaquina@email.com";
        var senha = "123456";
        // Assert
        Assert.True(emailCod.EmailSenhaValidos(email, senha)); // Verifica se o email e a senha são válidos

    }
    [Fact]
    public void EmailSenhaInvalidos() // Teste falha pois o email não é válido
    {
        // Arrange
        var email = "anajoaquinaemail.com";
        var senha = "123456";
    
        // Assert
        Assert.Throws<Exception>(() => emailCod.EmailSenhaValidos(email, senha));
    }
    [Fact]
    public void EmailSenhaInvalidos2() // Teste falha pois a senha não é válido
    {
        // Arrange
        var email = "anajoaquinaemail.com";
        var senha = "12356";
        
        // Assert
        Assert.Throws<Exception>(() => emailCod.EmailSenhaValidos(email, senha));

    }
    [Fact]
    public void EmailSenhaInvalidos3() // Teste falha pois o email e a senha não são válidos
    {
        // Arrange
        var email = "anajoaquinaemail.com";
        var senha = "12356";
    
        // Assert
        Assert.Throws<Exception>(() => emailCod.EmailSenhaValidos(email, senha));

    }
}