using CabInvoiceGenerator;

namespace CabInvoiceGeneratorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoiceGenerator = null;
        [TestMethod]
        public void TestMethod1()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
        [TestMethod]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride ( 2.0, 5 ), new Ride ( 0.1, 2 ) };

            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expected = new InvoiceSummary ( 2, 30.0 );

            Assert.AreEqual(expected, invoiceSummary);
        }
    }
}
