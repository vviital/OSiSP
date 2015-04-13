using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericTypeLab1Tests
{
    using Lab1;

    [TestClass]
    public class CovariantTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IBuilder<House> houseBuilder = new HouseBuilder();
            IBuilder<Mansion> mansionBuilder = new MansionBuilder();

            bool isGood = true;

            try
            {
                houseBuilder = (IBuilder<House>) mansionBuilder;
            }
            catch (Exception exception)
            {
                isGood = false;
            }

            Assert.AreEqual(true, isGood, "Interface IBuilder<T> isn't covariant");
        }
    }
}
