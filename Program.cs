using System; 
using System.Globalization; 

class Program 
{
    static void Main() 
    {
        Console.Write("Digite seu nome: "); 
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua altura (ex: 1.75): ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("\nAgora irei calcular o seu IMC (Índice de Massa Corporal):");

        double imc = peso / (altura * altura);

        Console.WriteLine($"\n{nome}, você tem {idade} anos, pesa {peso} quilos, seu IMC é {imc:F2} e você mede {altura} metros.");
    }
}
