using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainLib.Test
{
    [TestClass]
    public class PersonRepositoryTest
    {
        [TestMethod]
        public void AddPersonTest()
        {
            PersonRepository.AddPerson(new Person());
        }
    }
}
