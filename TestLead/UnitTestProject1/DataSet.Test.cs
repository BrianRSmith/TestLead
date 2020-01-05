using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using SUT = TestLead;

namespace TestLead.Test
{
    [TestClass]
    public class DataSetTest
    {
        [TestMethod]
        public void addAndGetRow()
        {
            SUT.DataSet data = new SUT.DataSet();

            List<string> expected = new List<string>();
            expected.Add("one");
            expected.Add("two");
            expected.Add("three");

            List<string> test = new List<string>();
            test.Add("one");
            test.Add("two");
            test.Add("three");

            data.addRow(test);

            List<string> value = data.getRow(0);

            Assert.AreEqual(expected[0], value[0]);
            Assert.AreEqual(expected[1], value[1]);
            Assert.AreEqual(expected[2], value[2]);
        }
    }
}
