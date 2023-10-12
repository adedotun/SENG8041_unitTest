using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemo;

namespace TestTriangle
{
    public class TriangleTest
    {
        [TestFixture]

        public class TriangleTest1
        {
            [Test]
            public void ValidTriangle()
            {
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid."; // Added period at the end

                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                Assert.That(actual, Is.EqualTo(expected));
                
                Console.WriteLine(" " +
                    " "+
                    "This test case has passed. My name is Adedotun");

            }
        }
    }
}