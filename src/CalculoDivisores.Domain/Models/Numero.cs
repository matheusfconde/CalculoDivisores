using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDivisores.Domain.Models
{
    public class Numero
    {
        public int NumeroEntrada { get; set; }

        public Numero(string numeroEntrada)
        {
            if (validaEntrada(numeroEntrada))
            {
                int numeroValidado = int.Parse(numeroEntrada);

                if (numeroValidado <= 1)
                {
                    throw new ArgumentException("Parametro inválido, favor entrar com um número maior que 2!");
                }

                this.NumeroEntrada = numeroValidado;
            }
            else
            {
                throw new ArgumentException("Parametro inválido, favor entrar com um número maior do que 2!");
            }
        }

        public bool validaEntrada(string numeroEntrada)
        {
            int resultado;
            return int.TryParse(numeroEntrada, out resultado);
        }
    }
}
