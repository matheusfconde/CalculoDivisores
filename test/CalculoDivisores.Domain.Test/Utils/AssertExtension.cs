﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculoDivisores.Domain.Test.Utilidades
{
    public static class AssertExtension
   {
        public static void ValidarMensagem(this ArgumentException argumentException, string mensagemError)
        {
            if (argumentException.Message == mensagemError)
            {
                Assert.True(true);
            }
            else
            {
                Assert.False(true, $"A mensagem esperada é {mensagemError}");
            }
        }
    }
}
