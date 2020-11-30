using CalculoDivisores.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDivisores.Domain.Services.Impl
{
    public class Divisores
    {
        public void GetDivisoresEPrimos()
        {
            try
            {
                List<int> listaDivisoresPrimos = new List<int>();
                Console.WriteLine("Entre com um número inteiro maior que 2 para obter seus divisores. E desses divisores, quais são primos:");
                var numeroEntrada = Console.ReadLine();
                Numero numero = new Numero(numeroEntrada);
                Console.WriteLine($"Lista de divisores do número {numeroEntrada}:");
                listaDivisoresPrimos = GetDivisores(numero.NumeroEntrada);
                Console.WriteLine($"Lista de divisores primos do número {numeroEntrada}:");
                ExibeDivisoresPrimos(listaDivisoresPrimos);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Parâmetro inválido: {ex}");
                GetDivisoresEPrimos();
            }
        }

        private void ExibeDivisoresPrimos(List<int> listaDivisoresPrimos)
        {
            foreach (int n in listaDivisoresPrimos)
            {
                Console.Write("{0}\t", n);
            }
        }

        public List<int> GetDivisores(int numeroEntrada)
        {
            List<int> listaDivisoresPrimos = new List<int>();  
            for (int i = 1; i <= numeroEntrada; i++)
            {
                if (numeroEntrada % i == 0)
                {
                    if (IsNumeroPrimo(i))
                        listaDivisoresPrimos.Add(i);
                    Console.Write("{0}\t", i);
                }
            }
            Console.WriteLine();
            return listaDivisoresPrimos;
        }
        public static bool IsNumeroPrimo(int numero)
        {
            bool bPrimo = false;
            
            if (numero != 1)
            {
                bPrimo = true;
                int fator = numero / 2;
                int i = 0;
                for (i = 2; i <= fator; i++)
                {
                    if ((numero % i) == 0)
                        bPrimo = false;
                }
                return bPrimo;
            }

            return bPrimo;
        }
    }
}
