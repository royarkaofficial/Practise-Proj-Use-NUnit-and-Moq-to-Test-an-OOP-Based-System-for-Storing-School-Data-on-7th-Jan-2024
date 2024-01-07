using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrarTest
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void StudentIdShouldBeSet()
        {
            var student = new Student { Id = 1, Name = "Jane Doe" };
            Assert.AreEqual(1, student.Id);
        }
    }
}
