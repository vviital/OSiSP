namespace ReflectionTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// Class ReflectionTest
    /// </summary>
    [TestClass]
    public class ReflectionTest
    {
        /// <summary>
        /// Loads the assembly.
        /// This test checks for the existence of assembly and shows the process of loading.
        /// Receive all the classes and interfaces assembly.
        /// </summary>
        [TestMethod]
        public void LoadAssemblyTest()
        {
            bool good = true;
            try
            {
                Assembly assembly = Assembly.Load("Lab2");
                Type[] types = assembly.GetTypes();
            }
            catch (Exception exception)
            {
                good = false;
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Tests the collection of items.
        /// </summary>
        [TestMethod]
        public void TestCollectionOfItems()
        {
            bool good = true;
            try
            {
                Assembly assembly = Assembly.Load("Lab2");
                Type[] types = assembly.GetTypes();
                List<object> itemsList = new List<object>();
                foreach (var item in types)
                {
                    if (!item.IsInterface)
                    {
                        itemsList.Add(Activator.CreateInstance(item));
                    }
                    if (item.IsInterface) Console.Write("Interface ");
                    else Console.Write("Class ");
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception exception)
            {
                good = false;
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Find all classes inheritance.
        /// </summary>
        [TestMethod]
        public void ClassInheritanceTest()
        {
            bool good = true;
            try
            {
                List<object> items = this.GetCollection("Lab2");
                foreach (var item in items)
                {
                    Type currentType = item.GetType();
                    if (currentType.BaseType.ToString().Equals("Lab2.Computer"))
                    {
                        Console.WriteLine(currentType.ToString() + " inherits " + currentType.BaseType.ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                good = false;
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Find all interfaces inheritance.
        /// </summary>
        [TestMethod]
        public void InterfaceInheritanceTest()
        {
            bool good = true;
            try
            {
                List<object> items = this.GetCollection("Lab2");
                foreach (var item in items)
                {
                    Type currentType = item.GetType();
                    Type currentInterface = currentType.GetInterface("Lab2.ICalculate");
                    if (currentInterface != null)
                    {
                        Console.WriteLine(currentType.ToString() + " inherits " + currentInterface.ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                good = false;
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Find all public properties of all types.
        /// </summary>
        [TestMethod]
        public void PublicPropertiesTest()
        {
            bool good = true;
            try
            {
                List<object> items = this.GetCollection("Lab2");
                foreach (var item in items)
                {
                    Console.WriteLine(item.GetType().ToString() + " public properties:");
                    PropertyInfo[] propertyInfo = item.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
                    foreach (var info in propertyInfo)
                    {
                        Console.WriteLine("--> " + info.ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                good = false;
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Find type with each alternative name and create instance.
        /// </summary>
        [TestMethod]
        public void AlternativeNameTest()
        {
            bool good = true;
            try
            {
                string[] alterName = { "Comp", "LTop", "SPhone", "SWatch" };
                Type[] types = Assembly.Load("Lab2").GetTypes();
                Type alias = Assembly.Load("Lab2").GetType("Lab2.Alias");
                foreach (var item in alterName)
                {
                    foreach (var type in types)
                    {
                        var attribute = type.GetCustomAttribute(alias, false);
                        if (attribute != null)
                        {
                            PropertyInfo aName = alias.GetProperty("AlternativeName");
                            if (item.Equals(aName.GetValue(attribute)))
                            {
                                object obj = Activator.CreateInstance(type);
                                Console.WriteLine("Create " + type.ToString());
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                good = false;
            }
            Assert.AreEqual(true, good);
        }

        /// <summary>
        /// Gets the collection which consist of one item of each type.
        /// </summary>
        /// <param name="name">The assembly name.</param>
        /// <returns></returns>
        public List<object> GetCollection(string name)
        {
            Assembly assembly = Assembly.Load("Lab2");
            Type[] types = assembly.GetTypes();
            List<object> items = new List<object>();
            foreach (var item in types)
            {
                if (!item.IsInterface)
                {
                    items.Add(Activator.CreateInstance(item));
                }
            }
            return items;
        } 
    }
}
