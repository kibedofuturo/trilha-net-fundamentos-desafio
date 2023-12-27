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
            //Implementação do método para adicionar veículo
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string veiculo = Console.ReadLine();

            veiculos.Add(veiculo.ToUpper());
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Any())
            {
                ListarVeiculos();
                
                //Implementação que salva a plca que o usuário digita
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = Console.ReadLine().ToUpper();

                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    //Salva o valor das horas na variável entrada
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    string entrada = Console.ReadLine();

                    try
                    {
                        //Cria a variável horas que recebe o valor da entrada porém como inteiro
                        int horas = int.Parse(entrada);

                        //Calcula o valor total
                        decimal valorTotal = precoInicial + precoPorHora * horas;

                        //Remove o veículo com a placa digitada
                        veiculos.Remove(placa);

                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, digite um valor válido para as horas.");
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //Percorrendo o array de veículos e exibindo quais estão estacionados
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
