using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TaskList2.Data;
using TaskList2.Models;
using TaskList2.Models.Data;

namespace TaskList2.Data
{
    public class DbInitializer
    {
        public static void Initialize(TasksContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Projects.Any())
            {
                return;   // DB has been seeded
            }

            var projects = new Project[]
            {
 /*               new Project{Category=0,ProjectName="A",StartDate= DateTime.Parse("2012-09-12"),
                    CompletionDate=DateTime.Parse("2019-10-01"),Priority=Priority.高,Comment=("メモ")},
                new Project{Category=0,ProjectName="B",StartDate= DateTime.Parse("2012-09-11"),
                    CompletionDate=DateTime.Parse("2019-10-02"),Priority=Priority.高,Comment=("メモ")},
                new Project{Category=0,ProjectName="C",StartDate= DateTime.Parse("2012-09-10"),
                    CompletionDate=DateTime.Parse("2019-10-03"),Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="X",StartDate= DateTime.Parse("2012-09-09"),
                    CompletionDate=DateTime.Parse("2000-10-04"),Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="Y",StartDate= DateTime.Parse("2012-09-08"),
                    CompletionDate=DateTime.Parse("2020-01-01"),Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="Z",StartDate= DateTime.Parse("2012-09-07"),
                    CompletionDate=DateTime.Parse("2010-10-06"),Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="1",StartDate= DateTime.Parse("2012-09-06"),
                    CompletionDate=DateTime.Parse("2010-10-07"),Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="2",StartDate= DateTime.Parse("2012-09-05"),
                    CompletionDate=DateTime.Parse("2010-10-08"),Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="5",StartDate= DateTime.Parse("2012-09-04"),
                    CompletionDate=DateTime.Parse("2010-10-09"),Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="あああ",StartDate= DateTime.Parse("2012-09-03"),
                    CompletionDate=DateTime.Parse("2010-10-10"),Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="いいい",StartDate= DateTime.Parse("2012-09-02"),
                    CompletionDate=DateTime.Parse("2010-10-11"),Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="ううう",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2010-10-12"),Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="1",StartDate= DateTime.Parse("2012-01-01"),
                    CompletionDate=DateTime.Parse("2012-04-04"),Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="1",StartDate= DateTime.Parse("2012-02-02"),
                    CompletionDate=DateTime.Parse("2012-05-05"),Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="1",StartDate= DateTime.Parse("2012-03-03"),
                    CompletionDate=DateTime.Parse("2012-06-06"),Priority=Priority.低,Comment=("メモ")},
*/
/*
                new Project{Category=0,ProjectName="A",StartDate= DateTime.Parse("2012-09-12"),
                    CompletionDate=DateTime.Parse("2019-10-01"),Status=Status.完了,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=0,ProjectName="B",StartDate= DateTime.Parse("2012-09-11"),
                    CompletionDate=DateTime.Parse("2019-10-02"),Status=Status.作業中,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=0,ProjectName="C",StartDate= DateTime.Parse("2012-09-10"),
                    CompletionDate=DateTime.Parse("2019-10-03"),Status=Status.対応なし,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="X",StartDate= DateTime.Parse("2012-09-09"),
                    CompletionDate=DateTime.Parse("2000-10-04"),Status=Status.未着手,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="Y",StartDate= DateTime.Parse("2012-09-08"),
                    CompletionDate=DateTime.Parse("2020-01-01"),Status=Status.作業中,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="Z",StartDate= DateTime.Parse("2012-09-07"),
                    CompletionDate=DateTime.Parse("2010-10-06"),Status=Status.作業中,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="1",StartDate= DateTime.Parse("2012-09-06"),
                    CompletionDate=DateTime.Parse("2010-10-07"),Status=Status.作業中,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="2",StartDate= DateTime.Parse("2012-09-05"),
                    CompletionDate=DateTime.Parse("2010-10-08"),Status=Status.未着手,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="5",StartDate= DateTime.Parse("2012-09-04"),
                    CompletionDate=DateTime.Parse("2010-10-09"),Status=Status.未着手,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="あああ",StartDate= DateTime.Parse("2012-09-03"),
                    CompletionDate=DateTime.Parse("2010-10-10"),Status=Status.未着手,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="いいい",StartDate= DateTime.Parse("2012-09-02"),
                    CompletionDate=DateTime.Parse("2010-10-11"),Status=Status.未着手,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="ううう",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2010-10-12"),Status=Status.対応なし,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="1",StartDate= DateTime.Parse("2012-01-01"),
                    CompletionDate=DateTime.Parse("2012-04-04"),Status=Status.対応なし,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="1",StartDate= DateTime.Parse("2012-02-02"),
                    CompletionDate=DateTime.Parse("2012-05-05"),Status=Status.完了,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="1",StartDate= DateTime.Parse("2012-03-03"),
                    CompletionDate=DateTime.Parse("2012-06-06"),Status=Status.完了,Priority=Priority.低,Comment=("メモ")},
*/ 
/*                new Project{Category=Category.故障,ProjectName="A",StartDate= DateTime.Parse("2012-09-30"),
                    CompletionDate=DateTime.Parse("2019-10-01"),Status=Status.完了,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="B",StartDate= DateTime.Parse("2012-09-28"),
                    CompletionDate=DateTime.Parse("2019-10-02"),Status=Status.作業中,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="C",StartDate= DateTime.Parse("2012-09-29"),
                    CompletionDate=DateTime.Parse("2019-10-03"),Status=Status.未着手,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.案件,ProjectName="Z",StartDate= DateTime.Parse("2012-09-15"),
                    CompletionDate=DateTime.Parse("2000-10-06"),Status=Status.対応なし,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.案件,ProjectName="X",StartDate= DateTime.Parse("2012-09-14"),
                    CompletionDate=DateTime.Parse("2020-01-05"),Status=Status.完了,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.案件,ProjectName="Y",StartDate= DateTime.Parse("2012-09-13"),
                    CompletionDate=DateTime.Parse("2010-10-04"),Status=Status.作業中,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="1",StartDate= DateTime.Parse("2012-09-22"),
                    CompletionDate=DateTime.Parse("2010-10-10"),Status=Status.完了,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="1",StartDate= DateTime.Parse("2012-09-23"),
                    CompletionDate=DateTime.Parse("2010-10-12"),Status=Status.未着手,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="1",StartDate= DateTime.Parse("2012-09-21"),
                    CompletionDate=DateTime.Parse("2010-10-11"),Status=Status.対応なし,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="1",StartDate= DateTime.Parse("2012-09-21"),
                    CompletionDate=DateTime.Parse("2010-10-11"),Status=Status.完了,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.その他,ProjectName="ううう",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2010-10-10"),Status=Status.未着手,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.その他,ProjectName="いいい",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2010-10-22"),Status=Status.未着手,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.その他,ProjectName="あああ",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2010-10-23"),Status=Status.対応なし,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="6",StartDate= DateTime.Parse("2012-01-01"),
                    CompletionDate=DateTime.Parse("2012-04-04"),Status=Status.対応なし,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="5",StartDate= DateTime.Parse("2012-02-02"),
                    CompletionDate=DateTime.Parse("2012-05-05"),Status=Status.完了,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="4",StartDate= DateTime.Parse("2012-03-03"),
                    CompletionDate=DateTime.Parse("2012-06-06"),Status=Status.完了,Priority=Priority.低,Comment=("メモ")},
*/
                new Project{Category=Category.故障,ProjectName="システムトラブルA",StartDate= DateTime.Parse("2012-09-30"),
                    CompletionDate=DateTime.Parse("2019-10-01"),Status=Status.未着手,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="端末不具合",StartDate= DateTime.Parse("2012-09-28"),
                    CompletionDate=DateTime.Parse("2019-10-02"),Status=Status.作業中,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.故障,ProjectName="画面が表示されない",StartDate= DateTime.Parse("2012-09-29"),
                    CompletionDate=DateTime.Parse("2019-10-03"),Status=Status.未着手,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.案件,ProjectName="新サービスの追加",StartDate= DateTime.Parse("2012-09-15"),
                    CompletionDate=DateTime.Parse("2000-10-06"),Status=Status.対応なし,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.案件,ProjectName="商品販売終了",StartDate= DateTime.Parse("2012-09-14"),
                    CompletionDate=DateTime.Parse("2020-01-05"),Status=Status.完了,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.案件,ProjectName="新製品発売",StartDate= DateTime.Parse("2012-09-13"),
                    CompletionDate=DateTime.Parse("2010-10-04"),Status=Status.作業中,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="問い合わせA",StartDate= DateTime.Parse("2012-09-22"),
                    CompletionDate=DateTime.Parse("2010-10-10"),Status=Status.未着手,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="問い合わせC",StartDate= DateTime.Parse("2012-09-23"),
                    CompletionDate=DateTime.Parse("2010-10-12"),Status=Status.未着手,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="問い合わせB",StartDate= DateTime.Parse("2012-09-21"),
                    CompletionDate=DateTime.Parse("2010-10-11"),Status=Status.対応なし,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.問い合わせ,ProjectName="問い合わせD",StartDate= DateTime.Parse("2012-09-21"),
                    CompletionDate=DateTime.Parse("2010-10-11"),Status=Status.完了,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.その他,ProjectName="パンク",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2010-10-10"),Status=Status.未着手,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.その他,ProjectName="資料整理",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2010-10-22"),Status=Status.未着手,Priority=Priority.高,Comment=("メモ")},
                new Project{Category=Category.その他,ProjectName="打ち合わせ",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2010-10-23"),Status=Status.対応なし,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="作業依頼１",StartDate= DateTime.Parse("2012-01-01"),
                    CompletionDate=DateTime.Parse("2012-04-04"),Status=Status.対応なし,Priority=Priority.中,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="作業依頼３",StartDate= DateTime.Parse("2012-02-02"),
                    CompletionDate=DateTime.Parse("2012-05-05"),Status=Status.作業中,Priority=Priority.低,Comment=("メモ")},
                new Project{Category=Category.作業依頼,ProjectName="作業依頼２",StartDate= DateTime.Parse("2012-03-03"),
                    CompletionDate=DateTime.Parse("2012-06-06"),Status=Status.完了,Priority=Priority.低,Comment=("メモ")},

            };

