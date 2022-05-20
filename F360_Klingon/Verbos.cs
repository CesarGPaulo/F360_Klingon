using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F360_Klingon
{
    public class Verbos
    {
        public void VerbosKligon(string textoKligon)
        {
            //os verbos sempre são palavras de 8 ou mais letras que terminam numa letra tipo foo.
            //Além disso, se um verbo começa com uma letra tipo bar, o verbo está em primeira pessoa.
            int contadorVerbos = 0;
            int contadorVerbosEmPrimeiraPessoa = 0;

            var letrasFoo = new List<char> { 's', 'l', 'f', 'w', 'k' };

            string[] qtdePalavras = textoKligon.Split(' ');
            foreach (var qt in qtdePalavras)
            {
                var ultimaLetra = qt[qt.Length - 1];
                var primeiraLetra = qt[0];

                if (qt.Length >= 8 && letrasFoo.Contains(ultimaLetra))
                {
                    contadorVerbos++;
                    if (!letrasFoo.Contains(primeiraLetra))
                        contadorVerbosEmPrimeiraPessoa++;
                }
            }
            Console.WriteLine($"A quantidade de verbos no texto é de {contadorVerbos}\nE a quantidade de verbos em primeira pessoa é de {contadorVerbosEmPrimeiraPessoa}\n");
        }
    }
}
