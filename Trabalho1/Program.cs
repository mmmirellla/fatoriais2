using System;
using System.Drawing;
using Trabalho1;

bool entrada = true;

do
{
    try
    {
        Console.WriteLine("\nEscolha uma opção:\n0) Sair\n1) Somar números\n2) Converter de metros para milímetros \n3) Calcular Aumento\n4) Calcular Desconto \n5) Aluguel Carro\n6) Calcular IMC\n7) Cantoneira até número fornecido\n8) Tabuada de cada número\n9) Múltiplos de 3 entre 0 e 100\n10) Fatoriais de 1 até 10\n11) Imposto de Renda\n12) Adivinhar número\n13) Financiamento do veículo\n14) Aposentadoria\n15) Jogo da velha ");
        int opcao = int.Parse(Console.ReadLine());
        int n; int m; float j;

        switch (opcao)
        {
            case 0:
                entrada = false;
                break;
            case 1:
                Console.WriteLine("Informe um número");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Precisa ser um número");
                }
                Console.WriteLine("Digite um número: ");
                while (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Precisa ser um número");
                }
                Console.WriteLine($"{n} + {m} = {Somatorio.Soma(n, m)}");
                break;
            case 2:
                Console.WriteLine("Quantos metros você tem?");
                while (!float.TryParse(Console.ReadLine(), out j))
                {
                    Console.WriteLine("Precisa ser um número!");
                }
                Console.WriteLine($"{j} metros em milímetros é: {ConverteMparaMM.Conversor(j)}mm");
                break;
            case 10:
                Console.WriteLine("Qual número você quer fatorar?");
                while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10)
                {
                    Console.WriteLine("O número inserido deve estar entre 1 e 10!");
                }
                Console.WriteLine($"{n}! = {CalculoFatorial.Fatorial(n)}");
                break;
            case 14:
                Console.WriteLine("Informe a sua idade:");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Precisa ser um número! ");
                }
                CalculoAposentadoria.Aposentadoria(n);
                break;
            case 15:
                JogoDaVelha.Main();
                break;
            default:
                Console.WriteLine("Opção inválida, tente novamente."); break;

        }

    }
    catch (FormatException)
    {
        Console.WriteLine("É necessário digitar um número inteiro dentre as opções dadas");
    }

} while (entrada);
