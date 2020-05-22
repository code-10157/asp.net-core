using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    //本に載ってた。これで実行するたびにdbが自動生成されるようになるらしい。System.Data.Entityが使えれば。
    public class createdb : DropCreateDatabaseAlways<MemberContext>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Emai { get; set; }
        public DateTime Birth { get; set; }
        public bool Married { get; set; }
        public string Memo { get; set; }

    }
}
