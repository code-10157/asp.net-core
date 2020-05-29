using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Test2.Models
{
    public class Member
    {
    public int Id { get; set; }
//表示名称を変えるなら→displayname
    [DisplayName("名前")]
    public string Name{ get; set; }
    public string Emai{ get; set; }
    public DateTime Birth { get; set; }
    public bool Married { get; set; }
    public string Memo { get; set; }


    }
}
