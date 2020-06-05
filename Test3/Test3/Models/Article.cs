using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test3.Models
{
    public class Article
    {
        public int Id { get; set; }
        //表示名称を変えるなら→displayname
        [DisplayName("URL")]
        [DataType(DataType.Url)]
        public string Url { get; set; }
        [DisplayName("タイトル")]
        public string Title { get; set; }
        [DisplayName("カテゴリー")]
        public string Category { get; set; }
        [DisplayName("概要")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DisplayName("ビュー数")]
        public int Viewcount { get; set; }
        [DisplayName("公開日")]
        [DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}")]
        public DateTime Published { get; set; }
        [DisplayName("公開済み")]
        public bool Released { get; set; }
        [DisplayName("コメント")]
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
