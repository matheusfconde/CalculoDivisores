using CalculoDivisores.Domain.Models;
using CalculoDivisores.Domain.Services.Impl;
using System;

namespace CalculoDivisores.Domain
{
    class Program
    {
        static void Main(string[] args)
        {            
            Divisores div = new Divisores();            
            div.GetDivisoresEPrimos();
            Console.ReadKey();
        }
    }
}
