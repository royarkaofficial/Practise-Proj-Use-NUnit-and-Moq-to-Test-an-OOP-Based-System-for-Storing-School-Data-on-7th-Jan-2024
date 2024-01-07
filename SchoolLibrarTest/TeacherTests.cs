using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrarTest
{
    [TestFixture]
    public class TeacherTests
    {
        [Test]
        public void TeacherIdShouldBeSet()
        {
            var teacher = new Teacher { Id = 1, Name = "John Doe" };
            Assert.AreEqual(1, teacher.Id);
        }
    }
}
