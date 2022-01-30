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
            Console.WriteLine("Digite quanto tempo de casa você completa esse ano.");
        }

        if (opcao == 2)
        {
            Console.WriteLine("Welcome " + name);
            Console.WriteLine("Enter how much homework you complete this year.");
        }
        
        if (opcao == 3)
        {
            Console.WriteLine("Bienvenue " + name);
            Console.WriteLine("Entrez le nombre de devoirs que vous avez terminés cette année.");
        }
        
        TempoDeCasa Anos = new TempoDeCasa();
        int anos = Convert.ToInt32(Console.ReadLine());
       
        if (opcao == 1) 
        {
         switch (anos)
         {
            case 1:
            Console.WriteLine("Parabéns " + name + " esse ano você receberá um vale brinde de R$ 300");
            break;

            case 2:
            Console.WriteLine("Parabéns " + name + " esse ano você receberá um Vale refeição de R$ 450");
            break;

            case 5:
            Console.WriteLine("Parabéns " + name + " esse ano você receberá um Relogio");
            break;

            case 10:
            Console.WriteLine("Parabéns " + name + " esse ano você receberá um Notebook");
            break;

            default:
            Console.WriteLine(name + " Esse ano você não recebera prêmios");
            break;
         }
        }
        
        if (opcao == 2)
        {
         switch (anos)
         {
            case 1:
            Console.WriteLine("Congratulations " + name + " this year you will receive a Gift voucher of $ 300");
            break;

            case 2:
            Console.WriteLine("Congratulations " + name + " this year you will receive a meal voucher $ 450");
            break;

            case 5:
            Console.WriteLine("Congratulations " + name + " this year you will receive a Watch");
            break;

            case 10:
            Console.WriteLine("Congratulations " + name + " this year you will receive a Notebook");
            break;

            default:
            Console.WriteLine(name + " This year you will not receive awards");
            break;
         }
        }
        if (opcao == 3)
        {
         switch (anos)
         {
            case 1:
            Console.WriteLine("Félicitations " + name + " cette année, vous recevrez un Chèque cadeau de $ 300");
            break;

            case 2:
            Console.WriteLine("Félicitations " + name + " cette année, vous recevrez un chèque-repas $ 450");
            break;

            case 5:
            Console.WriteLine("Félicitations " + name + " cette année, vous recevrez un Regardez");
            break;

            case 10:
            Console.WriteLine("Félicitations " + name + " cette année, vous recevrez un cahier");
            break;

            default:
            Console.WriteLine(name + " Cette année, vous ne recevrez pas de prix");
            break;
         }
        }
        
        }
    }
}

