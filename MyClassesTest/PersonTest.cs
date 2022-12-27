using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassesTest
{
    [TestClass]
    public class PersonTest :TestBase
    {
        #region Object variable is specific type or not
        [TestMethod]
        public void IsInstance()
        {
            PersonManager mgr = new PersonManager();
            Person per;
            per = mgr.CreatePerson("AMAN", "SINGH", true);
            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }
        #endregion


    }
}
