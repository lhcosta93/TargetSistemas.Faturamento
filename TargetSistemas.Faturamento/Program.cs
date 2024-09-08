class Program
{
    static void Main()
    {
        Console.WriteLine("Faturamento Anual---------------");
        Console.WriteLine($"Faturamento mínimo: {Invoicing.getInvoicingMin().ToString("n2")}");
        Console.WriteLine($"Faturamento máximo: {Invoicing.getInvoicingMax().ToString("n2")}");
        Console.WriteLine($"Faturamento acima da média: {Invoicing.getInvoicingAboveAverage().ToString("n0")}");
        Console.WriteLine("================================");
    }    
}

public static class Invoicing 
{
    private static decimal[] invoicing = { 100m, 200m, 0m, 0m, 500m, 300m, 0m, 450m };
    private static decimal[] invoicingValue = invoicing.Where(a => a > 0).ToArray();

    public static decimal getInvoicingMin()
    {
        return invoicingValue.Min();
    }
    public static decimal getInvoicingMax()
    {
        return invoicingValue.Max();
    }
    public static decimal getInvoicingAboveAverage()
    {
        decimal invoicingAverage = invoicingValue.Average();
        return invoicingValue.Where(x => x > invoicingAverage).Count();
    }
}

