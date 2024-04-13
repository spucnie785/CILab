using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(4, Program.Multiply("2", "2"));
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(15, Program.Multiply("5", "3"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-1, Program.Subtract("2", "3"));
            Assert.AreEqual(0, Program.Subtract("5", "5"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "b"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("b", "b"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(2, Program.Divide("4", "2"));
            Assert.AreEqual(3, Program.Divide("6", "2"));
            Assert.AreEqual(1.5, Program.Divide("3", "2"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "b"));
            Assert.Throws<FormatException>(() => Program.Divide("b", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("b", "b"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Divide_By_Zero()
        {
            Assert.Throws<DivideByZeroException>(() => Program.Divide("1", "0"));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(1, Program.Power("1", "2"));
            Assert.AreEqual(4, Program.Power("2", "2"));
            Assert.AreEqual(27, Program.Power("3", "3"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "b"));
            Assert.Throws<FormatException>(() => Program.Power("b", "1"));
            Assert.Throws<FormatException>(() => Program.Power("b", "b"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
