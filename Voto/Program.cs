using Voto;
namespace Voto;

public class Aprovação
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome da pessoa:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a idade da pessoa:");
        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, idade);

        Console.WriteLine($"{pessoa.Nome} tem {pessoa.Idade} anos.");
        if (idade >= 18&&pessoa.Pode)
        {
            Console.WriteLine($"{pessoa.Nome} pode votar e é obrigatório");
        }else if (idade >= 16 && idade <18 && pessoa.Pode){
            Console.WriteLine($"{pessoa.Nome} pode votar, porém não é obrigatório");
        }
        else
        {
            Console.WriteLine($"{pessoa.Nome} não pode votar.");
        }
    }
}