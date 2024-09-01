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

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // *IMPLEMENTADO*
            string placa = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(placa)) {
                Console.WriteLine("Campo Obrigatório! Favor digite uma placa.");
            } else {
                veiculos.Add(placa.ToUpper());
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // *IMPLEMENTADO*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
             
                // *IMPLEMENTADO*
                decimal valorTotal = 0; 
                string dados = Console.ReadLine();                              
                int horas = Convert.ToInt32(dados);
                valorTotal = precoInicial + (precoPorHora * horas);

                // *IMPLEMENTADO*
                veiculos.Remove(placa); 
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
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
