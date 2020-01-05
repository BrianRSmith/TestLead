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

        [TestMethod]
        public void getCell()
        {
            SUT.DataSet data = new SUT.DataSet();

            List<string> test = new List<string>();
            test.Add("one");
            test.Add("two");
            test.Add("three");

            data.addRow(test);

            string expected1 = "one";
            string expected2 = "two";
            string expected3 = "three";

            Assert.AreEqual(data.getCell(0, 0), expected1);
            Assert.AreEqual(data.getCell(0, 1), expected2);
            Assert.AreEqual(data.getCell(0, 2), expected3);
        }

        [TestMethod]
        public void editCell()
        {
            SUT.DataSet data = new SUT.DataSet();

            List<string> expected = new List<string>();
            expected.Add("1");
            expected.Add("2");
            expected.Add("3");

            List<string> test = new List<string>();
            test.Add("one");
            test.Add("two");
            test.Add("three");

            data.addRow(test);

            data.editCell(0, 0, "1");
            data.editCell(0, 1, "2");
            data.editCell(0, 2, "3");

            List<string> value = data.getRow(0);

            Assert.AreEqual(expected[0], value[0]);
            Assert.AreEqual(expected[1], value[1]);
            Assert.AreEqual(expected[2], value[2]);
        }

        [TestMethod]
        public void getData()
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

            List<List<string>> value = data.getData();

            Assert.AreEqual(expected[0], value[0][0]);
            Assert.AreEqual(expected[1], value[0][1]);
            Assert.AreEqual(expected[2], value[0][2]);
        }


    }
}
