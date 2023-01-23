using System;

namespace Stadium {
    class Menu {
        public static void Show() {
            while (true) {
                Console.WriteLine("Selecione o tipo de ingresso:");
                Console.WriteLine("1 - Normal");
                Console.WriteLine("2 - Cabine Inferior");
                Console.WriteLine("3 - Cabine Superior");
                Console.WriteLine("4 - VIP");
                Console.WriteLine("0 - Sair");

                string input = Console.ReadLine();
                int option;
                if (!int.TryParse(input, out option) || option < 0 || option > 4) {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    continue;
                }

                if (option == 0) {
                    break;
                }

                Console.WriteLine("Informe a quantidade de ingressos:");
                input = Console.ReadLine();
                int amount;
                if (!int.TryParse(input, out amount) || amount <= 0) {
                    Console.WriteLine("Entrada inválida, tente novamente.");
                    continue;
                }

                Ticket ticket = null;
                switch (option) {
                    case 1:
                        ticket = new Normal();
                        break;
                    case 2:
                        ticket = new LowerCabin();
                        break;
                    case 3:
                        ticket = new SuperiorCabin();
                        break;
                    case 4:
                        ticket = new Vip();
                        break;
                }

                ticket.Amount = amount;
                ticket.Total = ticket.Price * (decimal)ticket.Amount;
                Console.WriteLine($"Valor total: R${ticket.Total},00");
            }
        }
    }
}

