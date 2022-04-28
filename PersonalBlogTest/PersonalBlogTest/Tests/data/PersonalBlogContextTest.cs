using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalBlog.src.data;
using PersonalBlog.src.models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PersonalBlogTest.Tests.data
{
    [TestClass]
    public class PersonalBlogContextTest
    {
        private PersonalBlogContext _context;

        [TestInitialize]
        public void Initialization()
        {
            DbContextOptions<PersonalBlogContext> options = new DbContextOptionsBuilder<PersonalBlogContext>()
                .UseInMemoryDatabase(databaseName: "db_personalblog")
                .Options;

            _context = new PersonalBlogContext(options);
        }

        [TestMethod]
        public void InsertNewUserInDBReturnsUser()
        {
            UserModel user = new UserModel(0, "Rodrigo", "rodrigotest@email.com", "passwordtest123", "pictureLink");
            _context.Users.Add(user);
            _context.SaveChanges();
            Assert.IsNotNull(_context.Users.FirstOrDefault(u => u.Email == "rodrigotest@email.com"));
        }

    }
}
