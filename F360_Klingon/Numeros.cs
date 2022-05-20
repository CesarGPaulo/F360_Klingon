using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F360_Klingon
{
    public class Numeros
    {
        public void NumerosBonitos(string textoKlingon)
        {
            var alfabetoKlingon = new List<char> { 'k', 'b', 'w', 'r', 'q', 'd', 'n', 'f', 'x', 'j', 'm', 'l', 'v', 'h', 't', 'c', 'g', 'z', 'p', 's' };
            var palavras = textoKlingon.Split(" ");

            int numerosBonitos = 0;
           

            foreach (var palavra in palavras)
            {
                var numero = 0;
                int peso = 1;

                foreach(var letra in palavra)
                {
                    numero += alfabetoKlingon.IndexOf(letra) * peso;
                    peso *= 20;
                }
                
                if(numero >= 440566 && (numero % 3) == 0)
                {
                    numerosBonitos++;
                }
                    
            }
            Console.WriteLine($"a quantidade de numeros bonitos é: {numerosBonitos}\n");

        }

    }
}
