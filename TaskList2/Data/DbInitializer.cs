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
                new Project{Category=0,ProjectName="A",StartDate= DateTime.Parse("2012-09-12"),
                    CompletionDate=DateTime.Parse("2019-10-01"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="B",StartDate= DateTime.Parse("2012-09-11"),
                    CompletionDate=DateTime.Parse("2019-10-02"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="C",StartDate= DateTime.Parse("2012-09-10"),
                    CompletionDate=DateTime.Parse("2019-10-03"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="X",StartDate= DateTime.Parse("2012-09-09"),
                    CompletionDate=DateTime.Parse("2000-10-04"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="Y",StartDate= DateTime.Parse("2012-09-08"),
                    CompletionDate=DateTime.Parse("2020-01-01"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="Z",StartDate= DateTime.Parse("2012-09-07"),
                    CompletionDate=DateTime.Parse("2010-10-06"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="1",StartDate= DateTime.Parse("2012-09-06"),
                    CompletionDate=DateTime.Parse("2010-10-07"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="2",StartDate= DateTime.Parse("2012-09-05"),
                    CompletionDate=DateTime.Parse("2010-10-08"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="5",StartDate= DateTime.Parse("2012-09-04"),
                    CompletionDate=DateTime.Parse("2010-10-09"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="あああ",StartDate= DateTime.Parse("2012-09-03"),
                    CompletionDate=DateTime.Parse("2010-10-10"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="かかか",StartDate= DateTime.Parse("2012-09-02"),
                    CompletionDate=DateTime.Parse("2010-10-11"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="ななな",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2010-10-12"),Priority=0,Comment=("メモ")},

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
                new Thing{ID = 1,ProjectID =1,Process="SA",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-01"),Status=0,Progress=("100%"),Memo=("メモ")},
                new Thing{ID = 2,ProjectID =2,Process="UI",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-01"),Status=0,Progress=("100%"),Memo=("メモ")},
                new Thing{ID = 3,ProjectID =3,Process="SS",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-01"),Status=0,Progress=("100%"),Memo=("メモ")},
                new Thing{ID = 4,ProjectID =1,Process="SS",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-01"),Status=0,Progress=("100%"),Memo=("メモ")},
                new Thing{ID = 5,ProjectID =1,Process="PT",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-01"),Status=0,Progress=("100%"),Memo=("メモ")},

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