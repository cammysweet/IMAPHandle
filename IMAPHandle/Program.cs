using System;

namespace IMAPHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller carregaEmail = new Controller();

            Console.WriteLine("Escolha o servidor de email (Digite o número correspondente):");
            Console.WriteLine("1 - Outlook");
            Console.WriteLine("2 - Gmail");
            Console.WriteLine("3 - Yahoo");
            Console.WriteLine("4 - Bol");
            Console.WriteLine("5 - IG");
            string servidor = Console.ReadLine();
            if (servidor == "1")
            {

            }
            if (servidor == "2")
            {

            }
            if (servidor == "3")
            {

            }
            if (servidor == "4")
            {
                string[] emails = carregaEmail.CarregaCaixaEntrada(ServidorEnum.Bol);
                foreach (var x in emails)
                    Console.WriteLine(x);

                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadLine();
            }
        }
    }
}
