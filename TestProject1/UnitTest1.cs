using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Caso1()
        {
            int value = -5;
            string expected = "Inserte un número válido";
            string result = Decimales_a_romanos.Program.Convert(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso2()
        {
            int value = 4000;
            string expected = "Inserte un número válido";
            string result = Decimales_a_romanos.Program.Convert(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso3()
        {
            int value = 400;
            string expected = "D";
            string result = Decimales_a_romanos.Program.Convert(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso4()
        {
            int value = 0;
            string expected = "";
            string result = Decimales_a_romanos.Program.Convert(value);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Caso5()
        {
            int value = 1;
            string expected = "I";
            string result = Decimales_a_romanos.Program.Convert(value);
            Assert.AreEqual(expected, result);
        }

    }
}