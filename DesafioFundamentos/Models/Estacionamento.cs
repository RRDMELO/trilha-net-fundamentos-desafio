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
        /// <summary>
        /// Função para validar se a placa é válida ou se já existe na lista de veículos.
        /// </summary>
        /// <param name="placa">Placa do veículo a ser validada</param>
        /// <returns>Retorna "Valida" se a placa for válida e não existir na lista de veículos, caso contrário, retorna uma mensagem de erro</returns>
        private string ValidarPlaca(string placa)
        {
            // Verifica se a placa está no formato correto (exemplo simples: 3 letras seguidas de 4 números)
            if (!System.Text.RegularExpressions.Regex.IsMatch(placa, "^[A-Z]{3}[0-9]{4}$"))
            {
                return "Placa inválida. O formato correto é 3 letras seguidas de 4 números.";
            }
            // Verifica se a placa já existe na lista de veículos
            if (veiculos.Contains(placa))
            {
                return "Placa já existente na lista de veículos.";
            }
            return "Valida"; // Placa válida e não existente na lista
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); // Lê a placa digitada pelo usuário
            
            // Verifica se a placa é válida e se já existe na lista de veículos
            string validacao = ValidarPlaca(placa);
            if (validacao == "Valida")
            {
                veiculos.Add(placa); // Adiciona a placa na lista de veículos
                Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine(validacao);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
