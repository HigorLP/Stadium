namespace Stadium {
    internal class Normal : Ticket {
        public new const decimal Price = 10;
        public Normal() : base(Price, 0, 0) {
            Type = "Normal";
        }
    }
}