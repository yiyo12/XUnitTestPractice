using Practice_UnitTestWhitXUnit;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XunitTesting.Test
{
   public class MailValidatorShould
    {
        //[Fact] // palabra que define que es testeable
        //public void ValidateValidEmails()
        //{
        //    // Arrange
        //    // Definimos las variables u objetos que vamos a ocupar 
        //    var mailValidator = new MailValidator();
        //    string emailMock = "thecodercaveokm@gmail.com";

        //    // ACT
        //    // Definimos que queremos hacer o que accion se va a realizar
        //    bool isValid = mailValidator.IsValidEmail(emailMock);

        //    //Asser
        //    // Assert tiene una aserie de metodos staticos que validan algunas cosas, el mensaje o el segundo atributoi de true es un mensaje para cuando no cumple
        //    Assert.True(isValid, $"{emailMock} is not valid");
        //}

        //[Fact]
        //public void InvdalidateInvalidEmail()
        //{
        //    // Arrange
        //    // Definimos las variables u objetos que vamos a ocupar 
        //    var mailValidator = new MailValidator();
        //    string emailMock = "thecodercaveokm@gmail.commm";

        //    // ACT
        //    // Definimos que queremos hacer o que accion se va a realizar
        //    bool isValid = mailValidator.IsValidEmail(emailMock);

        //    //Assert
        //    // Assert tiene una aserie de metodos staticos que validan algunas cosas
        //    Assert.False(isValid);
        //}



        [Theory] // nos permite agregar mas dinamicamente , un DDT drive data testing
        [InlineData("thecodercaveokm@gmail.commm", false)] // inline datra nos permite mandar eesta data como parametros
        [InlineData("thecodercaveokm@gmail.com", true)]
        public void ValidateEmail(string email, bool expected)
        {
            // Arrange
            // Definimos las variables u objetos que vamos a ocupar 
            var mailValidator = new MailValidator();

            // ACT
            // Definimos que queremos hacer o que accion se va a realizar
            bool isValid = mailValidator.IsValidEmail(email);

            //Assert
            // Assert tiene una aserie de metodos staticos que validan algunas cosas
            Assert.Equal(expected,isValid);
        }


        [Theory] // nos permite agregar mas dinamicamente , un DDT drive data testing
        [InlineData("thecodercaveokm@spam.com", "SPAM")] // inline datra nos permite mandar eesta data como parametros
        [InlineData("thecodercaveokm@gmail.com", "INBOX")]
        public void IdentifySpam(string email, string expected)
        {
            // Arrange
            // Definimos las variables u objetos que vamos a ocupar 
            var mailValidator = new MailValidator();

            // ACT
            // Definimos que queremos hacer o que accion se va a realizar
            string result = mailValidator.IsSpam(email);

            //Assert
            // Assert tiene una aserie de metodos staticos que validan algunas cosas
            Assert.Equal(expected,result);
        }


        //Cuando una exepcion es esperada
        [Fact]
        public void ThrowExceptionWhenNullEmail()
        {
            // Arrange
            var mailValidator = new MailValidator();

            // ACT

            //Assert
            Assert.Throws<MailNotProvidedException>(() => mailValidator.IsValidEmail(null));
           // Assert.Throws<Exception>(() => mailValidator.IsValidEmail(null)); no funciona porque no es lo que stamos esperando
        }

        

    }
}
