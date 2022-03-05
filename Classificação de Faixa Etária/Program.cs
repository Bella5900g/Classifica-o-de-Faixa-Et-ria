using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classificação_de_Faixa_Etária
{
    internal class Program
    {
        enum Menu { Locar = 1, Sair}

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja Bem Vindo!");

                Console.WriteLine("Seja bem vindo a Locadora de Filmes, selecione uma das opções:");
                Console.WriteLine("===============");
                Console.WriteLine("1-Locar\n2-Sair");
                Console.WriteLine("===============");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                Console.WriteLine("===============");

                switch (opcao)
                {
                    case Menu.Locar:
                        Locar();
                        break;
                    case Menu.Sair:
                        escolheuSair=true;
                        break;
                }
                Console.Clear();
            }

        }
        static void Locar()
        {
            Console.WriteLine("Digite o Seu nome:");
            string nomeDoCliente;
            int idadeDoCliente;
            nomeDoCliente = Console.ReadLine();
            Console.WriteLine("==============");
            Console.WriteLine("Digite a Sua Idade:");
            idadeDoCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("==============");

            string nomeDoFilme;
            int classificacaoDoFilme;
            Console.WriteLine("Digite o Nome do Filme:");
            nomeDoFilme = Console.ReadLine();
            Console.WriteLine("Digite a Classificação do Filme:");
            classificacaoDoFilme = int.Parse(Console.ReadLine());

            Console.WriteLine("==============");
            Console.WriteLine($"Locador: {nomeDoCliente}");
            Console.WriteLine($"Sua Idade: {idadeDoCliente}");
            Console.WriteLine($"Filme: {nomeDoFilme}");
            Console.WriteLine($"Faixa Etária: {classificacaoDoFilme}");

            Console.WriteLine("==============");

            if (idadeDoCliente >= classificacaoDoFilme)
            {
                Console.WriteLine("Este filme é indicado para sua faixa etária!");
            }
            else
            {
                Console.WriteLine("Este filme não é indicado para sua faixa etária!");
            }
            Console.WriteLine("==============");
            Console.WriteLine("Aperte ENTER para voltar para o Menu");
            Console.ReadLine();
        }
    }
}
