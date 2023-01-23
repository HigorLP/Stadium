namespace Stadium {
    internal class Vip : Ticket {
        public new const decimal Price = 50;
        public Vip() : base(Price, 0, 0) {
            Type = "VIP";
        }
    }
}

