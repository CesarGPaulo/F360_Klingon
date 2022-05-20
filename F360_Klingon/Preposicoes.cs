using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F360_Klingon
{
    public class PreposicoesKlingon
    {
        public void PreposicoesKligon(string textoKligon)
        {
            int contadorPreposicoes = 0;

            var letrasFoo = new List<char> { 's', 'l', 'f', 'w', 'k' };

            //as preposicoes são palavras de 3 letras && não terminam com uma letraFoo && não ocorre a letra "d"
            string[] qtdePalavras = textoKligon.Split(' ');
            foreach (var qt in qtdePalavras)
            {
                var ultimaLetra = qt[qt.Length - 1];
                if (qt.Length == 3 && !letrasFoo.Contains(ultimaLetra) && !qt.Contains('d'))
                    contadorPreposicoes++;
            }

            Console.WriteLine($"o numero de preposições é: {contadorPreposicoes}\n");
        }
    }
}
