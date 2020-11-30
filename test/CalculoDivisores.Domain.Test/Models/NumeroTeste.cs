using CalculoDivisores.Domain.Models;
using CalculoDivisores.Domain.Test.Utilidades;
using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace CalculoDivisores.Domain.Test.Dividers
{
    public class DividersTest
    {
        [Fact]
        public void Numero_RetornaNumeroValido()
        {
            var numeroEntradaValido = new
            {
                NumeroEntrada = 12,
            };

            var numero = new Numero(numeroEntradaValido.NumeroEntrada.ToString());

            numeroEntradaValido.ToExpectedObject().ShouldMatch(numero);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Numero_NumeroMenorQue1_RetornaArgumentException(string numeroInvalido)
        {
            string mensagemError = "Parametro inválido, favor entrar com um número maior do que 2!";
            Assert.Throws<ArgumentException>(()
                  => new Numero(numeroInvalido)).ValidarMensagem(mensagemError);
        }

    }
}
