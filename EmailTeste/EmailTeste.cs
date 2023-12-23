using Email.Services;

namespace EmailTeste;

public class EmailTeste
{
    public required string Email { get; set; }
    public required string Senha { get; set; }
    
    [Fact]
    public void EmailSenhaValidos() // Teste passa pois o email é válido
    {
        // Arrange
        var email = "anajoaquina@email.com";
        var senha = "123456";
        // Act
        var emailCod = new EmailSenha();
        // Assert
        Assert.Equal(email, emailCod.EmailSenha(email, senha));

    }
    [Fact]
    public void EmailSenhaInvalidos() // Teste falha pois o email não é válido
    {
        // Arrange
        var email = "anajoaquinaemail.com";
        var senha = "123456";
        // Act
        var emailCod = new EmailSenha();
        // Assert
        Assert.Equal(email, emailCod.EmailSenha(email, senha));

    }
    [Fact]
    public void EmailSenhaInvalidos2() // Teste falha pois a senha não é válido
    {
        // Arrange
        var email = "anajoaquinaemail.com";
        var senha = "12356";
        // Act
        var emailCod = new EmailSenha();
        // Assert
        Assert.Equal(email, emailCod.EmailSenha(email, senha));

    }
    [Fact]
    public void EmailSenhaInvalidos3() // Teste falha pois o email e a senha não são válidos
    {
        // Arrange
        var email = "anajoaquinaemail.com";
        var senha = "12356";
        // Act
        var emailCod = new EmailSenha();
        // Assert
        Assert.Equal(email, emailCod.EmailSenha(email, senha));

    }
        [Fact]
        public void EmailSenhaInvalidos4() // Teste falha pois o email e a senha não são válidos pois contem espaços
        {
            // Arrange
            var email = "anajoaquina@email.com";
            var senha = "123456";
            // Act
            var emailCod = new EmailSenha();
            // Assert
            Assert.Equal(email, emailCod.EmailSenha(email, senha));

        }
}

internal class EmailSenha
{
    public EmailSenha()
    {
    }

    internal IEnumerable<char> EmailSenha(string email, string senha) => throw new NotImplementedException();
}