using Calculator.Logic;
using Calculator.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class Tests
    {
        private static readonly CalcModel _model = new();

        private readonly CalculationService _calculator = new(_model);

        [TestMethod()]
        public void ClearOutputField_EmptyString_EmptyString()
        {
            _model.OutPut = "322";

            Assert.AreEqual(string.Empty, _calculator.ClearOutputField(_model));
        }

        [TestMethod()]
        public void ClearOutputField_EmptyString_Empty()
        {
            _model.OutPut = "";

            Assert.AreEqual("empty", _calculator.ClearOutputField(_model));
        }

        [TestMethod()]
        public void NumberButtonIsPressed_Nine_PressedNine()
        {
            Assert.AreEqual("9", _calculator.NumberButtonIsPressed("9"));
        }

        [TestMethod()]
        public void NumberButtonIsPressed_LongNumber_Number()
        {
            Assert.AreEqual("43433443", _calculator.NumberButtonIsPressed("43433443"));
        }

        [TestMethod()]
        public void NumberButtonIsPressed_WrongNumber_EmptyString()
        {
            Assert.AreEqual(string.Empty, _calculator.NumberButtonIsPressed("3232f"));
        }
    }
}
