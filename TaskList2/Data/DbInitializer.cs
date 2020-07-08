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
                new Project{Category=0,ProjectName="A",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2019-10-01"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="B",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2019-10-01"),Priority=0,Comment=("メモ")},
                new Project{Category=0,ProjectName="C",StartDate= DateTime.Parse("2012-09-01"),
                    CompletionDate=DateTime.Parse("2019-10-01"),Priority=0,Comment=("メモ")},

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
                new Thing{ThingID = 1,ProjectID =1,Process="SA",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-01"),Status=0,Progress=("100%"),Memo=("メモ")},
                new Thing{ThingID = 2,ProjectID =2,Process="UI",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-01"),Status=0,Progress=("100%"),Memo=("メモ")},
                new Thing{ThingID = 3,ProjectID =3,Process="SS",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-01"),Status=0,Progress=("100%"),Memo=("メモ")},
                new Thing{ThingID = 4,ProjectID =1,Process="SS",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
                    End=DateTime.Parse("2019-09-01"),Status=0,Progress=("100%"),Memo=("メモ")},
                new Thing{ThingID = 5,ProjectID =1,Process="PT",TaskName="設計書",Start=DateTime.Parse("2012-09-01"),
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