using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadium {
    internal class Ticket {
        private decimal price;
        private string type;
        private double amount;
        private decimal total;

        public decimal Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public double Amount { get => amount; set => amount = value; }
        public decimal Total { get => total; set => total = value; }

        public Ticket(decimal price, string type, double amount, decimal total) {
            this.Price = price;
            this.Type = type;
            this.Amount = amount;
            this.Total = total;
        }

        public void showTicket() {
            Console.WriteLine($"Compra de {Amount} ingressos no valor de {Total} concluida.");
        }
    }
}
