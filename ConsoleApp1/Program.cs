using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            // Condicional Ternária
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Corsa || 2 - Gol");
            int id = int.Parse(Console.ReadLine());

            string carro = (id == 1) ? carro = "Corsa" : carro = "GOL";

            Console.WriteLine(carro);
          
        }
    }
}
