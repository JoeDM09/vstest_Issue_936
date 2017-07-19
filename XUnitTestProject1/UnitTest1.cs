using Database;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var builder = new DbContextOptionsBuilder<TestDbContext>();

            builder.UseInMemoryDatabase();

            var context = new TestDbContext(builder.Options);
        }
    }
}
