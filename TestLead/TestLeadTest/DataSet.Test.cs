
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataSet;

namespace TestLeadTest
{
    [TestClass]
    public class DataSetTest
    {
        [TestMethod]
        public void addRowTest()
        {
            List<string> test = new List<string>();
            test.Add("1");
            test.Add("2");
            test.Add("3");
            test.Add("A");
            test.Add("B");
            test.Add("C");

            DataSet data = new DataSet();
        }
    }
}
