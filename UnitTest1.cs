namespace CabInvoiceGeneratorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        InvoiceGenerator invoiceGenerator = null
        [TestMethod]
        public void TestMethod1()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

        }
    }
}
