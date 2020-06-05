using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test3.Models
{
    public class Member
    {
        public int Id { get; set; }
        //表示名称を変えるなら→displayname
        [DisplayName("名前")]
        public string Name { get; set; }
        public string Emai { get; set; }
        public DateTime Birth { get; set; }
        public bool Married { get; set; }
        //↓最大値
        [MaxLength(10)]
        public string Memo { get; set; }
        //   [DisplayName("登録日時")]
        //   public string DateTime { get; set; }
        //   [DisplayName("タイムスタンプ")]
        //↓using System.ComponentModel.DataAnnotations;
        //    [Timestamp]
        //    public Byte[] Timestamp { get; set; }
    }
}
