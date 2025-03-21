//Projeto de revisão do curso até o momento

/*## **Descrição do Projeto**

Vamos criar um programa que gerencie uma **lista de notas de alunos** e calcule a média. O usuário poderá:

1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)
2. Exibir as notas e calcular a média.
3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).*/

using System.Globalization;

Console.WriteLine("=== Gerenciador de Notas ===");

try
{
    double[] notas = new double[6];
    
    //captando as notas do aluno
    for (int i = 1; i < notas.Length; i++)
    {
        Console.WriteLine($"Digite a {i}ª nota: ");
        notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (notas[i] < 0 ||  notas[i] > 10)
        {
            throw new ArgumentOutOfRangeException("Nota inválida.");
        }
    }
    

    Console.WriteLine(" ");

    //exibindo as notas do aluno
    for (int i = 1; i < notas.Length; i++)
    {
        Console.WriteLine($"A {i}ª nota é: {notas[i]}");
    }

    Console.WriteLine(" ");

    Console.WriteLine($"A média das notas é {notas.Average()}");

    string resultado = (notas.Average() >= 7) ? "Aprovado" : "Reprovado";
    Console.WriteLine(resultado);
}
catch (FormatException)
{
    Console.WriteLine("Informe somente números.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Nota inválida.");
}
{

}
   