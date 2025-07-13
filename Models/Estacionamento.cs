using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SistemaDeEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInical = 0;
        private decimal precoporHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInical, decimal precoporHora)
        {
            this.precoInical;
            this.precoporHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do Veiculo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veiculo {placa} adicionado com sucesso ao estacionamento.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover:");
            string placa = Console.ReadLine();
            //verificar se o veiculo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que veiculo parmaneceu estacionado:");
                    int horas = int.Parse(Console.ReadLine());
                decimal ValorTotal = precoInical + (precoporHora * horas);
                    veiculos.Remove(placa);
                    Console.WriteLine($"O seu veiculo {placa} foi removido e o preco total foi de : {ValorTotal} R$ ");
                }
            else
            {
                Console.WriteLine("Desculpe, esse veiculo não esta estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        { //verifica se há veiculos  no estacionamento 
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são:");
                //exibindo os veiculos estacionados 
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
                {
                    Console.WriteLine("Não há veiculos estacionados");
                }
        }
    }
}