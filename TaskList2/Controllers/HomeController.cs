using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskList2.Models;

using Microsoft.EntityFrameworkCore;
using TaskList2.Data;
using TaskList2.Models.ProjectViewModels;
using TaskList2.Models.Data;

namespace TaskList2.Controllers
{
    /*    public class HomeController : Controller
        {
     *         private readonly ILogger<HomeController> _logger;
            public HomeController(ILogger<HomeController> logger)
            {
                _logger = logger;
            }
     */
    public class HomeController : Controller
    {
        private readonly TasksContext _context;

        public HomeController(TasksContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<ActionResult> About()
        {
            IQueryable<EnrollmentDateGroup> data =
                from project in _context.Projects
                group project by project.StartDate into dateGroup
                select new EnrollmentDateGroup()
                {
                    EnrollmentDate = dateGroup.Key,
                    ProjectCount = dateGroup.Count()
                };
            return View(await data.AsNoTracking().ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
