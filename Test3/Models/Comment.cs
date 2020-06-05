using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test3.Models
{
    [DisplayColumn("Body")]
    public class Comment
    {
        public int Id { get; set; }
        [DisplayName("氏名")]
        public string Name { get; set; }
        [DisplayName("コメント")]
        public string Body { get; set; }
        [DisplayName("更新日")]
        public DateTime Updated { get; set; }
        public int? ArticleId { get; set; }
        [DisplayName("記事")]
        public virtual Article Article  { get; set; }
    }
}
