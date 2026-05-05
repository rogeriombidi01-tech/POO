using System;
using System.Collections.Generic;
using System.Text;

namespace ArrendamentoVeiculos
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace ArrendandamentoVeiculo
    {
        public class Veiculo
        {
            private string Matricula;

            private string Marca;

            private double Quilometragem;

            private string Modelo;

            private int Anofaricacao;

            private string Cor;

            public Veiculo() { }

            public Veiculo(string matricula, string marca, string modelo, int ano, string cor, double km)
            {
                Matricula = matricula;
                Marca = marca;
                Modelo = modelo;
                Anofaricacao = ano;
                Cor = cor;
                Quilometragem = km;
            }

            public String get_Matricula()
            {
                return Matricula;
            }

            public void set_Matricula(String value)
            {
                Matricula = value;

            }

            public String get_Marca()
            {
                return Marca;
            }

            public void set_Marca(String value)
            {
                Marca = value;
            }

            public String get_Modelo()
            {
                return Modelo;
            }

            public void set_Modelo(String value)
            {
                Modelo = value;
            }

            public int get_Anofabricacao()
            {
                return Anofaricacao;
            }

            public void set_Anofabricacao(int value)
            {
                Anofaricacao = value;
            }

            public double get_Quilometragem()
            {
                return Quilometragem;
            }

            public String get_Cor()
            {
                return Cor;
            }

            public void set_Cor(String value)
            {
                Cor = value;
            }
            public void AtualizarQuilometragem(double kmPercorridos)
            {
                if (kmPercorridos > 0)
                {
                    // Ajustado para o nome correto: Quilometragem (Maiúsculo)
                    this.Quilometragem += kmPercorridos;
                }
            }

            public void ApresentarDados()
            {
                // Ajustado para usar os nomes que você definiu no topo
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Veículo: {this.Marca} {this.Modelo}");
                Console.WriteLine($"Matrícula: {this.Matricula} | Cor: {this.Cor}");
                Console.WriteLine($"Quilometragem: {this.Quilometragem} km");
                Console.WriteLine("-------------------------------------------");
            }

        }

    }
}
