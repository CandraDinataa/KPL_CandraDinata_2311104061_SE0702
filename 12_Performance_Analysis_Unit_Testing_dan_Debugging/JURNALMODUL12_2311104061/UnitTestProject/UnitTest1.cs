using Microsoft.VisualStudio.TestTools.UnitTesting;
using JURNALMODUL12_2311104061;
using System.Reflection;

namespace UnitTestProjectModul12
{
    [TestClass]
    public class UnitTest1
    {
        private Form1 form;

        [TestInitialize]
        public void Setup()
        {
            form = new Form1();
        }

        private int InvokeCariNilaiPangkat(int a, int b)
        {
            // Mengakses method private menggunakan refleksi
            MethodInfo method = typeof(Form1).GetMethod("CariNilaiPangkat", BindingFlags.NonPublic | BindingFlags.Instance);
            return (int)method.Invoke(form, new object[] { a, b });
        }

        [TestMethod]
        public void TestNormalPower()
        {
            int result = InvokeCariNilaiPangkat(2, 3); // 2^3 = 8
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestZeroPower()
        {
            int result = InvokeCariNilaiPangkat(5, 0); // b = 0 → 1
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestNegativePower()
        {
            int result = InvokeCariNilaiPangkat(2, -1); // b < 0 → -1
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestPowerAboveLimit()
        {
            int result = InvokeCariNilaiPangkat(2, 11); // b > 10 → -2
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestBaseAboveLimit()
        {
            int result = InvokeCariNilaiPangkat(101, 2); // a > 100 → -2
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestOverflow()
        {
            int result = InvokeCariNilaiPangkat(100, 10); // Overflow → -3
            Assert.AreEqual(-3, result);
        }
    }
}
