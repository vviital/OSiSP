using System.Net.Configuration;
using Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericTypeLab1Tests
{
    [TestClass]
    public class ContravariantTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IInformation<House> houseInformation = new HouseInformation();
            IInformation<Mansion> mansionInformation = new MansionInformation();

            bool isGood = true;

            try
            {
                mansionInformation = (IInformation<Mansion>)houseInformation;
            }
            catch (Exception exception)
            {
                isGood = false;
            }

            Assert.AreEqual(true, isGood, "Interface IInformation<T> isn't contravariant");
        }
    }
}
