using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskList2.Models

{

    public enum Category
    {
        案件, 故障, 作業依頼, 問い合わせ, その他
    }
    public enum Priority
    {
        高, 中, 低
    }
    public class Project
    {
    public int ID { get; set; }
    [Required]
    [DisplayName("分類")]
    public Category? Category { get; set; }
    [Required]
    [StringLength(50)]
    [DisplayName("プロジェクト名")]
    //[StringLength(50, MinimumLength = 2)]
    public string ProjectName { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DisplayName("開始日")]
    public DateTime StartDate { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DisplayName("完了日")]
    public DateTime CompletionDate { get; set; }
    [DisplayName("状態")]
    public Status? Status { get; set; }
    [Required]
    [DisplayName("優先度")]
    public Priority? Priority { get; set; }
    [DisplayName("備考")]
    [DataType(DataType.MultilineText)]
    public string Comment { get; set; }    
    public ICollection<Thing> Things { get; set; }
}
}
