using System;

internal class Ticket {
    private decimal price;
    private double amount;
    private decimal total;
    private string type;

    public decimal Price { get => price; set => price = value; }
    public double Amount { get => amount; set => amount = value; }
    public decimal Total { get => total; set => total = value; }
    public string Type { get => type; set => type = value; }

    public Ticket(decimal price, double amount, decimal total) {
        this.Price = price;
        this.Amount = amount;
        this.Total = total;
    }

    public void showTicket() {
        Console.WriteLine($"Compra de {Amount} ingressos {Type} no valor de {Total} concluida.");
    }
}
