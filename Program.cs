namespace CabInvoiceGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            double Fare = invoiceGenerator.CalculateFare(2.0, 5);

            Console.WriteLine(Fare);
        }
    }
}