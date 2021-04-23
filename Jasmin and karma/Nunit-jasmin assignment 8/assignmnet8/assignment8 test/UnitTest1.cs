
using assignment8;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace assignment8_test
    {
        public class Tests
        {
            [SetUp]
            public void Setup()
            {
            }


        /// <summary>
        /// 1.GetEmployees
        /// </summary>
       
            [OrderedTest(2)]
            public void TestGetEmployees()
            {
                //Arrange
                int total = 3;

                //Act + Assert
                Assert.That(Program.Getemployee(), Has.Count.EqualTo(total)
                            .And.All.Property("name").Not.Null
                            .And.All.Property("Id").Not.Null);
            }


        /// <summary>
        ///2. Test  getdepartment
        /// </summary>

        [OrderedTest(0)]
        public void TestGetdepartment()
        {
            //Arrange
            List<department> d1 = new List<department>();
            string depat_name = "IT";
            string depat_name2 = "EC";
            string depat_name3 = "CE";
            //Act
            List<department> actual = Program.Getdepartment();

            //Assert
            foreach (department d in d1)
            { 
                Assert.AreEqual(actual, (depat_name3));
                Assert.AreEqual(actual, (depat_name2));
                Assert.AreEqual(actual, (depat_name));
            }
        }
           
        /// <summary>
        /// 3.Get employee by age
        /// </summary>

            [OrderedTest(3)]
            public void Getemployeebyage()
            {
                //Arrange
                int age = 21;
                //Act
                List<employee> actualList = Program.GetemployeeBydepartment(age);
                //Assert
                Assert.That(actualList, Has.Count.EqualTo(1)
                                           .And.All.Property("age").EqualTo(21));
            }


        /// <summary>
        /// 4.get employee by name
        /// </summary>

            [OrderedTest(1)]
            public void getemployeeName()
            {
                //Arrange
                int id = 1;
                string name = "sweta";
                //Act + Assert
                Assert.That(Program.GetemployeeName(id), Is.EqualTo(name));
            }

        /// <summary>
        /// 5.GetLocation
        /// </summary>
        [OrderedTest(4)]
        public void Getlocation()
        {
            //Arrange
            int id= 1;
            //Act
            string actualList = Program.GetLocation(id);
            //Assert
            Assert.AreEqual(actualList,("vadodara"));
        }

        [TestCaseSource(sourceName: "TestSource")]
            public void MainTest(TestStructure test)
            {
                test.Test();
            }
            public static IEnumerable<TestCaseData> TestSource
            {
                get
                {
                    var assembly = Assembly.GetExecutingAssembly();
                    Dictionary<int, List<MethodInfo>> methods = assembly
                    .GetTypes()
                    .SelectMany(x => x.GetMethods())
                    .Where(y => y.GetCustomAttributes().OfType<OrderedTestAttribute>().Any())
                    .GroupBy(z => z.GetCustomAttribute<OrderedTestAttribute>().Order)
                    .ToDictionary(gdc => gdc.Key, gdc => gdc.ToList());
                    foreach (var order in methods.Keys.OrderBy(x => x))
                    {
                        foreach (var methodInfo in methods[order])
                        {
                            MethodInfo info = methodInfo;
                            yield return new TestCaseData(
                            new TestStructure
                            {
                                Test = () =>
                                {
                                    object classInstance = Activator.CreateInstance(info.DeclaringType, null);
                                    info.Invoke(classInstance, null);
                                }
                            }).SetName(methodInfo.Name);
                        }
                    }
                }
            }
        }
        public class TestStructure
        {
            public Action Test;
        }
        public class OrderedTestAttribute : Attribute
        {
            public int Order { get; set; }
            public OrderedTestAttribute(int order)
            {
                this.Order = order;
            }
        }
    }