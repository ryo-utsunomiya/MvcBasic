using System;
using System.Data.Entity;

namespace MvcBasic.Models
{
    public class MvcBasicInitializers : DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            context.Members.Add(new Member
            {
                Name = "Rio",
                Email = "rio@example.com",
                Birth = DateTime.Parse("1980-06-25"),
                Married = false,
                Memo = "I love piano"
            });

            context.SaveChanges();
        }
    }
}