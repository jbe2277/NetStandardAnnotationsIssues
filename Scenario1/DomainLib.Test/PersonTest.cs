using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainLib.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void SetName()
        {
            var p = new Person() { Name = "Bill" };
            Assert.AreEqual("Bill", p.Name);
        }
    }
}
