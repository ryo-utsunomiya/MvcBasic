using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MvcBasic.Models
{
    public class MvcBasicInitializers : DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            context.Members.AddRange(new List<Member>
            {
                new Member
                {
                    Name = "Rio",
                    Email = "rio@example.com",
                    Birth = DateTime.Parse("1980-06-25"),
                    Married = false,
                    Memo = "I love piano"
                },
                new Member
                {
                    Name = "Naohiro",
                    Email = "naohiro@example.com",
                    Birth = DateTime.Parse("1975-07-19"),
                    Married = false,
                    Memo = "I'm a child friendly doctor."
                },
            });
            context.SaveChanges();
        }
    }
}