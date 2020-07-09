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
    public class ProjectsController : Controller
    {
        private readonly TasksContext _context;

        public ProjectsController(TasksContext context)
        {
            _context = context;
        }

        // GET: Projects
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Projects.ToListAsync());
        //}
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            //ViewData["EnumSortParm"] = sortOrder == "Enum" ? "Enum_desc" : "Enum";
            ViewData["CatSortParm"] = sortOrder == "Cat" ? "Cat_desc" : "Cat";
            ViewData["PriSortParm"] = sortOrder == "Pri" ? "Pri_desc" : "Pri";
            var projects = from s in _context.Projects
                           select s;
            switch (sortOrder)
            {
                case "name_desc":
                    projects = projects.OrderByDescending(s => s.ProjectName);
                    //名前を選択すると通る
                    break;
                case "Date":
                    projects = projects.OrderBy(s => s.CompletionDate);
                    //日付を選択すると通る
                    projects = projects.OrderBy(s => s.StartDate);
                    break;
                case "date_desc":
                    projects = projects.OrderByDescending(s => s.CompletionDate);
                    //日付で昇順に並べ替えしたあとに選択すると通る
                    projects = projects.OrderByDescending(s => s.StartDate);
                    break;
                //enum要素ををそれぞれ並べ替える
                case "Cat":
                    projects = projects.OrderBy(s => s.Category);
                    break;
                case "Cat_desc":
                    projects = projects.OrderByDescending(s => s.Category);
                    break;
                case "Pri":
                    projects = projects.OrderBy(s => s.Priority);
                    break;
                case "Pri_desc":
                    projects = projects.OrderByDescending(s => s.Priority);
                    break;
                default:
                    projects = projects.OrderBy(s => s.ProjectName);
                    //projectページに遷移するときに通る
                    //→初期状態は名前の昇順
                    break;
            }
            return View(await projects.AsNoTracking().ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var project = await _context.Projects
            //    .FirstOrDefaultAsync(m => m.ID == id);
            var project = await _context.Projects
                .Include(s => s.Things)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Category,ProjectName,StartDate,CompletionDate,Priority,Comment")] Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Category,ProjectName,StartDate,CompletionDate,Priority,Comment")] Project project)
        {
            if (id != project.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ID))
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
            return View(project);
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .FirstOrDefaultAsync(m => m.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _context.Projects.Any(e => e.ID == id);
        }
    }
}
