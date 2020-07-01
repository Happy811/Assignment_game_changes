using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        Assignment_game.LogicClass Logic = new Assignment_game.LogicClass();


        [TestMethod]
        public void LoadTest()
        {
            try
            {
                Logic.Load();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);
            }
        }
            [TestMethod]
            public void SpinTest()
            {
                try
                {
                    Logic.Spin();
                    Assert.IsTrue(true);
                }
                catch
                {
                    Assert.IsFalse(false);
                }





            }
    }
}
