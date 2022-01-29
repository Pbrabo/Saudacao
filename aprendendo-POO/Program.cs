using System;
using aprendendo_POO.src.Entities;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {

            Idiomas idioma = new Idiomas();

            Console.WriteLine("Por favor selecione uma idioma para começarmos");
            Console.WriteLine("digite 1 para portugues, 2 for english ou 3 pour le français");
            int opcao = Convert.ToInt32(Console.ReadLine());

        

        switch (opcao)
        {
            case 1: 
            Console.WriteLine("Portugues");
            Console.WriteLine("Por favor, agora digite o seu nome.");
            
            break;
            case 2:
            Console.WriteLine("English");
            Console.WriteLine("Please now enter your name.");
            break;
            case 3:
            Console.WriteLine("Français");
            Console.WriteLine("Veuillez maintenant entrer votre nom.");
            break;

            default:
            break;
        }

        Nomes nome = new Nomes();

        string name = Convert.ToString(Console.ReadLine());

        if (opcao == 1)
        {
            Console.WriteLine("Bem-vindo " + name);
        }

        if (opcao == 2)
        {
            Console.WriteLine("Welcome " + name);
        }
        
        if (opcao == 3)
        {
            Console.WriteLine("Bienvenue " + name);
        }
        
        }
    }
}
