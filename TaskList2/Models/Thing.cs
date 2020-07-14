using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace TaskList2.Models
{
    public enum Status
    {
        未着手, 作業中, 完了,対応なし
    }

    public class Thing
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        [DisplayName("プロジェクト名")]
        public Project Projects { get; set; }
        public int ProjectID { get; set; }
        [Required(ErrorMessage = "{0}を入力してください。")]
        [DisplayName("工程")]
        public string Process { get; set; }
        [Required(ErrorMessage = "{0}を入力してください。")]
        [DisplayName("作業名")]
        public string TaskName { get; set; }
        [Required(ErrorMessage = "{0}を入力してください。")]
        [DisplayName("着手日")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Start { get; set; }
        [Required(ErrorMessage = "{0}を入力してください。")]
        [DisplayName("完了日")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime End { get; set; }
        [DisplayName("状態")]
        public Status? Status { get; set; }
        [Required(ErrorMessage = "{0}を入力してください。")]
        [DisplayName("進捗")]
        [Range(0,100,ErrorMessage = "0-100以内で入力してください")]
        public int Progress { get; set; }
/*        public IEnumerable<SelectListItem> ProgressList { get; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "0%", Value = "0" },
            new SelectListItem { Text = "iPhone", Value = "ios" },
            new SelectListItem { Text = "Windows 10 Mobile", Value = "windows" }
        };
*/
        [DisplayName("メモ")]
        [DataType(DataType.MultilineText)]
        public string Memo { get; set; }

    }
}
