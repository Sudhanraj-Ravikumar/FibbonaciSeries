using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonaciSeries
{
    [TestFixture]
    class Test
    {
        FibbonaciMethod fibbonaciMethod;
        [SetUp]
        public void Setup()
        {
            fibbonaciMethod = new FibbonaciMethod();
        }
        [Test]
        public void Fibboncai_Series_inCorreectSequence()
        {
            int input = 6;
            List<int> expectedValue = new List<int>(){ 0, 1, 1, 2, 3, 5 };
            
            List<int> result = new List<int>();

            result = fibbonaciMethod.GetFibbonnaciSolution(input);

            Assert.AreEqual(expectedValue, result);
            

        }
        
    }
}
