using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrarTest
{
    [TestFixture]
    public class SubjectTests
    {
        [Test]
        public void SubjectIdShouldBeSet()
        {
            var subject = new Subject { Id = 1, Name = "Math" };
            Assert.AreEqual(1, subject.Id);
        }
    }
}
