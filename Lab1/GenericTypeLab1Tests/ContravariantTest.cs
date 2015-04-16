namespace GenericTypeLab1Tests
{
    using System;
    using Lab1;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The unit test contravariance.
    /// </summary>
    [TestClass]
    public class ContravariantTest
    {
        /// <summary>
        /// Tests the method1.
        /// </summary>
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
