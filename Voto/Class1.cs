namespace Voto
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Pode { get; set; }

        public Pessoa(string pNome, int pIdade)
        {
            Nome = pNome;
            Idade = pIdade;
            Pode = PodeVotar(); 
        }
        private bool PodeVotar() 
        {
            if (Idade < 16)
            {
                return false;
            }
            else if (Idade >= 16 && 16 < 18)
            {
                return true;

            }
            else
            {
                return true;
            }
        }
    }
}