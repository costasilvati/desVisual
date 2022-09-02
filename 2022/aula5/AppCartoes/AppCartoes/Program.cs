using System;
using System.Collections;

namespace AppCartoes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string menu = "---- Sistema de cartões ---- \n" +
                "1 - Cadastrar Usuário \n" +
                "2 - Cadastrar Cartão \n" +
                "3 - Cadastrar Lançamento \n"+
                "4 - Listar Usuário e seus cartões \n"+
                "0 - SAIR \n ----------------------";

            ArrayList usuarios = new ArrayList();
            int option = 0;
            do
            {
                Console.WriteLine(menu);
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Digite o CPF do cliente");
                        string cpf = Console.ReadLine();
                        Usuario titular = new Usuario(cpf);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 0:
                        break;
                }

            } while (option != 0);
        }
    }
}
