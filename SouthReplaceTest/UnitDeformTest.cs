using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SouthReplace;

namespace SouthReplaceTest
{
    [TestClass]
    public class UnitDeformTest
    {
        

        [TestMethod]
        public void DeformIsValid()
        {
            Deform deform = new Deform();

            string text;
            var result = Deform.Deformer("South System", out text);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void DeformInValid()
        {
            Deform deform = new Deform();

            string text;
            var result = Deform.Deformer("50úth 515t3m", out text);
            Assert.AreEqual(false, result);

        }
    }
}
