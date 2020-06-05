using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test3.Models
{
    public class MemberContext : DbContext
    {
        public MemberContext (DbContextOptions<MemberContext> options)
            : base(options)
        {
        }

        public DbSet<Test3.Models.Member> Member { get; set; }
    }
}
