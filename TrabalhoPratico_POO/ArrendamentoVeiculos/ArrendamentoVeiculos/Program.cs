
using ArrendamentoVeiculos.ArrendandamentoVeiculo;
using System;
using System.Collections.Generic;

class Program
{
    static List<Veiculo> veiculos = new List<Veiculo>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();
            MostrarMenu();

            while (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.Write("Opção inválida. Tente novamente: ");
            }

            switch (opcao)
            {
                case 1:
                    RegistrarVeiculo();
                    break;

                case 2:
                    ListarVeiculos();
                    break;

                case 3:
                    AtualizarKm();
                    break;

                case 0:
                    Console.WriteLine("A sair...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        } while (opcao != 0);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("===== SISTEMA DE ALUGUER DE VEÍCULOS =====");
        Console.WriteLine("1 - Registrar veículo");
        Console.WriteLine("2 - Listar veículos");
        Console.WriteLine("3 - Atualizar quilometragem");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção: ");
    }

    static void RegistrarVeiculo()
    {
        Console.WriteLine("\n=== Novo Veículo ===");

        Console.Write("Matrícula: ");
        string matricula = Console.ReadLine();

        Console.Write("Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();

        int ano;
        Console.Write("Ano: ");
        while (!int.TryParse(Console.ReadLine(), out ano))
        {
            Console.Write("Ano inválido. Digite novamente: ");
        }

        Console.Write("Cor: ");
        string cor = Console.ReadLine();

        double km;
        Console.Write("Quilometragem: ");
        while (!double.TryParse(Console.ReadLine(), out km))
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        Veiculo v = new Veiculo(matricula, marca, modelo, ano, cor, km);
        veiculos.Add(v);

        Console.WriteLine("\nVeículo registado com sucesso!");
    }

    static void ListarVeiculos()
    {
        Console.WriteLine("\n=== Lista de Veículos ===");

        if (veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo registado.");
            return;
        }

        foreach (var v in veiculos)
        {
            v.ApresentarDados();
        }
    }

    static void AtualizarKm()
    {
        Console.Write("\nDigite a matrícula do veículo: ");
        string mat = Console.ReadLine();

        Veiculo v = null;


        foreach (var item in veiculos)
        {

            if (item.get_Matricula() == mat)
            {
                v = item;
                break;
            }
        }

        if (v == null)
        {
            Console.WriteLine("Veículo não encontrado!");
            return;
        }

        double km;
        Console.Write("Km percorridos: ");
        while (!double.TryParse(Console.ReadLine(), out km))
        {
            Console.Write("Valor inválido. Digite novamente: ");
        }

        v.AtualizarQuilometragem(km);

        Console.WriteLine("Quilometragem atualizada!");
    }
}