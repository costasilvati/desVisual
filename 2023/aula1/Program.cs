using System.IO;
public class Program
{
    static void Main(string[] args)
    {
        /* Atividade de aula 1
        int[] notas = new int[] { 100, 50, 20, 10, 5, 2 };
        Console.WriteLine("Digte o valor de saque");
        double saque = double.Parse(Console.ReadLine());
        if(saque > 0)
        {
            for(int i = 0; i < notas.Length; i++)
            {
                int qtd = (int) saque / notas[i];
                Console.WriteLine("Quantidade notas de " + notas[i] + ": "+ qtd);
                saque = saque - (notas[i] * qtd);
            }
        }*/
        // Leitura e escritade arquivos
        string caminhoArquivo = "E:/CSharp/IntroducaoAoCSharp/aula1Dados.csv";
        if (File.Exists(caminhoArquivo))
        {
            Stream file = File.Open(caminhoArquivo, FileMode.Open);
            StreamReader leitor = new StreamReader(file);
            string linha = leitor.ReadLine();
            while(linha != null)
            {
                Console.WriteLine(linha);
                linha = leitor.ReadLine();
            }
            leitor.Close();
            file.Close();
        }
        else
        {
            Console.WriteLine("Nenhum arquivo encontrado");
        }
        Console.ReadLine();
    }
}

