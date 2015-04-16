namespace GenericTypeLab1Tests
{   
    using System;
    using Lab1;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The unit test covariance.
    /// </summary>
    [TestClass]
    public class CovariantTest
    {
        /// <summary>
        /// Tests the method1.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            IBuilder<House> houseBuilder = new HouseBuilder();
            IBuilder<Mansion> mansionBuilder = new MansionBuilder();

            bool isGood = true;

            try
            {
                houseBuilder = (IBuilder<House>)mansionBuilder;
            }
            catch (Exception exception)
            {
                isGood = false;
            }

            Assert.AreEqual(true, isGood, "Interface IBuilder<T> isn't covariant");
        }
    }
}
