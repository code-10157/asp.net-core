using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskList2.Models;
using TaskList2.Models.Data;

namespace TaskList2.Controllers
{
    public class ThingsController : Controller
    {
        private readonly TasksContext _context;

        public ThingsController(TasksContext context)
        {
            _context = context;
        }

        // GET: Things
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["ProjectSortParm"] = sortOrder == "Project" ? "Project_desc" : "Project";
            ViewData["ProSortParm"] = sortOrder == "Pro" ? "Pro_desc" : "Pro";
            ViewData["SDateSortParm"] = sortOrder == "SDate" ? "SDate_desc" : "SDate";
            ViewData["EDateSortParm"] = sortOrder == "EDate" ? "Edate_desc" : "EDate";
            ViewData["StaSortParm"] = sortOrder == "Sta" ? "Sta_desc" : "Sta";
            ViewData["ProgSortParm"] = sortOrder == "Prog" ? "Prog_desc" : "Prog";
            //ViewData["EnumSortParm"] = sortOrder == "Enum" ? "Enum_desc" : "Enum";
            //ViewData["PriSortParm"] = sortOrder == "Pri" ? "Pri_desc" : "Pri";

            ViewData["CurrentFilter"] = searchString;

            var things = from s in _context.Things.Include(t => t.Projects)
            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                things = things.Where(s => s.TaskName.Contains(searchString));
            //                               || s.Projects.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    things = things.OrderByDescending(s => s.TaskName);
                    break;
                case "Project":
                    things = things.OrderBy(s => s.Projects).ThenBy(s => s.End).ThenBy(s => s.Start);
                    break;
                case "Project_desc":
                    things = things.OrderByDescending(s => s.Projects).ThenBy(s => s.End).ThenBy(s => s.Start);
                    break;
                case "Pro":
                    things = things.OrderBy(s => s.Process).ThenBy(s => s.End).ThenBy(s => s.Start);
                    break;
                case "Pro_desc":
                    things = things.OrderByDescending(s => s.Process).ThenBy(s => s.End).ThenBy(s => s.Start);
                    break;
                case "SDate":
                    things = things.OrderBy(s => s.Start).ThenBy(s => s.End);
                    break;
                case "Sdate_desc":
                    things = things.OrderByDescending(s => s.Start).ThenBy(s => s.End);
                    break;
                case "EDate":
                    things = things.OrderBy(s => s.End).ThenBy(s => s.Start);
                    break;
                case "Edate_desc":
                    things = things.OrderByDescending(s => s.End).ThenBy(s => s.Start);
                    break;
                case "Sta":
                    things = things.OrderBy(s => s.Status).ThenBy(s => s.End).ThenBy(s => s.Start);
                    break;
                case "Sta_desc":
                    things = things.OrderByDescending(s => s.Status).ThenBy(s => s.End).ThenBy(s => s.Start);
                    break;
                case "Prog":
                    things = things.OrderBy(s => s.Progress);
                    break;
                case "Prog_desc":
                    things = things.OrderByDescending(s => s.Progress);
                    break;
/*
                case "Pri":
                    things = things.OrderBy(s => s.Priority).ThenBy(s => s.CompletionDate);
                    break;
                case "Pri_desc":
                    things = things.OrderByDescending(s => s.Priority).ThenBy(s => s.CompletionDate);
                    break;
*/
                default:
                    things = things.OrderBy(s => s.TaskName).ThenBy(s => s.End).ThenBy(s => s.Start);
                    break;
            }

            //return View(await tasksContext.ToListAsync());
            return View(await things.AsNoTracking().ToListAsync());
        }

        // GET: Things/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thing = await _context.Things
                .Include(t => t.Projects)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (thing == null)
            {
                return NotFound();
            }

            return View(thing);
        }

        // GET: Things/Create
        public IActionResult Create()
        {
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "ProjectName");
            return View();
        }

        // POST: Things/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProjectID,Process,TaskName,Start,End,Status,Progress,Memo")] Thing thing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "ProjectName", thing.ProjectID);
            return View(thing);
        }

        // GET: Things/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thing = await _context.Things.FindAsync(id);
            if (thing == null)
            {
                return NotFound();
            }
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "ProjectName", thing.ProjectID);
            return View(thing);
        }

        // POST: Things/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProjectID,Process,TaskName,Start,End,Status,Progress,Memo")] Thing thing)
        {
            if (id != thing.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThingExists(thing.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "ProjectName", thing.ProjectID);
            return View(thing);
        }

        // GET: Things/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thing = await _context.Things
                .Include(t => t.Projects)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (thing == null)
            {
                return NotFound();
            }

            return View(thing);
        }

        // POST: Things/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thing = await _context.Things.FindAsync(id);
            _context.Things.Remove(thing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThingExists(int id)
        {
            return _context.Things.Any(e => e.ID == id);
        }
    }
}
