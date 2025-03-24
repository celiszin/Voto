using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voto
{
   public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public bool Pode {  get; set; }



        public Pessoa(string pNome, int pIdade)
        {
            Nome = pNome;
            Idade = pIdade;
        }



        public podeVotar(int Idade, bool Pode)
        {
            if (Idade < 16 | Idade >= 0)
            {
                Pode = false;
            }
            else if (Idade <= 17 | Idade >= 16)
            {
                Pode = true;
            }
            else
            {
                Pode = true;
            }

            return Pode;
        }

}
