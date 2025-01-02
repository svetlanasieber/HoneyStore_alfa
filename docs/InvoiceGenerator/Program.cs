using System;
using System.Text;

class InvoiceGenerator
{
    public string GenerateInvoice(string customerName, string[] products, decimal[] prices, int[] quantities)
    {
        StringBuilder invoice = new StringBuilder();

       
        invoice.AppendLine("==== Invoice ====");
        invoice.AppendLine($"Customer: {customerName}");
        invoice.AppendLine("Products:");
        invoice.AppendLine("------------------------------");

        decimal total = 0;

       
        for (int i = 0; i < products.Length; i++)
        {
            decimal productTotal = prices[i] * quantities[i];
            total += productTotal;

            invoice.AppendLine($"{products[i]} x{quantities[i]} - ${prices[i]} each | Total: ${productTotal}");
        }

        invoice.AppendLine("------------------------------");
        invoice.AppendLine($"Total Amount: ${total}");
        invoice.AppendLine("Thank you for your purchase!");

        return invoice.ToString();
    }
}


class Program
{
    static void Main()
    {
        InvoiceGenerator generator = new InvoiceGenerator();
        
        string[] products = { "Laptop", "Mouse", "Keyboard" };
        decimal[] prices = { 1200.99m, 25.50m, 45.75m };
        int[] quantities = { 1, 2, 1 };
        
        string invoice = generator.GenerateInvoice("John Doe", products, prices, quantities);
        Console.WriteLine(invoice);
    }
}
