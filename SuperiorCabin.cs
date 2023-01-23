namespace Stadium {
    internal class SuperiorCabin : Ticket {
        public new const decimal Price = 20;
        public SuperiorCabin() : base(Price, 0, 0) {
            Type = "SuperiorCabin";
        }
    }
}
