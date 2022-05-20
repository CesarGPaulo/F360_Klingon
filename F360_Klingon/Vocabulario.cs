using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F360_Klingon
{
    public class Vocabulario
    {
        public void VocabularioKligon(string textoKligon)
        {
            var alfabetoKlingon = new List<char> { 'k', 'b', 'w', 'r', 'q', 'd', 'n', 'f', 'x', 'j', 'm', 'l', 'v', 'h', 't', 'c', 'g', 'z', 'p', 's' };
            
            var textoSemRepeticao = textoKligon.Split(' ')
                                               .Distinct()
                                               .ToList();
            
            List<string> vocabulario = new List<string>();

            vocabulario = textoSemRepeticao.OrderBy(x => alfabetoKlingon.IndexOf(x[0]))
                                           .ThenBy(x => alfabetoKlingon.IndexOf(x[1]))
                                           .ThenBy(x => alfabetoKlingon.IndexOf(x[2])).ToList();
            
            var texto = new StringBuilder("");
            foreach(var palavra in vocabulario)
            {
                texto.Append($"{palavra} ");
            }

            Console.WriteLine($"{texto}\n");

        }
    }
}
