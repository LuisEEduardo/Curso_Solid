using System;

namespace CursoFoop_Solid_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            ILogger logger = new ConsoleLogger();
            Pedido pedido = new Pedido(logger);

            pedido.AdicionarPedido();

            Console.ReadLine();
        }
    }
}
