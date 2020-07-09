using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TaskList2.Models
{
    public enum Status
    {
        未着手, 作業中, 完了,対応なし
    }

    public class Thing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int ProjectID { get; set; }
        [DisplayName("工程")]
        public string Process { get; set; }
        [DisplayName("作業内容")]
        public string TaskName { get; set; }
        [DisplayName("着手日")]
        [DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}")]
        public DateTime Start { get; set; }
        [DisplayName("完了予定日")]
        [DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}")]
        public DateTime End { get; set; }
        [DisplayName("状態")]
        public Status? Status { get; set; }
        [DisplayName("進捗")]
        public String Progress { get; set; }
        [DisplayName("メモ")]
        [DataType(DataType.MultilineText)]
        public string Memo { get; set; }
        public Project Projects { get; set; }

    }
}
