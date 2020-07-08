using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAssignmentGame
{

    [TestClass]
    public class UnitTest1
    {
        Assignment_game.Logicclass Logic = new Assignment_game.Logicclass();

         //testing of load
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
        //testing of spin
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
