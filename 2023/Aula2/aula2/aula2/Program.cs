namespace aula2;
public class Program
{
    public static void Main(string[] args)
    {
        /*
        Console.WriteLine("Digte a idade ");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Acompanhado? \n false - Não | true - Sim");
        bool acompanhado = bool.Parse(Console.ReadLine());
        if(idade >= 18 && acompanhado == true)
        {
            Console.WriteLine("Acesso autorizado!");
        }
        else
        {
            Console.WriteLine("Acesso NÃO autorizado");
        }
        */

        /*
        Console.WriteLine("Digite o valor de saque");
        double saque = double.Parse(Console.ReadLine());
        int[] notas = new int[] {100, 50, 20, 10, 5, 2}; 
        for (int i = 0; i < notas.Length; i++)
        {
            int qtdNotas = (int) saque / notas[i];
            saque = saque - (qtdNotas * notas[i]);
            Console.WriteLine("Notas de " + notas[i] + 
                ": " + qtdNotas);
        }
        */
        /*
        int valor = 0;
        while(valor <= 100)
        {
            if(valor%3 == 0)
            {
                Console.Write(valor + " - ");
            }
            valor++;
        }
        */
        Console.WriteLine("Digite um número para ver sua tabuada");
        int numero = int.Parse(Console.ReadLine());
        int i = 0;
        do
        {
            i++; 
            Console.WriteLine(numero + " x " + i + " = " + (numero*i));
        } while (i < 10);

        Console.ReadLine(); // Aguarada uma tecla para enecrrar.
    }
}
