using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest : TestBase
    {
              
        #region AssertClass With AreNotEqual() Method: Case-Insensitive
        [TestMethod]
        public void AreNotEqualTest()
        {
            string str1 = "Aman";
            string str2 = "aman";

            Assert.AreNotEqual(str1, str2, false);
            //Assert.AreNotEqual(str1, str2, true);
        }
        #endregion
        
        
/****************************************************/



        #region Assert Class With AreEqual() Method: Case-sensitive
        [TestMethod]
        public void AreEqualTest()
        {
            string str1 = "Aman";
            string str2 = "aman";

            Assert.AreEqual(str1, str2, true);
        }
        #endregion


/****************************************************/

        [TestMethod]
        [DataRow(10, 10, DisplayName = "AreNumbersEqual?")]
        //[DataRow(40, 42, DisplayName = "AreNumbersEqual?")]
        public void AreNumbersEqual(int num1, int num2)
        {
            Assert.AreEqual(num1, num2);
        }

/***********************************************************************/

        #region TimeOut Attribute Implementation
        [TestMethod]
        [Timeout(3000)]
        public void SimulateTimeout()
        {
            System.Threading.Thread.Sleep(2000);
        }
        #endregion

/**************************************************************/
        #region Object Variable Point to Same object or not ?
        [TestMethod]
        public void AreSame1()
        {
            FileProcess obj1 = new FileProcess();
            FileProcess obj2 = new FileProcess();
            Assert.AreNotSame(obj1, obj2);
        }
        #endregion
        
/**************************************************************/
       
        
        #region Object Variable Point to Same object or not ?
        [TestMethod]
        public void AreSame2()
        {
            FileProcess obj1 = new FileProcess();
            FileProcess obj2 = obj1;
            Assert.AreSame(obj1, obj2);
        }
        #endregion

/**************************************************************/

        #region StringAssertClass Test: Contains() Method
        [TestMethod]
        public void ContainsTest()
        {
            string str1 = "Aman Singh";
            string str2 = "Singh";
            StringAssert.Contains(str1, str2);
        }
        #endregion

/**************************************************************/
        
        #region StringAssertClass Test: StartsWith() Method
        [TestMethod]
        public void StartWithTest()
        {
            string str1 = "Aman Singh";
            string str2 = "Aman";
            StringAssert.StartsWith(str1, str2);
        }
        #endregion
        /**************************************************************/
        #region StringAssertClass Test: Matches() Method
        [TestMethod]
        public void Matches()
        {
            Regex r = new Regex(@"^([^A-Z])+$");

            StringAssert.Matches("all lower case",r);
        }
        #endregion
        /**************************************************************/
        #region StringAssertClass Test: DoesNotMatches() Method
        [TestMethod]
        public void DoesNotMatches()
        {
            Regex r = new Regex(@"^([^A-Z])+$");

            StringAssert.DoesNotMatch("All Lower Case", r);
        }
        #endregion
    }
}
