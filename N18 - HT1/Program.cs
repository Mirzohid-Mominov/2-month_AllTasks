namespace N18___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        OrderManagementService orderManagementService = new OrderManagementService();

        orderManagementService.Add(100);
        orderManagementService.Add(154);
        orderManagementService.Add(2422);
        orderManagementService.Add(12);
        orderManagementService.Add(234);

        Console.WriteLine($"Max: {orderManagementService.Max()}");
        Console.WriteLine($"Min: {orderManagementService.Min()}");
        Console.WriteLine($"Sum: {orderManagementService.Sum()}");

        orderManagementService.Add(624);
        orderManagementService.Add(11);

        Console.WriteLine();
        Console.WriteLine($"Max: {orderManagementService.Max()}");
        Console.WriteLine($"Min: {orderManagementService.Min()}");



    }
}