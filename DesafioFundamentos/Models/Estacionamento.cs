using System.Text.RegularExpressions;
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // public void AdicionarVeiculo()
        // {
        //     Console.WriteLine("Digite a placa do veículo para estacionar:");
        //     // *IMPLEMENTADO*
        //     string placa = Console.ReadLine();
        //     if (string.IsNullOrWhiteSpace(placa)) {
        //         Console.WriteLine("Campo Obrigatório! Favor digite uma placa.");
        //     } else {
        //         veiculos.Add(placa);
        //     }
        // }

        public void AdicionarVeiculo() {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Lê a entrada do usuário (a placa do veículo) e armazena na variável 'placa'.
            string placa = Console.ReadLine();

            // Define a regex para validar o formato da placa.
            string pattern = @"^[A-Z]{3}-[0-9]{4}$";
            Regex regex = new Regex(pattern);

            // Verifica se a placa está vazia ou contém apenas espaços em branco.
            if (string.IsNullOrWhiteSpace(placa)) 
            {
                Console.WriteLine("Campo Obrigatório! Favor digite uma placa.");
            }
            // Verifica se a placa corresponde ao padrão definido.
            else if (!regex.IsMatch(placa)) 
            {
                Console.WriteLine("Formato de placa inválido! Favor digite no formato ABC-1234.");
            }
            else 
            {
                // Caso contrário, adiciona a placa à coleção de veículos.
                veiculos.Add(placa);
                Console.WriteLine("Veículo adicionado com sucesso!");
            }
        }

        // public void RemoverVeiculo()
        // {
        //     Console.WriteLine("Digite a placa do veículo para remover:");

        //     // *IMPLEMENTADO*
        //     string placa = Console.ReadLine();

        //     // Verifica se o veículo existe
        //     if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        //     {
        //         Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
             
        //         // *IMPLEMENTADO*
        //         decimal valorTotal = 0M; 
        //         string dados = Console.ReadLine();                              
        //         int horas = Convert.ToInt32(dados);
        //         valorTotal = precoInicial + (precoPorHora * horas);

        //         // *IMPLEMENTADO*
        //         veiculos.Remove(placa); 
        //         Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:C}");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        //     }
        // }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Lê a entrada do usuário (a placa do veículo) e armazena na variável 'placa'.
            string placa = Console.ReadLine();

            // Define a regex para validar o formato da placa.
            string pattern = @"^[A-Z]{3}-[0-9]{4}$";
            Regex regex = new Regex(pattern);

            // Verifica se a placa está vazia ou contém apenas espaços em branco.
            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Campo Obrigatório! Favor digite uma placa.");
            }
            // Verifica se a placa corresponde ao padrão definido.
            else if (!regex.IsMatch(placa))
            {
                Console.WriteLine("Formato de placa inválido! Favor digite no formato ABC-1234.");
            }
            // Verifica se o veículo existe
            else if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Tenta converter a entrada de horas para inteiro
                decimal valorTotal = 0M;
                string dados = Console.ReadLine();

                if (int.TryParse(dados, out int horas))
                {
                    valorTotal = precoInicial + (precoPorHora * horas);

                    // Remove a placa da coleção de veículos.
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:C}");
                }
                else
                {
                    Console.WriteLine("Quantidade de horas inválida. Por favor, insira um número inteiro.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // *IMPLEMENTADO*
                foreach(var veiculo in veiculos) {
                    Console.WriteLine($"Placa {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
