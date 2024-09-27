using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(initialPrice, pricePerHour);

bool showMenu = true;

// Realiza o loop do menu
while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            es.AddVehicle(Console.ReadLine());
            break;

        case "2":
            Console.WriteLine("Digite a placa do veículo para remover:");
            string vehiclePlate = Console.ReadLine();
            if (es.ContainVehiclePlate(vehiclePlate))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int hour = Convert.ToInt32(Console.ReadLine());
                decimal total = es.InitialPrice + es.PricePerHour * hour; 

                es.RemoveVehicle(vehiclePlate);

                Console.WriteLine($"O veículo {vehiclePlate} foi removido e o preço total foi de: R$ {total}");
            } 
            else 
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");

            }
            break;

        case "3":
        if (!es.IsEmptyVehicle)
            {
                Console.WriteLine("Os veículos estacionados são:");
                es.ListVehicles();
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");