using System;
using NUnit.Framework;

namespace Program.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int N = 10;
            int K = 1;
            double tolerance = 0.0001;
    
            Assert.AreEqual(Program.S0(N), Program.S1(N, 1), tolerance);
            Assert.AreEqual(Program.S0(N), Program.S2(N, N), tolerance);
            Assert.AreEqual(Program.S0(N), Program.S3(N, 1, 0), tolerance);
            Assert.AreEqual(Program.S0(N), Program.S4(N, N, 0), tolerance);
        }
    }
}