using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stadium {
    internal class Ticket {
        private string price;

        public Ticket(string price) {
            this.Price = price;
        }

        public string Price { get => price; set => price = value; }


        public void showPrice() {
            Console.Write(Price);
        }
    }
}
