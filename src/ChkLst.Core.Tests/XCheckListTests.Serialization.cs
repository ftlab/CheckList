using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ChkLst.Core.Tests
{
    [TestClass]
    public partial class XCheckListTests
    {
        [TestMethod]
        public void XCheckList_SerializationTest()
        {
            var actual = new XCheckList();
            actual.Header.WorkItem = "111";
            actual.MainItem.Name = "task";
            actual.MainItem.TimeCostDuration = TimeSpan.FromMinutes(1);
            actual.MainItem.Item.Add(new XItem() { Name = "subtask" });

            XCheckList expected;
            using (var ms = new MemoryStream())
            {
                actual.Serialize(ms);
                ms.Position = 0L;
                expected = XCheckList.Deserialize(ms);
            }

            Assert.AreEqual(expected.Header.WorkItem, "111");
            Assert.AreEqual(expected.MainItem.Name, "task");
            Assert.AreEqual(expected.MainItem.Item[0].Name, "subtask");
        }
    }
}
