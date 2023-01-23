namespace Stadium {
    internal class LowerCabin : Ticket {
        public new const decimal Price = 15;
        public LowerCabin() : base(Price, 0, 0) {
            Type = "LowerCabin";
        }
    }
}
