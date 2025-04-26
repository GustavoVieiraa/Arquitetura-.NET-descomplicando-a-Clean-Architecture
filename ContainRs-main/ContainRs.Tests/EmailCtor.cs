using ContainRs.Domain.Models;

namespace ContainRs.Tests
{
    public class EmailCtor
    {
        [Fact]
        public void Deve_Lancar_ArgumentException_Quando_Valor_Invalido()
        {
            //Arrange
            string emailInvalido = "www.testeinvlaido";

            //Act & //Assert
            Assert.Throws<ArgumentException>(() => new Email(emailInvalido));
            
        }

        [Fact]
        public void Deve_Validar_Email_Valido_Quando_Valor_Valido()
        {
            //Arrange
            string emailValido = "gustavieiradev@gmail.com";
            //Act
            Email email = new Email(emailValido);
            //Assert
            Assert.Equal(email.Value, emailValido);
        }
    }
}