            //context.Projects.AddRange(projects);
            //context.SaveChanges();
            foreach (Project s in projects)
            {
                context.Projects.Add(s);
            }
            context.SaveChanges();


            var things = new Thing[]
            {
 /*
                new Thing{ProjectID =1,Process="1.SA",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-02"),Status=0,Progress=("1%"),Memo=("メモ")},
                new Thing{ProjectID =1,Process="2.UI",TaskName="設計書",Start=DateTime.Parse("2012-09-02"),
                    End=DateTime.Parse("2019-09-03"),Status=0,Progress=("10%"),Memo=("メモ")},
                new Thing{ProjectID =3,Process="SS",TaskName="設計書",Start=DateTime.Parse("2012-09-03"),
                    End=DateTime.Parse("2019-09-04"),Status=0,Progress=("100%"),Memo=("メモ")},
                new Thing{ProjectID =1,Process="3.SS",TaskName="設計書",Start=DateTime.Parse("2012-09-04"),
                    End=DateTime.Parse("2019-09-05"),Status=0,Progress=("20%"),Memo=("メモ")},
                new Thing{ProjectID =1,Process="4.PT",TaskName="設計書",Start=DateTime.Parse("2012-09-05"),
                    End=DateTime.Parse("2019-09-06"),Status=0,Progress=("50%"),Memo=("メモ")},
                new Thing{ProjectID =1,Process="1.SA",TaskName="設計書",Start=DateTime.Parse("2012-09-06"),
                    End=DateTime.Parse("2019-09-07"),Status=0,Progress=("10%"),Memo=("メモ")},
*/
/*
                new Thing{ProjectID =1,Process="1.SA",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-02"),Status=0,Progress=1,Memo=("メモ")},
                new Thing{ProjectID =1,Process="2.UI",TaskName="設計書",Start=DateTime.Parse("2012-09-02"),
                    End=DateTime.Parse("2019-09-03"),Status=0,Progress=10,Memo=("メモ")},
                new Thing{ProjectID =3,Process="SS",TaskName="設計書",Start=DateTime.Parse("2012-09-03"),
                    End=DateTime.Parse("2019-09-04"),Status=0,Progress=100,Memo=("メモ")},
                new Thing{ProjectID =1,Process="3.SS",TaskName="設計書",Start=DateTime.Parse("2012-09-04"),
                    End=DateTime.Parse("2019-09-05"),Status=0,Progress=20,Memo=("メモ")},
                new Thing{ProjectID =1,Process="4.PT",TaskName="設計書",Start=DateTime.Parse("2012-09-05"),
                    End=DateTime.Parse("2019-09-06"),Status=0,Progress=50,Memo=("メモ")},
                new Thing{ProjectID =1,Process="1.SA",TaskName="設計書",Start=DateTime.Parse("2012-09-06"),
                    End=DateTime.Parse("2019-09-07"),Status=0,Progress=10,Memo=("メモ")},
*/
/*                new Thing{ProjectID =1,Process="1.SA",TaskName="作業A",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-02"),Status=Status.作業中,Progress=30,Memo=("メモ")},
                new Thing{ProjectID =1,Process="2.UI",TaskName="作業Z",Start=DateTime.Parse("2012-09-02"),
                    End=DateTime.Parse("2019-09-03"),Status=Status.完了,Progress=100,Memo=("メモ")},
                new Thing{ProjectID =3,Process="SS",TaskName="作業B",Start=DateTime.Parse("2012-09-03"),
                    End=DateTime.Parse("2019-09-04"),Status=Status.完了,Progress=100,Memo=("メモ")},
                new Thing{ProjectID =1,Process="3.SS",TaskName="設計書E",Start=DateTime.Parse("2012-09-06"),
                    End=DateTime.Parse("2019-09-05"),Status=Status.対応なし,Progress=0,Memo=("対応なし")},
                new Thing{ProjectID =1,Process="4.PT",TaskName="設計書C",Start=DateTime.Parse("2012-09-05"),
                    End=DateTime.Parse("2019-09-06"),Status=Status.未着手,Progress=0,Memo=("0905着手")},
                new Thing{ProjectID =1,Process="1.SA",TaskName="設計書F",Start=DateTime.Parse("2012-09-04"),
                    End=DateTime.Parse("2019-09-07"),Status=Status.作業中,Progress=80,Memo=("メモ")},
                new Thing{ProjectID =1,Process="SA",TaskName="設計書Y",Start=DateTime.Parse("2012-09-10"),
                    End=DateTime.Parse("2019-09-04"),Status=Status.完了,Progress=100,Memo=("メモ")},
                new Thing{ProjectID =1,Process="PT",TaskName="設計書X",Start=DateTime.Parse("2012-09-12"),
                    End=DateTime.Parse("2019-09-04"),Status=Status.作業中,Progress=20,Memo=("メモ")},
                new Thing{ProjectID =1,Process="UI",TaskName="設計書W",Start=DateTime.Parse("2012-09-11"),
                    End=DateTime.Parse("2019-09-04"),Status=Status.作業中,Progress=10,Memo=("メモ")},
                new Thing{ProjectID =1,Process="1.SA",TaskName="作業V",Start=DateTime.Parse("2012-09-30"),
                    End=DateTime.Parse("2019-09-02"),Status=Status.対応なし,Progress=0,Memo=("対応なし")},
                new Thing{ProjectID =1,Process="1.SA",TaskName="作業U",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-02"),Status=Status.作業中,Progress=50,Memo=("メモ")},
*/
                new Thing{ProjectID =1,Process="1.SA",TaskName="作業A",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-02"),Status=Status.作業中,Progress=30,Memo=("メモ")},
                new Thing{ProjectID =1,Process="2.UI",TaskName="作業Z",Start=DateTime.Parse("2012-09-02"),
                    End=DateTime.Parse("2019-09-03"),Status=Status.未着手,Progress=100,Memo=("メモ")},
                new Thing{ProjectID =3,Process="SS",TaskName="作業B",Start=DateTime.Parse("2012-09-03"),
                    End=DateTime.Parse("2019-09-04"),Status=Status.未着手,Progress=100,Memo=("メモ")},
                new Thing{ProjectID =1,Process="3.SS",TaskName="設計書E",Start=DateTime.Parse("2012-09-06"),
                    End=DateTime.Parse("2019-09-05"),Status=Status.対応なし,Progress=0,Memo=("対応なし")},
                new Thing{ProjectID =1,Process="4.PT",TaskName="設計書C",Start=DateTime.Parse("2012-09-05"),
                    End=DateTime.Parse("2019-09-06"),Status=Status.未着手,Progress=0,Memo=("0905着手")},
                new Thing{ProjectID =1,Process="SA",TaskName="設計書Y",Start=DateTime.Parse("2012-09-10"),
                    End=DateTime.Parse("2019-09-04"),Status=Status.作業中,Progress=100,Memo=("メモ")},
                new Thing{ProjectID =1,Process="PT",TaskName="設計書X",Start=DateTime.Parse("2012-09-12"),
                    End=DateTime.Parse("2019-09-04"),Status=Status.作業中,Progress=20,Memo=("メモ")},
                new Thing{ProjectID =1,Process="UI",TaskName="設計書W",Start=DateTime.Parse("2012-09-11"),
                    End=DateTime.Parse("2019-09-04"),Status=Status.作業中,Progress=10,Memo=("メモ")},
                new Thing{ProjectID =6,Process="4.PT",TaskName="試験書A",Start=DateTime.Parse("2012-09-23"),
                    End=DateTime.Parse("2019-09-27"),Status=Status.未着手,Progress=0,Memo=("メモ")},
                new Thing{ProjectID =6,Process="2.UI",TaskName="D設計書",Start=DateTime.Parse("2012-09-15"),
                    End=DateTime.Parse("2019-09-20"),Status=Status.完了,Progress=100,Memo=("メモ")},
                new Thing{ProjectID =6,Process="2.UI",TaskName="調査",Start=DateTime.Parse("2012-09-13"),
                    End=DateTime.Parse("2019-09-16"),Status=Status.作業中,Progress=60,Memo=("メモ")},
                new Thing{ProjectID =6,Process="1.SA",TaskName="見積",Start=DateTime.Parse("2012-09-11"),
                    End=DateTime.Parse("2012-09-15"),Status=Status.完了,Progress=100,Memo=("メモ")},
                new Thing{ProjectID =6,Process="3.SS",TaskName="E設計書",Start=DateTime.Parse("2012-09-20"),
                    End=DateTime.Parse("2019-09-23"),Status=Status.対応なし,Progress=0,Memo=("メモ")},

            };

            //context.Things.AddRange(things);
            //context.SaveChanges();
            //context.Database.EnsureCreated();
            foreach (Thing c in things)
            {
                context.Things.Add(c);
            }
            context.SaveChanges();

        }
    }
}